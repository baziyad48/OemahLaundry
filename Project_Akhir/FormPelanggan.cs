using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;

namespace Project_Akhir
{
    public partial class FormPelanggan : Form
    {
        static string username;

        static string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=oemah_laundry;SslMode=none";
        MySqlConnection conn = new MySqlConnection(connString);

        public FormPelanggan(string param)
        {
            InitializeComponent();
            username = param;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openFormPilihRole);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openFormPilihRole()
        {
            Application.Run(new FormPilihRole());
        }

        static private FormPemesananPelanggan frmpsnplgn;

        private void inputPesananToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmpsnplgn = new FormPemesananPelanggan(username);
            frmpsnplgn.MdiParent = this;
            frmpsnplgn.Show();
        }

        static private FormRiwayatPemesanan frmrwytpmsn;
        private void lihatPesananToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrwytpmsn = new FormRiwayatPemesanan(username);
            frmrwytpmsn.MdiParent = this;
            frmrwytpmsn.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM pelanggan WHERE username='" + username + "'";

            MySqlCommand commandDatabase = new MySqlCommand(query, conn);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            List<string> data = new List<string>();

            try
            {
                conn.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(reader.GetString("id_pelanggan"));
                    data.Add(reader.GetString("nama"));
                    data.Add(reader.GetString("username"));
                    data.Add(reader.GetString("password"));
                    data.Add(reader.GetString("telepon"));
                    data.Add(reader.GetString("alamat"));
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
            new Profile(data).Show();
        }
    }
}
