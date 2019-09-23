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
    public partial class FormPilihRole : Form
    {
        Thread th;
        public FormPilihRole()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openFormLoginPelanggan);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openFormLoginPelanggan()
        {
            Application.Run(new FormLoginPelanggan());
        }

        private void openFormLoginPetugas()
        {
            Application.Run(new FormLoginPetugas());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openFormLoginPetugas);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
