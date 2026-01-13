using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerpustakaanTgs.Model
{
    internal class Peminjaman
    {
        public int IdPinjam;
        public int IdBuku;
        public int IdAnggota;
        public DateTime TanggalPinjam;
        public DateTime TanggalJatuhTempo;
    }
}
