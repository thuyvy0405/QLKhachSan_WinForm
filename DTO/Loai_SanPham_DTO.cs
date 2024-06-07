using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Loai_SanPham_DTO
    {
        private int _idLoaiSP;
        private string _tenLoaiSP;

        public int IdLoaiSP { get => _idLoaiSP; set => _idLoaiSP = value; }
        public string TenLoaiSP { get => _tenLoaiSP; set => _tenLoaiSP = value; }
    }
}
