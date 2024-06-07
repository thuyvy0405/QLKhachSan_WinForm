using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang_DTO
    {
        private int _IDKH;
        private string _tenKH;
        private string _CCCD_KH;
        private string _SDT_Kh;
        private string _Email_KH;
        private string _Dchi_KH;
        private string _phai;
        private DateTime ngaytraphong;
        private DateTime ngaydatphong;
        private int id_phong;
        private int id_datphongphong;
        public int IDKH { get => _IDKH; set => _IDKH = value; }
        public string TenKH { get => _tenKH; set => _tenKH = value; }
        public string CCCD_KH { get => _CCCD_KH; set => _CCCD_KH = value; }
        public string SDT_Kh { get => _SDT_Kh; set => _SDT_Kh = value; }
        public string Email_KH { get => _Email_KH; set => _Email_KH = value; }
        public string Dchi_KH { get => _Dchi_KH; set => _Dchi_KH = value; }
        public string Phai { get => _phai; set => _phai = value; }
        public DateTime Ngaytraphong { get => ngaytraphong; set => ngaytraphong = value; }
        public DateTime Ngaydatphong { get => ngaydatphong; set => ngaydatphong = value; }
        public int Id_phong { get => id_phong; set => id_phong = value; }
        public int Id_datphongphong { get => id_datphongphong; set => id_datphongphong = value; }
    }
}
