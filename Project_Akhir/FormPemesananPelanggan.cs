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
using System.Globalization;

namespace Project_Akhir
{
    public partial class FormPemesananPelanggan : Form
    {
        static string username;
        static string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=oemah_laundry;SslMode=none";
        MySqlConnection conn = new MySqlConnection(connString);

        public FormPemesananPelanggan(string param)
        {
            InitializeComponent();
            username = param;
            textBox1.Text = param;
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO pemesanan (id_pelanggan, tipe_cucian, tanggal_masuk, barang_cucian) VALUES(@id, @tipe, @tglmsk, @jenis)";
            string queryID = "SELECT id_pelanggan FROM pelanggan WHERE username = @user";

            int id_pelanggan = 0;

            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlCommand commandID = new MySqlCommand(queryID, conn);

            commandID.Parameters.AddWithValue("@user", textBox1.Text);

            command.Parameters.AddWithValue("@tipe", comboBox1.SelectedItem.ToString());
            command.Parameters.AddWithValue("@tglmsk", dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
            command.Parameters.AddWithValue("@jenis", comboBox2.SelectedItem.ToString());

            commandID.CommandTimeout = 60;
            command.CommandTimeout = 60;

            MySqlDataReader read;

            try
            {
                conn.Open();
                read = commandID.ExecuteReader();
                while (read.Read())
                {
                    string id = read.GetString("id_pelanggan");
                    id_pelanggan = int.Parse(id);
                }
                command.Parameters.AddWithValue("@id", id_pelanggan);
                conn.Close();

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Berhasil memesan");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormPemesananPelanggan_Load(object sender, EventArgs e)
        {
            string query = "SELECT nama FROM barang_cucian";
            MySqlCommand commandDatabase = new MySqlCommand(query, conn);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                conn.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    string nama = reader.GetString("nama");
                    comboBox2.Items.Add(nama);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
