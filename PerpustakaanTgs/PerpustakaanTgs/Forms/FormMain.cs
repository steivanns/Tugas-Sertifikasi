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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnBuku_Click(object sender, EventArgs e)
        {
            new FormBuku1().Show();
        }

        private void btnAnggota_Click(object sender, EventArgs e)
        {
            new FormAnggota().Show();
        }

        private void btnPeminjaman_Click(object sender, EventArgs e)
        {
            new FormPeminjaman().Show();
        }

        private void btnPengembalian_Click(object sender, EventArgs e)
        {
            new FormPengembalian().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBuku_Click(object sender, EventArgs e)
        {
            new FormBuku1().Show();
        }

        private void panelAnggota_Click(object sender, EventArgs e)
        {
            new FormAnggota().Show();
        }

        private void panelPinjam_Click(object sender, EventArgs e)
        {
            new FormPeminjaman().Show();
        }

        private void panelKembali_Click(object sender, EventArgs e)
        {
            new FormPengembalian().Show();
        }
    }
}
