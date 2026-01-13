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
    public partial class FormUntukAnggota : Form
    {
        public FormUntukAnggota()
        {
            InitializeComponent();
        }

        private void FormUntukAnggota_Load(object sender, EventArgs e)
        {

        }

        private void PanelPinjam_Click(object sender, EventArgs e)
        {
            new FormAnggota().Show();
        }

        private void LblMember_Click(object sender, EventArgs e)
        {
            new FormAnggota().Show();
        }

        private void PanelKembali_Click(object sender, EventArgs e)
        {
            new FormPeminjamanAnggota().Show();
        }

        private void LblKembali_Click(object sender, EventArgs e)
        {
            new FormPeminjamanAnggota().Show();
        }
        private void PicKembali_Click(object sender, EventArgs e)
        {
            new FormPeminjamanAnggota().Show();
        }
        private void PicPinjam_Click(object sender, EventArgs e)
        {
            new FormAnggota().Show();
        }
    }
}
