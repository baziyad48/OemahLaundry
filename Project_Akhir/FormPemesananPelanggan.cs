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
            string query = "UPDATE pemesanan SET tipe_cucian = @tipe, tanggal_masuk = @tglmsk, tanggal_keluar = @tglklr, jenis_cucian = @jenis WHERE id_pelanggan = @id";
            string queryID = "SELECT id_pelanggan FROM pelanggan WHERE username = @user";

            int id_pelanggan = 0;

            DateTime date2;
            if (comboBox2.SelectedIndex.ToString() == "Pakaian")
            {
                date2 = dateTimePicker1.Value.AddDays(3);
            }
            else
            {
                date2 = dateTimePicker1.Value.AddDays(4);
            }

            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlCommand commandID = new MySqlCommand(queryID, conn);

            commandID.Parameters.AddWithValue("@user", textBox1.Text);

            command.Parameters.AddWithValue("@tipe", comboBox1.SelectedItem.ToString());
            command.Parameters.AddWithValue("@tglmsk", dateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
            command.Parameters.AddWithValue("@tglklr", date2.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
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

                MessageBox.Show("Data berhasil Diupdate");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
