using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DichVu_DTO
    {
        private int _IDDV;
        private string _tenDV;
        private int _IDLoaiDV;
        private string _tenLoaiDV;
        private SqlMoney _dongiaDV;
        private string _GhiCHu;

        public int IDDV { get => _IDDV; set => _IDDV = value; }
        public string TenDV { get => _tenDV; set => _tenDV = value; }
        public int IDLoaiDV { get => _IDLoaiDV; set => _IDLoaiDV = value; }
        public string TenLoaiDV { get => _tenLoaiDV; set => _tenLoaiDV = value; }
        public SqlMoney DongiaDV { get => _dongiaDV; set => _dongiaDV = value; }
        public string GhiCHu { get => _GhiCHu; set => _GhiCHu = value; }
    }
}
