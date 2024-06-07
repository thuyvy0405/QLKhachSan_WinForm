using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTiet_HD_DTO
    {
        private int _IDDP;
        private int ID_PHONG;
        private int _IDDV;
        private DateTime _NgaySD_DV;
        private int Soluong_CT;
        private float Dongia_CT;
        private string _tenPhong;
        private DateTime _ngaydat;
        private DateTime _ngaytra;
        private float _Thanhtien_Phong;
        private float _thanhtien_CT;
        private int _IDHD;
        private string _tenDV;



        public int IDDV { get => _IDDV; set => _IDDV = value; }
        public DateTime NgaySD_DV { get => _NgaySD_DV; set => _NgaySD_DV = value; }
        public int Soluong_CT1 { get => Soluong_CT; set => Soluong_CT = value; }
        public float Dongia_CT1 { get => Dongia_CT; set => Dongia_CT = value; }
        public string TenPhong { get => _tenPhong; set => _tenPhong = value; }
        public DateTime Ngaydat { get => _ngaydat; set => _ngaydat = value; }
        public DateTime Ngaytra { get => _ngaytra; set => _ngaytra = value; }
        public int IDDP { get => _IDDP; set => _IDDP = value; }
        public int ID_PHONG1 { get => ID_PHONG; set => ID_PHONG = value; }
        public float Thanhtien_Phong { get => _Thanhtien_Phong; set => _Thanhtien_Phong = value; }
        public float Thanhtien_CT { get => _thanhtien_CT; set => _thanhtien_CT = value; }
        public int IDHD { get => _IDHD; set => _IDHD = value; }
        public string TenDV { get => _tenDV; set => _tenDV = value; }
    }
}
