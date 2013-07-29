using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ST_InstructorUI
{
	public partial class Form1 : Form
	{
		private static Form1 self;
		private static bool quit_receive = false;
		UdpClient udp_send;
		UdpClient udp_recv;
		UdpClient ping_recv;
		Thread rcv_thread;
		Random random = new Random();

		int server_port = 0;
		string server_address = null;

		const int UDP_SERVER_RECV = 38702;
		const int UDP_CLIENT_RECV = 38708;
		const int UDP_INTERFACE_RECV = 38709;

		string QR_file = @"c:/ME19/code.txt";

		List<string[]> colors = new List<string[]>();
		List<string[]> backgrounds = new List<string[]>();
		List<string> tags = new List<string>();
		List<CheckBox> tagButtons;


		void ChangeStatus(string text)
		{
			toolStripStatusLabel1.Text = text;
		}

		public Form1()
		{
			InitializeComponent();
			GenerateTags();
			readConfigData();
			setItemContents();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// 最初は初期化タブのみ
			tabControl.TabPages.Remove(tabPage_Main);
			
			UpdateFormButtons("inited");

			self = this;
			udp_send = new UdpClient();
			udp_recv = new UdpClient(UDP_INTERFACE_RECV);
			try {
				ping_recv = new UdpClient(UDP_CLIENT_RECV);
			} catch (Exception) {
				MessageBox.Show("すでにクライアントもしくはUIアプリが起動しています");
				Application.Exit();
			}

			rcv_thread = new Thread(ReceiveProc);
			rcv_thread.Start();

			ResetCustomTags();
			ResetAllGameState();
		}

		// フォームを閉じるとき（ReceiveスレッドをAbortする）
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			readQRTimer.Stop();
			try {
				rcv_thread.Abort();
			} catch (Exception) {
			}
		}

		/********************************************************************************************
		 * UDP送信
		 ********************************************************************************************/
		void send_data_raw(string s, string address, int port)
		{
			//var enc = System.Text.Encoding.UTF8;
			Encoding unicode = Encoding.Unicode;
			Encoding utf8 = Encoding.UTF8;
			byte[] unicodeBytes = unicode.GetBytes(s+"\n");
			byte[] sendBytes = Encoding.Convert(unicode, utf8, unicodeBytes);

			for (int i = 0; i < unicodeBytes.Count(); i++)
				Debug.Print(unicodeBytes[i].ToString() + ",");
			Debug.Print("\n");

			for (int i = 0; i < sendBytes.Count(); i++)
				Debug.Print(sendBytes[i].ToString() + ",");
			Debug.Print("\n");

			try {
				udp_send.Send(sendBytes, sendBytes.Length, address, port);
			} catch (Exception) {
				// send中にWiFiが無効になったりしたときに
				// 落ちるのを防ぐ
			}

			//Thread.Sleep(50);
			Thread.Sleep(1);
			send_log(s);
		}

		void send_data(string s)
		{
			if (server_port != 0 && server_address != null)
			{
				send_data_raw(s, server_address, server_port);
			}
			else
			{
				Debug.Print("Server not found");
			}
		}

		/********************************************************************************************
		 * UDP受信
		 ********************************************************************************************/
		public static void ReceiveProc()
		{
			Debug.Print("begin receive thread");
			while (!quit_receive)
			{
				self.ReceiveThreadProc();
				Thread.Sleep(1);
			}
			Debug.Print("end of receive thread");
		}

		void UpdateSendLog(string text)
		{
			textBoxLog.Text = textBoxLog.Text + "$ " + text + "\r\n";
			textBoxLog.SelectionStart = textBoxLog.Text.Length;
			textBoxLog.Focus();
			textBoxLog.ScrollToCaret();
			textBoxSendMsg.Focus();
		}

		void UpdateRecvLog(string text)
		{
			textBoxLog.Text = textBoxLog.Text + " > " + text + "\r\n";
			textBoxLog.SelectionStart = textBoxLog.Text.Length;
			textBoxLog.Focus();
			textBoxLog.ScrollToCaret();
			textBoxSendMsg.Focus();
		}

		delegate void UpdateTextDelegate(string out_text);
		delegate void DoCommandDelegate(string type, string cmd, string[] arg);

		private void send_log(string s)
		{
			self.Invoke(new UpdateTextDelegate(UpdateSendLog), s);
		}

		private void recv_log(string s)
		{
			self.Invoke(new UpdateTextDelegate(UpdateRecvLog), s);
		}

		private void doCommand(string type, string cmd, string[] arg)
		{
			if (type == "ping")
			{
				if (cmd == "UI_PING" && arg.Length >= 3)
				{
					server_address = arg[1];
					server_port = int.Parse(arg[2]);
					send_data("PONG INSTRUCTOR_UI " + UDP_INTERFACE_RECV);
					ChangeStatus("CONNECTED: "+server_address);
					if (!tabControl.TabPages.Contains(tabPage_Main))
					{
						// 初回PINGのみ、操作タブが増える
						tabControl.TabPages.Add(tabPage_Main);
					}
					panelSecond.Visible = true;
					return;
				}
			} else {
				if (type == "server") {
					if (cmd == "STATE")
					{
						if (arg.Count() < 2)
						{
							recv_log("STATE ERROR");
							return;
						}

						Debug.Print(String.Format("ui was received STATE '{0}'\n", arg[1]));
						UpdateFormButtons(arg[1]);
					}
				}
			}
		}

		private void UpdateFormButtons(string state)
		{
			switch (state)
			{
			case "inited":
				Debug.Print("ui => inited\n");
				ChangeStatus("接続中");
				buttonLoad.Visible = false;
				buttonStart.Visible = false;
				buttonStop.Visible = false;
				buttonGoal.Visible = false;
				buttonInit.Visible = false;
				break;

			case "calibrating":
				Debug.Print("ui => calibrating\n");
				ChangeStatus("床の初期化中");
				buttonLoad.Visible = false;
				buttonStart.Visible = false;
				buttonStop.Visible = false;
				buttonGoal.Visible = false;
				buttonInit.Visible = true;
				break;

			case "ready":
				Debug.Print("ui => ready\n");
				ChangeStatus("出走可能");
				buttonLoad.Visible = true;
				buttonStart.Visible = false;
				buttonStop.Visible = false;
				buttonGoal.Visible = false;
				buttonInit.Visible = true;
				break;

			case "loading":
				Debug.Print("ui => loading\n");
				ChangeStatus("データロード中");
				buttonLoad.Visible = false;
				buttonStart.Visible = false;
				buttonStop.Visible = false;
				buttonGoal.Visible = false;
				buttonInit.Visible = true;
				break;

			case "waiting_run":
				Debug.Print("ui => waiging_run\n");
				ChangeStatus("スタート待ち");
				buttonLoad.Visible = false;
				buttonStart.Visible = true;
				buttonStop.Visible = false;
				buttonGoal.Visible = true;
				buttonInit.Visible = true;
				break;

			case "running":
				Debug.Print("ui => recording\n");
				ChangeStatus("記録中");
				buttonLoad.Visible = false;
				buttonStart.Visible = false;
				buttonStop.Visible = true;
				buttonGoal.Visible = true;
				buttonInit.Visible = true;
				break;

			case "waiting_playback":
				Debug.Print("ui => waiting_playback\n");
				ChangeStatus("記録完了");
				buttonLoad.Visible = false;
				buttonStart.Visible = false;
				buttonStop.Visible = false;
				buttonGoal.Visible = false;
				buttonInit.Visible = true;
				break;

			case "playing_back":
				Debug.Print("ui => playing_back\n");
				ChangeStatus("プレイバック中");
				buttonLoad.Visible = false;
				buttonStart.Visible = false;
				buttonStop.Visible = false;
				buttonGoal.Visible = false;
				buttonInit.Visible = true;
				break;

			case "saving":
				ChangeStatus("保存中");
				buttonLoad.Visible = false;
				buttonStart.Visible = false;
				buttonStop.Visible = false;
				buttonGoal.Visible = false;
				buttonInit.Visible = true;
				break;

			case "error":
				ChangeStatus("動作不良");
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

			if (udp_recv.Available > 0)
			{
				// Receive udp data
				IPEndPoint remoteEP = null;
				byte[] rcvBytes = udp_recv.Receive(ref remoteEP);
				if (rcvBytes.Length > 0)
				{
					Debug.Print("[udp recv] " + rcvBytes.Length.ToString() + " bytes received");
					string rcvMsg = enc.GetString(rcvBytes);
					string[] cmds = rcvMsg.Split(new char[] { ' ', '\t' });
					if (cmds.Length >= 1)
					{
						cmds[0] = cmds[0].ToUpper();
						self.Invoke(new DoCommandDelegate(doCommand), "server", cmds[0], cmds);
					}
					//recv_log(rcvMsg);
				}
			}
			if (ping_recv.Available > 0)
			{
				// Receive udp data
				IPEndPoint remoteEP = null;
				byte[] rcvBytes = ping_recv.Receive(ref remoteEP);
				if (rcvBytes.Length > 0) {
					Debug.Print("[ping recv] " + rcvBytes.Length.ToString() + " bytes received");
					string rcvMsg = enc.GetString(rcvBytes);
					string[] cmds = rcvMsg.Split(new char[] { ' ', '\t' });
					if (cmds.Length >= 1)
					{
						cmds[0] = cmds[0].ToUpper();
						self.Invoke(new DoCommandDelegate(doCommand), "ping", cmds[0], cmds);
					}
					//recv_log(rcvMsg);
				}
			}

		}

		/********************************************************************************************
			* 外部ファイルデータの読み書き
			********************************************************************************************/
		void readConfigTxt()
		{
			var sr = new StreamReader(@"CONFIG.txt", Encoding.GetEncoding("shift_jis"));
			while (sr.Peek()>0)
			{
				var line = sr.ReadLine();
				var elements = line.Split('=');
				if (elements.Count() >= 2 && elements[0] == "QRFILE")
					QR_file = elements[1];
			}
			sr.Close();
		}

		void readColorsTxt()
		{
			var sr = new StreamReader(@"C:\ST\UI\COLORS.txt", Encoding.GetEncoding("shift_jis"));
			while (sr.Peek()>0)
			{
				var line = sr.ReadLine();
				var elements = line.Split('\t');
				colors.Add(elements);
			}
			sr.Close();
		}

		void readBackgroundTxt()
		{
			var sr = new StreamReader(@"C:\ST\UI\BACKGROUNDS.txt", Encoding.GetEncoding("shift_jis"));
			while (sr.Peek()>0)
			{
				var line = sr.ReadLine();
				var elements = line.Split('\t');
				backgrounds.Add(elements);
			}
			sr.Close();
		}

		void readTagsTxt()
		{
			var sr = new StreamReader(@"C:\ST\UI\TAGS.txt", Encoding.GetEncoding("shift_jis"));
			while (sr.Peek()>0)
			{
				var tag = sr.ReadLine();
				tags.Add(tag);
			}
			sr.Close();
		}

		private void readConfigData()
		{
			try { readConfigTxt(); }
			catch (Exception ex) { Console.WriteLine(ex.Message); }

			try { readColorsTxt(); }
			catch (Exception ex) { Console.WriteLine(ex.Message); }

			try { readBackgroundTxt(); }
			catch (Exception ex) { Console.WriteLine(ex.Message); }

			try { readTagsTxt(); }
			catch (Exception ex) { Console.WriteLine(ex.Message); }
		}

		private void setItemContents()
		{
			{
				var combo = comboBox_Background;
				combo.BeginUpdate();
				for (int i = 0; i < backgrounds.Count; ++i)
					combo.Items.Add(backgrounds[i][1]);
				combo.EndUpdate();
			}

			{
				var combo = comboBox_Color;
				combo.BeginUpdate();
				for (int i = 0; i < colors.Count; ++i)
					combo.Items.Add(colors[i][1]);
				combo.EndUpdate();
			}

			for (int i = 0; i < tags.Count; ++i)
			{
				if (i < getPresetTagCount())
				{
					tagButtons[i].Text = tags[i];
				}
			}
		}


		/********************************************************************************************
		 * タグボタンの生成と動作
		 ********************************************************************************************/
		void GenerateTags()
		{
			tagButtons = new List<CheckBox>();
			for (int i=0; i<35; ++i)
			{
				CheckBox cell = new CheckBox();
				cell.Appearance = Appearance.Button;
				cell.Dock = DockStyle.Fill;
				cell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				cell.Margin = new Padding(0,0,0,0);
				tableLayoutPanel_Tag.Controls.Add(cell, -1, -1);
				tagButtons.Add(cell);
			}
		}

		/********************************************************************************************
			* コントロールイベントハンドラ
			********************************************************************************************/
		int getPresetTagCount()
		{
			return (tableLayoutPanel_Tag.ColumnCount) * (tableLayoutPanel_Tag.RowCount-1);
		}
		int getAllTagCount()
		{
			return tableLayoutPanel_Tag.ColumnCount * tableLayoutPanel_Tag.RowCount;
		}

		private void buttonLoad_Click(object sender, EventArgs e)
		{
			bool exist_player_qr = (textBox_playerQR.Text!="");
			bool exist_game_qr   = (textBox_gameQR.Text!="");
			if (exist_player_qr && exist_game_qr)
			{
				// 両方ある
			}
			else if (!exist_player_qr && !exist_game_qr)
			{
				// 両方ない
				var yesno = MessageBox.Show("走ったデータは記録されません。\nよいですか？", "確認です", MessageBoxButtons.YesNo);
				if (yesno==DialogResult.No)
				{
					return;
				}
			}
			else
			{
				var yesno = MessageBox.Show("走ったデータは記録されません。\nよいですか？", "確認です", MessageBoxButtons.YesNo);
				if (yesno==DialogResult.No)
				{
					return;
				}
			}


			int n;
			n = comboBox_Color.SelectedIndex;
			if (n >= 0) send_data("COLOR "+colors[n][0]);
			n = comboBox_Background.SelectedIndex;
			if (n >= 0) send_data("BACKGROUND "+backgrounds[n][0]);

			for (int i=0; i<getAllTagCount(); ++i)
			{
				CheckBox cell = tagButtons[i];
				if (cell.Checked)
				{
					send_data("TAG " + cell.Text);
					Debug.Print("TAG " + cell.Text+ "\n");
				}
			}
			string[]  partners = textBox_partnerQR.Text.Split(',');
			for (int i = 0; i < partners.Count(); i++)
				if (partners[i] != "") send_data("PARTNER " + partners[i]);
			string playerQR = textBox_playerQR.Text != "" ? textBox_playerQR.Text : "AJ3M";
			string recordQR = textBox_gameQR.Text != "" ? textBox_gameQR.Text : "99N3B";
			send_data("IDENT " + playerQR + " " + recordQR);

			ResetAllGameState();
		}

		void ResetAllTags()
		{
			for (int i=0; i<getAllTagCount(); ++i)
			{
				tagButtons[i].Checked = false;
			}
		}

		void ResetAllGameState()
		{
			ComboBoxRandom(comboBox_Background);
			ComboBoxRandom(comboBox_Color);
			textBox_playerQR.Text  = "";
			textBox_partnerQR.Text = "";
			textBox_gameQR.Text    = "";
			id_info.Clear();
		}

		string GetConnString()
		{
			return
				"Server = ST_SERVER;" +
				"Database = ST;" +
				"User ID = st_user;" +
				"Password = eureka;";
		}

		enum GameIdType
		{
			Invalid,
			NewGame,
			Partner,
		}
		struct IdInfo
		{
			public GameIdType idtype;
			public string player_name;
		}
		Dictionary<string,IdInfo> id_info = new Dictionary<string,IdInfo>();

		// ゲームIDをDBから読み取り、新規IDかパートナーIDか、不正であるかを判別
		GameIdType GetGameIdType(string id, out string player_name)
		{
			player_name = "";

			// cached
			if (id_info.ContainsKey(id))
			{
				player_name = id_info[id].player_name;
				return id_info[id].idtype;
			}

			GameIdType gid = GameIdType.Invalid;
			try
			{
				var conn = new MySqlConnection(GetConnString());
				conn.Open();
				string player_id = "";
				{
					string sql = "SELECT player_id FROM records WHERE record_id='"+id+"' OR record_id='G"+id+"' ORDER BY ID DESC";
					var cmd = conn.CreateCommand();
					cmd.CommandText = sql;
					MySqlDataReader reader = cmd.ExecuteReader();
					while (reader.Read())
					{
						if (reader.FieldCount==0)
							continue;
						var x = reader[0];
						if (x.GetType() == typeof(System.DBNull))
						{
							gid = GameIdType.NewGame;
						}
						else
						{
							player_id = x.ToString();
							gid = GameIdType.Partner;
						}
						break;
					}
					reader.Close();
					cmd.Dispose();
				}

				if (player_id.Length>0)
				{
					// プレイヤーIDがあるのなら名前をひく
					// 名前はPなしIDからもらう
					string sql = "SELECT names.username FROM users LEFT JOIN names ON names.user_id = users.id WHERE users.player_id='"+player_id.Substring(1)+"'";
					var cmd = conn.CreateCommand();
					cmd.CommandText = sql;
					MySqlDataReader reader = cmd.ExecuteReader();
					while (reader.Read())
					{
						if (reader.FieldCount==0)
							continue;
						var x = reader[0];
						if (x.GetType()!=typeof(System.DBNull))
						{
							player_name = x.ToString();
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
			ii.idtype = gid;
			ii.player_name = player_name;
			id_info[id] = ii;
			return gid;
		}

		// プレイヤーIDの正当性の確認
		bool IsValidPlayerId(string id, out string player_name)
		{
			bool valid = false;
			player_name = "";
			try
			{
				var conn = new MySqlConnection(GetConnString());
				conn.Open();

				string sql = "SELECT * FROM names left join users on names.user_id=users.id WHERE users.player_id='"+id+"' OR player_id='P"+id+"'";

				var cmd = conn.CreateCommand();
				cmd.CommandText = sql;
				MySqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					if (reader.FieldCount==0)
					{
					}
					else
					{
						// 見つかったらValidだ
						valid = true;
						player_name = reader["username"].ToString();
					}
				}
				reader.Close();
				cmd.Dispose();
				conn.Close();
			}
			catch (Exception)
			{
			}

			return valid;
		}
		bool IsExistPlayerId(string id)
		{
			bool exist = false;
			try
			{
				var conn = new MySqlConnection(GetConnString());
				conn.Open();

				string sql = "SELECT * FROM users WHERE users.player_id='"+id+"' OR player_id='P"+id+"'";

				var cmd = conn.CreateCommand();
				cmd.CommandText = sql;
				MySqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					if (reader.FieldCount==0)
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
			}

			return exist;
		}

		bool setQrData(string text)
		{
			if (text.Length==0)
			{
				return false;
			}

			string ok = "Ok";
			labelQrStatus.Text = ok;
			if (text.Length>=3 && text[0]=='M' && text[1]==':')
			{
				textBox_partnerQR.Text = text;
				labelPartnerName.Text = "どうぶつ";
			}
			else if (text[0]=='P')
			{
				string name;
				if (IsValidPlayerId(text.Substring(1), out name))
				{
					textBox_playerQR.Text =  text;
					labelPlayerName.Text = name+" さん";
				}
				else if (IsExistPlayerId(text.Substring(1)))
				{
					labelQrStatus.Text = "登録されていないプレイヤーQRコードです";
					labelPlayerName.Text = "";
				}
				else
				{
					labelQrStatus.Text = "存在しないプレイヤーQRコードです";
					labelPlayerName.Text = "";
				}
			}
			else if (text[0]=='G')
			{
				string gameplayer_name;
				switch (GetGameIdType(text.Substring(1), out gameplayer_name))
				{
				case GameIdType.Invalid:
					labelQrStatus.Text = "ただしくないゲームQRコードです";
					break;
				case GameIdType.NewGame:
					textBox_gameQR.Text = text;
					break;
				case GameIdType.Partner:
					textBox_partnerQR.Text = text;
					if (gameplayer_name.Length>0)
						labelPartnerName.Text = gameplayer_name+" さん";
					break;
				}
			}
			else
			{
				labelQrStatus.Text = "スポーツタイムマシン以外のQRコードです";
			}
			labelQrStatus.BackColor = (labelQrStatus.Text==ok)
				? System.Drawing.SystemColors.Control
				: System.Drawing.Color.Pink;
			
			return true;
		}

		private void readQRTimer_Tick(object sender, EventArgs e)
		{
			try
			{
				var sr = new StreamReader(QR_file, Encoding.GetEncoding("shift_jis"));
				string[] texts = sr.ReadToEnd().Split(new char[]{'\r','\n'});
				if (texts.Length==0)
				{
					label_QRval.Text = "#NODATA#";
				}
				else
				{
					foreach (var s in texts)
					{
						if (setQrData(s))
						{
							label_QRval.Text = s;
						}
					}
				}
				sr.Close();
			}
			catch (Exception ex)
			{
				ChangeStatus("QRファイルが読めません" + QR_file + ex.Message);
			}
		}

		// コンボボックスの中身をランダムで選ぶ
		private void ComboBoxRandom(ComboBox combo)
		{
			if (combo.Items.Count!=0)
			{
				combo.SelectedIndex = random.Next() % combo.Items.Count;
			}
		}

		private void buttonStart_Click(object sender, EventArgs e)
			{ send_data("START"); }
		private void buttonStop_Click(object sender, EventArgs e)
			{ send_data("STOP"); }
		private void buttonGoal_Click(object sender, EventArgs e)
			{ send_data("GOAL"); }
		private void buttonInit_Click(object sender, EventArgs e)
			{ send_data("INIT"); }
		private void buttonMute_Click(object sender, EventArgs e)
			{ send_data("MUTE ON"); }
		private void buttonBlind_Click(object sender, EventArgs e)
			{ send_data("SHOUT BLACK"); }
		private void buttonInitSystem_Click(object sender, EventArgs e)
			{ send_data("STATE init"); }
		private void buttonRandomBackground_Click(object sender, EventArgs e)
			{ ComboBoxRandom(comboBox_Background); }
		private void buttonRandomColor_Click(object sender, EventArgs e)
			{ ComboBoxRandom(comboBox_Color); }

		// PONGをうけたらSecondがVisibleになります
		private void button_All_Init_Click(object sender, EventArgs e)
			{ send_data_raw("INIT", "255.255.255.255", UDP_SERVER_RECV); }
		private void buttonCalibration_Click(object sender, EventArgs e)
			{ send_data("STATE calibrating");
			  panelThird.Visible = true; }
		private void buttonGotoMain_Click(object sender, EventArgs e)
			{ tabControl.SelectedTab = tabPage_Main; }

		private void buttonSendAll_Click(object sender, EventArgs e)
		{
			send_data(textBoxSendMsg.Text);
		//#	textBoxSendMsg.Text = "";
		}

		void ResetCustomTags()
		{
			int index = getPresetTagCount();
			tagButtons[index+0].Text = textBox_Tag1.Text;
			tagButtons[index+1].Text = textBox_Tag2.Text;
			tagButtons[index+2].Text = textBox_Tag3.Text;
			tagButtons[index+3].Text = textBox_Tag4.Text;
			tagButtons[index+4].Text = textBox_Tag5.Text;
		}

		private void ExtraTagsTextChanged(int num, string s)
		{
			tagButtons[getPresetTagCount()+num-1].Text = s;
		}

		private void textBox_Tag1_TextChanged(object sender, EventArgs e)
			{ ExtraTagsTextChanged(1, ((TextBox)sender).Text); }
		private void textBox_Tag2_TextChanged(object sender, EventArgs e)
			{ ExtraTagsTextChanged(2, ((TextBox)sender).Text); }
		private void textBox_Tag3_TextChanged(object sender, EventArgs e)
			{ ExtraTagsTextChanged(3, ((TextBox)sender).Text); }
		private void textBox_Tag4_TextChanged(object sender, EventArgs e)
			{ ExtraTagsTextChanged(4, ((TextBox)sender).Text); }
		private void textBox_Tag5_TextChanged(object sender, EventArgs e)
			{ ExtraTagsTextChanged(5, ((TextBox)sender).Text); }

		private void buttonClearTags_Click(object sender, EventArgs e)
		{
			ResetAllTags();
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{

		}

		private void buttonClearPlayer_Click(object sender, EventArgs e)
			{ textBox_playerQR.Text = "";
			  labelPlayerName.Text = ""; }
		private void buttonClearPartner_Click(object sender, EventArgs e)
			{ textBox_partnerQR.Text = "";
			  labelPartnerName.Text = ""; }
		private void buttonClearGame_Click(object sender, EventArgs e)
			{ textBox_gameQR.Text = ""; }
	}
}
