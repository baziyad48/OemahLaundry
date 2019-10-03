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
    public partial class FormLihatPelanggan : Form
    {
        string id;

        static string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=oemah_laundry;SslMode=none";
        MySqlConnection conn = new MySqlConnection(connString);

        public FormLihatPelanggan()
        {
            InitializeComponent();
            refresh();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string query = "UPDATE pelanggan SET id_pelanggan = @id,nama=@nama, username = @username, password= @password, telepon=@telepon, alamat=@alamat WHERE id_pelanggan = @id";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nama", tb_nama.Text);
                cmd.Parameters.AddWithValue("@username", tb_username.Text);
                cmd.Parameters.AddWithValue("@password", tb_password.Text);
                cmd.Parameters.AddWithValue("@telepon", tb_telepon.Text);
                cmd.Parameters.AddWithValue("@alamat", tb_alamat.Text);
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
            string query = "DELETE FROM pelanggan WHERE id_pelanggan=@id";
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
            list_pelanggan.Items.Clear();
            string query = "SELECT * FROM pelanggan";
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
                        ListViewItem(reader["id_pelanggan"].ToString());
                        listViewItem.SubItems.Add(reader["username"].ToString());
                        listViewItem.SubItems.Add(reader["nama"].ToString());
                        listViewItem.SubItems.Add(reader["password"].ToString());
                        listViewItem.SubItems.Add(reader["telepon"].ToString());
                        listViewItem.SubItems.Add(reader["alamat"].ToString());

                        list_pelanggan.Items.Add(listViewItem);
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

        private void list_pelanggan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_pelanggan.SelectedItems.Count == 0)
                return;
            ListViewItem item = list_pelanggan.SelectedItems[0];

            id = item.Text;
            tb_username.Text = item.SubItems[1].Text;
            tb_nama.Text = item.SubItems[2].Text;
            tb_password.Text = item.SubItems[3].Text;
            tb_telepon.Text = item.SubItems[4].Text;
            tb_alamat.Text = item.SubItems[5].Text;
        }
    }
}
