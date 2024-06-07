using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Chitiet_TienNghi_DTO
    {
        private int _IDPhong;
        private int _IDTN;
        private DateTime _ThgianSuDung;
        private string _ghiChu_TN;
        private string _tenPHong;
        private string _TenTN;
        private int _soluongSD;

        public int IDPhong { get => _IDPhong; set => _IDPhong = value; }
        public int IDTN { get => _IDTN; set => _IDTN = value; }
        public DateTime ThgianSuDung { get => _ThgianSuDung; set => _ThgianSuDung = value; }
        public string GhiChu_TN { get => _ghiChu_TN; set => _ghiChu_TN = value; }
        public string TenPHong { get => _tenPHong; set => _tenPHong = value; }
        public string TenTN { get => _TenTN; set => _TenTN = value; }
        public int SoluongSD { get => _soluongSD; set => _soluongSD = value; }
    }
}
