using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham_DTO
    {
        private int _IDSP;
        private string _tensp;
        private int _IDLoaisp;
        private int _IDDVT;
        private float _dongiaSP;
        private float _soluongSP;

        public int IDSP { get => _IDSP; set => _IDSP = value; }
        public string Tensp { get => _tensp; set => _tensp = value; }
        public int IDLoaisp { get => _IDLoaisp; set => _IDLoaisp = value; }
        public int IDDVT { get => _IDDVT; set => _IDDVT = value; }
        public float DongiaSP { get => _dongiaSP; set => _dongiaSP = value; }
        public float SoluongSP { get => _soluongSP; set => _soluongSP = value; }
    }
}
