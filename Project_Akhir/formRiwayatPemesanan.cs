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
    public partial class FormRiwayatPemesanan : Form
    {
        static string username;
        public FormRiwayatPemesanan(string param)
        {
            InitializeComponent();
            username = param;
            label2.Text = param;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=oemah_laundry;SslMode=none";
            string query = "SELECT pm.id_pemesanan, pt.nama, pm.tipe_cucian, pm.jenis_cucian, pm.berat, pm.harga, pm.tanggal_masuk, pm.tanggal_keluar, pm.`status` FROM pemesanan pm inner join petugas pt on pt.id_petugas = pm.id_petugas INNER JOIN pelanggan pl on pl.id_pelanggan = pm.id_pelanggan WHERE pl.username='" + username +"'";


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            listView1.Items.Clear();

            try
            {
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8) };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                databaseConnection.Clone();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
