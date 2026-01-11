using MySql.Data.MySqlClient;
using PerpustakaanTgs.Config;
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
    public partial class FormPengembalian : Form
    {
        public FormPengembalian()
        {
            InitializeComponent();
        }

        private void FormPengembalian_Load(object sender, EventArgs e)
        {
            LoadPeminjaman();
            LoadDataGrid();
            dgvPengembalian.AllowUserToAddRows = false;
            dtpKembali.Value = DateTime.Now;
        }

        private void LoadPeminjaman()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query =
                    "SELECT p.id_pinjam, CONCAT(a.nama, ' - ', b.judul) AS info " +
                    "FROM peminjaman p " +
                    "JOIN anggota a ON p.id_anggota = a.id_anggota " +
                    "JOIN buku b ON p.id_buku = b.id_buku " +
                    "LEFT JOIN pengembalian k ON p.id_pinjam = k.id_pinjam " +
                    "WHERE k.id_pinjam IS NULL";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbPinjam.DataSource = dt;
                cmbPinjam.DisplayMember = "info";
                cmbPinjam.ValueMember = "id_pinjam";
            }
        }

        private int HitungDenda(DateTime jatuhTempo, DateTime kembali)
        {
            int telat = (kembali - jatuhTempo).Days;
            return telat > 0 ? telat * 1000 : 0;
        }

        private void btnKembalikan_Click(object sender, EventArgs e)
        {
            if (cmbPinjam.SelectedValue == null)
            {
                MessageBox.Show("Pilih data peminjaman.");
                return;
            }

            int idPinjam = Convert.ToInt32(cmbPinjam.SelectedValue);
            DateTime tglKembali = dtpKembali.Value;

            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string insert =
                    "INSERT INTO pengembalian (id_pinjam, tanggal_kembali) " +
                    "VALUES (@pinjam, @kembali)";

                MySqlCommand cmd = new MySqlCommand(insert, conn);
                cmd.Parameters.AddWithValue("@pinjam", idPinjam);
                cmd.Parameters.AddWithValue("@kembali", tglKembali);
                cmd.ExecuteNonQuery();

                string updateStok =
                    "UPDATE buku SET stok = stok + 1 " +
                    "WHERE id_buku = (SELECT id_buku FROM peminjaman WHERE id_pinjam=@id)";

                MySqlCommand cmdStok = new MySqlCommand(updateStok, conn);
                cmdStok.Parameters.AddWithValue("@id", idPinjam);
                cmdStok.ExecuteNonQuery();
            }

            MessageBox.Show("Pengembalian berhasil");

            LoadPeminjaman();
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query =
                    "SELECT k.id_kembali, p.id_pinjam, a.id_anggota, a.nama, b.judul, p.tanggal_pinjam, p.tanggal_jatuh_tempo, k.tanggal_kembali " +
                    "FROM pengembalian k " +
                    "JOIN peminjaman p ON k.id_pinjam = p.id_pinjam " +
                    "JOIN anggota a ON p.id_anggota = a.id_anggota " +
                    "JOIN buku b ON p.id_buku = b.id_buku";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvPengembalian.DataSource = dt;
            }
        }
    }
}
