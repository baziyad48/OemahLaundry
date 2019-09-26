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
    public partial class FormEditProfile : Form
    {
        static string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=oemah_laundry;SslMode=none";
        MySqlConnection conn = new MySqlConnection(connString);

        List<string> userData;

        public FormEditProfile(List<string> list)
        {
            InitializeComponent();
            userData = list;
            tb_nama.Text = list[1];
            tb_password.Text = list[3];
            tb_telepon.Text = list[4];
            tb_alamat.Text = list[5];
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            string query = "UPDATE pelanggan SET nama=@nama, password=@password, telepon=@telepon, alamat=@alamat WHERE id_pelanggan=@id";

            List<string> data = new List<string>();

            MySqlCommand cmd = new MySqlCommand(query, conn)
            {
                CommandTimeout = 60
            };
            try
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@nama", tb_nama.Text);
                cmd.Parameters.AddWithValue("@password", tb_password.Text);
                cmd.Parameters.AddWithValue("@telepon", tb_telepon.Text);
                cmd.Parameters.AddWithValue("@alamat", tb_alamat.Text);
                cmd.Parameters.AddWithValue("@id", userData[0]);

                cmd.ExecuteNonQuery();

                data.Add(userData[0]);
                data.Add(tb_nama.Text);
                data.Add(tb_password.Text);
                data.Add(tb_telepon.Text);
                data.Add(tb_alamat.Text);

                MessageBox.Show("Data berhasil diubah");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                this.Hide();
            }
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
