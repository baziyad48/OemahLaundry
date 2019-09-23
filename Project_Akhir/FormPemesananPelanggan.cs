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
    public partial class FormPemesananPelanggan : Form
    {
        static string nama;
        public FormPemesananPelanggan(string tes)
        {
            InitializeComponent();
            nama = tes;
        }

        private void FormPemesananPelanggan_Load(object sender, EventArgs e)
        {
            MessageBox.Show(nama);
        }
    }
}
