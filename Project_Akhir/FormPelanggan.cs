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

namespace Project_Akhir
{
    public partial class FormPelanggan : Form
    {
        static string username;
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
    }
}
