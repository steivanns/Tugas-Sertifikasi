# Aplikasi Perpustakaan Desktop
  Aplikasi Perpustakaan ini merupakan aplikasi desktop berbasis C# WinForms yang digunakan untuk mengelola data buku, anggota, peminjaman, dan pengembalian buku. Aplikasi ini terhubung dengan database MySQL dan menerapkan konsep CRUD, OOP sederhana, serta soft delete.
  
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
## Form Utama
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
