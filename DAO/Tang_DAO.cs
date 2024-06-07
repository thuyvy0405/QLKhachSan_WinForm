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
    public class Tang_DAO
    {
        static SqlConnection con;
        public static List<Tang_DTO> LayDSTANG()
        {
            string sTruyVan = "select * from TANG";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Tang_DTO> ltsLoaiphong = new List<Tang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Tang_DTO lp = new Tang_DTO();
                lp.IDtang = int.Parse(dt.Rows[i]["ID_TANG"].ToString());
                lp.TenTang = dt.Rows[i]["TEN_TANG"].ToString();
                ltsLoaiphong.Add(lp);
            }
            return ltsLoaiphong;
        }
        public static bool add(Tang_DTO lp)
        {
            string sTruyVan = string.Format(@"insert into TANG values(N'{0}')",
              lp.TenTang);
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            KetNoi.Dongketnoi();
            return kq;

        }
        public static bool update(Tang_DTO p)
        {
            string sTruyVan = "update TANG set ten_tang =N'" + p.TenTang +"' where ID_TANG = " + p.IDtang + "";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
    }
}
