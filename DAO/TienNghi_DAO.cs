using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TienNghi_DAO
    {
        static SqlConnection con;
        public static List<TienNghi_DTO> LayDSTienNghi()
        {
            string sTruyVan = "select * from TIENNGHI";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TienNghi_DTO> ltsDSTiennghi = new List<TienNghi_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TienNghi_DTO tn = new TienNghi_DTO();
                tn.IDTN= int.Parse(dt.Rows[i]["ID_TN"].ToString());
                tn.TenTN= dt.Rows[i]["TEN_TN"].ToString();
                tn.Dongia=double.Parse( dt.Rows[i]["DONGIA_TN"].ToString());
                ltsDSTiennghi.Add(tn);
            }
            return ltsDSTiennghi;
        }

        public static bool add(TienNghi_DTO tn)
        {
            string sTruyVan = string.Format(@"insert into TIENNGHI values(N'{0}',{1})",
               tn.TenTN ,tn.Dongia);
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            KetNoi.Dongketnoi();
            return kq;

        }
        public static bool update(TienNghi_DTO tn)
        {
            string sTruyVan = "update TIENNGHI set TEN_TN =N'" + tn.TenTN + "', DONGIA_TN = " +tn.Dongia + " where ID_TN = " + tn.IDTN + "";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static bool Delete(TienNghi_DTO tn)
        {
            string sTruyVan = " delete TIENNGHI where ID_TN = '" + tn.IDTN + "'";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static List<TienNghi_DTO> TimTNTheoMa(string ma)
        {
            string sTruyVan = "select * from TIENNGHI where ID_TN   ='"+ma+"'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TienNghi_DTO> ltsDSTiennghi = new List<TienNghi_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TienNghi_DTO tn = new TienNghi_DTO();
                tn.IDTN = int.Parse(dt.Rows[i]["ID_TN"].ToString());
                tn.TenTN = dt.Rows[i]["TEN_TN"].ToString();
                tn.Dongia = double.Parse(dt.Rows[i]["DONGIA_TN"].ToString());
                ltsDSTiennghi.Add(tn);
            }
            return ltsDSTiennghi;
        }
        public static List<TienNghi_DTO> TimTNTheoTen(string ten)
        {
            string sTruyVan = "select * from TIENNGHI  where TEN_TN   like N'%"+ten+"%'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TienNghi_DTO> ltsDSTiennghi = new List<TienNghi_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TienNghi_DTO tn = new TienNghi_DTO();
                tn.IDTN = int.Parse(dt.Rows[i]["ID_TN"].ToString());
                tn.TenTN = dt.Rows[i]["TEN_TN"].ToString();
                tn.Dongia = double.Parse(dt.Rows[i]["DONGIA_TN"].ToString());
                ltsDSTiennghi.Add(tn);
            }
            return ltsDSTiennghi;
        }
    }
}
