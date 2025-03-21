using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Threading;
using ST_InstructorUI.Properties;

namespace ST_InstructorUI
{
    /// <summary>
    /// Utility class for managing application languages
    /// </summary>
    public static class LanguageUtils
    {
        // Dictionary of available languages (display name -> culture)
        private static readonly Dictionary<string, CultureInfo> AvailableLanguages = new Dictionary<string, CultureInfo>
        {
            { "English", new CultureInfo("en-US") },
            { "日本語", new CultureInfo("ja-JP") },
            { "한국어", new CultureInfo("ko-KR") }
        };

        /// <summary>
        /// Gets the currently configured culture from app.config
        /// </summary>
        public static CultureInfo GetCurrentCulture()
        {
            string cultureName = ConfigurationManager.AppSettings["Culture"];

            if (!string.IsNullOrEmpty(cultureName))
            {
                try
                {
                    return new CultureInfo(cultureName);
                }
                catch (CultureNotFoundException)
                {
                    // Default to Japanese if culture not found
                    return new CultureInfo("ja-JP");
                }
            }

            // Default to Japanese if no culture specified
            return new CultureInfo("ja-JP");
        }

        /// <summary>
        /// Gets list of available language display names for populating UI
        /// </summary>
        public static List<string> GetAvailableLanguageDisplayNames()
        {
            return AvailableLanguages.Keys.ToList();
        }

        /// <summary>
        /// Changes the application language
        /// </summary>
        public static void ChangeLanguage(CultureInfo culture)
        {
            Thread.CurrentThread.CurrentUICulture = culture;
            Resources.Culture = culture;

            // Update app.config to remember the last selected language
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["Culture"].Value = culture.Name;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        /// <summary>
        /// Changes language by display name
        /// </summary>
        public static void ChangeLanguageByDisplayName(string displayName)
        {
            if (AvailableLanguages.ContainsKey(displayName))
            {
                ChangeLanguage(AvailableLanguages[displayName]);
            }
        }

        /// <summary>
        /// Gets culture info by display name
        /// </summary>
        public static CultureInfo GetCultureInfoByDisplayName(string displayName)
        {
            return AvailableLanguages.ContainsKey(displayName)
                ? AvailableLanguages[displayName]
                : new CultureInfo("ja-JP");
        }

        /// <summary>
        /// Gets display name by culture
        /// </summary>
        public static string GetDisplayNameByCulture(CultureInfo culture)
        {
            foreach (var language in AvailableLanguages)
            {
                if (language.Value.Name == culture.Name)
                {
                    return language.Key;
                }
            }

            return "日本語"; // Default to Japanese display name
        }
    }
}