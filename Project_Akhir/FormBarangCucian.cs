using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_Akhir
{
    public partial class FormBarangCucian : Form
    {
        public FormBarangCucian()
        {
            InitializeComponent();
        }
        string id;
        static string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=oemah_laundry;SslMode=none";
        MySqlConnection conn = new MySqlConnection(connString);

        private void FormBarangCucian_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM barang_cucian";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader read;
            try
            {
                listView1.Items.Clear();
                conn.Open();
                read = command.ExecuteReader();
                int i = 1;
                while (read.Read())
                {
                    string[] row = { i++, read.GetString(1), read.GetString(2)};
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
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

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into barang_cucian (id, nama, harga) value (@id, @nama, @harga)";
            MySqlCommand command = new MySqlCommand(query, conn);

            command.CommandTimeout = 60;

            try
            {
                command.Parameters.AddWithValue("@id", textBox1.Text);
                command.Parameters.AddWithValue("@nama", textBox2.Text);
                command.Parameters.AddWithValue("@harga", textBox3.Text);
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data berhasil ditambahkan");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FormBarangCucian_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "update barang_cucian set nama = @nama, harga = @harga where id = @no";
            MySqlCommand command = new MySqlCommand(query, conn);

            command.CommandTimeout = 60;

            try
            {
                command.Parameters.AddWithValue("@no", id);
                command.Parameters.AddWithValue("@nama", textBox2.Text);
                command.Parameters.AddWithValue("@harga", textBox3.Text);
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data berhasil diubah");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FormBarangCucian_Load(sender, e);
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            id = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "delete from barang_cucian where id = @no";
            MySqlCommand command = new MySqlCommand(query, conn);

            command.CommandTimeout = 60;

            try
            {
                command.Parameters.AddWithValue("@no", id);
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data berhasil dihapus");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FormBarangCucian_Load(sender, e);
        }
    }
}
