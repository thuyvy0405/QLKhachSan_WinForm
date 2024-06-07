using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanQuyen_DTO
    {
        private int _IDPhanQuyen;
        private string _tenQuyen;
        private string _GhiCHu_PQ;

        public int IDPhanQuyen { get => _IDPhanQuyen; set => _IDPhanQuyen = value; }
        public string TenQuyen { get => _tenQuyen; set => _tenQuyen = value; }
        public string GhiCHu_PQ { get => _GhiCHu_PQ; set => _GhiCHu_PQ = value; }
    }
}
