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
    public partial class FormAnggota : Form
    {
        Anggota[] daftarAnggota = new Anggota[100];
        int indexAnggota = 0;
        public FormAnggota()
        {
            InitializeComponent();
        }

        private void FormAnggota_Load(object sender, EventArgs e)
        {
            LoadDataAnggota();
            dgvAnggota.AllowUserToAddRows = false;
            dgvAnggota.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private bool CekInput(out string pesan)
        {
            pesan = "";

            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                pesan = "Nama wajib diisi.";
                txtNama.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAlamat.Text))
            {
                pesan = "Penulis wajib diisi.";
                txtAlamat.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNoHp.Text))
            {
                pesan = "No Hp Wajib diisi";
                txtNoHp.Focus();
                return false;
            }

            return true;
        }
        private bool AnggotaSudahAdaTambah(string nama, string alamat, string noHp)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query =
                    "SELECT COUNT(*) FROM anggota " +
                    "WHERE nama = @nama AND alamat = @alamat AND no_hp = @nohp";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@alamat", alamat);
                cmd.Parameters.AddWithValue("@nohp", noHp);

                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }
        private bool AnggotaSudahAdaUbah(string noHp, int idAnggota)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query =
                    "SELECT COUNT(*) FROM anggota " +
                    "WHERE no_hp = @nohp AND id_anggota <> @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nohp", noHp);
                cmd.Parameters.AddWithValue("@id", idAnggota);

                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }
        private bool AnggotaMasihMeminjam(int idAnggota)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query =
                    "SELECT COUNT(*) " +
                    "FROM peminjaman p " +
                    "LEFT JOIN pengembalian k ON p.id_pinjam = k.id_pinjam " +
                    "WHERE p.id_anggota = @id AND k.id_pinjam IS NULL";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idAnggota);

                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private void LoadDataAnggota()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM anggota WHERE aktif = 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                indexAnggota = 0;

                while (reader.Read())
                {
                    daftarAnggota[indexAnggota] = new Anggota
                    {
                        Id = reader.GetInt32("id_anggota"),
                        Nama = reader.GetString("nama"),
                        Alamat = reader.GetString("alamat"),
                        NoHp = reader.GetString("no_hp")
                    };
                    indexAnggota++;
                }
            }
            TampilkanKeGrid();
        }

        private void TampilkanKeGrid()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id_anggota");
            dt.Columns.Add("nama");
            dt.Columns.Add("alamat");
            dt.Columns.Add("no_hp");

            for (int i = 0; i < indexAnggota; i++)
            {
                dt.Rows.Add(
                    daftarAnggota[i].Id,
                    daftarAnggota[i].Nama,
                    daftarAnggota[i].Alamat,
                    daftarAnggota[i].NoHp
                );
            }
            dgvAnggota.DataSource = dt;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (!CekInput(out string pesan))
            {
                MessageBox.Show(pesan);
                return;
            }
            string nama = txtNama.Text.Trim();
            string alamat = txtAlamat.Text.Trim();
            string noHp = txtNoHp.Text.Trim();

            if (AnggotaSudahAdaTambah(nama, alamat, noHp))
            {
                MessageBox.Show(
                "Data anggota dengan nama, alamat, dan nomor HP yang sama sudah terdaftar.",
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
                    "INSERT INTO anggota (nama, alamat, no_hp) " +
                    "VALUES (@nama, @alamat, @nohp)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", txtNama.Text.Trim());
                cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text.Trim());
                cmd.Parameters.AddWithValue("@nohp", noHp);

                cmd.ExecuteNonQuery();
            }

            LoadDataAnggota();
            ResetForm();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgvAnggota.CurrentRow == null || dgvAnggota.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Pilih data anggota terlebih dahulu.");
                return;
            }

            if (!CekInput(out string pesan))
            {
                MessageBox.Show(pesan);
                return;
            }

            int id = Convert.ToInt32(dgvAnggota.CurrentRow.Cells["id_anggota"].Value);
            string noHp = txtNoHp.Text.Trim();

            if (AnggotaSudahAdaUbah(noHp, id))
            {
                MessageBox.Show("Nomor HP sudah digunakan anggota lain.");
                return;
            }

            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query =
                    "UPDATE anggota SET nama=@nama, alamat=@alamat, no_hp=@nohp " +
                    "WHERE id_anggota=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", txtNama.Text.Trim());
                cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text.Trim());
                cmd.Parameters.AddWithValue("@nohp", noHp);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }

            LoadDataAnggota();
            ResetForm();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvAnggota.CurrentRow == null || dgvAnggota.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Pilih anggota terlebih dahulu.");
                return;
            }

            int id = Convert.ToInt32(dgvAnggota.CurrentRow.Cells["id_anggota"].Value);

            if (AnggotaMasihMeminjam(id))
            {
                MessageBox.Show(
                    "Anggota masih memiliki peminjaman aktif.\n\n" +
                    "Selesaikan pengembalian terlebih dahulu.",
                    "Tidak Bisa Dinonaktifkan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            var confirm = MessageBox.Show(
                "Anggota akan dinonaktifkan.\nRiwayat peminjaman tetap tersimpan.\n\nLanjutkan?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes) return;

            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "UPDATE anggota SET aktif = 0 WHERE id_anggota = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }

            LoadDataAnggota();
            ResetForm();
        }

        private void dgvAnggota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNama.Text = dgvAnggota.Rows[e.RowIndex].Cells["nama"].Value.ToString();
                txtAlamat.Text = dgvAnggota.Rows[e.RowIndex].Cells["alamat"].Value.ToString();
                txtNoHp.Text = dgvAnggota.Rows[e.RowIndex].Cells["no_hp"].Value.ToString();
            }
        }

        private void ResetForm()
        {
            txtNama.Clear();
            txtAlamat.Clear();
            txtNoHp.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
