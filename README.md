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

### collections table

| Column | Type |
|--------|------|
| id | INT (PK, AUTO_INCREMENT) |
| title | VARCHAR(200) |
| author | VARCHAR(100) |
| total_copies | INT |
| available_copies | INT |
