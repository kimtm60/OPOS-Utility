namespace Opos_Utility
{
    partial class PTR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PTR));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.print_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.openFile_btn = new System.Windows.Forms.Button();
            this.default_btn = new System.Windows.Forms.Button();
            this.ptr_text = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.simpleModeGroup = new System.Windows.Forms.GroupBox();
            this.sClose_btn = new System.Windows.Forms.Button();
            this.sOpen_btn = new System.Windows.Forms.Button();
            this.simpleModeCheck = new System.Windows.Forms.CheckBox();
            this.clearReturnCode_btn = new System.Windows.Forms.Button();
            this.close_returnCode = new System.Windows.Forms.TextBox();
            this.release_returnCode = new System.Windows.Forms.TextBox();
            this.claim_returnCode = new System.Windows.Forms.TextBox();
            this.open_returnCode = new System.Windows.Forms.TextBox();
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
            this.axOPOSPOSPrinter1 = new AxOposPOSPrinter_1_5_Lib.AxOPOSPOSPrinter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.simpleModeGroup.SuspendLayout();
            this.detailModeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axOPOSPOSPrinter1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.textBox24);
            this.groupBox3.Controls.Add(this.print_btn);
            this.groupBox3.Controls.Add(this.clear_btn);
            this.groupBox3.Controls.Add(this.openFile_btn);
            this.groupBox3.Controls.Add(this.default_btn);
            this.groupBox3.Controls.Add(this.ptr_text);
            this.groupBox3.Location = new System.Drawing.Point(270, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 539);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // textBox24
            // 
            this.textBox24.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox24.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox24.Location = new System.Drawing.Point(6, 20);
            this.textBox24.Multiline = true;
            this.textBox24.Name = "textBox24";
            this.textBox24.ReadOnly = true;
            this.textBox24.Size = new System.Drawing.Size(281, 45);
            this.textBox24.TabIndex = 44;
            this.textBox24.Text = "Printer Text";
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // print_btn
            // 
            this.print_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.print_btn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_btn.Location = new System.Drawing.Point(212, 389);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(75, 39);
            this.print_btn.TabIndex = 13;
            this.print_btn.Text = "Print";
            this.print_btn.UseVisualStyleBackColor = false;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clear_btn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.Location = new System.Drawing.Point(212, 332);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 39);
            this.clear_btn.TabIndex = 12;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // openFile_btn
            // 
            this.openFile_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.openFile_btn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFile_btn.Location = new System.Drawing.Point(110, 332);
            this.openFile_btn.Name = "openFile_btn";
            this.openFile_btn.Size = new System.Drawing.Size(75, 39);
            this.openFile_btn.TabIndex = 11;
            this.openFile_btn.Text = "Open File";
            this.openFile_btn.UseVisualStyleBackColor = false;
            this.openFile_btn.Click += new System.EventHandler(this.openFile_btn_Click);
            // 
            // default_btn
            // 
            this.default_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.default_btn.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.default_btn.Location = new System.Drawing.Point(6, 331);
            this.default_btn.Name = "default_btn";
            this.default_btn.Size = new System.Drawing.Size(75, 39);
            this.default_btn.TabIndex = 10;
            this.default_btn.Text = "Default";
            this.default_btn.UseVisualStyleBackColor = false;
            this.default_btn.Click += new System.EventHandler(this.default_btn_Click);
            // 
            // ptr_text
            // 
            this.ptr_text.Location = new System.Drawing.Point(6, 88);
            this.ptr_text.Multiline = true;
            this.ptr_text.Name = "ptr_text";
            this.ptr_text.Size = new System.Drawing.Size(281, 232);
            this.ptr_text.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.simpleModeGroup);
            this.groupBox2.Controls.Add(this.simpleModeCheck);
            this.groupBox2.Controls.Add(this.clearReturnCode_btn);
            this.groupBox2.Controls.Add(this.close_returnCode);
            this.groupBox2.Controls.Add(this.release_returnCode);
            this.groupBox2.Controls.Add(this.claim_returnCode);
            this.groupBox2.Controls.Add(this.open_returnCode);
            this.groupBox2.Controls.Add(this.device_name);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.detailModeGroup);
            this.groupBox2.Location = new System.Drawing.Point(12, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 539);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // simpleModeGroup
            // 
            this.simpleModeGroup.Controls.Add(this.sClose_btn);
            this.simpleModeGroup.Controls.Add(this.sOpen_btn);
            this.simpleModeGroup.Location = new System.Drawing.Point(6, 139);
            this.simpleModeGroup.Name = "simpleModeGroup";
            this.simpleModeGroup.Size = new System.Drawing.Size(76, 361);
            this.simpleModeGroup.TabIndex = 26;
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
            // simpleModeCheck
            // 
            this.simpleModeCheck.AutoSize = true;
            this.simpleModeCheck.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleModeCheck.Location = new System.Drawing.Point(7, 506);
            this.simpleModeCheck.Name = "simpleModeCheck";
            this.simpleModeCheck.Size = new System.Drawing.Size(103, 18);
            this.simpleModeCheck.TabIndex = 8;
            this.simpleModeCheck.Text = "Simple Mode";
            this.simpleModeCheck.UseVisualStyleBackColor = true;
            this.simpleModeCheck.CheckedChanged += new System.EventHandler(this.simpleModeCheck_CheckedChanged);
            // 
            // clearReturnCode_btn
            // 
            this.clearReturnCode_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clearReturnCode_btn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearReturnCode_btn.Location = new System.Drawing.Point(116, 506);
            this.clearReturnCode_btn.Name = "clearReturnCode_btn";
            this.clearReturnCode_btn.Size = new System.Drawing.Size(125, 27);
            this.clearReturnCode_btn.TabIndex = 7;
            this.clearReturnCode_btn.Text = "Clear Result";
            this.clearReturnCode_btn.UseVisualStyleBackColor = false;
            this.clearReturnCode_btn.Click += new System.EventHandler(this.clearReturnCode_btn_Click);
            // 
            // close_returnCode
            // 
            this.close_returnCode.BackColor = System.Drawing.SystemColors.HighlightText;
            this.close_returnCode.Location = new System.Drawing.Point(101, 453);
            this.close_returnCode.Name = "close_returnCode";
            this.close_returnCode.ReadOnly = true;
            this.close_returnCode.Size = new System.Drawing.Size(140, 21);
            this.close_returnCode.TabIndex = 23;
            // 
            // release_returnCode
            // 
            this.release_returnCode.BackColor = System.Drawing.SystemColors.HighlightText;
            this.release_returnCode.Location = new System.Drawing.Point(101, 391);
            this.release_returnCode.Name = "release_returnCode";
            this.release_returnCode.ReadOnly = true;
            this.release_returnCode.Size = new System.Drawing.Size(140, 21);
            this.release_returnCode.TabIndex = 21;
            // 
            // claim_returnCode
            // 
            this.claim_returnCode.BackColor = System.Drawing.SystemColors.HighlightText;
            this.claim_returnCode.Location = new System.Drawing.Point(101, 204);
            this.claim_returnCode.Name = "claim_returnCode";
            this.claim_returnCode.ReadOnly = true;
            this.claim_returnCode.Size = new System.Drawing.Size(140, 21);
            this.claim_returnCode.TabIndex = 15;
            // 
            // open_returnCode
            // 
            this.open_returnCode.BackColor = System.Drawing.SystemColors.HighlightText;
            this.open_returnCode.Location = new System.Drawing.Point(101, 139);
            this.open_returnCode.Name = "open_returnCode";
            this.open_returnCode.ReadOnly = true;
            this.open_returnCode.Size = new System.Drawing.Size(140, 21);
            this.open_returnCode.TabIndex = 8;
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
            this.textBox1.Text = "Printer";
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
            this.detailModeGroup.TabIndex = 25;
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
            // axOPOSPOSPrinter1
            // 
            this.axOPOSPOSPrinter1.Enabled = true;
            this.axOPOSPOSPrinter1.Location = new System.Drawing.Point(0, 0);
            this.axOPOSPOSPrinter1.Name = "axOPOSPOSPrinter1";
            this.axOPOSPOSPrinter1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axOPOSPOSPrinter1.OcxState")));
            this.axOPOSPOSPrinter1.Size = new System.Drawing.Size(0, 0);
            this.axOPOSPOSPrinter1.TabIndex = 14;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PTR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(575, 549);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "PTR";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.simpleModeGroup.ResumeLayout(false);
            this.detailModeGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axOPOSPOSPrinter1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button openFile_btn;
        private System.Windows.Forms.Button default_btn;
        private System.Windows.Forms.TextBox ptr_text;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox simpleModeCheck;
        private System.Windows.Forms.Button clearReturnCode_btn;
        private System.Windows.Forms.TextBox close_returnCode;
        private System.Windows.Forms.TextBox release_returnCode;
        private System.Windows.Forms.TextBox claim_returnCode;
        private System.Windows.Forms.TextBox open_returnCode;
        private System.Windows.Forms.Button dClose_btn;
        private System.Windows.Forms.Button dRelease_btn;
        private System.Windows.Forms.Button dDisable_btn;
        private System.Windows.Forms.Button dEnable_btn;
        private System.Windows.Forms.Button dClaim_btn;
        private System.Windows.Forms.Button dOpen_btn;
        private System.Windows.Forms.Button sClose_btn;
        private System.Windows.Forms.Button sOpen_btn;
        private System.Windows.Forms.ComboBox device_name;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private AxOposPOSPrinter_1_5_Lib.AxOPOSPOSPrinter axOPOSPOSPrinter1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox detailModeGroup;
        private System.Windows.Forms.GroupBox simpleModeGroup;
        private System.Windows.Forms.TextBox textBox24;
    }
}