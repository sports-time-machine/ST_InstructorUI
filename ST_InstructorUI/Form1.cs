using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ST_InstructorUI.Properties;

namespace ST_InstructorUI
{
    public partial class Form1 : Form
    {
        private static Form1 _self;
        private static bool _quitReceive = false;
        private UdpClient _udpSend;
        private UdpClient _udpRecv;
        private UdpClient _pingRecv;
        private Thread _rcvThread;
        private readonly Random _random = new Random();

        private int _serverPort;
        private string _serverAddress;

        private const int UdpServerRecv = 38702;
        private const int UdpClientRecv = 38708;
        private const int UdpInterfaceRecv = 38709;

        private string _qrFile = @"c:/ME19/code.txt";

        private readonly List<string[]> _colors = new List<string[]>();
        private readonly List<string[]> _backgrounds = new List<string[]>();
        private readonly List<string> _tags = new List<string>();
        private List<CheckBox> _tagButtons;


        private void ChangeStatus(string text)
        {
            toolStripStatusLabel1.Text = text;
        }

        public Form1()
        {
            InitializeComponent();
            GenerateTags();
            ReadConfigData();
            SetItemContents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // app.configから言語設定を読み込み
            var cultureName = ConfigurationManager.AppSettings["Culture"];
            if (!string.IsNullOrEmpty(cultureName))
            {
                try
                {
                    var culture = new CultureInfo(cultureName);
                    Thread.CurrentThread.CurrentUICulture = culture;
                    Resources.Culture = culture;
                }
                catch (CultureNotFoundException)
                {
                    // 言語が見つからない場合は日本語をデフォルトとする
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("ja-JP");
                    Resources.Culture = new CultureInfo("ja-JP");
                }
            }

            // リソースを適用
            ApplyResources();

            // 最初は初期化タブのみ
            tabControl.TabPages.Remove(tabPage_Main);
            UpdateFormButtons("inited");

            _self = this;
            _udpSend = new UdpClient();
            _udpRecv = new UdpClient(UdpInterfaceRecv);
            try
            {
                _pingRecv = new UdpClient(UdpClientRecv);
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.ResourceManager.GetString("Dialog.ClientAlreadyRunning"));
                Application.Exit();
            }

            _rcvThread = new Thread(ReceiveProc);
            _rcvThread.Start();

            ResetCustomTags();
            ResetAllGameState();
        }

