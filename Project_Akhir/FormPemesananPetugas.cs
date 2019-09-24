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
    public partial class FormPemesananPetugas : Form
    {
        static string username;
        public FormPemesananPetugas(string param)
        {
            InitializeComponent();
            username = param;

        }

        private FormGenerateAkun frmgenerate;
        private void button3_Click(object sender, EventArgs e)
        {
            frmgenerate = new FormGenerateAkun();
            frmgenerate.Show();
        }
    }
}
