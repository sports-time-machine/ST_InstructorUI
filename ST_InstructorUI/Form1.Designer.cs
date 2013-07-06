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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage_Main = new System.Windows.Forms.TabPage();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
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
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.buttonGotoMain = new System.Windows.Forms.Button();
			this.buttonSendAll = new System.Windows.Forms.Button();
			this.textBoxSendMsg = new System.Windows.Forms.TextBox();
			this.buttonInitSystem = new System.Windows.Forms.Button();
			this.buttonInitFloor = new System.Windows.Forms.Button();
			this.button_Init = new System.Windows.Forms.Button();
			this.textBoxLog = new System.Windows.Forms.TextBox();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage_Main.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.tabPage_System.SuspendLayout();
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
			this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
			this.splitContainer1.Size = new System.Drawing.Size(928, 662);
			this.splitContainer1.SplitterDistance = 632;
			this.splitContainer1.SplitterWidth = 1;
			this.splitContainer1.TabIndex = 2;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage_Main);
			this.tabControl1.Controls.Add(this.tabPage_System);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(928, 632);
			this.tabControl1.TabIndex = 2;
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
			this.tabPage_Main.Text = "通常運用機能";
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
			this.splitContainer2.SplitterDistance = 618;
			this.splitContainer2.SplitterWidth = 10;
			this.splitContainer2.TabIndex = 0;
			// 
			// buttonClearTags
			// 
			this.buttonClearTags.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonClearTags.Location = new System.Drawing.Point(20, 506);
			this.buttonClearTags.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.buttonClearTags.Name = "buttonClearTags";
			this.buttonClearTags.Size = new System.Drawing.Size(77, 70);
			this.buttonClearTags.TabIndex = 17;
			this.buttonClearTags.Text = "タグの初期化";
			this.buttonClearTags.UseVisualStyleBackColor = true;
			this.buttonClearTags.Click += new System.EventHandler(this.buttonClearTags_Click);
			// 
			// labelQrStatus
			// 
			this.labelQrStatus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.labelQrStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelQrStatus.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelQrStatus.Location = new System.Drawing.Point(422, 95);
			this.labelQrStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelQrStatus.Name = "labelQrStatus";
			this.labelQrStatus.Size = new System.Drawing.Size(142, 78);
			this.labelQrStatus.TabIndex = 16;
			this.labelQrStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("メイリオ", 12F);
			this.label6.Location = new System.Drawing.Point(339, 509);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(122, 24);
			this.label6.TabIndex = 15;
			this.label6.Text = "プレイヤーの色";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("メイリオ", 12F);
			this.label5.Location = new System.Drawing.Point(151, 509);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 24);
			this.label5.TabIndex = 14;
			this.label5.Text = "背景";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("メイリオ", 9F);
			this.label4.Location = new System.Drawing.Point(446, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(97, 18);
			this.label4.TabIndex = 13;
			this.label4.Text = "カメラからのQR";
			// 
			// buttonRandomColor
			// 
			this.buttonRandomColor.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonRandomColor.Location = new System.Drawing.Point(466, 498);
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
			this.label3.Location = new System.Drawing.Point(65, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(113, 24);
			this.label3.TabIndex = 9;
			this.label3.Text = "パートナーQR";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("メイリオ", 12F);
			this.label2.Location = new System.Drawing.Point(17, 145);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(161, 24);
			this.label2.TabIndex = 10;
			this.label2.Text = "これから記録するQR";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("メイリオ", 12F);
			this.label1.Location = new System.Drawing.Point(65, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 24);
			this.label1.TabIndex = 8;
			this.label1.Text = "プレイヤーQR";
			// 
			// buttonRandomBackground
			// 
			this.buttonRandomBackground.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonRandomBackground.Location = new System.Drawing.Point(227, 498);
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
			this.label_QRval.Location = new System.Drawing.Point(422, 50);
			this.label_QRval.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label_QRval.Name = "label_QRval";
			this.label_QRval.Size = new System.Drawing.Size(142, 45);
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
			this.tableLayoutPanel_Tag.Location = new System.Drawing.Point(20, 189);
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
			this.comboBox_Color.Location = new System.Drawing.Point(349, 545);
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
			this.comboBox_Background.Location = new System.Drawing.Point(110, 545);
			this.comboBox_Background.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.comboBox_Background.Name = "comboBox_Background";
			this.comboBox_Background.Size = new System.Drawing.Size(210, 32);
			this.comboBox_Background.TabIndex = 3;
			// 
			// textBox_gameQR
			// 
			this.textBox_gameQR.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_gameQR.Location = new System.Drawing.Point(183, 137);
			this.textBox_gameQR.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.textBox_gameQR.Name = "textBox_gameQR";
			this.textBox_gameQR.Size = new System.Drawing.Size(224, 36);
			this.textBox_gameQR.TabIndex = 2;
			this.textBox_gameQR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox_partnerQR
			// 
			this.textBox_partnerQR.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_partnerQR.Location = new System.Drawing.Point(183, 95);
			this.textBox_partnerQR.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.textBox_partnerQR.Name = "textBox_partnerQR";
			this.textBox_partnerQR.Size = new System.Drawing.Size(224, 36);
			this.textBox_partnerQR.TabIndex = 1;
			this.textBox_partnerQR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox_playerQR
			// 
			this.textBox_playerQR.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_playerQR.Location = new System.Drawing.Point(183, 50);
			this.textBox_playerQR.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.textBox_playerQR.Name = "textBox_playerQR";
			this.textBox_playerQR.Size = new System.Drawing.Size(224, 36);
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
			this.textBox_Tag3.Text = "50メートル";
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
			this.textBox_Tag2.Text = "山口市商店街";
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
			this.textBox_Tag1.Text = "YCAM";
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
			this.tabPage_System.Controls.Add(this.label12);
			this.tabPage_System.Controls.Add(this.label11);
			this.tabPage_System.Controls.Add(this.label10);
			this.tabPage_System.Controls.Add(this.label9);
			this.tabPage_System.Controls.Add(this.buttonGotoMain);
			this.tabPage_System.Controls.Add(this.buttonSendAll);
			this.tabPage_System.Controls.Add(this.textBoxSendMsg);
			this.tabPage_System.Controls.Add(this.buttonInitSystem);
			this.tabPage_System.Controls.Add(this.buttonInitFloor);
			this.tabPage_System.Controls.Add(this.button_Init);
			this.tabPage_System.Controls.Add(this.textBoxLog);
			this.tabPage_System.Location = new System.Drawing.Point(4, 22);
			this.tabPage_System.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.tabPage_System.Name = "tabPage_System";
			this.tabPage_System.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.tabPage_System.Size = new System.Drawing.Size(920, 606);
			this.tabPage_System.TabIndex = 1;
			this.tabPage_System.Text = "オプション機能";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("メイリオ", 10F);
			this.label12.Location = new System.Drawing.Point(320, 284);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(206, 21);
			this.label12.TabIndex = 12;
			this.label12.Text = "以下のボックスはつかいません";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("メイリオ", 10F);
			this.label11.Location = new System.Drawing.Point(607, 138);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(187, 63);
			this.label11.TabIndex = 11;
			this.label11.Text = "2つの初期化が終わったら、\r\nこのボタンでメイン画面に\r\n移りましょう。";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("メイリオ", 10F);
			this.label10.Location = new System.Drawing.Point(320, 138);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(220, 84);
			this.label10.TabIndex = 10;
			this.label10.Text = "初期化後、3分程度たったら、\r\n床情報の初期化を行います。\r\n初期化している間、画面が\r\n白っぽくなり、赤い球がでます。";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("メイリオ", 10F);
			this.label9.Location = new System.Drawing.Point(17, 138);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(262, 84);
			this.label9.TabIndex = 9;
			this.label9.Text = "まずはじめに「システムの初期化」で\r\n初期化してください。初期化すると、\r\nクライアントの画面が「スリープ状態」\r\nから「待機画面」になります。";
			// 
			// buttonGotoMain
			// 
			this.buttonGotoMain.Font = new System.Drawing.Font("メイリオ", 14F, System.Drawing.FontStyle.Bold);
			this.buttonGotoMain.Location = new System.Drawing.Point(592, 28);
			this.buttonGotoMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.buttonGotoMain.Name = "buttonGotoMain";
			this.buttonGotoMain.Size = new System.Drawing.Size(215, 88);
			this.buttonGotoMain.TabIndex = 8;
			this.buttonGotoMain.Text = "③メイン画面へ";
			this.buttonGotoMain.UseVisualStyleBackColor = true;
			this.buttonGotoMain.Click += new System.EventHandler(this.buttonGotoMain_Click);
			// 
			// buttonSendAll
			// 
			this.buttonSendAll.Location = new System.Drawing.Point(550, 545);
			this.buttonSendAll.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.buttonSendAll.Name = "buttonSendAll";
			this.buttonSendAll.Size = new System.Drawing.Size(204, 27);
			this.buttonSendAll.TabIndex = 3;
			this.buttonSendAll.Text = "全クライアントにメッセージ";
			this.buttonSendAll.UseVisualStyleBackColor = true;
			this.buttonSendAll.Click += new System.EventHandler(this.buttonSendAll_Click);
			// 
			// textBoxSendMsg
			// 
			this.textBoxSendMsg.Font = new System.Drawing.Font("メイリオ", 12F);
			this.textBoxSendMsg.Location = new System.Drawing.Point(76, 542);
			this.textBoxSendMsg.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
			this.textBoxSendMsg.Name = "textBoxSendMsg";
			this.textBoxSendMsg.Size = new System.Drawing.Size(470, 31);
			this.textBoxSendMsg.TabIndex = 2;
			// 
			// buttonInitSystem
			// 
			this.buttonInitSystem.Font = new System.Drawing.Font("メイリオ", 14F, System.Drawing.FontStyle.Bold);
			this.buttonInitSystem.Location = new System.Drawing.Point(35, 28);
			this.buttonInitSystem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.buttonInitSystem.Name = "buttonInitSystem";
			this.buttonInitSystem.Size = new System.Drawing.Size(215, 88);
			this.buttonInitSystem.TabIndex = 0;
			this.buttonInitSystem.Text = "①システムの初期化";
			this.buttonInitSystem.UseVisualStyleBackColor = true;
			this.buttonInitSystem.Click += new System.EventHandler(this.button_All_Init_Click);
			// 
			// buttonInitFloor
			// 
			this.buttonInitFloor.Font = new System.Drawing.Font("メイリオ", 14F, System.Drawing.FontStyle.Bold);
			this.buttonInitFloor.Location = new System.Drawing.Point(311, 28);
			this.buttonInitFloor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.buttonInitFloor.Name = "buttonInitFloor";
			this.buttonInitFloor.Size = new System.Drawing.Size(215, 88);
			this.buttonInitFloor.TabIndex = 1;
			this.buttonInitFloor.Text = "②床情報の初期化";
			this.buttonInitFloor.UseVisualStyleBackColor = true;
			this.buttonInitFloor.Click += new System.EventHandler(this.buttonCalibration_Click);
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
			// textBoxLog
			// 
			this.textBoxLog.BackColor = System.Drawing.Color.Black;
			this.textBoxLog.Font = new System.Drawing.Font("Consolas", 12F);
			this.textBoxLog.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.textBoxLog.Location = new System.Drawing.Point(76, 319);
			this.textBoxLog.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.textBoxLog.Multiline = true;
			this.textBoxLog.Name = "textBoxLog";
			this.textBoxLog.ReadOnly = true;
			this.textBoxLog.Size = new System.Drawing.Size(678, 220);
			this.textBoxLog.TabIndex = 4;
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
			this.Load += new System.EventHandler(this.Form1_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage_Main.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.tabPage_System.ResumeLayout(false);
			this.tabPage_System.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Timer readQRTimer;
        private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TabControl tabControl1;
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
		private System.Windows.Forms.Button buttonSendAll;
		private System.Windows.Forms.TextBox textBoxSendMsg;
		private System.Windows.Forms.Button buttonInitSystem;
		private System.Windows.Forms.Button buttonInitFloor;
		private System.Windows.Forms.Button button_Init;
		private System.Windows.Forms.TextBox textBoxLog;
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
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label labelQrStatus;
		private System.Windows.Forms.Button buttonClearTags;

    }
}

