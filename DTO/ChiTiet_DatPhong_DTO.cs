using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DTO
{
    public class ChiTiet_DatPhong_DTO
    {
        private int _IDDatPhong;
        private int _IDPhong;
        private DateTime _ngaydat;
        private DateTime _ngaytra;
        private string _TenPhong;
        private int _IDLP;
        private string _tenLoaiP;
        private double _thanhtien;
        public string TenPhong { get; set; }
        public int IDPhong { get; set; }

        public int IDDatPhong { get => _IDDatPhong; set => _IDDatPhong = value; }
       // public int IDPhong { get => _IDPhong; set => _IDPhong = value; }
        public DateTime Ngaydat { get => _ngaydat; set => _ngaydat = value; }
        public DateTime Ngaytra { get => _ngaytra; set => _ngaytra = value; }
       // public string TenPhong { get => _TenPhong; set => _TenPhong = value; }
        public int IDLP { get => _IDLP; set => _IDLP = value; }
        public string TenLoaiP { get => _tenLoaiP; set => _tenLoaiP = value; }
        public double Thanhtien { get => _thanhtien; set => _thanhtien = value; }
    }
}
