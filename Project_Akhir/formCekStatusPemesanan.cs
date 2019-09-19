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
    public partial class formCekStatusPemesanan : Form
    {
        public formCekStatusPemesanan()
        {
            InitializeComponent();
        }

        private static string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ppk;SslMode=none";
        MySqlConnection conn = new MySqlConnection(connString);

        private void formCekStatusPemesanan_Load(object sender, EventArgs e)
        {
            string query = "select u.nama, u.alamat, u.no_telp, p.id, p.jenis_cucian, p.harga, p.berat, p.tanggal_masuk, p.tanggal_keluar from pesanan p inner join user u on p.id_user = u.id where p.id = 1";
            MySqlCommand commDatabase = new MySqlCommand(query, conn);
            commDatabase.CommandTimeout = 60;
            try
            {
                MySqlDataReader reader;
                conn.Open();
                reader = commDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] row =
                        {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5),
                        reader.GetString(6),
                        reader.GetString(7),
                        reader.GetString(8)
                    };
                        idPemesanan.Text = row[3];
                        namaPemesan.Text = row[0];
                        alamatPemesan.Text = row[1];
                        noTelp.Text = row[2];
                        jenisCucian.Text = row[4];
                        harga.Text = row[5];
                        berat.Text = row[6];
                        tanggalMasuk.Text = row[7];
                        tanggalKeluar.Text = row[8];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
