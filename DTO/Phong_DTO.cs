using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phong_DTO
    {
        private int _IDPhong;
        private string _tenPhong;
        private int _IDTrangThai;
        private int _IDTang;
        private int _IDLoaiPhong;
        private string _tenTrangThai;
        private string _tenLoaiPhong;
        private string _SoTang;
        private int TongSoPhong;
        private double DongiaPhong;
        private double DongiaGio;

        public int TongSoPhong1 { get => TongSoPhong; set => TongSoPhong = value; }
        public int IDPhong { get => _IDPhong; set => _IDPhong = value; }
        public string TenPhong { get => _tenPhong; set => _tenPhong = value; }
        public int IDTrangThai { get => _IDTrangThai; set => _IDTrangThai = value; }
        public int IDTang { get => _IDTang; set => _IDTang = value; }
        public int IDLoaiPhong { get => _IDLoaiPhong; set => _IDLoaiPhong = value; }
        public string TenTrangThai { get => _tenTrangThai; set => _tenTrangThai = value; }
        public string TenLoaiPhong { get => _tenLoaiPhong; set => _tenLoaiPhong = value; }
        public string SoTang { get => _SoTang; set => _SoTang = value; }
        public double DongiaPhong1 { get => DongiaPhong; set => DongiaPhong = value; }
        public double DongiaGio1 { get => DongiaGio; set => DongiaGio = value; }
    }
}
