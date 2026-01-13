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

namespace PerpustakaanTgs.Forms
{
    public partial class FormBuku1 : Form
    {
        Buku[] daftarBuku = new Buku[100];
        int indexBuku = 0;
        public FormBuku1()
        {
            InitializeComponent();
        }

        private void FormBuku1_Load(object sender, EventArgs e)
        {
            LoadDataBuku();
            numStok.Minimum = 1;
            numTahun.Minimum = 1980;
            numTahun.Maximum = DateTime.Now.Year;
            dgvBuku.AllowUserToAddRows = false;
        }
        private bool CekInputBuku(out string pesan)
        {
            pesan = "";

            if (string.IsNullOrWhiteSpace(txtJudul.Text))
            {
                pesan = "Judul buku wajib diisi.";
                txtJudul.Focus();
                return false;
            }
            
            if (string.IsNullOrWhiteSpace(txtPenulis.Text))
            {
                pesan = "Penulis wajib diisi.";
                txtPenulis.Focus();
                return false;
            }

            if (numStok.Value <= 0)
            {
                pesan = "Stok harus lebih dari 0.";
                numStok.Focus();
                return false;
            }

            return true;
        }

        private bool BukuSudahAdaTambah(string judul, string penulis, int tahun)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query =
                    "SELECT COUNT(*) FROM buku " +
                    "WHERE judul=@judul AND penulis=@penulis AND tahun=@tahun";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@judul", judul);
                cmd.Parameters.AddWithValue("@penulis", penulis);
                cmd.Parameters.AddWithValue("@tahun", tahun);

                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }
        private bool BukuSudahAdaUbah(string judul, string penulis, int tahun, int idBuku)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query =
                    "SELECT COUNT(*) FROM buku " +
                    "WHERE judul=@judul AND penulis=@penulis AND tahun=@tahun " +
                    "AND id_buku <> @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@judul", judul);
                cmd.Parameters.AddWithValue("@penulis", penulis);
                cmd.Parameters.AddWithValue("@tahun", tahun);
                cmd.Parameters.AddWithValue("@id", idBuku);

                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }
        private bool BukuMasihDipinjam(int idBuku)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query =
                    "SELECT COUNT(*) " +
                    "FROM peminjaman p " +
                    "LEFT JOIN pengembalian k ON p.id_pinjam = k.id_pinjam " +
                    "WHERE p.id_buku = @id AND k.id_pinjam IS NULL";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idBuku);

                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private void ResetForm()
        {
            txtJudul.Clear();
            txtPenulis.Clear();
            numTahun.Value = numTahun.Minimum;
            numStok.Value = numStok.Minimum;
        }
        private void LoadDataBuku()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM buku WHERE aktif = 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                indexBuku = 0;

                while (reader.Read())
                {
                    daftarBuku[indexBuku] = new Buku
                    {
                        Id = reader.GetInt32("id_buku"),
                        Judul = reader.GetString("judul"),
                        Penulis = reader.GetString("penulis"),
                        Tahun = reader.GetInt32("tahun"),
                        Stok = reader.GetInt32("stok")
                    };
                    indexBuku++;
                }
            }

            TampilkanKeGrid();
        }
        private void TampilkanKeGrid()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id_buku");
            dt.Columns.Add("judul");
            dt.Columns.Add("penulis");
            dt.Columns.Add("tahun");
            dt.Columns.Add("stok");

            for (int i = 0; i < indexBuku; i++)
            {
                dt.Rows.Add(
                    daftarBuku[i].Id,
                    daftarBuku[i].Judul,
                    daftarBuku[i].Penulis,
                    daftarBuku[i].Tahun,
                    daftarBuku[i].Stok
                );
            }

            dgvBuku.DataSource = dt;
        }
        void LoadData()
        {
            MySqlConnection conn = Database.GetConnection();
            conn.Open();

            string query = "SELECT * FROM buku";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvBuku.DataSource = dt;
            conn.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (!CekInputBuku(out string pesan))
            {
                MessageBox.Show(pesan);
                return;
            }

            string judul = txtJudul.Text.Trim();
            string penulis = txtPenulis.Text.Trim();
            int tahun = (int)numTahun.Value;

            if (BukuSudahAdaTambah(judul, penulis, tahun))
            {
                MessageBox.Show(
                    "Buku dengan judul, penulis, dan tahun yang sama sudah terdaftar.",
                    "Duplikasi Data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query =
                    "INSERT INTO buku (judul, penulis, tahun, stok) " +
                    "VALUES (@judul, @penulis, @tahun, @stok)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@judul", judul);
                cmd.Parameters.AddWithValue("@penulis", penulis);
                cmd.Parameters.AddWithValue("@tahun", tahun);
                cmd.Parameters.AddWithValue("@stok", numStok.Value);

                cmd.ExecuteNonQuery();
            }

            LoadDataBuku();
            ResetForm();
        }

        private void dgvBuku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtJudul.Text = dgvBuku.Rows[e.RowIndex].Cells["judul"].Value.ToString();
                txtPenulis.Text = dgvBuku.Rows[e.RowIndex].Cells["penulis"].Value.ToString();
                numTahun.Value = Convert.ToInt32(dgvBuku.Rows[e.RowIndex].Cells["tahun"].Value);
                numStok.Value = Convert.ToInt32(dgvBuku.Rows[e.RowIndex].Cells["stok"].Value);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvBuku.CurrentRow == null || dgvBuku.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Pilih buku terlebih dahulu.");
                return;
            }

            int id = Convert.ToInt32(dgvBuku.CurrentRow.Cells["id_buku"].Value);

            if (BukuMasihDipinjam(id))
            {
                MessageBox.Show(
                    "Buku masih sedang dipinjam.\n\n" +
                    "Selesaikan pengembalian terlebih dahulu.",
                    "Tidak Bisa Dinonaktifkan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            var confirm = MessageBox.Show(
                "Buku akan dinonaktifkan.\n" +
                "Riwayat peminjaman tetap disimpan.\n\nLanjutkan?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes) return;

            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "UPDATE buku SET aktif = 0 WHERE id_buku = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }

            LoadDataBuku();
            ResetForm();
        }
        private void dgvBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvBuku.Rows[e.RowIndex];

            if (row.IsNewRow) return;

            if (!dgvBuku.Columns.Contains("stok") ||
                !dgvBuku.Columns.Contains("tahun")) return;

            txtJudul.Text = row.Cells["judul"]?.Value?.ToString() ?? "";
            txtPenulis.Text = row.Cells["penulis"]?.Value?.ToString() ?? "";

            if (int.TryParse(row.Cells["tahun"]?.Value?.ToString(), out int tahun))
            {
                numTahun.Value = Math.Min(
                    Math.Max(tahun, (int)numTahun.Minimum),
                    (int)numTahun.Maximum
                );
            }
            else
            {
                numTahun.Value = numTahun.Minimum;
            }

            if (int.TryParse(row.Cells["stok"]?.Value?.ToString(), out int stok))
            {
                numStok.Value = Math.Max(stok, (int)numStok.Minimum);
            }
            else
            {
                numStok.Value = numStok.Minimum;
            }
        }
        private string GetInfoPeminjam(int idBuku)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query =
                    "SELECT a.nama, p.tanggal_pinjam " +
                    "FROM peminjaman p " +
                    "JOIN anggota a ON p.id_anggota = a.id_anggota " +
                    "LEFT JOIN pengembalian k ON p.id_pinjam = k.id_pinjam " +
                    "WHERE p.id_buku = @id AND k.id_pinjam IS NULL " +
                    "LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idBuku);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string nama = reader.GetString("nama");
                        DateTime tgl = reader.GetDateTime("tanggal_pinjam");

                        return
                            $"Buku masih sedang dipinjam.\n\n" +
                            $"Nama: {nama}\n" +
                            $"Tanggal Pinjam: {tgl:dd-MM-yyyy}";
                    }
                }
            }

            return null;
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgvBuku.CurrentRow == null || dgvBuku.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Pilih buku terlebih dahulu.");
                return;
            }

            if (!CekInputBuku(out string pesan))
            {
                MessageBox.Show(pesan);
                return;
            }

            int id = Convert.ToInt32(dgvBuku.CurrentRow.Cells["id_buku"].Value);
            string judul = txtJudul.Text.Trim();
            string penulis = txtPenulis.Text.Trim();
            int tahun = (int)numTahun.Value;

            if (BukuSudahAdaUbah(judul, penulis, tahun, id))
            {
                MessageBox.Show("Data buku dengan informasi yang sama sudah ada.");
                return;
            }

            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query =
                    "UPDATE buku SET judul=@judul, penulis=@penulis, tahun=@tahun, stok=@stok " +
                    "WHERE id_buku=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@judul", judul);
                cmd.Parameters.AddWithValue("@penulis", penulis);
                cmd.Parameters.AddWithValue("@tahun", tahun);
                cmd.Parameters.AddWithValue("@stok", numStok.Value);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }

            LoadDataBuku();
            ResetForm();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void numStok_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtJudul_TextChanged(object sender, EventArgs e)
        {

        }

        private void numTahun_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPenulis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
