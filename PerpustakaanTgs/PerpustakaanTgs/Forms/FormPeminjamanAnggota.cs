using MySql.Data.MySqlClient;
using PerpustakaanTgs.Config;
using PerpustakaanTgs.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace PerpustakaanTgs.Forms
{
    public partial class FormPeminjamanAnggota : Form
    {
        public FormPeminjamanAnggota()
        {
            InitializeComponent();
        }
        private void FormPeminjamanAnggota_Load(object sender, EventArgs e)
        {
            LoadAnggota();
            LoadBuku();
            LoadDataGrid();
            dtpPinjam.Value = DateTime.Now;
            lblJatuhTempo.Text = dtpPinjam.Value.AddDays(7).ToString("dd-MM-yyyy");
            dgvPeminjaman.AllowUserToAddRows = false;
            dgvPeminjaman.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPeminjaman.AllowUserToAddRows = false;
            dgvPeminjaman.RowHeadersVisible = false;
            dgvPeminjaman.ReadOnly = true;
            dgvPeminjaman.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadAnggota()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query =
                    "SELECT id_anggota, CONCAT(nama, ' - ', no_hp) AS info " +
                    "FROM anggota " +
                    "WHERE aktif = 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbAnggota.DataSource = dt;
                cmbAnggota.DisplayMember = "info";
                cmbAnggota.ValueMember = "id_anggota";
            }
        }

        private void LoadBuku()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query =
                    "SELECT id_buku, CONCAT(judul, ' - ', penulis) AS info " +
                    "FROM buku " +
                    "WHERE aktif = 1 AND stok > 0";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbBuku.DataSource = dt;
                cmbBuku.DisplayMember = "info";
                cmbBuku.ValueMember = "id_buku";
            }
        }

        private void btnPinjam_Click(object sender, EventArgs e)
        {
            if (cmbAnggota.SelectedValue == null)
            {
                MessageBox.Show("pilih anggota terlebih dahulu.");
                return;
            }

            if (cmbBuku.SelectedValue == null)
            {
                MessageBox.Show("tidak ada buku yang tersedia untuk dipinjam.");
                return;
            }

            int idAnggota = Convert.ToInt32(cmbAnggota.SelectedValue);
            int idBuku = Convert.ToInt32(cmbBuku.SelectedValue);

            DateTime tglPinjam = DateTime.Now;
            DateTime tglJatuhTempo = tglPinjam.AddDays(7);

            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string insert =
                    "INSERT INTO peminjaman (id_buku, id_anggota, tanggal_pinjam, tanggal_jatuh_tempo) " +
                    "VALUES (@buku, @anggota, @pinjam, @tempo)";

                MySqlCommand cmd = new MySqlCommand(insert, conn);
                cmd.Parameters.AddWithValue("@buku", idBuku);
                cmd.Parameters.AddWithValue("@anggota", idAnggota);
                cmd.Parameters.AddWithValue("@pinjam", tglPinjam);
                cmd.Parameters.AddWithValue("@tempo", tglJatuhTempo);
                cmd.ExecuteNonQuery();

                string updateStok =
                    "UPDATE buku SET stok = stok - 1 WHERE id_buku = @id";

                MySqlCommand cmdStok = new MySqlCommand(updateStok, conn);
                cmdStok.Parameters.AddWithValue("@id", idBuku);
                cmdStok.ExecuteNonQuery();
            }

            MessageBox.Show($"Peminjaman berhasil.\nJatuh tempo: {tglJatuhTempo:dd-MM-yyyy}");

            LoadBuku();
            LoadDataGrid();
        }

        private void dtpPinjam_ValueChanged(object sender, EventArgs e)
        {
            DateTime tanggalPinjam = dtpPinjam.Value;
            DateTime jatuhTempo = tanggalPinjam.AddDays(7);

            lblJatuhTempo.Text = jatuhTempo.ToString("dd-MM-yyyy");
        }

        private void LoadDataGrid()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query ="SELECT * FROM buku WHERE aktif = 1";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvPeminjaman.DataSource = dt;
            }
        }
    }
}
