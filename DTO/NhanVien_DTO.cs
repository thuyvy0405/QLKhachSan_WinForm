using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private int _IDNV;
        private string _tenNV;
        private string _SDTNV;
        private string _EmailNV;
        private string _DchiNV;
        private string _CCCD_NV;

        public int IDNV { get => _IDNV; set => _IDNV = value; }
        public string TenNV { get => _tenNV; set => _tenNV = value; }
        public string SDTNV { get => _SDTNV; set => _SDTNV = value; }
        public string EmailNV { get => _EmailNV; set => _EmailNV = value; }
        public string DchiNV { get => _DchiNV; set => _DchiNV = value; }
        public string CCCD_NV { get => _CCCD_NV; set => _CCCD_NV = value; }
    }
}
