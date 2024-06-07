using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DatPhong_DTO
    {
        private int _IDDatPhong;
        private string _tenDatpPhong;
        private DateTime _NgaylapphieuDP;
        private int _IDKH;
        private string _tenKH;
        private double _thanhtienphong;
        private int _id_phong;
        private int ID_trangthai;
        private string tranthai;


        public int IDDatPhong { get => _IDDatPhong; set => _IDDatPhong = value; }
        public string TenDatpPhong { get => _tenDatpPhong; set => _tenDatpPhong = value; }
        public DateTime NgaylapphieuDP { get => _NgaylapphieuDP; set => _NgaylapphieuDP = value; }
        public int IDKH { get => _IDKH; set => _IDKH = value; }
        public string TenKH { get => _tenKH; set => _tenKH = value; }
        public double Thanhtienphong { get => _thanhtienphong; set => _thanhtienphong = value; }
        public int Id_phong { get => _id_phong; set => _id_phong = value; }
        public int ID_trangthai1 { get => ID_trangthai; set => ID_trangthai = value; }
        public string Tranthai { get => tranthai; set => tranthai = value; }
    }
}
