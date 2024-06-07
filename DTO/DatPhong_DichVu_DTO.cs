using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DatPhong_DichVu_DTO
    {
        private int _IDDP;
        private int ID_PHONG;
        private int _IDDV;
        private DateTime _NgaySD_DV;
        private int _SoluongDV;
        private double _DongiaDV;
        private double _ThanhtienDV;
        private string _TenDV;

        public int IDDP { get => _IDDP; set => _IDDP = value; }
        public int ID_PHONG1 { get => ID_PHONG; set => ID_PHONG = value; }
        public int IDDV { get => _IDDV; set => _IDDV = value; }
        public DateTime NgaySD_DV { get => _NgaySD_DV; set => _NgaySD_DV = value; }
        public int SoluongDV { get => _SoluongDV; set => _SoluongDV = value; }
        public double DongiaDV { get => _DongiaDV; set => _DongiaDV = value; }
        public double ThanhtienDV { get => _ThanhtienDV; set => _ThanhtienDV = value; }
        public string TenDV { get => _TenDV; set => _TenDV = value; }
    }
}
