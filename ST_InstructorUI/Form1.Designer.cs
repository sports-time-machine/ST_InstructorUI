namespace ST_InstructorUI
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.readQRTimer = new System.Windows.Forms.Timer(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage_Main = new System.Windows.Forms.TabPage();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.buttonClearGame = new System.Windows.Forms.Button();
			this.buttonClearPartner = new System.Windows.Forms.Button();
			this.buttonClearPlayer = new System.Windows.Forms.Button();
			this.labelPlayerName = new System.Windows.Forms.Label();
			this.buttonClearTags = new System.Windows.Forms.Button();
			this.labelQrStatus = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonRandomColor = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonRandomBackground = new System.Windows.Forms.Button();
			this.label_QRval = new System.Windows.Forms.Label();
			this.tableLayoutPanel_Tag = new System.Windows.Forms.TableLayoutPanel();
			this.comboBox_Color = new System.Windows.Forms.ComboBox();
			this.comboBox_Background = new System.Windows.Forms.ComboBox();
			this.textBox_gameQR = new System.Windows.Forms.TextBox();
			this.textBox_partnerQR = new System.Windows.Forms.TextBox();
			this.textBox_playerQR = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox_Tag3 = new System.Windows.Forms.TextBox();
			this.textBox_Tag5 = new System.Windows.Forms.TextBox();
			this.textBox_Tag2 = new System.Windows.Forms.TextBox();
			this.textBox_Tag4 = new System.Windows.Forms.TextBox();
			this.buttonLoad = new System.Windows.Forms.Button();
			this.textBox_Tag1 = new System.Windows.Forms.TextBox();
			this.buttonStop = new System.Windows.Forms.Button();
			this.buttonStart = new System.Windows.Forms.Button();
			this.buttonGoal = new System.Windows.Forms.Button();
			this.buttonInit = new System.Windows.Forms.Button();
			this.tabPage_System = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.panelThird = new System.Windows.Forms.Panel();
			this.buttonGotoMain = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.panelSecond = new System.Windows.Forms.Panel();
			this.buttonInitFloor = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.panelFirst = new System.Windows.Forms.Panel();
			this.buttonInitSystem = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button_Init = new System.Windows.Forms.Button();
			this.tabPage_Admin = new System.Windows.Forms.TabPage();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.textBoxLog = new System.Windows.Forms.TextBox();
			this.splitContainer4 = new System.Windows.Forms.SplitContainer();
			this.textBoxSendMsg = new System.Windows.Forms.TextBox();
			this.buttonSendAll = new System.Windows.Forms.Button();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPage_Main.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.tabPage_System.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panelThird.SuspendLayout();
			this.panelSecond.SuspendLayout();
			this.panelFirst.SuspendLayout();
			this.tabPage_Admin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
			this.splitContainer4.Panel1.SuspendLayout();
			this.splitContainer4.Panel2.SuspendLayout();
			this.splitContainer4.SuspendLayout();
			this.SuspendLayout();
			// 
			// readQRTimer
			// 
			this.readQRTimer.Enabled = true;
			this.readQRTimer.Interval = 200;
			this.readQRTimer.Tick += new System.EventHandler(this.readQRTimer_Tick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 0);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(928, 29);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(25, 24);
			this.toolStripStatusLabel1.Text = "OK";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tabControl);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
			this.splitContainer1.Size = new System.Drawing.Size(928, 662);
			this.splitContainer1.SplitterDistance = 632;
			this.splitContainer1.SplitterWidth = 1;
			this.splitContainer1.TabIndex = 2;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPage_Main);
			this.tabControl.Controls.Add(this.tabPage_System);
			this.tabControl.Controls.Add(this.tabPage_Admin);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(928, 632);
			this.tabControl.TabIndex = 2;
			// 
			// tabPage_Main
			// 
			this.tabPage_Main.BackColor = System.Drawing.Color.Gainsboro;
			this.tabPage_Main.Controls.Add(this.splitContainer2);
			this.tabPage_Main.Location = new System.Drawing.Point(4, 27);
			this.tabPage_Main.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.tabPage_Main.Name = "tabPage_Main";
			this.tabPage_Main.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.tabPage_Main.Size = new System.Drawing.Size(920, 601);
			this.tabPage_Main.TabIndex = 0;
			this.tabPage_Main.Text = "メイン画面";
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer2.Location = new System.Drawing.Point(2, 3);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.buttonClearGame);
			this.splitContainer2.Panel1.Controls.Add(this.buttonClearPartner);
			this.splitContainer2.Panel1.Controls.Add(this.buttonClearPlayer);
			this.splitContainer2.Panel1.Controls.Add(this.labelPlayerName);
			this.splitContainer2.Panel1.Controls.Add(this.buttonClearTags);
			this.splitContainer2.Panel1.Controls.Add(this.labelQrStatus);
			this.splitContainer2.Panel1.Controls.Add(this.label6);
			this.splitContainer2.Panel1.Controls.Add(this.label5);
			this.splitContainer2.Panel1.Controls.Add(this.label4);
			this.splitContainer2.Panel1.Controls.Add(this.buttonRandomColor);
			this.splitContainer2.Panel1.Controls.Add(this.label3);
			this.splitContainer2.Panel1.Controls.Add(this.label2);
			this.splitContainer2.Panel1.Controls.Add(this.label1);
			this.splitContainer2.Panel1.Controls.Add(this.buttonRandomBackground);
			this.splitContainer2.Panel1.Controls.Add(this.label_QRval);
			this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel_Tag);
			this.splitContainer2.Panel1.Controls.Add(this.comboBox_Color);
			this.splitContainer2.Panel1.Controls.Add(this.comboBox_Background);
			this.splitContainer2.Panel1.Controls.Add(this.textBox_gameQR);
			this.splitContainer2.Panel1.Controls.Add(this.textBox_partnerQR);
			this.splitContainer2.Panel1.Controls.Add(this.textBox_playerQR);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.label8);
			this.splitContainer2.Panel2.Controls.Add(this.label7);
			this.splitContainer2.Panel2.Controls.Add(this.textBox_Tag3);
			this.splitContainer2.Panel2.Controls.Add(this.textBox_Tag5);
			this.splitContainer2.Panel2.Controls.Add(this.textBox_Tag2);
			this.splitContainer2.Panel2.Controls.Add(this.textBox_Tag4);
			this.splitContainer2.Panel2.Controls.Add(this.buttonLoad);
			this.splitContainer2.Panel2.Controls.Add(this.textBox_Tag1);
			this.splitContainer2.Panel2.Controls.Add(this.buttonStop);
			this.splitContainer2.Panel2.Controls.Add(this.buttonStart);
			this.splitContainer2.Panel2.Controls.Add(this.buttonGoal);
			this.splitContainer2.Panel2.Controls.Add(this.buttonInit);
			this.splitContainer2.Size = new System.Drawing.Size(916, 595);
			this.splitContainer2.SplitterDistance = 588;
			this.splitContainer2.SplitterWidth = 10;
			this.splitContainer2.TabIndex = 0;
			// 
			// buttonClearGame
			// 
			this.buttonClearGame.Location = new System.Drawing.Point(347, 97);
			this.buttonClearGame.Margin = new System.Windows.Forms.Padding(0);
			this.buttonClearGame.Name = "buttonClearGame";
			this.buttonClearGame.Size = new System.Drawing.Size(52, 38);
			this.buttonClearGame.TabIndex = 21;
			this.buttonClearGame.Text = "クリア";
			this.buttonClearGame.UseVisualStyleBackColor = true;
			this.buttonClearGame.Click += new System.EventHandler(this.buttonClearGame_Click);
			// 
			// buttonClearPartner
			// 
			this.buttonClearPartner.Location = new System.Drawing.Point(347, 57);
			this.buttonClearPartner.Margin = new System.Windows.Forms.Padding(0);
			this.buttonClearPartner.Name = "buttonClearPartner";
			this.buttonClearPartner.Size = new System.Drawing.Size(52, 38);
			this.buttonClearPartner.TabIndex = 20;
			this.buttonClearPartner.Text = "クリア";
			this.buttonClearPartner.UseVisualStyleBackColor = true;
			this.buttonClearPartner.Click += new System.EventHandler(this.buttonClearPartner_Click);
			// 
			// buttonClearPlayer
			// 
			this.buttonClearPlayer.Location = new System.Drawing.Point(347, 17);
			this.buttonClearPlayer.Margin = new System.Windows.Forms.Padding(0);
			this.buttonClearPlayer.Name = "buttonClearPlayer";
			this.buttonClearPlayer.Size = new System.Drawing.Size(52, 38);
			this.buttonClearPlayer.TabIndex = 19;
			this.buttonClearPlayer.Text = "クリア";
			this.buttonClearPlayer.UseVisualStyleBackColor = true;
			this.buttonClearPlayer.Click += new System.EventHandler(this.buttonClearPlayer_Click);
			// 
			// labelPlayerName
			// 
			this.labelPlayerName.AutoSize = true;
			this.labelPlayerName.Font = new System.Drawing.Font("メイリオ", 10F);
			this.labelPlayerName.Location = new System.Drawing.Point(402, 28);
			this.labelPlayerName.Name = "labelPlayerName";
			this.labelPlayerName.Size = new System.Drawing.Size(178, 21);
			this.labelPlayerName.TabIndex = 18;
			this.labelPlayerName.Text = "ここに名前が表示されます";
			// 
			// buttonClearTags
			// 
			this.buttonClearTags.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonClearTags.Location = new System.Drawing.Point(30, 509);
			this.buttonClearTags.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.buttonClearTags.Name = "buttonClearTags";
			this.buttonClearTags.Size = new System.Drawing.Size(86, 70);
			this.buttonClearTags.TabIndex = 17;
			this.buttonClearTags.Text = "全タグの選択解除";
			this.buttonClearTags.UseVisualStyleBackColor = true;
			this.buttonClearTags.Click += new System.EventHandler(this.buttonClearTags_Click);
			// 
			// labelQrStatus
			// 
			this.labelQrStatus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.labelQrStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelQrStatus.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelQrStatus.Location = new System.Drawing.Point(275, 139);
			this.labelQrStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelQrStatus.Name = "labelQrStatus";
			this.labelQrStatus.Size = new System.Drawing.Size(284, 39);
			this.labelQrStatus.TabIndex = 16;
			this.labelQrStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("メイリオ", 12F);
			this.label6.Location = new System.Drawing.Point(349, 512);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(122, 24);
			this.label6.TabIndex = 15;
			this.label6.Text = "プレイヤーの色";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("メイリオ", 12F);
			this.label5.Location = new System.Drawing.Point(165, 512);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 24);
			this.label5.TabIndex = 14;
			this.label5.Text = "背景";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("メイリオ", 9F);
			this.label4.Location = new System.Drawing.Point(27, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(97, 18);
			this.label4.TabIndex = 13;
			this.label4.Text = "カメラからのQR";
			// 
			// buttonRandomColor
			// 
			this.buttonRandomColor.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonRandomColor.Location = new System.Drawing.Point(476, 501);
			this.buttonRandomColor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.buttonRandomColor.Name = "buttonRandomColor";
			this.buttonRandomColor.Size = new System.Drawing.Size(93, 47);
			this.buttonRandomColor.TabIndex = 6;
			this.buttonRandomColor.Text = "ランダム";
			this.buttonRandomColor.UseVisualStyleBackColor = true;
			this.buttonRandomColor.Click += new System.EventHandler(this.buttonRandomColor_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("メイリオ", 12F);
			this.label3.Location = new System.Drawing.Point(11, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(113, 24);
			this.label3.TabIndex = 9;
			this.label3.Text = "パートナーQR";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("メイリオ", 12F);
			this.label2.Location = new System.Drawing.Point(27, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 24);
			this.label2.TabIndex = 10;
			this.label2.Text = "記録するQR";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("メイリオ", 12F);
			this.label1.Location = new System.Drawing.Point(11, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 24);
			this.label1.TabIndex = 8;
			this.label1.Text = "プレイヤーQR";
			// 
			// buttonRandomBackground
			// 
			this.buttonRandomBackground.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonRandomBackground.Location = new System.Drawing.Point(241, 501);
			this.buttonRandomBackground.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.buttonRandomBackground.Name = "buttonRandomBackground";
			this.buttonRandomBackground.Size = new System.Drawing.Size(93, 47);
			this.buttonRandomBackground.TabIndex = 4;
			this.buttonRandomBackground.Text = "ランダム";
			this.buttonRandomBackground.UseVisualStyleBackColor = true;
			this.buttonRandomBackground.Click += new System.EventHandler(this.buttonRandomBackground_Click);
			// 
			// label_QRval
			// 
			this.label_QRval.BackColor = System.Drawing.SystemColors.Info;
			this.label_QRval.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label_QRval.Font = new System.Drawing.Font("Consolas", 12F);
			this.label_QRval.Location = new System.Drawing.Point(129, 140);
			this.label_QRval.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label_QRval.Name = "label_QRval";
			this.label_QRval.Size = new System.Drawing.Size(142, 38);
			this.label_QRval.TabIndex = 7;
			this.label_QRval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel_Tag
			// 
			this.tableLayoutPanel_Tag.BackColor = System.Drawing.Color.Transparent;
			this.tableLayoutPanel_Tag.ColumnCount = 5;
			this.tableLayoutPanel_Tag.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel_Tag.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel_Tag.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel_Tag.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel_Tag.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel_Tag.Location = new System.Drawing.Point(30, 192);
			this.tableLayoutPanel_Tag.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.tableLayoutPanel_Tag.Name = "tableLayoutPanel_Tag";
			this.tableLayoutPanel_Tag.RowCount = 7;
			this.tableLayoutPanel_Tag.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			this.tableLayoutPanel_Tag.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.tableLayoutPanel_Tag.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.tableLayoutPanel_Tag.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.tableLayoutPanel_Tag.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.tableLayoutPanel_Tag.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.tableLayoutPanel_Tag.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
			this.tableLayoutPanel_Tag.Size = new System.Drawing.Size(537, 288);
			this.tableLayoutPanel_Tag.TabIndex = 11;
			// 
			// comboBox_Color
			// 
			this.comboBox_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Color.Font = new System.Drawing.Font("メイリオ", 12F);
			this.comboBox_Color.FormattingEnabled = true;
			this.comboBox_Color.Location = new System.Drawing.Point(359, 548);
			this.comboBox_Color.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.comboBox_Color.Name = "comboBox_Color";
			this.comboBox_Color.Size = new System.Drawing.Size(210, 32);
			this.comboBox_Color.TabIndex = 5;
			// 
			// comboBox_Background
			// 
			this.comboBox_Background.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Background.Font = new System.Drawing.Font("メイリオ", 12F);
			this.comboBox_Background.FormattingEnabled = true;
			this.comboBox_Background.Location = new System.Drawing.Point(124, 548);
			this.comboBox_Background.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.comboBox_Background.Name = "comboBox_Background";
			this.comboBox_Background.Size = new System.Drawing.Size(210, 32);
			this.comboBox_Background.TabIndex = 3;
			// 
			// textBox_gameQR
			// 
			this.textBox_gameQR.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_gameQR.Location = new System.Drawing.Point(129, 97);
			this.textBox_gameQR.Margin = new System.Windows.Forms.Padding(2);
			this.textBox_gameQR.Name = "textBox_gameQR";
			this.textBox_gameQR.Size = new System.Drawing.Size(216, 36);
			this.textBox_gameQR.TabIndex = 2;
			this.textBox_gameQR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox_partnerQR
			// 
			this.textBox_partnerQR.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_partnerQR.Location = new System.Drawing.Point(129, 57);
			this.textBox_partnerQR.Margin = new System.Windows.Forms.Padding(2);
			this.textBox_partnerQR.Name = "textBox_partnerQR";
			this.textBox_partnerQR.Size = new System.Drawing.Size(216, 36);
			this.textBox_partnerQR.TabIndex = 1;
			this.textBox_partnerQR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox_playerQR
			// 
			this.textBox_playerQR.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_playerQR.Location = new System.Drawing.Point(129, 17);
			this.textBox_playerQR.Margin = new System.Windows.Forms.Padding(2);
			this.textBox_playerQR.Name = "textBox_playerQR";
			this.textBox_playerQR.Size = new System.Drawing.Size(216, 36);
			this.textBox_playerQR.TabIndex = 0;
			this.textBox_playerQR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("メイリオ", 9F);
			this.label8.Location = new System.Drawing.Point(3, 212);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(104, 18);
			this.label8.TabIndex = 22;
			this.label8.Text = "開始や終了の命令";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("メイリオ", 9F);
			this.label7.Location = new System.Drawing.Point(3, 11);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(212, 18);
			this.label7.TabIndex = 16;
			this.label7.Text = "追加のタグ（最下段に反映されます）";
			// 
			// textBox_Tag3
			// 
			this.textBox_Tag3.Font = new System.Drawing.Font("メイリオ", 12F);
			this.textBox_Tag3.Location = new System.Drawing.Point(2, 95);
			this.textBox_Tag3.Margin = new System.Windows.Forms.Padding(0);
			this.textBox_Tag3.Name = "textBox_Tag3";
			this.textBox_Tag3.Size = new System.Drawing.Size(270, 31);
			this.textBox_Tag3.TabIndex = 21;
			this.textBox_Tag3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox_Tag3.TextChanged += new System.EventHandler(this.textBox_Tag3_TextChanged);
			// 
			// textBox_Tag5
			// 
			this.textBox_Tag5.Font = new System.Drawing.Font("メイリオ", 12F);
			this.textBox_Tag5.Location = new System.Drawing.Point(2, 157);
			this.textBox_Tag5.Margin = new System.Windows.Forms.Padding(0);
			this.textBox_Tag5.Name = "textBox_Tag5";
			this.textBox_Tag5.Size = new System.Drawing.Size(270, 31);
			this.textBox_Tag5.TabIndex = 17;
			this.textBox_Tag5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox_Tag5.TextChanged += new System.EventHandler(this.textBox_Tag5_TextChanged);
			// 
			// textBox_Tag2
			// 
			this.textBox_Tag2.Font = new System.Drawing.Font("メイリオ", 12F);
			this.textBox_Tag2.Location = new System.Drawing.Point(2, 64);
			this.textBox_Tag2.Margin = new System.Windows.Forms.Padding(0);
			this.textBox_Tag2.Name = "textBox_Tag2";
			this.textBox_Tag2.Size = new System.Drawing.Size(270, 31);
			this.textBox_Tag2.TabIndex = 20;
			this.textBox_Tag2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox_Tag2.TextChanged += new System.EventHandler(this.textBox_Tag2_TextChanged);
			// 
			// textBox_Tag4
			// 
			this.textBox_Tag4.Font = new System.Drawing.Font("メイリオ", 12F);
			this.textBox_Tag4.Location = new System.Drawing.Point(2, 126);
			this.textBox_Tag4.Margin = new System.Windows.Forms.Padding(0);
			this.textBox_Tag4.Name = "textBox_Tag4";
			this.textBox_Tag4.Size = new System.Drawing.Size(270, 31);
			this.textBox_Tag4.TabIndex = 16;
			this.textBox_Tag4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox_Tag4.TextChanged += new System.EventHandler(this.textBox_Tag4_TextChanged);
			// 
			// buttonLoad
			// 
			this.buttonLoad.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonLoad.Location = new System.Drawing.Point(2, 233);
			this.buttonLoad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(270, 64);
			this.buttonLoad.TabIndex = 0;
			this.buttonLoad.Text = "出走の準備";
			this.buttonLoad.UseVisualStyleBackColor = true;
			this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
			// 
			// textBox_Tag1
			// 
			this.textBox_Tag1.Font = new System.Drawing.Font("メイリオ", 12F);
			this.textBox_Tag1.Location = new System.Drawing.Point(2, 32);
			this.textBox_Tag1.Margin = new System.Windows.Forms.Padding(0);
			this.textBox_Tag1.Name = "textBox_Tag1";
			this.textBox_Tag1.Size = new System.Drawing.Size(270, 31);
			this.textBox_Tag1.TabIndex = 19;
			this.textBox_Tag1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox_Tag1.TextChanged += new System.EventHandler(this.textBox_Tag1_TextChanged);
			// 
			// buttonStop
			// 
			this.buttonStop.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold);
			this.buttonStop.Location = new System.Drawing.Point(2, 372);
			this.buttonStop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size(270, 64);
			this.buttonStop.TabIndex = 2;
			this.buttonStop.Text = "やりなおし";
			this.buttonStop.UseVisualStyleBackColor = true;
			this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
			// 
			// buttonStart
			// 
			this.buttonStart.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold);
			this.buttonStart.Location = new System.Drawing.Point(2, 302);
			this.buttonStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(270, 64);
			this.buttonStart.TabIndex = 1;
			this.buttonStart.Text = "スタート";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// buttonGoal
			// 
			this.buttonGoal.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold);
			this.buttonGoal.Location = new System.Drawing.Point(2, 442);
			this.buttonGoal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.buttonGoal.Name = "buttonGoal";
			this.buttonGoal.Size = new System.Drawing.Size(270, 64);
			this.buttonGoal.TabIndex = 3;
			this.buttonGoal.Text = "手動でゴール";
			this.buttonGoal.UseVisualStyleBackColor = true;
			this.buttonGoal.Click += new System.EventHandler(this.buttonGoal_Click);
			// 
			// buttonInit
			// 
			this.buttonInit.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold);
			this.buttonInit.ForeColor = System.Drawing.Color.Brown;
			this.buttonInit.Location = new System.Drawing.Point(2, 512);
			this.buttonInit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.buttonInit.Name = "buttonInit";
			this.buttonInit.Size = new System.Drawing.Size(270, 64);
			this.buttonInit.TabIndex = 4;
			this.buttonInit.Text = "中断";
			this.buttonInit.UseVisualStyleBackColor = true;
			this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
			// 
			// tabPage_System
			// 
			this.tabPage_System.BackColor = System.Drawing.Color.Gainsboro;
			this.tabPage_System.Controls.Add(this.panel1);
			this.tabPage_System.Controls.Add(this.panelThird);
			this.tabPage_System.Controls.Add(this.panelSecond);
			this.tabPage_System.Controls.Add(this.panelFirst);
			this.tabPage_System.Controls.Add(this.button_Init);
			this.tabPage_System.Location = new System.Drawing.Point(4, 22);
			this.tabPage_System.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.tabPage_System.Name = "tabPage_System";
			this.tabPage_System.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.tabPage_System.Size = new System.Drawing.Size(920, 606);
			this.tabPage_System.TabIndex = 1;
			this.tabPage_System.Text = "初期化画面";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightYellow;
			this.panel1.Controls.Add(this.label9);
			this.panel1.Location = new System.Drawing.Point(150, 419);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(656, 78);
			this.panel1.TabIndex = 19;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(41, 20);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(584, 36);
			this.label9.TabIndex = 0;
			this.label9.Text = "接続状態によっては、インストラクター用ソフトの起動時、すでに「システムの初期化」がおわっており、\r\n「床情報の初期化」ボタンが有効になっていることもあります。";
			// 
			// panelThird
			// 
			this.panelThird.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panelThird.Controls.Add(this.buttonGotoMain);
			this.panelThird.Controls.Add(this.textBox3);
			this.panelThird.Location = new System.Drawing.Point(618, 122);
			this.panelThird.Name = "panelThird";
			this.panelThird.Size = new System.Drawing.Size(277, 273);
			this.panelThird.TabIndex = 18;
			this.panelThird.Visible = false;
			// 
			// buttonGotoMain
			// 
			this.buttonGotoMain.Font = new System.Drawing.Font("メイリオ", 14F, System.Drawing.FontStyle.Bold);
			this.buttonGotoMain.Location = new System.Drawing.Point(32, 20);
			this.buttonGotoMain.Margin = new System.Windows.Forms.Padding(30, 20, 30, 10);
			this.buttonGotoMain.Name = "buttonGotoMain";
			this.buttonGotoMain.Size = new System.Drawing.Size(215, 88);
			this.buttonGotoMain.TabIndex = 8;
			this.buttonGotoMain.Text = "③メイン画面へ";
			this.buttonGotoMain.UseVisualStyleBackColor = true;
			this.buttonGotoMain.Click += new System.EventHandler(this.buttonGotoMain_Click);
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.Font = new System.Drawing.Font("メイリオ", 10F);
			this.textBox3.Location = new System.Drawing.Point(50, 145);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(187, 76);
			this.textBox3.TabIndex = 15;
			this.textBox3.Text = "2つの初期化が終わったら、\r\nこのボタンでメイン画面に\r\n移りましょう。";
			// 
			// panelSecond
			// 
			this.panelSecond.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panelSecond.Controls.Add(this.buttonInitFloor);
			this.panelSecond.Controls.Add(this.textBox2);
			this.panelSecond.Location = new System.Drawing.Point(317, 122);
			this.panelSecond.Name = "panelSecond";
			this.panelSecond.Size = new System.Drawing.Size(277, 273);
			this.panelSecond.TabIndex = 17;
			this.panelSecond.Visible = false;
			// 
			// buttonInitFloor
			// 
			this.buttonInitFloor.Font = new System.Drawing.Font("メイリオ", 14F, System.Drawing.FontStyle.Bold);
			this.buttonInitFloor.Location = new System.Drawing.Point(32, 20);
			this.buttonInitFloor.Margin = new System.Windows.Forms.Padding(30, 20, 30, 10);
			this.buttonInitFloor.Name = "buttonInitFloor";
			this.buttonInitFloor.Size = new System.Drawing.Size(215, 88);
			this.buttonInitFloor.TabIndex = 1;
			this.buttonInitFloor.Text = "②床情報の初期化";
			this.buttonInitFloor.UseVisualStyleBackColor = true;
			this.buttonInitFloor.Click += new System.EventHandler(this.buttonCalibration_Click);
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Font = new System.Drawing.Font("メイリオ", 10F);
			this.textBox2.Location = new System.Drawing.Point(12, 128);
			this.textBox2.Margin = new System.Windows.Forms.Padding(10);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(257, 129);
			this.textBox2.TabIndex = 14;
			this.textBox2.Text = "「システムの初期化」のあと、3分程度たってから「床情報の初期化」を行います。\r\nこのとき、走る場所（スクリーンの前）に\r\n誰もいないことを確認してください。\r\n床" +
    "情報を初期化している間は、画面が黒くなります。\r\n";
			// 
			// panelFirst
			// 
			this.panelFirst.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panelFirst.Controls.Add(this.buttonInitSystem);
			this.panelFirst.Controls.Add(this.textBox1);
			this.panelFirst.Location = new System.Drawing.Point(17, 122);
			this.panelFirst.Name = "panelFirst";
			this.panelFirst.Size = new System.Drawing.Size(277, 273);
			this.panelFirst.TabIndex = 16;
			// 
			// buttonInitSystem
			// 
			this.buttonInitSystem.Font = new System.Drawing.Font("メイリオ", 14F, System.Drawing.FontStyle.Bold);
			this.buttonInitSystem.Location = new System.Drawing.Point(30, 20);
			this.buttonInitSystem.Margin = new System.Windows.Forms.Padding(30, 20, 30, 10);
			this.buttonInitSystem.Name = "buttonInitSystem";
			this.buttonInitSystem.Size = new System.Drawing.Size(217, 88);
			this.buttonInitSystem.TabIndex = 0;
			this.buttonInitSystem.Text = "①システムの初期化";
			this.buttonInitSystem.UseVisualStyleBackColor = true;
			this.buttonInitSystem.Click += new System.EventHandler(this.button_All_Init_Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("メイリオ", 10F);
			this.textBox1.Location = new System.Drawing.Point(10, 128);
			this.textBox1.Margin = new System.Windows.Forms.Padding(10);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(257, 129);
			this.textBox1.TabIndex = 13;
			this.textBox1.Text = "6台のクライアントとサーバーを起動しおえたら「システムの初期化」ボタンを押してください。\r\n初期化すると、待ち時間（アイドル時）の音楽とアナウンスの声が先頭から流" +
    "れ始めます。\r\n";
			// 
			// button_Init
			// 
			this.button_Init.BackColor = System.Drawing.Color.DarkOrchid;
			this.button_Init.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.button_Init.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button_Init.Location = new System.Drawing.Point(735, 662);
			this.button_Init.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.button_Init.Name = "button_Init";
			this.button_Init.Size = new System.Drawing.Size(65, 27);
			this.button_Init.TabIndex = 7;
			this.button_Init.Text = "INIT";
			this.button_Init.UseVisualStyleBackColor = false;
			// 
			// tabPage_Admin
			// 
			this.tabPage_Admin.Controls.Add(this.splitContainer3);
			this.tabPage_Admin.Location = new System.Drawing.Point(4, 22);
			this.tabPage_Admin.Name = "tabPage_Admin";
			this.tabPage_Admin.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Admin.Size = new System.Drawing.Size(920, 606);
			this.tabPage_Admin.TabIndex = 2;
			this.tabPage_Admin.Text = "管理者画面";
			this.tabPage_Admin.UseVisualStyleBackColor = true;
			// 
			// splitContainer3
			// 
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer3.IsSplitterFixed = true;
			this.splitContainer3.Location = new System.Drawing.Point(3, 3);
			this.splitContainer3.Name = "splitContainer3";
			this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.textBoxLog);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
			this.splitContainer3.Size = new System.Drawing.Size(914, 600);
			this.splitContainer3.SplitterDistance = 562;
			this.splitContainer3.TabIndex = 16;
			// 
			// textBoxLog
			// 
			this.textBoxLog.BackColor = System.Drawing.Color.Black;
			this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxLog.Font = new System.Drawing.Font("Consolas", 12F);
			this.textBoxLog.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.textBoxLog.Location = new System.Drawing.Point(0, 0);
			this.textBoxLog.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.textBoxLog.Multiline = true;
			this.textBoxLog.Name = "textBoxLog";
			this.textBoxLog.ReadOnly = true;
			this.textBoxLog.Size = new System.Drawing.Size(914, 562);
			this.textBoxLog.TabIndex = 15;
			// 
			// splitContainer4
			// 
			this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer4.IsSplitterFixed = true;
			this.splitContainer4.Location = new System.Drawing.Point(0, 0);
			this.splitContainer4.Name = "splitContainer4";
			// 
			// splitContainer4.Panel1
			// 
			this.splitContainer4.Panel1.Controls.Add(this.textBoxSendMsg);
			// 
			// splitContainer4.Panel2
			// 
			this.splitContainer4.Panel2.Controls.Add(this.buttonSendAll);
			this.splitContainer4.Size = new System.Drawing.Size(914, 34);
			this.splitContainer4.SplitterDistance = 725;
			this.splitContainer4.TabIndex = 0;
			// 
			// textBoxSendMsg
			// 
			this.textBoxSendMsg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxSendMsg.Font = new System.Drawing.Font("メイリオ", 12F);
			this.textBoxSendMsg.Location = new System.Drawing.Point(0, 0);
			this.textBoxSendMsg.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
			this.textBoxSendMsg.Name = "textBoxSendMsg";
			this.textBoxSendMsg.Size = new System.Drawing.Size(725, 31);
			this.textBoxSendMsg.TabIndex = 13;
			// 
			// buttonSendAll
			// 
			this.buttonSendAll.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonSendAll.Location = new System.Drawing.Point(0, 0);
			this.buttonSendAll.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.buttonSendAll.Name = "buttonSendAll";
			this.buttonSendAll.Size = new System.Drawing.Size(185, 34);
			this.buttonSendAll.TabIndex = 14;
			this.buttonSendAll.Text = "全クライアントにメッセージ";
			this.buttonSendAll.UseVisualStyleBackColor = true;
			this.buttonSendAll.Click += new System.EventHandler(this.buttonSendAll_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(928, 662);
			this.Controls.Add(this.splitContainer1);
			this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.Text = "スポーツタイムマシン UI";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tabControl.ResumeLayout(false);
			this.tabPage_Main.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.tabPage_System.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panelThird.ResumeLayout(false);
			this.panelThird.PerformLayout();
			this.panelSecond.ResumeLayout(false);
			this.panelSecond.PerformLayout();
			this.panelFirst.ResumeLayout(false);
			this.panelFirst.PerformLayout();
			this.tabPage_Admin.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel1.PerformLayout();
			this.splitContainer3.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
			this.splitContainer3.ResumeLayout(false);
			this.splitContainer4.Panel1.ResumeLayout(false);
			this.splitContainer4.Panel1.PerformLayout();
			this.splitContainer4.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
			this.splitContainer4.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Timer readQRTimer;
        private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPage_Main;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonRandomColor;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonRandomBackground;
		private System.Windows.Forms.Label label_QRval;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Tag;
		private System.Windows.Forms.ComboBox comboBox_Color;
		private System.Windows.Forms.ComboBox comboBox_Background;
		private System.Windows.Forms.TextBox textBox_gameQR;
		private System.Windows.Forms.TextBox textBox_partnerQR;
		private System.Windows.Forms.TextBox textBox_playerQR;
		private System.Windows.Forms.Button buttonLoad;
		private System.Windows.Forms.Button buttonStop;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Button buttonGoal;
		private System.Windows.Forms.Button buttonInit;
		private System.Windows.Forms.TabPage tabPage_System;
		private System.Windows.Forms.Button buttonInitSystem;
		private System.Windows.Forms.Button buttonInitFloor;
		private System.Windows.Forms.Button button_Init;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox_Tag3;
		private System.Windows.Forms.TextBox textBox_Tag2;
		private System.Windows.Forms.TextBox textBox_Tag1;
		private System.Windows.Forms.TextBox textBox_Tag5;
		private System.Windows.Forms.TextBox textBox_Tag4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button buttonGotoMain;
		private System.Windows.Forms.Label labelQrStatus;
		private System.Windows.Forms.Button buttonClearTags;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel panelThird;
		private System.Windows.Forms.Panel panelSecond;
		private System.Windows.Forms.Panel panelFirst;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TabPage tabPage_Admin;
		private System.Windows.Forms.Button buttonSendAll;
		private System.Windows.Forms.TextBox textBoxSendMsg;
		private System.Windows.Forms.TextBox textBoxLog;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.SplitContainer splitContainer4;
		private System.Windows.Forms.Label labelPlayerName;
		private System.Windows.Forms.Button buttonClearGame;
		private System.Windows.Forms.Button buttonClearPartner;
		private System.Windows.Forms.Button buttonClearPlayer;

    }
}

