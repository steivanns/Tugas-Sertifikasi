# Aplikasi Perpustakaan Desktop
  Aplikasi Perpustakaan ini merupakan aplikasi desktop berbasis C# WinForms yang digunakan untuk mengelola data buku, anggota, peminjaman, dan pengembalian buku. Aplikasi ini terhubung dengan database MySQL dan menerapkan konsep CRUD, OOP sederhana, serta soft delete.

# Tools 

- Programming Language: C#
- Framework: .NET (WinForms)
- Database: MySQL
- IDE: Visual Studio
- Library: MySql.Data

# Fitur Utama 
- Manajemen Data Buku
- Manajemen Data Anggota
- Proses Peminjaman Buku
- Proses Pengembalian Buku
- Perhitungan stok buku otomatis
- Soft delete (data tidak dihapus permanen)
- Validasi input dan pencegahan data duplikat

# Struktur Folder Project
```text
PerpustakaanTgs/
├── Config/
│   └── Database.cs
├── Forms/
│   ├── FormMain.cs
│   ├── FormBuku1.cs
│   ├── FormAnggota.cs
│   ├── FormPeminjaman.cs
│   └── FormPengembalian.cs
└── Model/
    ├── Anggota.cs
    ├── Buku.cs
    ├── Peminjaman.cs
    └── Pengembalian.cs
```

# Screenshot
## Form Pemilihan User 
<img width="795" height="482" alt="image" src="https://github.com/user-attachments/assets/6532269d-c995-4021-a4c2-4b55e0d06325" />

## Form Utama Untuk Anggota 
<img width="797" height="481" alt="image" src="https://github.com/user-attachments/assets/ec7cfb77-acd9-41ce-b725-4a2baf007f1a" />

## Form Utama untuk Admin
<img width="891" height="532" alt="image" src="https://github.com/user-attachments/assets/5c19b660-c943-4b30-ba3e-04b687adbbe3" />

## Form Mananagemen Buku 
<img width="977" height="528" alt="image" src="https://github.com/user-attachments/assets/81520d11-7964-4c5b-ae2b-ff40de8c262b" />

## Form Managemen Anggota
<img width="975" height="530" alt="image" src="https://github.com/user-attachments/assets/05eb4bf1-9c73-4ef8-9937-574473b85eb6" />

## Form Pinjam Buku 
<img width="975" height="531" alt="image" src="https://github.com/user-attachments/assets/8d70cf8c-2ff3-4612-b7c7-2b76d4f88304" />

## Form Pengembalian
<img width="978" height="532" alt="image" src="https://github.com/user-attachments/assets/c129a529-e656-4666-a9a6-b167178ce91d" />

# Database Design 
Aplikasi ini menggunakan database relasional MySQL dengan nama perpustakaan. Desain database dibuat untuk mendukung proses manajemen buku, anggota, peminjaman, dan pengembalian, serta menerapkan soft delete untuk menjaga integritas data dan riwayat transaksi.

### Table Buku

| Column | Type |
|------|------|
| id_buku | INT (PK, AUTO_INCREMENT) |
| judul | VARCHAR(100) |
| penulis | VARCHAR(100) |
| tahun | INT |
| stok | INT |
| aktif | TINYINT(1) |

### Table Anggota 

| Column | Type |
|------|------|
| id_anggota | INT (PK, AUTO_INCREMENT) |
| nama | VARCHAR(100) |
| alamat | VARCHAR(150) |
| no_hp | VARCHAR(20) |
| aktif | TINYINT(1) |

### Table Peminjaman
| Column | Type |
|------|------|
| id_pinjam | INT (PK, AUTO_INCREMENT) |
| id_buku | INT (FK → buku.id_buku) |
| id_anggota | INT (FK → anggota.id_anggota) |
| tanggal_pinjam | DATE |
| tanggal_jatuh_tempo | DATE |

### Table Pengembalian
| Column | Type |
|------|------|
| id_kembali | INT (PK, AUTO_INCREMENT) |
| id_pinjam | INT (FK → peminjaman.id_pinjam) |
| tanggal_kembali | DATE |

