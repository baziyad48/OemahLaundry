namespace Project_Akhir
{
    partial class Riwayat
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tanggal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.biaya = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tutup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.tanggal,
            this.biaya});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(403, 311);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 33;
            // 
            // tanggal
            // 
            this.tanggal.Text = "Tanggal";
            this.tanggal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tanggal.Width = 184;
            // 
            // biaya
            // 
            this.biaya.Text = "Biaya";
            this.biaya.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.biaya.Width = 182;
            // 
            // tutup
            // 
            this.tutup.Location = new System.Drawing.Point(340, 329);
            this.tutup.Name = "tutup";
            this.tutup.Size = new System.Drawing.Size(75, 23);
            this.tutup.TabIndex = 1;
            this.tutup.Text = "Tutup";
            this.tutup.UseVisualStyleBackColor = true;
            this.tutup.Click += new System.EventHandler(this.tutup_Click);
            // 
            // Riwayat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 369);
            this.ControlBox = false;
            this.Controls.Add(this.tutup);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Riwayat";
            this.Text = "Riwayat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader tanggal;
        private System.Windows.Forms.ColumnHeader biaya;
        private System.Windows.Forms.Button tutup;
    }
}