        // フォームを閉じるとき（ReceiveスレッドをAbortする）
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            readQRTimer.Stop();
            try
            {
                _rcvThread.Abort();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        /********************************************************************************************
         * UDP送信
         ********************************************************************************************/
        private void send_data_raw(string s, string address, int port)
        {
            //var enc = System.Text.Encoding.UTF8;
            var unicode = Encoding.Unicode;
            var utf8 = Encoding.UTF8;
            var unicodeBytes = unicode.GetBytes(s + "\n");
            var sendBytes = Encoding.Convert(unicode, utf8, unicodeBytes);

            for (var i = 0; i < unicodeBytes.Count(); i++)
                Debug.Print(unicodeBytes[i] + ",");
            Debug.Print("\n");

            for (var i = 0; i < sendBytes.Count(); i++)
                Debug.Print(sendBytes[i] + ",");
            Debug.Print("\n");

            try
            {
                _udpSend.Send(sendBytes, sendBytes.Length, address, port);
            }
            catch (Exception)
            {
                // send中にWiFiが無効になったりしたときに
                // 落ちるのを防ぐ
            }

            //Thread.Sleep(50);
            Thread.Sleep(1);
            send_log(s);
        }

        private void send_data(string s)
        {
            if (_serverPort != 0 && _serverAddress != null)
            {
                send_data_raw(s, _serverAddress, _serverPort);
            }
            else
            {
                Debug.Print("Server not found");
            }
        }

        /********************************************************************************************
         * UDP受信
         ********************************************************************************************/
        private static void ReceiveProc()
        {
            Debug.Print("begin receive thread");
            while (!_quitReceive)
            {
                _self.ReceiveThreadProc();
                Thread.Sleep(1);
            }

            Debug.Print("end of receive thread");
        }

        private void UpdateSendLog(string text)
        {
            textBoxLog.Text = $@"{textBoxLog.Text} $ {text}{Environment.NewLine}";
            textBoxLog.SelectionStart = textBoxLog.Text.Length;
            textBoxLog.Focus();
            textBoxLog.ScrollToCaret();
            textBoxSendMsg.Focus();
        }

        private void UpdateRecvLog(string text)
        {
            textBoxLog.Text = $@"{textBoxLog.Text} > {text}{Environment.NewLine}";
            textBoxLog.SelectionStart = textBoxLog.Text.Length;
            textBoxLog.Focus();
            textBoxLog.ScrollToCaret();
            textBoxSendMsg.Focus();
        }

        private delegate void UpdateTextDelegate(string outText);

        private delegate void DoCommandDelegate(string type, string cmd, string[] arg);

        private void send_log(string s)
        {
            _self.Invoke(new UpdateTextDelegate(UpdateSendLog), s);
        }

        private void recv_log(string s)
        {
            _self.Invoke(new UpdateTextDelegate(UpdateRecvLog), s);
        }

        private void DoCommand(string type, string cmd, string[] arg)
        {
            if (type == "ping")
            {
                if (cmd == "UI_PING" && arg.Length >= 3)
                {
                    _serverAddress = arg[1];
                    _serverPort = int.Parse(arg[2]);
                    send_data("PONG INSTRUCTOR_UI " + UdpInterfaceRecv);
                    ChangeStatus("CONNECTED: " + _serverAddress);
                    if (!tabControl.TabPages.Contains(tabPage_Main))
                    {
                        // 初回PINGのみ、操作タブが増える
                        tabControl.TabPages.Add(tabPage_Main);
                    }

                    panelSecond.Visible = true;
                }
            }
            else
            {
                if (type != "server") return;
                if (cmd != "STATE") return;
                if (arg.Count() < 2)
                {
                    recv_log("STATE ERROR");
                    return;
                }

                Debug.Print($"ui was received STATE '{arg[1]}'\n");
                UpdateFormButtons(arg[1]);
            }
        }

        private void UpdateFormButtons(string state)
        {
            switch (state)
            {
                case "inited":
                    Debug.Print("ui => inited\n");
                    ChangeStatus(Resources.ResourceManager.GetString("StatusMessage.Initializing"));
                    buttonLoad.Visible = false;
                    buttonStart.Visible = false;
                    buttonStop.Visible = false;
                    buttonGoal.Visible = false;
                    buttonInit.Visible = false;
                    break;

                case "calibrating":
                    Debug.Print("ui => calibrating\n");
                    ChangeStatus(Resources.ResourceManager.GetString("StatusMessage.Calibrating"));
                    buttonLoad.Visible = false;
                    buttonStart.Visible = false;
                    buttonStop.Visible = false;
                    buttonGoal.Visible = false;
                    buttonInit.Visible = true;
                    break;

                case "ready":
                    Debug.Print("ui => ready\n");
                    ChangeStatus(Resources.ResourceManager.GetString("StatusMessage.Ready"));
                    buttonLoad.Visible = true;
                    buttonStart.Visible = false;
                    buttonStop.Visible = false;
                    buttonGoal.Visible = false;
                    buttonInit.Visible = true;
                    break;

                case "loading":
                    Debug.Print("ui => loading\n");
                    ChangeStatus(Resources.ResourceManager.GetString("StatusMessage.Loading"));
                    buttonLoad.Visible = false;
                    buttonStart.Visible = false;
                    buttonStop.Visible = false;
                    buttonGoal.Visible = false;
                    buttonInit.Visible = true;
                    break;

                case "waiting_run":
                    Debug.Print("ui => waiging_run\n");
                    ChangeStatus(Resources.ResourceManager.GetString("StatusMessage.WaitingRun"));
                    buttonLoad.Visible = false;
                    buttonStart.Visible = true;
                    buttonStop.Visible = false;
                    buttonGoal.Visible = true;
                    buttonInit.Visible = true;
                    break;

                case "running":
                    Debug.Print("ui => recording\n");
                    ChangeStatus(Resources.ResourceManager.GetString("StatusMessage.Running"));
                    buttonLoad.Visible = false;
                    buttonStart.Visible = false;
                    buttonStop.Visible = true;
                    buttonGoal.Visible = true;
                    buttonInit.Visible = true;
                    break;

                case "waiting_playback":
                    Debug.Print("ui => waiting_playback\n");
                    ChangeStatus(Resources.ResourceManager.GetString("StatusMessage.WaitingPlayback"));
                    buttonLoad.Visible = false;
                    buttonStart.Visible = false;
                    buttonStop.Visible = false;
                    buttonGoal.Visible = false;
                    buttonInit.Visible = true;
                    break;

                case "playing_back":
                    Debug.Print("ui => playing_back\n");
                    ChangeStatus(Resources.ResourceManager.GetString("StatusMessage.PlayingBack"));
                    buttonLoad.Visible = false;
                    buttonStart.Visible = false;
                    buttonStop.Visible = false;
                    buttonGoal.Visible = false;
                    buttonInit.Visible = true;
                    break;

                case "saving":
                    ChangeStatus(Resources.ResourceManager.GetString("StatusMessage.Saving"));
                    buttonLoad.Visible = false;
                    buttonStart.Visible = false;
                    buttonStop.Visible = false;
                    buttonGoal.Visible = false;
                    buttonInit.Visible = true;
                    break;

                case "error":
                    ChangeStatus(Resources.ResourceManager.GetString("StatusMessage.Error"));
                    buttonLoad.Visible = false;
                    buttonStart.Visible = false;
                    buttonStop.Visible = false;
                    buttonGoal.Visible = false;
                    buttonInit.Visible = true;
                    break;
            }
        }

        private void ReceiveThreadProc()
        {
            var enc = Encoding.UTF8;

            if (_udpRecv.Available > 0)
            {
                // Receive udp data
                IPEndPoint remoteEP = null;
                var rcvBytes = _udpRecv.Receive(ref remoteEP);
                if (rcvBytes.Length > 0)
                {
                    Debug.Print("[udp recv] " + rcvBytes.Length + " bytes received");
                    var rcvMsg = enc.GetString(rcvBytes);
                    var cmds = rcvMsg.Split(' ', '\t');
                    if (cmds.Length >= 1)
                    {
                        cmds[0] = cmds[0].ToUpper();
                        _self.Invoke(new DoCommandDelegate(DoCommand), "server", cmds[0], cmds);
                    }
                    //recv_log(rcvMsg);
                }
            }

            if (_pingRecv.Available > 0)
            {
                // Receive udp data
                IPEndPoint remoteEP = null;
                var rcvBytes = _pingRecv.Receive(ref remoteEP);
                if (rcvBytes.Length <= 0) return;

                Debug.Print("[ping recv] " + rcvBytes.Length + " bytes received");
                var rcvMsg = enc.GetString(rcvBytes);
                var cmds = rcvMsg.Split(' ', '\t');
                if (cmds.Length < 1) return;

                cmds[0] = cmds[0].ToUpper();
                _self.Invoke(new DoCommandDelegate(DoCommand), "ping", cmds[0], cmds);
                //recv_log(rcvMsg);
            }
        }

        /********************************************************************************************
         * 外部ファイルデータの読み書き
         ********************************************************************************************/
        private void ReadConfigFile<T>(string filePath, Func<string, T> lineParser, ICollection<T> collection)
        {
            if (!File.Exists(filePath))
            {
                Debug.Print($"Config file not found: {filePath}");
                return;
            }

            try
            {
                using (var sr = new StreamReader(filePath, Encoding.GetEncoding("shift_jis")))
                {
                    while (sr.Peek() > 0)
                    {
                        var line = sr.ReadLine();
                        if (string.IsNullOrEmpty(line))
                            continue;

                        collection.Add(lineParser(line));
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Print($"Error reading config file {filePath}: {ex.Message}");
            }
        }

        private void ReadConfigTxt()
        {
            const string configPath = @"CONFIG.txt";

            if (!File.Exists(configPath))
            {
                Debug.Print($"Config file not found: {configPath}");
                return;
            }

            try
            {
                using (var sr = new StreamReader(configPath, Encoding.GetEncoding("shift_jis")))
                {
                    while (sr.Peek() > 0)
                    {
                        var line = sr.ReadLine();
                        if (string.IsNullOrEmpty(line))
                            continue;

                        var elements = line.Split('=');
                        if (elements.Length >= 2 && elements[0] == "QRFILE")
                            _qrFile = elements[1];
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Print($"Error reading config file: {ex.Message}");
            }
        }

        private void ReadColorsTxt()
        {
            ReadConfigFile(@"C:\ST\UI\COLORS.txt",
                line => line.Split('\t'),
                _colors);
        }

        private void ReadBackgroundTxt()
        {
            ReadConfigFile(@"C:\ST\UI\BACKGROUNDS.txt",
                line => line.Split('\t'),
                _backgrounds);
        }

        private void ReadTagsTxt()
        {
            ReadConfigFile(@"C:\ST\UI\TAGS.txt",
                line => line,
                _tags);
        }

        private void ReadConfigData()
        {
            try
            {
                ReadConfigTxt();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                ReadColorsTxt();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                ReadBackgroundTxt();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                ReadTagsTxt();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private void SetItemContents()
        {
            {
                var combo = comboBox_Background;
                combo.BeginUpdate();
                foreach (var background in _backgrounds)
                    combo.Items.Add(background[1]);

                combo.EndUpdate();
            }

            {
                var combo = comboBox_Color;
                combo.BeginUpdate();
                foreach (var color in _colors)
                    combo.Items.Add(color[1]);

                combo.EndUpdate();
            }

            for (var i = 0; i < _tags.Count; ++i)
            {
                if (i < GetPresetTagCount())
                {
                    _tagButtons[i].Text = _tags[i];
                }
            }
        }


        /********************************************************************************************
         * タグボタンの生成と動作
         ********************************************************************************************/
        private void GenerateTags()
        {
            _tagButtons = new List<CheckBox>();
            for (var i = 0; i < 35; ++i)
            {
                var cell = new CheckBox();
                cell.Appearance = Appearance.Button;
                cell.Dock = DockStyle.Fill;
                cell.TextAlign = ContentAlignment.MiddleCenter;
                cell.Margin = new Padding(0, 0, 0, 0);
                tableLayoutPanel_Tag.Controls.Add(cell, -1, -1);
                _tagButtons.Add(cell);
            }
        }

        /********************************************************************************************
         * コントロールイベントハンドラ
         ********************************************************************************************/
        private int GetPresetTagCount()
        {
            return (tableLayoutPanel_Tag.ColumnCount) * (tableLayoutPanel_Tag.RowCount - 1);
        }

        private int GetAllTagCount()
        {
            return tableLayoutPanel_Tag.ColumnCount * tableLayoutPanel_Tag.RowCount;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            var existPlayerQr = (textBox_playerQR.Text != "");
            var existGameQr = (textBox_gameQR.Text != "");
            switch (existPlayerQr)
            {
                case true when existGameQr:
                    // 両方ある
                    break;
                case false when !existGameQr:
                {
                    // 両方ない
                    var yesno = MessageBox.Show(
                        Resources.ResourceManager.GetString("Dialog.ConfirmNoRecord"),
                        Resources.ResourceManager.GetString("Dialog.Confirmation"),
                        MessageBoxButtons.YesNo);
                    if (yesno == DialogResult.No)
                    {
                        return;
                    }

                    break;
                }
                default:
                {
                    var yesno = MessageBox.Show(
                        Resources.ResourceManager.GetString("Dialog.ConfirmNoRecord"),
                        Resources.ResourceManager.GetString("Dialog.Confirmation"),
                        MessageBoxButtons.YesNo);
                    if (yesno == DialogResult.No)
                    {
                        return;
                    }

                    break;
                }
            }

            var n = comboBox_Color.SelectedIndex;
            if (n >= 0) send_data("COLOR " + _colors[n][0]);
            n = comboBox_Background.SelectedIndex;
            if (n >= 0) send_data("BACKGROUND " + _backgrounds[n][0]);

            for (var i = 0; i < GetAllTagCount(); ++i)
            {
                var cell = _tagButtons[i];
                if (!cell.Checked) continue;
                send_data("TAG " + cell.Text);
                Debug.Print("TAG " + cell.Text + "\n");
            }

            var partners = textBox_partnerQR.Text.Split(',');
            for (var i = 0; i < partners.Count(); i++)
                if (partners[i] != "")
                    send_data("PARTNER " + partners[i]);
            var playerQR = textBox_playerQR.Text != "" ? textBox_playerQR.Text : "AJ3M";
            var recordQR = textBox_gameQR.Text != "" ? textBox_gameQR.Text : "99N3B";
            send_data("IDENT " + playerQR + " " + recordQR);

            ResetAllGameState();
        }

        private void ResetAllTags()
        {
            for (var i = 0; i < GetAllTagCount(); ++i)
            {
                _tagButtons[i].Checked = false;
            }
        }

        private void ResetAllGameState()
        {
            ComboBoxRandom(comboBox_Background);
            ComboBoxRandom(comboBox_Color);
            textBox_playerQR.Text = "";
            textBox_partnerQR.Text = "";
            textBox_gameQR.Text = "";
            _idInfo.Clear();
        }

        private string GetConnString()
        {
            return
                "Server = ST_SERVER;" +
                "Database = ST;" +
                "User ID = st_user;" +
                "Password = eureka;";
        }

        private enum GameIdType
        {
            Invalid,
            NewGame,
            Partner,
        }

        private struct IdInfo
        {
            public GameIdType Idtype;
            public string PlayerName;
        }

        private readonly Dictionary<string, IdInfo> _idInfo = new Dictionary<string, IdInfo>();

        // ゲームIDをDBから読み取り、新規IDかパートナーIDか、不正であるかを判別
        private GameIdType GetGameIdType(string id, out string playerName)
        {
            playerName = "";

            // cached
            if (_idInfo.ContainsKey(id))
            {
                playerName = _idInfo[id].PlayerName;
                return _idInfo[id].Idtype;
            }

            GameIdType gid = GameIdType.Invalid;
            try
            {
                var conn = new MySqlConnection(GetConnString());
                conn.Open();
                var playerId = "";
                {
                    var sql =
                        $"SELECT player_id FROM records WHERE record_id='{id}' OR record_id='G{id}' ORDER BY ID DESC";
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.FieldCount == 0)
                            continue;
                        var x = reader[0];
                        if (x is DBNull)
                        {
                            gid = GameIdType.NewGame;
                        }
                        else
                        {
                            playerId = x.ToString();
                            gid = GameIdType.Partner;
                        }

                        break;
                    }

                    reader.Close();
                    cmd.Dispose();
                }

                if (playerId.Length > 0)
                {
                    // プレイヤーIDがあるのなら名前をひく
                    // 名前はPなしIDからもらう
                    var sql =
                        $"SELECT names.username FROM users LEFT JOIN names ON names.user_id = users.id WHERE users.player_id='{playerId.Substring(1)}'";
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.FieldCount == 0)
                            continue;
                        var x = reader[0];
                        if (!(x is DBNull))
                        {
                            playerName = x.ToString();
                        }

                        break;
                    }

                    reader.Close();
                    cmd.Dispose();
                }

                conn.Close();
            }
            catch (Exception)
            {
                gid = GameIdType.Invalid;
            }

            // cache
            IdInfo ii;
            ii.Idtype = gid;
            ii.PlayerName = playerName;
            _idInfo[id] = ii;
            return gid;
        }

        // プレイヤーIDの正当性の確認
        private bool IsValidPlayerId(string id, out string playerName)
        {
            var valid = false;
            playerName = "";
            try
            {
                var conn = new MySqlConnection(GetConnString());
                conn.Open();

                var sql =
                    $"SELECT * FROM names left join users on names.user_id=users.id WHERE users.player_id='{id}' OR player_id='P{id}'";

                var cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.FieldCount == 0)
                    {
                    }
                    else
                    {
                        // 見つかったらValidだ
                        valid = true;
                        playerName = reader["username"].ToString();
                    }
                }

                reader.Close();
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception)
            {
                // ignored
            }

            return valid;
        }

        private bool IsExistPlayerId(string id)
        {
            var exist = false;
            try
            {
                var conn = new MySqlConnection(GetConnString());
                conn.Open();

                var sql = $"SELECT * FROM users WHERE users.player_id='{id}' OR player_id='P{id}'";

                var cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.FieldCount == 0)
                    {
                    }
                    else
                    {
                        // 見つかった
                        exist = true;
                    }
                }

                reader.Close();
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception)
            {
                // ignored
            }

