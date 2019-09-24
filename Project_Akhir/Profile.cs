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
        static readonly string rule = "datasource=127.0.0.1;port=3306;username=root;password=wil;database=test;SslMode=none";
        MySqlConnection CONNECTION = new MySqlConnection(Profile.rule);

        EditProfile prf;
        Riwayat rwt;

        public Profile()
        {
            InitializeComponent();
            prf = new EditProfile();
            rwt = new Riwayat();
        }

        private void editProfile_Click(object sender, EventArgs e)
        {
            if (prf != null)
            {
                prf.Show();
            }
        }

        private void riwayat_Click(object sender, EventArgs e)
        {
            if (rwt != null)
            {
                rwt.Show();
            }
        }
    }
}
