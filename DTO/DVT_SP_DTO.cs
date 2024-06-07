using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DVT_SP_DTO
    {
        private int _IDDVT;
        private string _tenDVT;

        public int IDDVT { get => _IDDVT; set => _IDDVT = value; }
        public string TenDVT { get => _tenDVT; set => _tenDVT = value; }
    }
}
