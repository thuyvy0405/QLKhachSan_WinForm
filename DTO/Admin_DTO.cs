using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Admin_DTO
    {
        private string _Usename;
        private string _Pass;
        private int _IDQuyen;
        private string _TenQuyen;

        public string Usename { get => _Usename; set => _Usename = value; }
        public string Pass { get => _Pass; set => _Pass = value; }
        public int IDQuyen { get => _IDQuyen; set => _IDQuyen = value; }
        public string TenQuyen { get => _TenQuyen; set => _TenQuyen = value; }
    }
}
