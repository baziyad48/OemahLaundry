namespace Project_Akhir
{
    partial class FormTambahPetugas
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
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.list_petugas = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.rb_admin = new System.Windows.Forms.RadioButton();
            this.rb_umum = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_hapus
            // 
            this.btn_hapus.Location = new System.Drawing.Point(686, 261);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(75, 23);
            this.btn_hapus.TabIndex = 19;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(605, 261);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_tambah
            // 
            this.btn_tambah.Location = new System.Drawing.Point(522, 261);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(75, 23);
            this.btn_tambah.TabIndex = 17;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(605, 165);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(156, 20);
            this.tb_password.TabIndex = 16;
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(605, 123);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(156, 20);
            this.tb_nama.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Akun Petugas";
            // 
            // list_petugas
            // 
            this.list_petugas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.list_petugas.FullRowSelect = true;
            this.list_petugas.HideSelection = false;
            this.list_petugas.Location = new System.Drawing.Point(16, 63);
            this.list_petugas.Name = "list_petugas";
            this.list_petugas.Size = new System.Drawing.Size(481, 292);
            this.list_petugas.TabIndex = 11;
            this.list_petugas.UseCompatibleStateImageBehavior = false;
            this.list_petugas.View = System.Windows.Forms.View.Details;
            this.list_petugas.SelectedIndexChanged += new System.EventHandler(this.list_petugas_SelectedIndexChanged);
            // 
            // No
            // 
            this.No.Text = "id";
            this.No.Width = 30;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Username";
            this.columnHeader1.Width = 129;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nama Petugas";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Password";
            this.columnHeader3.Width = 88;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tipe Petugas";
            this.columnHeader4.Width = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Username";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(605, 84);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(156, 20);
            this.tb_username.TabIndex = 21;
            // 
            // rb_admin
            // 
            this.rb_admin.AutoSize = true;
            this.rb_admin.Location = new System.Drawing.Point(605, 202);
            this.rb_admin.Name = "rb_admin";
            this.rb_admin.Size = new System.Drawing.Size(54, 17);
            this.rb_admin.TabIndex = 22;
            this.rb_admin.TabStop = true;
            this.rb_admin.Text = "Admin";
            this.rb_admin.UseVisualStyleBackColor = true;
            // 
            // rb_umum
            // 
            this.rb_umum.AutoSize = true;
            this.rb_umum.Checked = true;
            this.rb_umum.Location = new System.Drawing.Point(675, 202);
            this.rb_umum.Name = "rb_umum";
            this.rb_umum.Size = new System.Drawing.Size(53, 17);
            this.rb_umum.TabIndex = 23;
            this.rb_umum.TabStop = true;
            this.rb_umum.Text = "umum";
            this.rb_umum.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tipe Petugas";
            // 
            // FormTambahPetugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rb_umum);
            this.Controls.Add(this.rb_admin);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_petugas);
            this.Name = "FormTambahPetugas";
            this.Text = "FormTambahPetugas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView list_petugas;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.RadioButton rb_admin;
        private System.Windows.Forms.RadioButton rb_umum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}