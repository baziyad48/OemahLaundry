using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Akhir
{
    public partial class FormTambahPetugas : Form
    {
        string id;

        static string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=oemah_laundry;SslMode=none";
        MySqlConnection conn = new MySqlConnection(connString);

        public FormTambahPetugas()
        {
            InitializeComponent();
            refresh();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            string tipe = "umum";
            if (rb_admin.Checked)
            {
                tipe = "admin";
            }
            if (rb_umum.Checked)
            {
                tipe = "umum";
            }

            
            string query = "INSERT INTO petugas (nama, username, password,tipe) VALUES (@nama,@username,@password,@tipe)";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@nama", tb_nama.Text);
                cmd.Parameters.AddWithValue("@username", tb_username.Text);
                cmd.Parameters.AddWithValue("@password", tb_password.Text);
                cmd.Parameters.AddWithValue("@tipe", tipe);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil ditambahkan");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                refresh();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string tipe = "umum";
            if (rb_admin.Checked)
            {
                tipe = "admin";
            }
            if (rb_umum.Checked)
            {
                tipe = "umum";
            }
            string query = "UPDATE petugas SET id_petugas = @id, nama=@nama,username = @username, password= @password, tipe=@tipe WHERE id_petugas = @id";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nama", tb_nama.Text);
                cmd.Parameters.AddWithValue("@username", tb_username.Text);
                cmd.Parameters.AddWithValue("@password", tb_password.Text);
                cmd.Parameters.AddWithValue("@tipe", tipe);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diupdate");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                refresh();
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM petugas WHERE id_petugas=@id";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                refresh();
            }
        }

        private void refresh()
        {
            list_petugas.Items.Clear();
            string query = "SELECT * FROM petugas";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new
                        ListViewItem(reader["id_petugas"].ToString());
                        listViewItem.SubItems.Add(reader["username"].ToString());
                        listViewItem.SubItems.Add(reader["nama"].ToString());
                        listViewItem.SubItems.Add(reader["password"].ToString());
                        listViewItem.SubItems.Add(reader["tipe"].ToString());

                        list_petugas.Items.Add(listViewItem);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void list_petugas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_petugas.SelectedItems.Count == 0)
                return;
            ListViewItem item = list_petugas.SelectedItems[0];

            id = item.Text;
            tb_username.Text = item.SubItems[1].Text;
            tb_nama.Text = item.SubItems[2].Text;
            tb_password.Text = item.SubItems[3].Text;
        }
    }
}
