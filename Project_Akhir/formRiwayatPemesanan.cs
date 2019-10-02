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

        private static string connectionString = "server=localhost;port=3306;username=root;password=;database=oemah_laundry;";
        private MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        public FormRiwayatPemesanan(string param)
        {
            InitializeComponent();
            username = param;
            label2.Text = param;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            string query = "SELECT pm.id_pemesanan, pt.nama, pm.tipe_cucian, pm.barang_cucian, pm.berat, pm.harga, pm.tanggal_masuk, pm.tanggal_keluar, pm.`status` FROM pemesanan pm inner join petugas pt on pt.id_petugas = pm.id_petugas INNER JOIN pelanggan pl on pl.id_pelanggan = pm.id_pelanggan WHERE pl.username='"+username+"'";

            try
            {
                databaseConnection.Open();

                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;

                MySqlDataReader reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new ListViewItem(reader["id_pemesanan"].ToString());
                        listViewItem.SubItems.Add(reader["nama"].ToString());
                        listViewItem.SubItems.Add(reader["tipe_cucian"].ToString());
                        listViewItem.SubItems.Add(reader["barang_cucian"].ToString());
                        listViewItem.SubItems.Add(reader["berat"].ToString());
                        listViewItem.SubItems.Add(reader["harga"].ToString());
                        listViewItem.SubItems.Add(reader["tanggal_masuk"].ToString());
                        listViewItem.SubItems.Add(reader["tanggal_keluar"].ToString());
                        listViewItem.SubItems.Add(reader["status"].ToString());

                        listView1.Items.Add(listViewItem);
                    }

                    reader.Close();
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }
    }
}
