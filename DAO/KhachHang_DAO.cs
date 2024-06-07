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
    public class KhachHang_DAO
    {
        static SqlConnection con;
        public static List<KhachHang_DTO> LayDSKhachHang()
        {
            string sTruyVan = "select * from KHang";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> ltskhachhang = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.IDKH= int.Parse(dt.Rows[i]["ID_KH"].ToString());
                kh.TenKH = dt.Rows[i]["HOTEN_KH"].ToString();
                kh.Phai = dt.Rows[i]["phai"].ToString();
                kh.SDT_Kh = dt.Rows[i]["SDT_KH"].ToString();
                kh.CCCD_KH = dt.Rows[i]["CCCD_KH"].ToString();
                kh.Email_KH = dt.Rows[i]["EMAIL"].ToString();
                kh.Dchi_KH = dt.Rows[i]["DCHI_KH"].ToString();
                ltskhachhang.Add(kh);
            }
            return ltskhachhang;
        }
        public static bool add(KhachHang_DTO kh)
        {
            string sTruyVan = "insert into KHang values(N'"+kh.TenKH.Trim().ToUpper()+ "', '"+kh.CCCD_KH+"', '"+kh.SDT_Kh+"', '"+kh.Email_KH+"', N'"+kh.Dchi_KH.Trim().ToUpper()+"', N'"+kh.Phai+"')";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            KetNoi.Dongketnoi();
            return kq;

        }
        public static bool update(KhachHang_DTO kh)
        {
            string sTruyVan = "update KHang set HOTEN_KH =N'" + kh.TenKH +
                    "',phai = N'" + kh.Phai + "', SDT_KH = '" + kh.SDT_Kh + "', EMAIL = '" +kh.Email_KH+ "',DCHI_KH= N'" + kh.Dchi_KH +
                    "' where ID_KH = '" +kh.IDKH+ "'";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static bool Delete(KhachHang_DTO kh)
        {
            string sTruyVan = " delete KHang where ID_KH = '" +kh.IDKH + "'";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static List<KhachHang_DTO> TimKHTheoMaKH(string ma)
        {
            string sTruyVan = string.Format(@"select * from KHang where ID_NV='{0}'", ma);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> ltskhachhang = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.IDKH = int.Parse(dt.Rows[i]["ID_KH"].ToString());
                kh.TenKH = dt.Rows[i]["HOTEN_KH"].ToString();
                kh.Phai = dt.Rows[i]["phai"].ToString();
                kh.SDT_Kh = dt.Rows[i]["SDT_KH"].ToString();
                kh.CCCD_KH = dt.Rows[i]["CCCD_KH"].ToString();
                kh.Email_KH = dt.Rows[i]["EMAIL"].ToString();
                kh.Dchi_KH = dt.Rows[i]["DCHI_KH"].ToString();
                ltskhachhang.Add(kh);
            }
            return ltskhachhang;
        }
        public static List<KhachHang_DTO> TimKhachhangTheoTen(string ten)
        {
            string sTruyVan = "select * from KHang where HOTEN_KH like N'%" + ten + "%'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> ltskhachhang = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.IDKH = int.Parse(dt.Rows[i]["ID_KH"].ToString());
                kh.TenKH = dt.Rows[i]["HOTEN_KH"].ToString();
                kh.Phai = dt.Rows[i]["phai"].ToString();
                kh.SDT_Kh = dt.Rows[i]["SDT_KH"].ToString();
                kh.CCCD_KH = dt.Rows[i]["CCCD_KH"].ToString();
                kh.Email_KH = dt.Rows[i]["EMAIL"].ToString();
                kh.Dchi_KH = dt.Rows[i]["DCHI_KH"].ToString();
                ltskhachhang.Add(kh);
            }
            return ltskhachhang;
        }
        public static List<KhachHang_DTO> TimKHTheoCCCD(string cccd)
        {
            string sTruyVan = "select * from KHang where CCCD_KH like '%" + cccd + "%'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> ltskhachhang = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.IDKH = int.Parse(dt.Rows[i]["ID_KH"].ToString());
                kh.TenKH = dt.Rows[i]["HOTEN_KH"].ToString();
                kh.Phai = dt.Rows[i]["phai"].ToString();
                kh.SDT_Kh = dt.Rows[i]["SDT_KH"].ToString();
                kh.CCCD_KH = dt.Rows[i]["CCCD_KH"].ToString();
                kh.Email_KH = dt.Rows[i]["EMAIL"].ToString();
                kh.Dchi_KH = dt.Rows[i]["DCHI_KH"].ToString();
                ltskhachhang.Add(kh);
            }
            return ltskhachhang;
        }
        public static List<KhachHang_DTO> TimKHTheoSDT(string sdt)
        {
            string sTruyVan = "select * from KHang where SDT_KH like '%" + sdt + "%'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> ltskhachhang = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.IDKH = int.Parse(dt.Rows[i]["ID_KH"].ToString());
                kh.TenKH = dt.Rows[i]["HOTEN_KH"].ToString();
                kh.Phai = dt.Rows[i]["phai"].ToString();
                kh.SDT_Kh = dt.Rows[i]["SDT_KH"].ToString();
                kh.CCCD_KH = dt.Rows[i]["CCCD_KH"].ToString();
                kh.Email_KH = dt.Rows[i]["EMAIL"].ToString();
                kh.Dchi_KH = dt.Rows[i]["DCHI_KH"].ToString();
                ltskhachhang.Add(kh);
            }
            return ltskhachhang;
        }
        public static KhachHang_DTO TimKhachhangTheoMaKH(string ma)
        {
            string sTruyVan = string.Format(@"select * from KHang where ID_NV='{0}'", ma);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.IDKH = int.Parse(dt.Rows[0]["ID_KH"].ToString());
                kh.TenKH = dt.Rows[0]["HOTEN_KH"].ToString();
                kh.Phai = dt.Rows[0]["phai"].ToString();
                kh.SDT_Kh = dt.Rows[0]["SDT_KH"].ToString();
                kh.CCCD_KH = dt.Rows[0]["CCCD_KH"].ToString();
                kh.Email_KH = dt.Rows[0]["EMAIL"].ToString();
                kh.Dchi_KH = dt.Rows[0]["DCHI_KH"].ToString();

            return kh;
        }
        public static KhachHang_DTO TimKhachhangTheoTenKH(string ten)
        {
            string sTruyVan = "select * from KHang where HOTEN_KH like N'%"+ten+"%'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            KhachHang_DTO kh = new KhachHang_DTO();
            kh.IDKH = int.Parse(dt.Rows[0]["ID_KH"].ToString());
            kh.TenKH = dt.Rows[0]["HOTEN_KH"].ToString();
            kh.Phai = dt.Rows[0]["phai"].ToString();
            kh.SDT_Kh = dt.Rows[0]["SDT_KH"].ToString();
            kh.CCCD_KH = dt.Rows[0]["CCCD_KH"].ToString();
            kh.Email_KH = dt.Rows[0]["EMAIL"].ToString();
            kh.Dchi_KH = dt.Rows[0]["DCHI_KH"].ToString();

            return kh;
        }
        public static KhachHang_DTO TimKhachhangTheoCCCD(string CCCD)
        {
            string sTruyVan = "select * from KHang where CCCD_KH = '"+CCCD+"'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            KhachHang_DTO kh = new KhachHang_DTO();
            kh.IDKH = int.Parse(dt.Rows[0]["ID_KH"].ToString());
            kh.TenKH = dt.Rows[0]["HOTEN_KH"].ToString();
            kh.Phai = dt.Rows[0]["phai"].ToString();
            kh.SDT_Kh = dt.Rows[0]["SDT_KH"].ToString();
            kh.CCCD_KH = dt.Rows[0]["CCCD_KH"].ToString();
            kh.Email_KH = dt.Rows[0]["EMAIL"].ToString();
            kh.Dchi_KH = dt.Rows[0]["DCHI_KH"].ToString();

            return kh;
        }
        public static KhachHang_DTO TimKhachhangTheoSDT(string sdt)
        {
            string sTruyVan = "select * from KHang where SDT_KH='"+sdt+"'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            KhachHang_DTO kh = new KhachHang_DTO();
            kh.IDKH = int.Parse(dt.Rows[0]["ID_KH"].ToString());
            kh.TenKH = dt.Rows[0]["HOTEN_KH"].ToString();
            kh.Phai = dt.Rows[0]["phai"].ToString();
            kh.SDT_Kh = dt.Rows[0]["SDT_KH"].ToString();
            kh.CCCD_KH = dt.Rows[0]["CCCD_KH"].ToString();
            kh.Email_KH = dt.Rows[0]["EMAIL"].ToString();
            kh.Dchi_KH = dt.Rows[0]["DCHI_KH"].ToString();

            return kh;
        }
        public static bool CheckSDT(string sdt)
        {
            using (con)
            {
                string sTruyVan = "SELECT COUNT(*) FROM KHang WHERE SDT_KH ='" + sdt + "'";
                using (SqlCommand command = new SqlCommand(sTruyVan, con))
                {
                    KetNoi.MoKetNoi();
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        return false;
                    }
                    return true;

                }
            }
        }
        public static bool CheckCCCD(string cccd)
        {
            using (con)
            {
                string sTruyVan = "SELECT COUNT(*) FROM KHang WHERE CCCD_KH ='" + cccd + "'";
                using (SqlCommand command = new SqlCommand(sTruyVan, con))
                {
                    KetNoi.MoKetNoi();
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        return false;
                    }
                    return true;

                }
            }
        }
    }
}
