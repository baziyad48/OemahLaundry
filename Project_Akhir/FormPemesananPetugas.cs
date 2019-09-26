using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Globalization;

namespace Project_Akhir
{
    public partial class FormPemesananPetugas : Form
    {
        static string username;
        static string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=oemah_laundry;SslMode=none";
        MySqlConnection conn = new MySqlConnection(connString);
        private int id_petugas, id_pelanggan, hargaTotal = 0, hargaJenis = 0, hargaTipe = 0, berat;

        public FormPemesananPetugas(string param)
        {
            InitializeComponent();
            username = param;
        }

        //Generate akun
        private FormGenerateAkun frmgenerate;
        private void button3_Click(object sender, EventArgs e)
        {
            frmgenerate = new FormGenerateAkun();
            frmgenerate.Show();
        }


        //Load Combobox petugas
        private void FormPemesananPetugas_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM petugas";
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
                    comboBox1.Items.Add(nama);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dateTimePicker2.Enabled = false;
        }

        private void hitungJenis(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedItem.ToString())
            {
                case "Pakaian":
                    hargaJenis = 2000;
                    dateTimePicker2.Value = dateTimePicker1.Value.AddDays(3);
                    break;
                case "Selimut":
                    hargaJenis = 5000;
                    dateTimePicker2.Value = dateTimePicker1.Value.AddDays(4);
                    break;
                case "Seprei":
                    hargaJenis = 3500;
                    dateTimePicker2.Value = dateTimePicker1.Value.AddDays(4);
                    break;
                case "Boneka":
                    hargaJenis = 8000;
                    dateTimePicker2.Value = dateTimePicker1.Value.AddDays(4);
                    
                    break;
                default:
                    MessageBox.Show("Tipe Cucian Belum Dipilih!");
                    break;
            }
            hitungHarga(sender, e);
        }

        

        private void hitungTipe(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem.ToString())
            {
                case "Cuci Kering":
                    hargaTipe = 3000;
                    break;
                case "Cuci Seterika":
                    hargaTipe = 4000;
                    break;
                default:
                    MessageBox.Show("Jenis Cucian Belum Dipilih!");
                    break;
            }
            hitungHarga(sender, e);
        }

        private void hitungHarga(object sender, EventArgs e)
        {
            if (textBox6.Text != null)
            {
                berat = 0;
                hargaTotal = hargaTipe + berat * hargaJenis;
                textBox2.Text = hargaTotal.ToString();
            }
            else
            {
                while (textBox6.Text == null)
                {
                    string brt = textBox6.Text;
                    berat = int.Parse(brt);
                    hargaTotal = hargaTipe + berat * hargaJenis;
                    textBox2.Text = hargaTotal.ToString();
                }
            }
        }

        //Simpan
        private void button1_Click(object sender, EventArgs e)
        {
            string queryIDPet = "SELECT id_petugas FROM petugas WHERE nama = @nama";
            string queryIDPel = "SELECT id_pelanggan FROM pelanggan WHERE username = @username";
            string query = "INSERT INTO pemesanan " +
                "(id_pelanggan, id_petugas, tipe_cucian, jenis_cucian, berat, harga, tanggal_masuk, tanggal_keluar, status) " +
                "VALUES " +
                "(@idpel, @idpet, @tipe, @jenis, @berat, @harga, @tglmsk, @tglklr, 'belum diproses')";

            MySqlCommand commandID = new MySqlCommand(queryIDPet, conn);
            MySqlCommand commandPel = new MySqlCommand(queryIDPel, conn);
            MySqlCommand command = new MySqlCommand(query, conn);

            commandID.Parameters.AddWithValue("@nama", comboBox1.SelectedItem.ToString());

            commandPel.Parameters.AddWithValue("@username", textBox1.Text);

            command.Parameters.AddWithValue("@tipe", comboBox2.SelectedItem.ToString());
            command.Parameters.AddWithValue("@jenis", comboBox3.SelectedItem.ToString());
            command.Parameters.AddWithValue("@berat", textBox6.Text);
            command.Parameters.AddWithValue("@harga", textBox2.Text);
            command.Parameters.AddWithValue("@tglmsk", dateTimePicker1.Value.ToString("yyyy-MM-dd",CultureInfo.InvariantCulture));
            command.Parameters.AddWithValue("@tglklr", dateTimePicker2.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));

            commandID.CommandTimeout = 60;
            command.CommandTimeout = 60;
            commandPel.CommandTimeout = 60;

            MySqlDataReader readerIDpet, readerIDpel;
            try
            {
                conn.Open();
                readerIDpet = commandID.ExecuteReader();
                while (readerIDpet.Read())
                {
                    string id = readerIDpet.GetString("id_petugas");
                    id_petugas = int.Parse(id);

                }
                conn.Close();

                conn.Open();
                readerIDpel = commandPel.ExecuteReader();
                while (readerIDpel.Read())
                {
                    string id = readerIDpel.GetString("id_pelanggan");
                    id_pelanggan = int.Parse(id);
                }
                command.Parameters.AddWithValue("@idpel", id_pelanggan);
                command.Parameters.AddWithValue("@idpet", id_petugas);
                conn.Close();

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data berhasil ditambahkan");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        //Harga Tipe Cucian
        //private void hitungTipe()
        //{
        //    switch (comboBox2.SelectedItem.ToString())
        //    {
        //        case "Cuci Kering":
        //            hargaTipe = 3000;
        //            break;
        //        case "Cuci Seterika":
        //            hargaTipe = 4000;
        //            break;
        //        default:
        //            MessageBox.Show("Jenis Cucian Belum Dipilih!");
        //            break;
        //    }
        //}
        

        //Harga Jenis Cucian & Tanggal Selesai
        //private void hitungJenis()
        //{
        //    switch (comboBox3.SelectedItem.ToString())
        //    {
        //        case "Pakaian":
        //            hargaJenis = 2000;
        //            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(3);
        //            break;
        //        case "Selimut":
        //            hargaJenis = 5000;
        //            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(4);
        //            break;
        //        case "Seprei":
        //            hargaJenis = 3500;
        //            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(4);
        //            break;
        //        case "Boneka":
        //            hargaJenis = 8000;
        //            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(4);
        //            break;
        //        default:
        //            MessageBox.Show("Tipe Cucian Belum Dipilih!");
        //            break;
        //    }
        //}


        //Hitung Harga Total
        //private void hitungHarga()
        //{
        //    hargaTotal = hargaTipe + berat * hargaJenis;
        //    textBox2.Text = hargaTotal.ToString();
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            hitungTipe(sender, e);
            hitungJenis(sender, e);
            hitungHarga(sender, e);
        }
    }
}
