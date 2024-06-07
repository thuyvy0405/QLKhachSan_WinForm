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
    public class LoaiPhong_DAO
    {
        static SqlConnection con;
        public static List<Loai_Phong_DTO> LayDSLoaiPhong()
        {
            string sTruyVan = "select * from LOAIPHONG";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Loai_Phong_DTO> ltsLoaiphong = new List<Loai_Phong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Loai_Phong_DTO lp = new Loai_Phong_DTO();
                lp.IDLoaiP = int.Parse(dt.Rows[i]["ID_LP"].ToString());
                lp.TenLoaiP = dt.Rows[i]["TEN_LP"].ToString();
                lp.DongiaLP_ngay =float.Parse( dt.Rows[i]["DONGIA_LP"].ToString());
                lp.Dongia_Time_LP = float.Parse(dt.Rows[i]["DONGIA_TIME_LP"].ToString());
                lp.SoGiuong =int.Parse( dt.Rows[i]["SOGIUONG"].ToString());
                lp.SoNguoi = int.Parse(dt.Rows[i]["SONGUOI"].ToString());
                ltsLoaiphong.Add(lp);
            }
            return ltsLoaiphong;
        }
        public static bool add(Loai_Phong_DTO lp)
        {
            string sTruyVan = string.Format(@"insert into LOAIPHONG values(N'{0}',{1},{2},{3},{4})",
             lp.TenLoaiP, lp.DongiaLP_ngay, lp.SoNguoi, lp.SoGiuong, lp.Dongia_Time_LP);
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            KetNoi.Dongketnoi();
            return kq;

        }
        public static bool update(Loai_Phong_DTO p)
        {
            string sTruyVan = "update LOAIPHONG set TEN_LP = N'" + p.TenLoaiP +
                    "',DONGIA_LP = " + p.DongiaLP_ngay + ", DONGIA_TIME_LP = " + p.Dongia_Time_LP + ", SOGIUONG= " + p.SoGiuong + ", SONGUOI= " + p.SoNguoi +
                    " where ID_LP = '" + p.IDLoaiP + "'";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static bool Delete(Loai_Phong_DTO p)
        {
            string sTruyVan = " delete LOAIPHONG where ID_LP = '" + p.IDLoaiP + "'";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static List<Loai_Phong_DTO> TimLoaiPhongtheoMaLP(int ma)
        {
            string sTruyVan = string.Format(@"select * from LOAIPHONG where ID_LP='{0}'", ma);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Loai_Phong_DTO> ltsLoaiphong = new List<Loai_Phong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Loai_Phong_DTO lp = new Loai_Phong_DTO();
                lp.IDLoaiP = int.Parse(dt.Rows[i]["ID_LP"].ToString());
                lp.TenLoaiP = dt.Rows[i]["TEN_LP"].ToString();
                lp.DongiaLP_ngay = float.Parse(dt.Rows[i]["DONGIA_LP"].ToString());
                lp.Dongia_Time_LP = float.Parse(dt.Rows[i]["DONGIA_TIME_LP"].ToString());
                lp.SoGiuong = int.Parse(dt.Rows[i]["SOGIUONG"].ToString());
                lp.SoNguoi = int.Parse(dt.Rows[i]["SONGUOI"].ToString());
                ltsLoaiphong.Add(lp);
            }
            return ltsLoaiphong;
        }
        public static List<Loai_Phong_DTO> TimLoaiPhongtheoTenLoai(string ten)
        {
            string sTruyVan = string.Format(@"select * from LOAIPHONG where TEN_LP =N'{0}'", ten);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Loai_Phong_DTO> ltsLoaiphong = new List<Loai_Phong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Loai_Phong_DTO lp = new Loai_Phong_DTO();
                lp.IDLoaiP = int.Parse(dt.Rows[i]["ID_LP"].ToString());
                lp.TenLoaiP = dt.Rows[i]["TEN_LP"].ToString();
                lp.DongiaLP_ngay = float.Parse(dt.Rows[i]["DONGIA_LP"].ToString());
                lp.Dongia_Time_LP = float.Parse(dt.Rows[i]["DONGIA_TIME_LP"].ToString());
                lp.SoGiuong = int.Parse(dt.Rows[i]["SOGIUONG"].ToString());
                lp.SoNguoi = int.Parse(dt.Rows[i]["SONGUOI"].ToString());
                ltsLoaiphong.Add(lp);
            }
            return ltsLoaiphong;
        }
        public static Loai_Phong_DTO TimLoai_PhongtheoTenLoai(string ten)
        {
            string sTruyVan = "select * from LOAIPHONG where TEN_LP= N'"+ten+"'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
                Loai_Phong_DTO lp = new Loai_Phong_DTO();
                lp.IDLoaiP = int.Parse(dt.Rows[0]["ID_LP"].ToString());
                lp.TenLoaiP = dt.Rows[0]["TEN_LP"].ToString();
                lp.DongiaLP_ngay = float.Parse(dt.Rows[0]["DONGIA_LP"].ToString());
                lp.Dongia_Time_LP = float.Parse(dt.Rows[0]["DONGIA_TIME_LP"].ToString());
                lp.SoGiuong = int.Parse(dt.Rows[0]["SOGIUONG"].ToString());
                lp.SoNguoi = int.Parse(dt.Rows[0]["SONGUOI"].ToString());
            
            return lp;
        }
        public static Loai_Phong_DTO Lay_DonGia(string id_loai)
        {
            string sTruyVan = "select * from LOAIPHONG where ID_LP='"+id_loai+"'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
                Loai_Phong_DTO lp = new Loai_Phong_DTO();
                lp.IDLoaiP = int.Parse(dt.Rows[0]["ID_LP"].ToString());
                lp.TenLoaiP = dt.Rows[0]["TEN_LP"].ToString();
                lp.DongiaLP_ngay = float.Parse(dt.Rows[0]["DONGIA_LP"].ToString());
                lp.Dongia_Time_LP = float.Parse(dt.Rows[0]["DONGIA_TIME_LP"].ToString());
                lp.SoGiuong = int.Parse(dt.Rows[0]["SOGIUONG"].ToString());
                lp.SoNguoi = int.Parse(dt.Rows[0]["SONGUOI"].ToString());

            
            return lp;
        }


    }
}
