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
    public class NhanVien_DAO
    {
        static SqlConnection con;
        public static List<NhanVien_DTO> LayDSNhanVien()
        {
            string sTruyVan = "select * from NHANVIEN where HOTEN_NV not like N'%ADMIN%'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> ltsNhanVien = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.IDNV =int.Parse( dt.Rows[i]["ID_NV"].ToString());
                nv.TenNV = dt.Rows[i]["HOTEN_NV"].ToString();
                nv.SDTNV = dt.Rows[i]["SDT_NV"].ToString();
                nv.CCCD_NV = dt.Rows[i]["CCCD_NV"].ToString();
                nv.EmailNV = dt.Rows[i]["EMAIL_NV"].ToString();
                nv.DchiNV = dt.Rows[i]["DCHI_NV"].ToString();
                ltsNhanVien.Add(nv);
            }
            return ltsNhanVien;
        }
        public static bool add(NhanVien_DTO nv)
        {
            string sTruyVan = string.Format(@"insert into nhanvien values(N'{0}','{1}','{2}','{3}',N'{4}')",
                nv.TenNV, nv.SDTNV, nv.CCCD_NV, nv.EmailNV, nv.DchiNV);
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            KetNoi.Dongketnoi();
            return kq;

        }
        public static bool update(NhanVien_DTO nv)
        {
            string sTruyVan = "update NHANVIEN set HOTEN_NV = N'" + nv.TenNV +"', SDT_NV = '" + nv.SDTNV + "', EMAIL_NV = '" + nv.EmailNV + "' , DCHI_NV= N'" + nv.DchiNV +"' where ID_NV = '" + nv.IDNV + "'";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static bool Delete(NhanVien_DTO nv)
        {
            string sTruyVan = " delete NHANVIEN where manv = '" + nv.IDNV + "'";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static List<NhanVien_DTO> TimNhanVienTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from nhanvien where ID_NV=N'{0}'", ma);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> ltsNhanVien = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.IDNV = int.Parse(dt.Rows[i]["ID_NV"].ToString());
                nv.TenNV = dt.Rows[i]["HOTEN_NV"].ToString();
                nv.SDTNV = dt.Rows[i]["SDT_NV"].ToString();
                nv.CCCD_NV = dt.Rows[i]["CCCD_NV"].ToString();
                nv.EmailNV = dt.Rows[i]["EMAIL_NV"].ToString();
                nv.DchiNV = dt.Rows[i]["DCHI_NV"].ToString();
                ltsNhanVien.Add(nv);
            }
            return ltsNhanVien;
        }
        public static NhanVien_DTO TimNhanVienTheoMa1(string ma)
        {
            string sTruyVan = string.Format(@"select * from nhanvien where ID_NV=N'{0}'", ma);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.IDNV = int.Parse(dt.Rows[0]["ID_NV"].ToString());
                nv.TenNV = dt.Rows[0]["HOTEN_NV"].ToString();
                nv.SDTNV = dt.Rows[0]["SDT_NV"].ToString();
                nv.CCCD_NV = dt.Rows[0]["CCCD_NV"].ToString();
                nv.EmailNV = dt.Rows[0]["EMAIL_NV"].ToString();
                nv.DchiNV = dt.Rows[0]["DCHI_NV"].ToString();
            return nv;
        }
        public static List<NhanVien_DTO> TimNhanVienTheoTen(string ten)
        {
            string sTruyVan = "select * from NHANVIEN where HOTEN_NV like N'%"+ten+"%'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> ltsNhanVien = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.IDNV = int.Parse(dt.Rows[i]["ID_NV"].ToString());
                nv.TenNV = dt.Rows[i]["HOTEN_NV"].ToString();
                nv.SDTNV = dt.Rows[i]["SDT_NV"].ToString();
                nv.CCCD_NV = dt.Rows[i]["CCCD_NV"].ToString();
                nv.EmailNV = dt.Rows[i]["EMAIL_NV"].ToString();
                nv.DchiNV = dt.Rows[i]["DCHI_NV"].ToString();
                ltsNhanVien.Add(nv);
            }
            return ltsNhanVien;
        }
        public static List<NhanVien_DTO> TimNhanVienTheoCCCD(string cccd)
        {
            string sTruyVan = "select * from NHANVIEN where CCCD_NV like '%" + cccd + "%'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> ltsNhanVien = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.IDNV = int.Parse(dt.Rows[i]["ID_NV"].ToString());
                nv.TenNV = dt.Rows[i]["HOTEN_NV"].ToString();
                nv.SDTNV = dt.Rows[i]["SDT_NV"].ToString();
                nv.CCCD_NV = dt.Rows[i]["CCCD_NV"].ToString();
                nv.EmailNV = dt.Rows[i]["EMAIL_NV"].ToString();
                nv.DchiNV = dt.Rows[i]["DCHI_NV"].ToString();
                ltsNhanVien.Add(nv);
            }
            return ltsNhanVien;
        }
        public static List<NhanVien_DTO> TimNhanVienTheoSDT(string sdt)
        {
            string sTruyVan = "select * from NHANVIEN where SDT_NV like '%" + sdt + "%'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> ltsNhanVien = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.IDNV = int.Parse(dt.Rows[i]["ID_NV"].ToString());
                nv.TenNV = dt.Rows[i]["HOTEN_NV"].ToString();
                nv.SDTNV = dt.Rows[i]["SDT_NV"].ToString();
                nv.CCCD_NV = dt.Rows[i]["CCCD_NV"].ToString();
                nv.EmailNV = dt.Rows[i]["EMAIL_NV"].ToString();
                nv.DchiNV = dt.Rows[i]["DCHI_NV"].ToString();
                ltsNhanVien.Add(nv);
            }
            return ltsNhanVien;
        }
        public static bool CheckCCCD(string cccd)
        {
            using (con)
            {
                string sTruyVan = "SELECT COUNT(*) FROM NHANVIEN WHERE CCCD_NV ='" + cccd + "'";
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
        public static bool CheckSDT(string sdt)
        {
            using (con)
            {
                string sTruyVan = "SELECT COUNT(*) FROM NHANVIEN WHERE SDT_NV ='" + sdt + "'";
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
