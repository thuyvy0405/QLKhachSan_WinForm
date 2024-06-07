using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguoiDung_DTO
    {
        private int _IDNguoiDung;
        private string _USERName;
        private string _Password;
        private int _IDQuyen;
        private string _tenQuyen;
        private int _IDNV;
        private string _tenNV;

        public int IDNguoiDung { get => _IDNguoiDung; set => _IDNguoiDung = value; }
        public string USERName { get => _USERName; set => _USERName = value; }
        public string Password { get => _Password; set => _Password = value; }
        public int IDQuyen { get => _IDQuyen; set => _IDQuyen = value; }
        public string TenQuyen { get => _tenQuyen; set => _tenQuyen = value; }
        public int IDNV { get => _IDNV; set => _IDNV = value; }
        public string TenNV { get => _tenNV; set => _tenNV = value; }
    }
}
