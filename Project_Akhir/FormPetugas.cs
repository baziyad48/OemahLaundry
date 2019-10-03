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
    public partial class FormPetugas : Form
    {
        static string username;

        static string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=oemah_laundry;SslMode=none";
        MySqlConnection conn = new MySqlConnection(connString);

        public FormPetugas(string param)
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

        static private FormLihatPemesanan frm;

        private void lihatPesananToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm = new FormLihatPemesanan(username);
            frm.MdiParent = this;
            frm.Show();
        }

        static private FormPemesananPetugas frmpmsnptgs;
        private void inputPesananToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmpmsnptgs = new FormPemesananPetugas(username);
            frmpmsnptgs.MdiParent = this;
            frmpmsnptgs.Show();
        }

        private void laundryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        static private FormBarangCucian fBarangCucian;
        private void tambahJenisCucianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBarangCucian = new FormBarangCucian();
            fBarangCucian.MdiParent = this;
            fBarangCucian.Show();
        }

        private void petugasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tipe = getTipePetugas();
            switch (tipe)
            {
                case "admin":
                    new FormTambahPetugas().Show();
                    break;

                case "umum":
                    MessageBox.Show("Anda tidak memiliki hak akses pada fitur ini");
                    break;

                default:
                    MessageBox.Show("Anda tidak memiliki hak akses pada fitur ini");
                    break;
            }
        }

        private string getTipePetugas()
        {
            string query = "SELECT tipe FROM petugas WHERE username=@username";
            string tipe = "umum";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tipe = reader["tipe"].ToString();
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
            return tipe;
        }

        private void pelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tipe = getTipePetugas();
            switch (tipe)
            {
                case "admin":
                    new FormLihatPelanggan().Show();
                    break;

                case "umum":
                    MessageBox.Show("Anda tidak memiliki hak akses pada fitur ini");
                    break;

                default:
                    MessageBox.Show("Anda tidak memiliki hak akses pada fitur ini");
                    break;
            }
        }
    }
}
