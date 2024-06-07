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
    public class PhanQuyen_DAO
    {
        static SqlConnection con;
        public static List<PhanQuyen_DTO> LayDSQuyen()
        {
            string sTruyVan = "select * from PHANQUYEN";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<PhanQuyen_DTO> ltsQuyen = new List<PhanQuyen_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhanQuyen_DTO nd = new PhanQuyen_DTO();
                nd.IDPhanQuyen =int.Parse( dt.Rows[i]["ID_QUYEN"].ToString());
                nd.TenQuyen = dt.Rows[i]["TEN_QUYEN"].ToString();
                ltsQuyen.Add(nd);
            }
            return ltsQuyen;
        }
    }
}
