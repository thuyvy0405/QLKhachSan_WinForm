using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TienNghi_DTO
    {
        private int _IDTN;
        private string _TenTN;
        private double _dongia;

        public int IDTN { get => _IDTN; set => _IDTN = value; }
        public string TenTN { get => _TenTN; set => _TenTN = value; }
        public double Dongia { get => _dongia; set => _dongia = value; }
    }
}
