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
    public partial class FormPetugas : Form
    {
        static string username;
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
    }
}
