namespace Opos_Utility
{
    partial class SCN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SCN));
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
            this.detailModeGroup = new System.Windows.Forms.GroupBox();
            this.dOpen_btn = new System.Windows.Forms.Button();
            this.dClaim_btn = new System.Windows.Forms.Button();
            this.dEnable_btn = new System.Windows.Forms.Button();
            this.dDisable_btn = new System.Windows.Forms.Button();
            this.dRelease_btn = new System.Windows.Forms.Button();
            this.dClose_btn = new System.Windows.Forms.Button();
            this.device_name = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.scan_tb = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.axOPOSScanner1 = new AxOposScanner_CCO.AxOPOSScanner();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.simpleModeGroup.SuspendLayout();
            this.detailModeGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axOPOSScanner1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.groupBox2.Controls.Add(this.detailModeGroup);
            this.groupBox2.Controls.Add(this.device_name);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 539);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // simpleModeGroup
            // 
            this.simpleModeGroup.Controls.Add(this.sClose_btn);
            this.simpleModeGroup.Controls.Add(this.sOpen_btn);
            this.simpleModeGroup.Location = new System.Drawing.Point(6, 139);
            this.simpleModeGroup.Name = "simpleModeGroup";
            this.simpleModeGroup.Size = new System.Drawing.Size(76, 361);
            this.simpleModeGroup.TabIndex = 58;
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
            this.close_returnCode.TabIndex = 56;
            // 
            // release_returnCode
            // 
            this.release_returnCode.BackColor = System.Drawing.SystemColors.HighlightText;
            this.release_returnCode.Location = new System.Drawing.Point(101, 391);
            this.release_returnCode.Name = "release_returnCode";
            this.release_returnCode.ReadOnly = true;
            this.release_returnCode.Size = new System.Drawing.Size(140, 21);
            this.release_returnCode.TabIndex = 55;
            // 
            // claim_returnCode
            // 
            this.claim_returnCode.BackColor = System.Drawing.SystemColors.HighlightText;
            this.claim_returnCode.Location = new System.Drawing.Point(101, 204);
            this.claim_returnCode.Name = "claim_returnCode";
            this.claim_returnCode.ReadOnly = true;
            this.claim_returnCode.Size = new System.Drawing.Size(140, 21);
            this.claim_returnCode.TabIndex = 54;
            // 
            // open_returnCode
            // 
            this.open_returnCode.BackColor = System.Drawing.SystemColors.HighlightText;
            this.open_returnCode.Location = new System.Drawing.Point(101, 139);
            this.open_returnCode.Name = "open_returnCode";
            this.open_returnCode.ReadOnly = true;
            this.open_returnCode.Size = new System.Drawing.Size(140, 21);
            this.open_returnCode.TabIndex = 53;
            // 
            // simpleModeCheck
            // 
            this.simpleModeCheck.AutoSize = true;
            this.simpleModeCheck.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleModeCheck.Location = new System.Drawing.Point(7, 506);
            this.simpleModeCheck.Name = "simpleModeCheck";
            this.simpleModeCheck.Size = new System.Drawing.Size(103, 18);
            this.simpleModeCheck.TabIndex = 52;
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
            this.button13.TabIndex = 51;
            this.button13.Text = "Clear Result";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.clearReturnCode_btn_Click);
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
            this.detailModeGroup.TabIndex = 57;
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
            this.textBox1.Font = new System.Drawing.Font("Consolas", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(234, 87);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Scanner";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.scan_tb);
            this.groupBox3.Controls.Add(this.textBox24);
            this.groupBox3.Controls.Add(this.axOPOSScanner1);
            this.groupBox3.Location = new System.Drawing.Point(270, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 539);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // scan_tb
            // 
            this.scan_tb.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scan_tb.Location = new System.Drawing.Point(9, 66);
            this.scan_tb.Multiline = true;
            this.scan_tb.Name = "scan_tb";
            this.scan_tb.Size = new System.Drawing.Size(278, 41);
            this.scan_tb.TabIndex = 54;
            this.scan_tb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.scan_tb_MouseClick);
            // 
            // textBox24
            // 
            this.textBox24.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox24.CausesValidation = false;
            this.textBox24.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox24.Location = new System.Drawing.Point(6, 20);
            this.textBox24.Multiline = true;
            this.textBox24.Name = "textBox24";
            this.textBox24.ReadOnly = true;
            this.textBox24.Size = new System.Drawing.Size(281, 40);
            this.textBox24.TabIndex = 53;
            this.textBox24.Text = "Scan Data";
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // axOPOSScanner1
            // 
            this.axOPOSScanner1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.axOPOSScanner1.Enabled = true;
            this.axOPOSScanner1.Location = new System.Drawing.Point(3, 344);
            this.axOPOSScanner1.Name = "axOPOSScanner1";
            this.axOPOSScanner1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axOPOSScanner1.OcxState")));
            this.axOPOSScanner1.Size = new System.Drawing.Size(287, 192);
            this.axOPOSScanner1.TabIndex = 5;
            this.axOPOSScanner1.Visible = false;
            this.axOPOSScanner1.DataEvent += new AxOposScanner_CCO._IOPOSScannerEvents_DataEventEventHandler(this.axOPOSScanner1_DataEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 14);
            this.label1.TabIndex = 56;
            this.label1.Text = "Example Barcode";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Opos_Utility.Properties.Resources.barcode1;
            this.pictureBox1.Location = new System.Drawing.Point(11, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // SCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 549);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "SCN";
            this.Text = "SCN";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.simpleModeGroup.ResumeLayout(false);
            this.detailModeGroup.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axOPOSScanner1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private AxOposScanner_CCO.AxOPOSScanner axOPOSScanner1;
        private System.Windows.Forms.TextBox scan_tb;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}