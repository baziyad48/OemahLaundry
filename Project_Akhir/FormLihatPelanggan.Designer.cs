namespace Project_Akhir
{
    partial class FormLihatPelanggan
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
            this.list_pelanggan = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_telepon = new System.Windows.Forms.TextBox();
            this.tb_alamat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // list_pelanggan
            // 
            this.list_pelanggan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.list_pelanggan.FullRowSelect = true;
            this.list_pelanggan.HideSelection = false;
            this.list_pelanggan.Location = new System.Drawing.Point(12, 50);
            this.list_pelanggan.Name = "list_pelanggan";
            this.list_pelanggan.Size = new System.Drawing.Size(530, 292);
            this.list_pelanggan.TabIndex = 12;
            this.list_pelanggan.UseCompatibleStateImageBehavior = false;
            this.list_pelanggan.View = System.Windows.Forms.View.Details;
            this.list_pelanggan.SelectedIndexChanged += new System.EventHandler(this.list_pelanggan_SelectedIndexChanged);
            // 
            // No
            // 
            this.No.Text = "id";
            this.No.Width = 30;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nama";
            this.columnHeader1.Width = 97;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Username";
            this.columnHeader2.Width = 107;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Password";
            this.columnHeader3.Width = 84;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telepon";
            this.columnHeader4.Width = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Akun Pelanggan";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Alamat";
            this.columnHeader5.Width = 115;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(556, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Telepon";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(641, 50);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(156, 20);
            this.tb_username.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Username";
            // 
            // btn_hapus
            // 
            this.btn_hapus.Location = new System.Drawing.Point(722, 266);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(75, 23);
            this.btn_hapus.TabIndex = 31;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(641, 266);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 30;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(641, 131);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(156, 20);
            this.tb_password.TabIndex = 28;
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(641, 89);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(156, 20);
            this.tb_nama.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(556, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Alamat";
            // 
            // tb_telepon
            // 
            this.tb_telepon.Location = new System.Drawing.Point(641, 169);
            this.tb_telepon.Name = "tb_telepon";
            this.tb_telepon.Size = new System.Drawing.Size(156, 20);
            this.tb_telepon.TabIndex = 38;
            // 
            // tb_alamat
            // 
            this.tb_alamat.Location = new System.Drawing.Point(641, 204);
            this.tb_alamat.Name = "tb_alamat";
            this.tb_alamat.Size = new System.Drawing.Size(156, 20);
            this.tb_alamat.TabIndex = 39;
            // 
            // FormLihatPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 383);
            this.Controls.Add(this.tb_alamat);
            this.Controls.Add(this.tb_telepon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_pelanggan);
            this.Name = "FormLihatPelanggan";
            this.Text = "FormLihatPelanggan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list_pelanggan;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_telepon;
        private System.Windows.Forms.TextBox tb_alamat;
    }
}