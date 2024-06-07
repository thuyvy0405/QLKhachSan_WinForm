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
    public class ADMIN_DAO
    {
        static SqlConnection con;
        public static List<Admin_DTO> LayADMIN()
        {
            string sTruyVan = "select ad.username ,ad.pass ,  pq.TEN_QUYEN from Adminn ad, PHANQUYEN pq where ad.ID_QUYEN = pq.ID_QUYEN";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Admin_DTO> ltsADMIN = new List<Admin_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Admin_DTO ad = new Admin_DTO();
                ad.Usename= dt.Rows[i]["username"].ToString();
                ad.Pass= dt.Rows[i]["pass"].ToString();
                ad.TenQuyen = dt.Rows[i]["TEN_QUYEN"].ToString();
                ltsADMIN.Add(ad);
            }
            return ltsADMIN;
        }
    }
}
