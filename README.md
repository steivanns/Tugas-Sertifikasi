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
