using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Loai_DichVu_DTO
    {
        private int _IDLDV;
        private string _tenLoaiDV;

        public int IDLDV { get => _IDLDV; set => _IDLDV = value; }
        public string TenLoaiDV { get => _tenLoaiDV; set => _tenLoaiDV = value; }
    }
}