# SQL Schema 
```Text
CREATE DATABASE perpustakaan;
USE perpustakaan;

CREATE TABLE buku (
    id_buku INT AUTO_INCREMENT PRIMARY KEY,
    judul VARCHAR(100) NOT NULL,
    penulis VARCHAR(100) NOT NULL,
    tahun INT NOT NULL,
    stok INT NOT NULL,
    aktif TINYINT(1) NOT NULL DEFAULT 1
);

CREATE TABLE anggota (
    id_anggota INT AUTO_INCREMENT PRIMARY KEY,
    nama VARCHAR(100) NOT NULL,
    alamat VARCHAR(150) NOT NULL,
    no_hp VARCHAR(20) NOT NULL,
    aktif TINYINT(1) NOT NULL DEFAULT 1
);

CREATE TABLE peminjaman (
    id_pinjam INT AUTO_INCREMENT PRIMARY KEY,
    id_buku INT NOT NULL,
    id_anggota INT NOT NULL,
    tanggal_pinjam DATE NOT NULL,
    tanggal_jatuh_tempo DATE NOT NULL,
    FOREIGN KEY (id_buku) REFERENCES buku(id_buku)
        ON DELETE RESTRICT
        ON UPDATE CASCADE,
    FOREIGN KEY (id_anggota) REFERENCES anggota(id_anggota)
        ON DELETE RESTRICT
        ON UPDATE CASCADE
);

CREATE TABLE pengembalian (
    id_kembali INT AUTO_INCREMENT PRIMARY KEY,
    id_pinjam INT NOT NULL,
    tanggal_kembali DATE NOT NULL,
    FOREIGN KEY (id_pinjam) REFERENCES peminjaman(id_pinjam)
        ON DELETE RESTRICT
        ON UPDATE CASCADE
);
```

# ER Diagram 
<img width="1025" height="477" alt="image" src="https://github.com/user-attachments/assets/3ca05970-e50f-40c9-a144-0642b87563f1" />

# Business Rules

- Buku tidak dapat dinonaktifkan jika masih dipinjam
- Anggota tidak dapat dinonaktifkan jika memiliki peminjaman aktif
- Stok buku otomatis berkurang saat peminjaman
- Stok buku otomatis bertambah saat pengembalian
- Data tidak dihapus permanen (soft delete)

# POenggunaan OOP 
- Class digunakan untuk merepresentasikan data (Buku, Anggota, Peminjaman, Pengembalian)
- Setiap Form bertanggung jawab pada satu fitur
- Pemisahan antara:
  - Config (koneksi database)
  - Model (data)
  - Forms (logic & UI)

# Pengujian Sistem (Manual Testing)

Pengujian dilakukan secara manual untuk memastikan seluruh fitur utama
pada Aplikasi Manajemen Perpustakaan berjalan sesuai dengan kebutuhan
dan aturan bisnis yang telah ditentukan.

---

### 🔹 Pengujian Antarmuka Aplikasi

| No | Fitur | Langkah Pengujian | Hasil yang Diharapkan | Hasil Aktual | Status |
|----|------|------------------|----------------------|-------------|--------|
| 1 | Form Utama | Menjalankan aplikasi | Form utama tampil tanpa error | Sesuai | ✅ |
| 2 | Navigasi Menu | Klik menu Buku, Anggota, Peminjaman, Pengembalian | Form terbuka sesuai menu | Sesuai | ✅ |

---

### 🔹 Pengujian Manajemen Buku

| No | Fitur | Langkah Pengujian | Hasil yang Diharapkan | Hasil Aktual | Status |
|----|------|------------------|----------------------|-------------|--------|
| 3 | Lihat Buku | Membuka Form Buku | Data buku aktif tampil | Sesuai | ✅ |
| 4 | Tambah Buku | Input data buku valid lalu simpan | Buku tersimpan ke database | Sesuai | ✅ |
| 5 | Nonaktifkan Buku | Menghapus buku yang masih dipinjam | Sistem menolak proses | Ditolak oleh sistem | ✅ |

---

### 🔹 Pengujian Manajemen Anggota

| No | Fitur | Langkah Pengujian | Hasil yang Diharapkan | Hasil Aktual | Status |
|----|------|------------------|----------------------|-------------|--------|
| 6 | Tambah Anggota | Input data anggota valid | Data anggota tersimpan | Sesuai | ✅ |
| 7 | Nonaktifkan Anggota | Menghapus anggota yang masih meminjam | Sistem menolak proses | Ditolak oleh sistem | ✅ |

---

### 🔹 Pengujian Peminjaman Buku

| No | Fitur | Langkah Pengujian | Hasil yang Diharapkan | Hasil Aktual | Status |
|----|------|------------------|----------------------|-------------|--------|
| 8 | Peminjaman Buku | Memilih anggota & buku | Stok buku berkurang 1 | Sesuai | ✅ |
| 9 | Tanggal Jatuh Tempo | Melakukan peminjaman | Jatuh tempo +7 hari | Sesuai | ✅ |

---

### 🔹 Pengujian Pengembalian Buku

| No | Fitur | Langkah Pengujian | Hasil yang Diharapkan | Hasil Aktual | Status |
|----|------|------------------|----------------------|-------------|--------|
| 10 | Pengembalian Buku | Mengembalikan buku | Stok buku bertambah | Sesuai | ✅ |

---

### Catatan Pengujian

- Sistem menerapkan aturan bisnis untuk menjaga integritas data
- Seluruh fungsi utama berjalan sesuai perancangan

---

###  Kesimpulan

Berdasarkan hasil pengujian manual, aplikasi berjalan stabil dan
seluruh fitur utama berfungsi dengan baik.  
Aplikasi dinyatakan **layak untuk digunakan**.

---
