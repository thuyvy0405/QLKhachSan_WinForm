using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon_DTO
    {
        private int _IDHD;
        private DateTime _NgayGD;
        private int _IDCty;
        private int _IDNV;
        private double _TongHD;
        private int _IDDatphong;
        private string _tencty;
        private string _tenNV;
        private string _IDPhong;
        private string _tenPhong;
        private int _IDKH;
        private string _tenkh;
        private double TienPhong;
        private double tiendichvu;
        private double tienkhachtra;
        private double tientralai;
        private int trangthai;


        public int IDHD { get => _IDHD; set => _IDHD = value; }
        public DateTime NgayGD { get => _NgayGD; set => _NgayGD = value; }
        public int IDCty { get => _IDCty; set => _IDCty = value; }
        public int IDNV { get => _IDNV; set => _IDNV = value; }
        public double TongHD { get => _TongHD; set => _TongHD = value; }
        public int IDDatphong { get => _IDDatphong; set => _IDDatphong = value; }
        public string Tencty { get => _tencty; set => _tencty = value; }
        public string TenNV { get => _tenNV; set => _tenNV = value; }
        public string IDPhong { get => _IDPhong; set => _IDPhong = value; }
        public string TenPhong { get => _tenPhong; set => _tenPhong = value; }
        public int IDKH { get => _IDKH; set => _IDKH = value; }
        public string Tenkh { get => _tenkh; set => _tenkh = value; }
        public int Trangthai { get => trangthai; set => trangthai = value; }
    }
}
