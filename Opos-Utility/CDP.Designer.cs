namespace Opos_Utility
{
    partial class CDP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDP));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.simpleModeGroup = new System.Windows.Forms.GroupBox();
            this.sClose_btn = new System.Windows.Forms.Button();
            this.sOpen_btn = new System.Windows.Forms.Button();
            this.close_returnCode = new System.Windows.Forms.TextBox();
            this.release_returnCode = new System.Windows.Forms.TextBox();
            this.claim_returnCode = new System.Windows.Forms.TextBox();
            this.open_returnCode = new System.Windows.Forms.TextBox();
            this.simpleModeCheck = new System.Windows.Forms.CheckBox();
            this.button13 = new System.Windows.Forms.Button();
            this.device_name = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.detailModeGroup = new System.Windows.Forms.GroupBox();
            this.dOpen_btn = new System.Windows.Forms.Button();
            this.dClaim_btn = new System.Windows.Forms.Button();
            this.dEnable_btn = new System.Windows.Forms.Button();
            this.dDisable_btn = new System.Windows.Forms.Button();
            this.dRelease_btn = new System.Windows.Forms.Button();
            this.dClose_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.clearText_btn = new System.Windows.Forms.Button();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.secondLineText = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.firstLineText = new System.Windows.Forms.TextBox();
            this.display_returnCode = new System.Windows.Forms.TextBox();
            this.display_single = new System.Windows.Forms.Button();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.singleText = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.axOPOSLineDisplay1 = new AxOposLineDisplay_CCO.AxOPOSLineDisplay();
            this.groupBox2.SuspendLayout();
            this.simpleModeGroup.SuspendLayout();
            this.detailModeGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axOPOSLineDisplay1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.simpleModeGroup);
            this.groupBox2.Controls.Add(this.close_returnCode);
            this.groupBox2.Controls.Add(this.release_returnCode);
            this.groupBox2.Controls.Add(this.claim_returnCode);
            this.groupBox2.Controls.Add(this.open_returnCode);
            this.groupBox2.Controls.Add(this.simpleModeCheck);
            this.groupBox2.Controls.Add(this.button13);
            this.groupBox2.Controls.Add(this.device_name);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.detailModeGroup);
            this.groupBox2.Location = new System.Drawing.Point(12, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 539);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // simpleModeGroup
            // 
            this.simpleModeGroup.Controls.Add(this.sClose_btn);
            this.simpleModeGroup.Controls.Add(this.sOpen_btn);
            this.simpleModeGroup.Location = new System.Drawing.Point(6, 139);
            this.simpleModeGroup.Name = "simpleModeGroup";
            this.simpleModeGroup.Size = new System.Drawing.Size(76, 361);
            this.simpleModeGroup.TabIndex = 40;
            this.simpleModeGroup.TabStop = false;
            // 
            // sClose_btn
            // 
            this.sClose_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sClose_btn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sClose_btn.Location = new System.Drawing.Point(6, 183);
            this.sClose_btn.Name = "sClose_btn";
            this.sClose_btn.Size = new System.Drawing.Size(71, 172);
            this.sClose_btn.TabIndex = 4;
            this.sClose_btn.Text = "Close";
            this.sClose_btn.UseVisualStyleBackColor = false;
            this.sClose_btn.Click += new System.EventHandler(this.sClose_btn_Click);
            // 
            // sOpen_btn
            // 
            this.sOpen_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sOpen_btn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sOpen_btn.Location = new System.Drawing.Point(5, 0);
            this.sOpen_btn.Name = "sOpen_btn";
            this.sOpen_btn.Size = new System.Drawing.Size(71, 173);
            this.sOpen_btn.TabIndex = 3;
            this.sOpen_btn.Text = "Open";
            this.sOpen_btn.UseVisualStyleBackColor = false;
            this.sOpen_btn.Click += new System.EventHandler(this.sOpen_btn_Click);
            // 
            // close_returnCode
            // 
            this.close_returnCode.BackColor = System.Drawing.SystemColors.HighlightText;
            this.close_returnCode.Location = new System.Drawing.Point(101, 453);
            this.close_returnCode.Name = "close_returnCode";
            this.close_returnCode.ReadOnly = true;
            this.close_returnCode.Size = new System.Drawing.Size(140, 21);
            this.close_returnCode.TabIndex = 38;
            // 
            // release_returnCode
            // 
            this.release_returnCode.BackColor = System.Drawing.SystemColors.HighlightText;
            this.release_returnCode.Location = new System.Drawing.Point(101, 391);
            this.release_returnCode.Name = "release_returnCode";
            this.release_returnCode.ReadOnly = true;
            this.release_returnCode.Size = new System.Drawing.Size(140, 21);
            this.release_returnCode.TabIndex = 37;
            // 
            // claim_returnCode
            // 
            this.claim_returnCode.BackColor = System.Drawing.SystemColors.HighlightText;
            this.claim_returnCode.Location = new System.Drawing.Point(101, 204);
            this.claim_returnCode.Name = "claim_returnCode";
            this.claim_returnCode.ReadOnly = true;
            this.claim_returnCode.Size = new System.Drawing.Size(140, 21);
            this.claim_returnCode.TabIndex = 36;
            // 
            // open_returnCode
            // 
            this.open_returnCode.BackColor = System.Drawing.SystemColors.HighlightText;
            this.open_returnCode.Location = new System.Drawing.Point(101, 139);
            this.open_returnCode.Name = "open_returnCode";
            this.open_returnCode.ReadOnly = true;
            this.open_returnCode.Size = new System.Drawing.Size(140, 21);
            this.open_returnCode.TabIndex = 35;
            // 
            // simpleModeCheck
            // 
            this.simpleModeCheck.AutoSize = true;
            this.simpleModeCheck.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleModeCheck.Location = new System.Drawing.Point(7, 506);
            this.simpleModeCheck.Name = "simpleModeCheck";
            this.simpleModeCheck.Size = new System.Drawing.Size(103, 18);
            this.simpleModeCheck.TabIndex = 34;
            this.simpleModeCheck.Text = "Simple Mode";
            this.simpleModeCheck.UseVisualStyleBackColor = true;
            this.simpleModeCheck.Click += new System.EventHandler(this.simpleModeCheck_CheckedChanged);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button13.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(116, 506);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(125, 27);
            this.button13.TabIndex = 33;
            this.button13.Text = "Clear Result";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.clearReturnCode_btn_Click);
            // 
            // device_name
            // 
            this.device_name.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.device_name.FormattingEnabled = true;
            this.device_name.Location = new System.Drawing.Point(60, 111);
            this.device_name.Name = "device_name";
            this.device_name.Size = new System.Drawing.Size(181, 20);
            this.device_name.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(7, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(54, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "LDN";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(234, 87);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Line \r\nDisplay";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // detailModeGroup
            // 
            this.detailModeGroup.Controls.Add(this.dOpen_btn);
            this.detailModeGroup.Controls.Add(this.dClaim_btn);
            this.detailModeGroup.Controls.Add(this.dEnable_btn);
            this.detailModeGroup.Controls.Add(this.dDisable_btn);
            this.detailModeGroup.Controls.Add(this.dRelease_btn);
            this.detailModeGroup.Controls.Add(this.dClose_btn);
            this.detailModeGroup.Location = new System.Drawing.Point(7, 137);
            this.detailModeGroup.Name = "detailModeGroup";
            this.detailModeGroup.Size = new System.Drawing.Size(103, 363);
            this.detailModeGroup.TabIndex = 39;
            this.detailModeGroup.TabStop = false;
            // 
            // dOpen_btn
            // 
            this.dOpen_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dOpen_btn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dOpen_btn.Location = new System.Drawing.Point(1, 2);
            this.dOpen_btn.Name = "dOpen_btn";
            this.dOpen_btn.Size = new System.Drawing.Size(94, 43);
            this.dOpen_btn.TabIndex = 8;
            this.dOpen_btn.Text = "O";
            this.dOpen_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dOpen_btn.UseVisualStyleBackColor = false;
            this.dOpen_btn.Click += new System.EventHandler(this.detail_btn_Click);
            // 
            // dClaim_btn
            // 
            this.dClaim_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dClaim_btn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dClaim_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dClaim_btn.Location = new System.Drawing.Point(1, 67);
            this.dClaim_btn.Name = "dClaim_btn";
            this.dClaim_btn.Size = new System.Drawing.Size(94, 43);
            this.dClaim_btn.TabIndex = 9;
            this.dClaim_btn.Text = "C";
            this.dClaim_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dClaim_btn.UseVisualStyleBackColor = false;
            this.dClaim_btn.Click += new System.EventHandler(this.detail_btn_Click);
            // 
            // dEnable_btn
            // 
            this.dEnable_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dEnable_btn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dEnable_btn.Location = new System.Drawing.Point(1, 132);
            this.dEnable_btn.Name = "dEnable_btn";
            this.dEnable_btn.Size = new System.Drawing.Size(94, 44);
            this.dEnable_btn.TabIndex = 10;
            this.dEnable_btn.Text = "E";
            this.dEnable_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dEnable_btn.UseVisualStyleBackColor = false;
            this.dEnable_btn.Click += new System.EventHandler(this.detail_btn_Click);
            // 
            // dDisable_btn
            // 
            this.dDisable_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dDisable_btn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dDisable_btn.Location = new System.Drawing.Point(0, 187);
            this.dDisable_btn.Name = "dDisable_btn";
            this.dDisable_btn.Size = new System.Drawing.Size(94, 43);
            this.dDisable_btn.TabIndex = 11;
            this.dDisable_btn.Text = "D";
            this.dDisable_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dDisable_btn.UseVisualStyleBackColor = false;
            this.dDisable_btn.Click += new System.EventHandler(this.detail_btn_Click);
            // 
            // dRelease_btn
            // 
            this.dRelease_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dRelease_btn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dRelease_btn.Location = new System.Drawing.Point(0, 254);
            this.dRelease_btn.Name = "dRelease_btn";
            this.dRelease_btn.Size = new System.Drawing.Size(95, 43);
            this.dRelease_btn.TabIndex = 12;
            this.dRelease_btn.Text = "R";
            this.dRelease_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dRelease_btn.UseVisualStyleBackColor = false;
            this.dRelease_btn.Click += new System.EventHandler(this.detail_btn_Click);
            // 
            // dClose_btn
            // 
            this.dClose_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dClose_btn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dClose_btn.Location = new System.Drawing.Point(1, 314);
            this.dClose_btn.Name = "dClose_btn";
            this.dClose_btn.Size = new System.Drawing.Size(94, 43);
            this.dClose_btn.TabIndex = 13;
            this.dClose_btn.Text = "C";
            this.dClose_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dClose_btn.UseVisualStyleBackColor = false;
            this.dClose_btn.Click += new System.EventHandler(this.detail_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.textBox15);
            this.groupBox3.Controls.Add(this.clearText_btn);
            this.groupBox3.Controls.Add(this.textBox16);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBox17);
            this.groupBox3.Controls.Add(this.secondLineText);
            this.groupBox3.Controls.Add(this.textBox19);
            this.groupBox3.Controls.Add(this.firstLineText);
            this.groupBox3.Controls.Add(this.display_returnCode);
            this.groupBox3.Controls.Add(this.display_single);
            this.groupBox3.Controls.Add(this.textBox21);
            this.groupBox3.Controls.Add(this.singleText);
            this.groupBox3.Controls.Add(this.textBox23);
            this.groupBox3.Controls.Add(this.textBox24);
            this.groupBox3.Controls.Add(this.axOPOSLineDisplay1);
            this.groupBox3.Location = new System.Drawing.Point(270, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 539);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox15.Location = new System.Drawing.Point(126, 483);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(161, 21);
            this.textBox15.TabIndex = 55;
            // 
            // clearText_btn
            // 
            this.clearText_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clearText_btn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearText_btn.Location = new System.Drawing.Point(6, 482);
            this.clearText_btn.Name = "clearText_btn";
            this.clearText_btn.Size = new System.Drawing.Size(120, 35);
            this.clearText_btn.TabIndex = 56;
            this.clearText_btn.Text = "Clear Text";
            this.clearText_btn.UseVisualStyleBackColor = false;
            this.clearText_btn.Click += new System.EventHandler(this.clearText_btn_Click);
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox16.Location = new System.Drawing.Point(126, 400);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(161, 21);
            this.textBox16.TabIndex = 53;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 54;
            this.button1.Text = "Display (2L)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox17.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.Location = new System.Drawing.Point(6, 361);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(80, 22);
            this.textBox17.TabIndex = 52;
            this.textBox17.Text = "Line 2";
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secondLineText
            // 
            this.secondLineText.Location = new System.Drawing.Point(85, 361);
            this.secondLineText.Name = "secondLineText";
            this.secondLineText.Size = new System.Drawing.Size(202, 21);
            this.secondLineText.TabIndex = 51;
            this.secondLineText.Text = "happy cristmas to me";
            // 
            // textBox19
            // 
            this.textBox19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox19.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox19.Location = new System.Drawing.Point(6, 331);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(80, 22);
            this.textBox19.TabIndex = 50;
            this.textBox19.Text = "Line 1";
            this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // firstLineText
            // 
            this.firstLineText.Location = new System.Drawing.Point(85, 331);
            this.firstLineText.Name = "firstLineText";
            this.firstLineText.Size = new System.Drawing.Size(202, 21);
            this.firstLineText.TabIndex = 49;
            this.firstLineText.Text = "hi valcretec happy !";
            // 
            // display_returnCode
            // 
            this.display_returnCode.BackColor = System.Drawing.SystemColors.HighlightText;
            this.display_returnCode.Location = new System.Drawing.Point(126, 173);
            this.display_returnCode.Name = "display_returnCode";
            this.display_returnCode.ReadOnly = true;
            this.display_returnCode.Size = new System.Drawing.Size(161, 21);
            this.display_returnCode.TabIndex = 45;
            // 
            // display_single
            // 
            this.display_single.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.display_single.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_single.Location = new System.Drawing.Point(6, 172);
            this.display_single.Name = "display_single";
            this.display_single.Size = new System.Drawing.Size(120, 35);
            this.display_single.TabIndex = 46;
            this.display_single.Text = "Display (1L)";
            this.display_single.UseVisualStyleBackColor = false;
            this.display_single.Click += new System.EventHandler(this.display_single_Click);
            // 
            // textBox21
            // 
            this.textBox21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox21.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox21.Location = new System.Drawing.Point(6, 123);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(80, 22);
            this.textBox21.TabIndex = 48;
            this.textBox21.Text = "Text";
            this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // singleText
            // 
            this.singleText.Location = new System.Drawing.Point(85, 123);
            this.singleText.Name = "singleText";
            this.singleText.Size = new System.Drawing.Size(202, 21);
            this.singleText.TabIndex = 47;
            this.singleText.Text = "hi valcretec happy !";
            // 
            // textBox23
            // 
            this.textBox23.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox23.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox23.Location = new System.Drawing.Point(6, 237);
            this.textBox23.Multiline = true;
            this.textBox23.Name = "textBox23";
            this.textBox23.ReadOnly = true;
            this.textBox23.Size = new System.Drawing.Size(281, 75);
            this.textBox23.TabIndex = 44;
            this.textBox23.Text = "Line Display\r\nOutput - Line";
            this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox24
            // 
            this.textBox24.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox24.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox24.Location = new System.Drawing.Point(6, 21);
            this.textBox24.Multiline = true;
            this.textBox24.Name = "textBox24";
            this.textBox24.ReadOnly = true;
            this.textBox24.Size = new System.Drawing.Size(281, 75);
            this.textBox24.TabIndex = 43;
            this.textBox24.Text = "Line Display\r\nOutput";
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // axOPOSLineDisplay1
            // 
            this.axOPOSLineDisplay1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.axOPOSLineDisplay1.Enabled = true;
            this.axOPOSLineDisplay1.Location = new System.Drawing.Point(3, 344);
            this.axOPOSLineDisplay1.Name = "axOPOSLineDisplay1";
            this.axOPOSLineDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axOPOSLineDisplay1.OcxState")));
            this.axOPOSLineDisplay1.Size = new System.Drawing.Size(287, 192);
            this.axOPOSLineDisplay1.TabIndex = 12;
            // 
            // CDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 549);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "CDP";
            this.Text = "CDP";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.simpleModeGroup.ResumeLayout(false);
            this.detailModeGroup.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axOPOSLineDisplay1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox device_name;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox simpleModeGroup;
        private System.Windows.Forms.Button sClose_btn;
        private System.Windows.Forms.Button sOpen_btn;
        private System.Windows.Forms.TextBox close_returnCode;
        private System.Windows.Forms.TextBox release_returnCode;
        private System.Windows.Forms.TextBox claim_returnCode;
        private System.Windows.Forms.TextBox open_returnCode;
        private System.Windows.Forms.CheckBox simpleModeCheck;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.GroupBox detailModeGroup;
        private System.Windows.Forms.Button dOpen_btn;
        private System.Windows.Forms.Button dClaim_btn;
        private System.Windows.Forms.Button dEnable_btn;
        private System.Windows.Forms.Button dDisable_btn;
        private System.Windows.Forms.Button dRelease_btn;
        private System.Windows.Forms.Button dClose_btn;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Button clearText_btn;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox secondLineText;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox firstLineText;
        private System.Windows.Forms.TextBox display_returnCode;
        private System.Windows.Forms.Button display_single;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox singleText;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private AxOposLineDisplay_CCO.AxOPOSLineDisplay axOPOSLineDisplay1;
    }
}