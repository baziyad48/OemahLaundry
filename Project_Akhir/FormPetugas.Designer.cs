namespace Project_Akhir
{
    partial class FormPetugas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pesananToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputPesananToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lihatPesananToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesananToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pesananToolStripMenuItem
            // 
            this.pesananToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputPesananToolStripMenuItem,
            this.lihatPesananToolStripMenuItem});
            this.pesananToolStripMenuItem.Name = "pesananToolStripMenuItem";
            this.pesananToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.pesananToolStripMenuItem.Text = "Pesanan";
            // 
            // inputPesananToolStripMenuItem
            // 
            this.inputPesananToolStripMenuItem.Name = "inputPesananToolStripMenuItem";
            this.inputPesananToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inputPesananToolStripMenuItem.Text = "Input Pesanan";
            // 
            // lihatPesananToolStripMenuItem
            // 
            this.lihatPesananToolStripMenuItem.Name = "lihatPesananToolStripMenuItem";
            this.lihatPesananToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lihatPesananToolStripMenuItem.Text = "Lihat Pesanan";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // FormPetugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPetugas";
            this.Text = "Oemah Laundry";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pesananToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputPesananToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lihatPesananToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}