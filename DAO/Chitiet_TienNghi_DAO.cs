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
    public class Chitiet_TienNghi_DAO
    {
        static SqlConnection con;
        public static List<Chitiet_TienNghi_DTO> LayChitietTiennghi()
        {
            string sTruyVan = "select p.ID_PHONG,tn.ID_TN, tn.TEN_TN , p.TENPHONG , ct.TIMESD_TN , ct.Soluong_SD, ct.GHICHU_TN from CT_TN ct, TIENNGHI tn, PHONG p where ct.ID_TN = tn.ID_TN and ct.ID_PHONG = p.ID_PHONG";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Chitiet_TienNghi_DTO> ltsCTTN= new List<Chitiet_TienNghi_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Chitiet_TienNghi_DTO ct = new Chitiet_TienNghi_DTO();
                ct.IDPhong = int.Parse(dt.Rows[i]["ID_PHONG"].ToString());
                ct.IDTN =int.Parse( dt.Rows[i]["ID_TN"].ToString());
                ct.TenTN= dt.Rows[i]["TEN_TN"].ToString();
                ct.TenPHong= dt.Rows[i]["TENPHONG"].ToString();
                ct.ThgianSuDung=DateTime.Parse(dt.Rows[i]["TIMESD_TN"].ToString());
                ct.SoluongSD = int.Parse(dt.Rows[i]["Soluong_SD"].ToString());
                ct.GhiChu_TN = dt.Rows[i]["GHICHU_TN"].ToString();
                ltsCTTN.Add(ct);
            }
            return ltsCTTN;
        }
        public static bool add(Chitiet_TienNghi_DTO ct)
        {
            string sTruyVan = string.Format(@"insert into CT_TN values({0},{1},N'{2}',N'{3}',{4})",
                ct.IDTN, ct.IDPhong , ct.ThgianSuDung , ct.GhiChu_TN, ct.SoluongSD);
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            KetNoi.Dongketnoi();
            return kq;

        }
        public static bool update(Chitiet_TienNghi_DTO ct)
        {
            string sTruyVan = "update CT_TN set ID_PHONG = "+ct.IDPhong+", Soluong_SD = "+ct.SoluongSD+", GHICHU_TN = N'"+ct.GhiChu_TN+"' where ID_TN = "+ct.IDTN+" and ID_PHONG= "+ct.IDPhong+"";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static bool Delete(Chitiet_TienNghi_DTO ct)
        {
            string sTruyVan = " delete CT_TN where ID_TN = '" + ct.IDTN+ "'";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static List<Chitiet_TienNghi_DTO> TimTNtheoTenTN(string ten)
        {
            string sTruyVan = "select tn.TEN_TN , p.TENPHONG , ct.TIMESD_TN , ct.Soluong_SD, ct.GHICHU_TN from CT_TN ct, TIENNGHI tn, PHONG p where ct.ID_TN = tn.ID_TN and ct.ID_PHONG = p.ID_PHONG and tn.TEN_TN like N'%"+ten+"%'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Chitiet_TienNghi_DTO> ltsCTTN = new List<Chitiet_TienNghi_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Chitiet_TienNghi_DTO ct = new Chitiet_TienNghi_DTO();
                ct.TenTN = dt.Rows[i]["TEN_TN"].ToString();
                ct.TenPHong = dt.Rows[i]["TENPHONG"].ToString();
                ct.ThgianSuDung = DateTime.Parse(dt.Rows[i]["TIMESD_TN"].ToString());
                ct.SoluongSD = int.Parse(dt.Rows[i]["Soluong_SD"].ToString());
                ct.GhiChu_TN = dt.Rows[i]["GHICHU_TN"].ToString();
                ltsCTTN.Add(ct);
            }
            return ltsCTTN;
        }
        public static List<Chitiet_TienNghi_DTO> TimTNtheoTenPhong(string phong)
        {
            string sTruyVan = "select tn.TEN_TN , p.TENPHONG , ct.TIMESD_TN , ct.Soluong_SD, ct.GHICHU_TN from CT_TN ct, TIENNGHI tn, PHONG p where ct.ID_TN = tn.ID_TN and ct.ID_PHONG = p.ID_PHONG and p.TENPHONG like N'%"+phong+"%'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Chitiet_TienNghi_DTO> ltsCTTN = new List<Chitiet_TienNghi_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Chitiet_TienNghi_DTO ct = new Chitiet_TienNghi_DTO();
                ct.TenTN = dt.Rows[i]["TEN_TN"].ToString();
                ct.TenPHong = dt.Rows[i]["TENPHONG"].ToString();
                ct.ThgianSuDung = DateTime.Parse(dt.Rows[i]["TIMESD_TN"].ToString());
                ct.SoluongSD = int.Parse(dt.Rows[i]["Soluong_SD"].ToString());
                ct.GhiChu_TN = dt.Rows[i]["GHICHU_TN"].ToString();
                ltsCTTN.Add(ct);
            }
            return ltsCTTN;
        }
        public static List<Chitiet_TienNghi_DTO> TimTNtheoTHGiANSD(DateTime thoigian)
        {
            string sTruyVan = string.Format(@"select tn.TEN_TN , p.TENPHONG , ct.TIMESD_TN , ct.Soluong_SD, ct.GHICHU_TN +
               from CT_TN ct, TIENNGHI tn, PHONG p where ct.ID_TN = tn.ID_TN and ct.ID_PHONG = p.ID_PHONG and ct.TIMESD_TN ='{2}'", thoigian);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Chitiet_TienNghi_DTO> ltsCTTN = new List<Chitiet_TienNghi_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Chitiet_TienNghi_DTO ct = new Chitiet_TienNghi_DTO();
                ct.TenTN = dt.Rows[i]["TEN_TN"].ToString();
                ct.TenPHong = dt.Rows[i]["TENPHONG"].ToString();
                ct.ThgianSuDung = DateTime.Parse(dt.Rows[i]["TIMESD_TN"].ToString());
                ct.SoluongSD = int.Parse(dt.Rows[i]["Soluong_SD"].ToString());
                ct.GhiChu_TN = dt.Rows[i]["GHICHU_TN"].ToString();
                ltsCTTN.Add(ct);
            }
            return ltsCTTN;
        }
    }
}
