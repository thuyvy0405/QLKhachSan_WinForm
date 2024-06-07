using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Tang_DTO
    {
        private int _IDtang;
        private string _TenTang;

        public int IDtang { get => _IDtang; set => _IDtang = value; }
        public string TenTang { get => _TenTang; set => _TenTang = value; }
    }
}
