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
    public partial class Profile : Form
    {
        List<string> userData;
        string username;

        static string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=oemah_laundry;SslMode=none";
        MySqlConnection conn = new MySqlConnection(connString);

        public Profile(List<string> list)
        {
            InitializeComponent();
            userData = list;
            username = list[2];
            updateForm();
        }

        private void editProfile_Click(object sender, EventArgs e)
        {
            new FormEditProfile(userData).Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void updateForm()
        {
            string query = "SELECT * FROM pelanggan WHERE username='" + username + "'";

            MySqlCommand commandDatabase = new MySqlCommand(query, conn);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    nama_user.Text = reader.GetString("nama");
                    username_user.Text = reader.GetString("username");
                    telepon_user.Text = reader.GetString("telepon");
                    alamat_user.Text = reader.GetString("alamat");
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
    }
}
