using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoaiDV_DAO
    {
        static SqlConnection con;
        public static List<Loai_DichVu_DTO> LayDSLoaiDV()
        {
            string sTruyVan = " select * from LOAI_DV";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Loai_DichVu_DTO> ltsLoaiDV = new List<Loai_DichVu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Loai_DichVu_DTO ldv = new Loai_DichVu_DTO();
                ldv.IDLDV = int.Parse(dt.Rows[i]["ID_LDV"].ToString());
                ldv.TenLoaiDV = dt.Rows[i]["TEN_LDV"].ToString();
                ltsLoaiDV.Add(ldv);
            }
            return ltsLoaiDV;
        }
        public static bool add(Loai_DichVu_DTO ldv)
        {
            string sTruyVan = string.Format(@"insert into LOAI_DV values(N'{0}')",ldv.TenLoaiDV);
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            KetNoi.Dongketnoi();
            return kq;

        }
        public static bool update(Loai_DichVu_DTO p)
        {
            string sTruyVan = "update LOAI_DV set TEN_LDV =N'" + p.TenLoaiDV + "' where ID_LDV = " + p.IDLDV + "";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
    }
}
