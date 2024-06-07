using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TrangThai_Phong_DTO
    {
        private int _IDTTPhong;
        private string _TenTTPhong;

        public int IDTTPhong { get => _IDTTPhong; set => _IDTTPhong = value; }
        public string TenTTPhong { get => _TenTTPhong; set => _TenTTPhong = value; }
    }
}
