using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Loai_Phong_DTO
    {
        private int _IDLoaiP;
        private string _tenLoaiP;
        private float _dongiaLP_ngay;
        private int _soNguoi;
        private int _soGiuong;
        private float _Dongia_Time_LP;

        public int IDLoaiP { get => _IDLoaiP; set => _IDLoaiP = value; }
        public string TenLoaiP { get => _tenLoaiP; set => _tenLoaiP = value; }
        public float DongiaLP_ngay { get => _dongiaLP_ngay; set => _dongiaLP_ngay = value; }
        public int SoNguoi { get => _soNguoi; set => _soNguoi = value; }
        public int SoGiuong { get => _soGiuong; set => _soGiuong = value; }
        public float Dongia_Time_LP { get => _Dongia_Time_LP; set => _Dongia_Time_LP = value; }
    }
}
