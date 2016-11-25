namespace Opos_Utility
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.scn_init = new System.Windows.Forms.Button();
            this.ptr_init = new System.Windows.Forms.Button();
            this.msr_init = new System.Windows.Forms.Button();
            this.cdp_init = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.windowWToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.fileToolStripMenuItem.Text = "File(F)";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.viewToolStripMenuItem.Text = "View(V)";
            // 
            // windowWToolStripMenuItem
            // 
            this.windowWToolStripMenuItem.Name = "windowWToolStripMenuItem";
            this.windowWToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.windowWToolStripMenuItem.Text = "Window(W)";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.scn_init);
            this.groupBox1.Controls.Add(this.ptr_init);
            this.groupBox1.Controls.Add(this.msr_init);
            this.groupBox1.Controls.Add(this.cdp_init);
            this.groupBox1.Location = new System.Drawing.Point(7, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 78);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(7, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 587);
            this.panel1.TabIndex = 8;
            // 
            // scn_init
            // 
            this.scn_init.BackgroundImage = global::Opos_Utility.Properties.Resources.scanner;
            this.scn_init.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scn_init.Location = new System.Drawing.Point(190, 15);
            this.scn_init.Name = "scn_init";
            this.scn_init.Size = new System.Drawing.Size(54, 54);
            this.scn_init.TabIndex = 3;
            this.scn_init.UseVisualStyleBackColor = true;
            this.scn_init.Click += new System.EventHandler(this.scn_init_Click);
            // 
            // ptr_init
            // 
            this.ptr_init.BackColor = System.Drawing.SystemColors.Control;
            this.ptr_init.BackgroundImage = global::Opos_Utility.Properties.Resources.printer;
            this.ptr_init.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptr_init.Location = new System.Drawing.Point(10, 15);
            this.ptr_init.Name = "ptr_init";
            this.ptr_init.Size = new System.Drawing.Size(54, 54);
            this.ptr_init.TabIndex = 0;
            this.ptr_init.UseVisualStyleBackColor = false;
            this.ptr_init.Click += new System.EventHandler(this.ptr_init_Click);
            // 
            // msr_init
            // 
            this.msr_init.BackgroundImage = global::Opos_Utility.Properties.Resources.msr;
            this.msr_init.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.msr_init.Location = new System.Drawing.Point(130, 15);
            this.msr_init.Name = "msr_init";
            this.msr_init.Size = new System.Drawing.Size(54, 54);
            this.msr_init.TabIndex = 2;
            this.msr_init.UseVisualStyleBackColor = true;
            this.msr_init.Click += new System.EventHandler(this.msr_init_Click);
            // 
            // cdp_init
            // 
            this.cdp_init.BackgroundImage = global::Opos_Utility.Properties.Resources.cdp;
            this.cdp_init.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cdp_init.Location = new System.Drawing.Point(70, 15);
            this.cdp_init.Name = "cdp_init";
            this.cdp_init.Size = new System.Drawing.Size(54, 54);
            this.cdp_init.TabIndex = 1;
            this.cdp_init.UseVisualStyleBackColor = true;
            this.cdp_init.Click += new System.EventHandler(this.cdp_init_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(607, 699);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "589, 710";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowWToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button scn_init;
        private System.Windows.Forms.Button ptr_init;
        private System.Windows.Forms.Button msr_init;
        private System.Windows.Forms.Button cdp_init;
        private System.Windows.Forms.Panel panel1;
    }
}

