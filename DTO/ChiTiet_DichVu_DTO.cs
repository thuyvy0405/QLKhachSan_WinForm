using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTiet_DichVu_DTO
    {
        private int _STT;
        private int _IDDV;
        private int _IDSP;
        private string _tenDV;
        private string _tenSP;

        public int STT { get => _STT; set => _STT = value; }
        public int IDDV { get => _IDDV; set => _IDDV = value; }
        public int IDSP { get => _IDSP; set => _IDSP = value; }
        public string TenDV { get => _tenDV; set => _tenDV = value; }
        public string TenSP { get => _tenSP; set => _tenSP = value; }
    }
}