            return exist;
        }

        private bool SetQrData(string text)
        {
            if (text.Length == 0)
            {
                return false;
            }

            string ok = Resources.ResourceManager.GetString("StatusMessage.OK");
            labelQrStatus.Text = ok;
            if (text.Length >= 3 && text[0] == 'M' && text[1] == ':')
            {
                textBox_partnerQR.Text = text;
                labelPartnerName.Text = Resources.ResourceManager.GetString("Label.AnimalPartner");
            }

            else
                switch (text[0])
                {
                    case 'P':
                    {
                        if (IsValidPlayerId(text.Substring(1), out var name))
                        {
                            textBox_playerQR.Text = text;
                            labelPlayerName.Text = string.Format(
                                Resources.ResourceManager.GetString("Label.PlayerFormat") ?? "{0}",
                                name);
                        }
                        else if (IsExistPlayerId(text.Substring(1)))
                        {
                            labelQrStatus.Text =
                                Resources.ResourceManager.GetString("StatusMessage.UnregisteredPlayerQR");
                            labelPlayerName.Text = "";
                        }
                        else
                        {
                            labelQrStatus.Text =
                                Resources.ResourceManager.GetString("StatusMessage.InvalidPlayerQR");
                            labelPlayerName.Text = "";
                        }

                        break;
                    }
                    case 'G':
                    {
                        switch (GetGameIdType(text.Substring(1), out var gamePlayerName))
                        {
                            case GameIdType.Invalid:
                                labelQrStatus.Text =
                                    Resources.ResourceManager.GetString("StatusMessage.InvalidGameQR");
                                break;
                            case GameIdType.NewGame:
                                textBox_gameQR.Text = text;
                                break;
                            case GameIdType.Partner:
                                textBox_partnerQR.Text = text;
                                if (gamePlayerName.Length > 0)
                                    labelPartnerName.Text = string.Format(
                                        Resources.ResourceManager.GetString("Label.PlayerFormat") ?? "{0}",
                                        gamePlayerName);
                                break;
                        }

                        break;
                    }
                    default:
                        labelQrStatus.Text = Resources.ResourceManager.GetString("StatusMessage.NonSTQR");
                        break;
                }

            labelQrStatus.BackColor = (labelQrStatus.Text == ok)
                ? SystemColors.Control
                : Color.Pink;

            return true;
        }

        public void ChangeLanguage(CultureInfo culture)
        {
            Thread.CurrentThread.CurrentUICulture = culture;
            Resources.Culture = culture;

            // app.configに言語設定を保存
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["Culture"].Value = culture.Name;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            ApplyResources();
        }

        private void ApplyResources()
        {
            // フォームのタイトル
            Text = Resources.ResourceManager.GetString("Form1.Text");

            // タブページ
            tabPage_Main.Text = Resources.ResourceManager.GetString("tabPage_Main.Text");
            tabPage_System.Text = Resources.ResourceManager.GetString("tabPage_System.Text");
            tabPage_Admin.Text = Resources.ResourceManager.GetString("tabPage_Admin.Text");

            // メイン画面のボタン
            buttonLoad.Text = Resources.ResourceManager.GetString("buttonLoad.Text");
            buttonStart.Text = Resources.ResourceManager.GetString("buttonStart.Text");
            buttonStop.Text = Resources.ResourceManager.GetString("buttonStop.Text");
            buttonGoal.Text = Resources.ResourceManager.GetString("buttonGoal.Text");
            buttonInit.Text = Resources.ResourceManager.GetString("buttonInit.Text");

            // ラベル
            label1.Text = Resources.ResourceManager.GetString("label1.Text");
            label2.Text = Resources.ResourceManager.GetString("label2.Text");
            label3.Text = Resources.ResourceManager.GetString("label3.Text");
            label4.Text = Resources.ResourceManager.GetString("label4.Text");
            label5.Text = Resources.ResourceManager.GetString("label5.Text");
            label6.Text = Resources.ResourceManager.GetString("label6.Text");
            label7.Text = Resources.ResourceManager.GetString("label7.Text");
            label8.Text = Resources.ResourceManager.GetString("label8.Text");
            label9.Text = Resources.ResourceManager.GetString("label9.Text");

            // クリアボタン
            buttonClearTags.Text = Resources.ResourceManager.GetString("buttonClearTags.Text");
            buttonClearPlayer.Text = Resources.ResourceManager.GetString("buttonClearPlayer.Text");
            buttonClearPartner.Text = Resources.ResourceManager.GetString("buttonClearPartner.Text");
            buttonClearGame.Text = Resources.ResourceManager.GetString("buttonClearGame.Text");

            // ランダムボタン
            buttonRandomBackground.Text =
                Resources.ResourceManager.GetString("buttonRandomBackground.Text");
            buttonRandomColor.Text = Resources.ResourceManager.GetString("buttonRandomColor.Text");

            // 初期化画面のボタン
            button_Init.Text = Resources.ResourceManager.GetString("button_Init.Text");
            buttonInitSystem.Text = Resources.ResourceManager.GetString("buttonInitSystem.Text");
            buttonInitFloor.Text = Resources.ResourceManager.GetString("buttonInitFloor.Text");
            buttonGotoMain.Text = Resources.ResourceManager.GetString("buttonGotoMain.Text");

            // テキストボックス
            textBox1.Text = Resources.ResourceManager.GetString("textBox1.Text");
            textBox2.Text = Resources.ResourceManager.GetString("textBox2.Text");
            textBox3.Text = Resources.ResourceManager.GetString("textBox3.Text");

            // 管理者画面
            buttonSendAll.Text = Resources.ResourceManager.GetString("buttonSendAll.Text");

            // 状態表示ラベル
            toolStripStatusLabel1.Text =
                Resources.ResourceManager.GetString("toolStripStatusLabel1.Text");

            // プレイヤー情報とパートナー情報のラベル
            labelPlayerName.Text = Resources.ResourceManager.GetString("labelPlayerName.Text");
            labelPartnerName.Text = Resources.ResourceManager.GetString("labelPartnerName.Text");

            // QR状態ラベル
            if (labelQrStatus.Text == "" || labelQrStatus.Text ==
                Resources.ResourceManager.GetString("StatusMessage.OK"))
            {
                labelQrStatus.Text = Resources.ResourceManager.GetString("StatusMessage.OK");
            }

            // 言語切り替えボタン
            languageToggleButton.Text = Thread.CurrentThread.CurrentUICulture.Name == "ja-JP" ? "English" : "日本語";

            // ダイアログテキストは直接適用できないが、必要時に取得
            // MessageBoxなどで使用する際は Properties.Resources.ResourceManager.GetString("Dialog.XXX") を使用

            // 状態メッセージの更新
            UpdateFormButtons(toolStripStatusLabel1.Text);
        }

        private void languageToggleButton_Click(object sender, EventArgs e)
        {
            ChangeLanguage(Thread.CurrentThread.CurrentUICulture.Name == "ja-JP"
                ? new CultureInfo("en")
                : new CultureInfo("ja-JP"));

            languageToggleButton.Text = Resources.languageToggleButton_Text;
        }

        private void readQRTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                var sr = new StreamReader(_qrFile, Encoding.GetEncoding("shift_jis"));
                var texts = sr.ReadToEnd().Split('\r', '\n');
                if (texts.Length == 0)
                {
                    label_QRval.Text = Resources.ResourceManager.GetString("NoQRData");
                }
                else
                {
                    foreach (var s in texts)
                    {
                        if (SetQrData(s))
                        {
                            label_QRval.Text = s;
                        }
                    }
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                ChangeStatus(Resources.ResourceManager.GetString("StatusMessage.QRFileError") + _qrFile +
                             ex.Message);
            }
        }

        // コンボボックスの中身をランダムで選ぶ
        private void ComboBoxRandom(ComboBox combo)
        {
            if (combo.Items.Count != 0)
            {
                combo.SelectedIndex = _random.Next() % combo.Items.Count;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            send_data("START");
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            send_data("STOP");
        }

        private void buttonGoal_Click(object sender, EventArgs e)
        {
            send_data("GOAL");
        }

        private void buttonInit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(Resources.ResourceManager.GetString("Dialog.ConfirmAbortMessage"),
                Resources.ResourceManager.GetString("Dialog.ConfirmAbort"), MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                send_data("INIT");
            }
        }

        private void buttonMute_Click(object sender, EventArgs e)
        {
            send_data("MUTE ON");
        }

        private void buttonBlind_Click(object sender, EventArgs e)
        {
            send_data("SHOUT BLACK");
        }

        private void buttonInitSystem_Click(object sender, EventArgs e)
        {
            send_data("STATE init");
        }

        private void buttonRandomBackground_Click(object sender, EventArgs e)
        {
            ComboBoxRandom(comboBox_Background);
        }

        private void buttonRandomColor_Click(object sender, EventArgs e)
        {
            ComboBoxRandom(comboBox_Color);
        }

        // PONGをうけたらSecondがVisibleになります
        private void button_All_Init_Click(object sender, EventArgs e)
        {
            send_data_raw("INIT", "255.255.255.255", UdpServerRecv);
        }

        private void buttonCalibration_Click(object sender, EventArgs e)
        {
            send_data("STATE calibrating");
            panelThird.Visible = true;
        }

        private void buttonGotoMain_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPage_Main;
        }

        private void buttonSendAll_Click(object sender, EventArgs e)
        {
            send_data(textBoxSendMsg.Text);
            //#	textBoxSendMsg.Text = "";
        }

        private void ResetCustomTags()
        {
            var index = GetPresetTagCount();
            _tagButtons[index + 0].Text = textBox_Tag1.Text;
            _tagButtons[index + 1].Text = textBox_Tag2.Text;
            _tagButtons[index + 2].Text = textBox_Tag3.Text;
            _tagButtons[index + 3].Text = textBox_Tag4.Text;
            _tagButtons[index + 4].Text = textBox_Tag5.Text;
        }

        private void ExtraTagsTextChanged(int num, string s)
        {
            _tagButtons[GetPresetTagCount() + num - 1].Text = s;
        }

        private void textBox_Tag1_TextChanged(object sender, EventArgs e)
        {
            ExtraTagsTextChanged(1, ((TextBox)sender).Text);
        }

        private void textBox_Tag2_TextChanged(object sender, EventArgs e)
        {
            ExtraTagsTextChanged(2, ((TextBox)sender).Text);
        }

        private void textBox_Tag3_TextChanged(object sender, EventArgs e)
        {
            ExtraTagsTextChanged(3, ((TextBox)sender).Text);
        }

        private void textBox_Tag4_TextChanged(object sender, EventArgs e)
        {
            ExtraTagsTextChanged(4, ((TextBox)sender).Text);
        }

        private void textBox_Tag5_TextChanged(object sender, EventArgs e)
        {
            ExtraTagsTextChanged(5, ((TextBox)sender).Text);
        }

        private void buttonClearTags_Click(object sender, EventArgs e)
        {
            ResetAllTags();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void buttonClearPlayer_Click(object sender, EventArgs e)
        {
            textBox_playerQR.Text = "";
            labelPlayerName.Text = "";
        }

        private void buttonClearPartner_Click(object sender, EventArgs e)
        {
            textBox_partnerQR.Text = "";
            labelPartnerName.Text = "";
        }

        private void buttonClearGame_Click(object sender, EventArgs e)
        {
            textBox_gameQR.Text = "";
        }
    }
}