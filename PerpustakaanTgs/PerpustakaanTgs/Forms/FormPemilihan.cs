using PerpustakaanTgs.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerpustakaanTgs.Forms
{
    public partial class FormPemilihan : Form
    {
        public FormPemilihan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new FormMain().Show();
        }

        private void Panel1_Click(object sender, EventArgs e)
        {
            new FormMain().Show();
        }

        private void PanelBuku_Click(object sender, EventArgs e)
        {
            new FormMain().Show();
        }

        private void OpenFormMain()
        {
            FormMain fm = new FormMain();
            fm.Show();
            this.Hide();
        }

        private void Panel2_Click(object sender, EventArgs e)
        {
            new FormUntukAnggota().Show();
        }
        private void Panel3_Click(object sender, EventArgs e)
        {
            new FormUntukAnggota().Show();
        }
        private void Label2_Click(object sender, EventArgs e)
        {
            new FormUntukAnggota().Show();
        }

        private void OpenFormPemilihan()
        {
            FormUntukAnggota fp = new FormUntukAnggota();
            fp.Show();
            this.Hide();
        }
    }
}
