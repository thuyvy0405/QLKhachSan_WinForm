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
    public class Phong_DAO
    {
        static SqlConnection con;
        public static List<Phong_DTO> LayDSPHong()
        {
            string sTruyVan = "select p.ID_PHONG , p.TENPHONG, lp.TEN_LP , tg.TEN_TANG, tt.TEN_TT" +
                " from PHONG p, LOAIPHONG lp, TANG tg, TRANGTHAI_PHONG tt " +
                "where p.ID_LP = lp.ID_LP and p.ID_TANG= tg.ID_TANG and p.ID_TT = tt.ID_TT";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Phong_DTO> ltsphong = new List<Phong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Phong_DTO p = new Phong_DTO();
                p.IDPhong = int.Parse(dt.Rows[i]["ID_PHONG"].ToString());
                p.TenPhong = dt.Rows[i]["TENPHONG"].ToString();
                p.TenLoaiPhong = dt.Rows[i]["TEN_LP"].ToString();
                p.SoTang = dt.Rows[i]["TEN_TANG"].ToString();
                p.TenTrangThai = dt.Rows[i]["TEN_TT"].ToString();
                ltsphong.Add(p);
            }
            return ltsphong;
        }
        public static List<Phong_DTO> Layphong()
        {
            string sTruyVan = "select * from PHONG";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Phong_DTO> ltsphong = new List<Phong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Phong_DTO p = new Phong_DTO();
                p.IDPhong = int.Parse(dt.Rows[i]["ID_PHONG"].ToString());
                p.TenPhong = dt.Rows[i]["TENPHONG"].ToString();
                p.IDLoaiPhong = int.Parse(dt.Rows[i]["ID_LP"].ToString());
                p.IDTang = int.Parse(dt.Rows[i]["ID_TANG"].ToString());
                p.IDTrangThai = int.Parse(dt.Rows[i]["ID_TT"].ToString());
                ltsphong.Add(p);
            }
            return ltsphong;
        }
         public static List<Tang_DTO> LayDanhSachTang()
        {
            string sTruyVan = "select * from TANG";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Tang_DTO> ltsphong = new List<Tang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Tang_DTO p = new Tang_DTO();
                p.IDtang = int.Parse(dt.Rows[i]["ID_TANG"].ToString());
                p.TenTang = dt.Rows[i]["TEN_TANG"].ToString();
                ltsphong.Add(p);
            }
            return ltsphong;
        }
        public static bool add(Phong_DTO p)
        {
            string sTruyVan = string.Format(@"insert into PHONG values(N'{0}',{1},{2},{3})",
               p.TenPhong, p.IDTrangThai, p.IDTang, p.IDLoaiPhong);
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            KetNoi.Dongketnoi();
            return kq;

        }
        public static bool update(Phong_DTO p)
        {
            string sTruyVan = "update PHONG set TENPHONG =N'" + p.TenPhong +
                    "',ID_TT = " + p.IDTrangThai + ", ID_TANG = " + p.IDTang + ", ID_LP= " + p.IDLoaiPhong +
                    " where ID_PHONG = " + p.IDPhong + "";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static bool updateTrangThai_Dat(Phong_DTO p)
        {
            string sTruyVan = "update PHONG set ID_TT = 5 where ID_PHONG = " + p.IDPhong + "";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static bool updateTrangThai_Thue(Phong_DTO p)
        {
            string sTruyVan = "update PHONG set ID_TT = 4 where ID_PHONG = " + p.IDPhong + "";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static bool updateTrangThai_phong(Phong_DTO p, int trangthai)
        {
            string sTruyVan = "update PHONG set ID_TT = "+trangthai+" where ID_PHONG = " + p.IDPhong + "";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static bool Delete(Phong_DTO p)
        {
            string sTruyVan = " delete PHONG where ID_PHONG = '" + p.IDPhong + "'";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static List<Phong_DTO> TimPhongtheoMaP(string ma)
        {
            string sTruyVan = string.Format(@"select p.ID_PHONG , p.TENPHONG, lp.TEN_LP , tg.TEN_TANG, tt.TEN_TT 
                 from PHONG p, LOAIPHONG lp, TANG tg, TRANGTHAI_PHONG tt  where p.ID_LP = lp.ID_LP and p.ID_TANG= tg.ID_TANG and p.ID_TT = tt.ID_TT and p.ID_PHONG='{0}'", ma);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Phong_DTO> ltskhachhang = new List<Phong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Phong_DTO p = new Phong_DTO();
                p.IDPhong = int.Parse(dt.Rows[i]["ID_PHONG"].ToString());
                p.TenPhong = dt.Rows[i]["TENPHONG"].ToString();
                p.TenLoaiPhong = dt.Rows[i]["TEN_LP"].ToString();
                p.SoTang = dt.Rows[i]["TEN_TANG"].ToString();
                p.TenTrangThai = dt.Rows[i]["TEN_TT"].ToString();
                ltskhachhang.Add(p);
            }
            return ltskhachhang;
        }
        public static List<Phong_DTO> TimPhongtheoTenPhong(string ten)
        {
            string sTruyVan = string.Format(@"select p.ID_PHONG , p.TENPHONG, lp.TEN_LP , tg.TEN_TANG, tt.TEN_TT 
                 from PHONG p, LOAIPHONG lp, TANG tg, TRANGTHAI_PHONG tt  where p.ID_LP = lp.ID_LP and p.ID_TANG= tg.ID_TANG and p.ID_TT = tt.ID_TT and p.TENPHONG='{1}'", ten);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Phong_DTO> ltsphong = new List<Phong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Phong_DTO p = new Phong_DTO();
                p.IDPhong = int.Parse(dt.Rows[i]["ID_PHONG"].ToString());
                p.TenPhong = dt.Rows[i]["TENPHONG"].ToString();
                p.TenLoaiPhong = dt.Rows[i]["TEN_LP"].ToString();
                p.SoTang = dt.Rows[i]["TEN_TANG"].ToString();
                p.TenTrangThai = dt.Rows[i]["TEN_TT"].ToString();
                ltsphong.Add(p);
            }
            return ltsphong;
        }

        public static List<Phong_DTO> TimPhongtheoLoaiphong(string tenloai)
        {
            string sTruyVan = string.Format(@"select p.ID_PHONG , p.TENPHONG, lp.TEN_LP , tg.TEN_TANG, tt.TEN_TT 
                 from PHONG p, LOAIPHONG lp, TANG tg, TRANGTHAI_PHONG tt  where p.ID_LP = lp.ID_LP and p.ID_TANG= tg.ID_TANG and p.ID_TT = tt.ID_TT and lp.TEN_LP ='{2}'", tenloai);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Phong_DTO> ltsphong = new List<Phong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Phong_DTO p = new Phong_DTO();
                p.IDPhong = int.Parse(dt.Rows[i]["ID_PHONG"].ToString());
                p.TenPhong = dt.Rows[i]["TENPHONG"].ToString();
                p.TenLoaiPhong = dt.Rows[i]["TEN_LP"].ToString();
                p.SoTang = dt.Rows[i]["TEN_TANG"].ToString();
                p.TenTrangThai = dt.Rows[i]["TEN_TT"].ToString();
                ltsphong.Add(p);
            }
            return ltsphong;
        }
        public static List<Phong_DTO> TimPhongtheoTang(string tang)
        {
            string sTruyVan = string.Format(@"select p.ID_PHONG , p.TENPHONG, lp.TEN_LP , tg.TEN_TANG, tt.TEN_TT 
                 from PHONG p, LOAIPHONG lp, TANG tg, TRANGTHAI_PHONG tt  where p.ID_LP = lp.ID_LP and p.ID_TANG= tg.ID_TANG and p.ID_TT = tt.ID_TT and tg.TEN_TANG ='{3}'", tang);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Phong_DTO> ltsphong = new List<Phong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Phong_DTO p = new Phong_DTO();
                p.IDPhong = int.Parse(dt.Rows[i]["ID_PHONG"].ToString());
                p.TenPhong = dt.Rows[i]["TENPHONG"].ToString();
                p.TenLoaiPhong = dt.Rows[i]["TEN_LP"].ToString();
                p.SoTang = dt.Rows[i]["TEN_TANG"].ToString();
                p.TenTrangThai = dt.Rows[i]["TEN_TT"].ToString();
                ltsphong.Add(p);
            }
            return ltsphong;
        }
        public static List<Phong_DTO> TimPhongtheoTrangThai(string TT)
        {
            string sTruyVan = string.Format(@"select p.ID_PHONG , p.TENPHONG, lp.TEN_LP , tg.TEN_TANG, tt.TEN_TT 
                 from PHONG p, LOAIPHONG lp, TANG tg, TRANGTHAI_PHONG tt  where p.ID_LP = lp.ID_LP and p.ID_TANG= tg.ID_TANG and p.ID_TT = tt.ID_TT and tt.TEN_TT  ='{4}'", TT);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Phong_DTO> ltsphong = new List<Phong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Phong_DTO p = new Phong_DTO();
                p.IDPhong = int.Parse(dt.Rows[i]["ID_PHONG"].ToString());
                p.TenPhong = dt.Rows[i]["TENPHONG"].ToString();
                p.TenLoaiPhong = dt.Rows[i]["TEN_LP"].ToString();
                p.SoTang = dt.Rows[i]["TEN_TANG"].ToString();
                p.TenTrangThai = dt.Rows[i]["TEN_TT"].ToString();
                ltsphong.Add(p);
            }
            return ltsphong;
        }
        public static Phong_DTO TimPhongtheoID(string ma)
        {
            string sTruyVan = "select p.ID_PHONG , p.TENPHONG, lp.TEN_LP , tg.TEN_TANG, tt.TEN_TT  from PHONG p, LOAIPHONG lp, TANG tg, TRANGTHAI_PHONG tt  where p.ID_LP = lp.ID_LP and p.ID_TANG= tg.ID_TANG and p.ID_TT = tt.ID_TT and ID_PHONG='" + ma + "'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            Phong_DTO p = new Phong_DTO();
            p.IDPhong = int.Parse(dt.Rows[0]["ID_PHONG"].ToString());
            p.TenPhong = dt.Rows[0]["TENPHONG"].ToString();
            p.TenLoaiPhong = dt.Rows[0]["TEN_LP"].ToString();
            p.SoTang = dt.Rows[0]["TEN_TANG"].ToString();
            p.TenTrangThai = dt.Rows[0]["TEN_TT"].ToString();
            return p;
        }
        public static Phong_DTO TimPhongtheoTen(string tenphong)
        {
            string sTruyVan = "select * from PHONG where TENPHONG = N'" + tenphong + "'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            Phong_DTO p = new Phong_DTO();
            p.IDPhong = int.Parse(dt.Rows[0]["ID_PHONG"].ToString());
            p.TenPhong = dt.Rows[0]["TENPHONG"].ToString();
            p.IDLoaiPhong = int.Parse(dt.Rows[0]["ID_LP"].ToString());
            return p;
        }
        public static List<Phong_DTO> LayDSPHongAll()
        {
            string sTruyVan = "select * from phong p, loaiphong lp, tang t, TRANGTHAI_PHONG ttp where p.id_lp = lp.id_lp and p.id_tang = t.id_tang and ttp.ID_TT = p.ID_TT";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Phong_DTO> ltsphong = new List<Phong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Phong_DTO p = new Phong_DTO();
                p.IDPhong = int.Parse(dt.Rows[i]["ID_PHONG"].ToString());
                p.TenPhong = dt.Rows[i]["TENPHONG"].ToString();
                p.IDTrangThai = int.Parse(dt.Rows[i]["ID_TT"].ToString());
                p.IDTang = int.Parse(dt.Rows[i]["ID_TANG"].ToString());
                p.IDLoaiPhong =int.Parse(dt.Rows[i]["ID_LP"].ToString());
                p.DongiaPhong1 = Double.Parse(dt.Rows[i]["DONGIA_LP"].ToString());
                p.DongiaGio1 = double.Parse(dt.Rows[i]["DONGIA_TIME_LP"].ToString());
                p.TenLoaiPhong = dt.Rows[i]["TEN_LP"].ToString();
                p.SoTang = dt.Rows[i]["TEN_TANG"].ToString();
                p.TenTrangThai = dt.Rows[i]["TEN_TT"].ToString();
                ltsphong.Add(p);
            }
            KetNoi.Dongketnoi();
            return ltsphong;
        }
        public static List<Phong_DTO> LayDSPHongAll_TheoDieuKien(int id_loaiphong, int id_trangthai)
        {
            string sTruyVan = "select * from phong p, loaiphong lp, tang t, TRANGTHAI_PHONG ttp where p.id_lp = lp.ID_LP and p.id_tang = t.id_tang  and p.ID_TT = ttp.ID_TT and p.ID_LP = " + id_loaiphong+" and p.ID_TT ="+id_trangthai+"";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Phong_DTO> ltsphong = new List<Phong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Phong_DTO p = new Phong_DTO();
                p.IDPhong = int.Parse(dt.Rows[i]["ID_PHONG"].ToString());
                p.TenPhong = dt.Rows[i]["TENPHONG"].ToString();
                p.IDTrangThai = int.Parse(dt.Rows[i]["ID_TT"].ToString());
                p.IDTang = int.Parse(dt.Rows[i]["ID_TANG"].ToString());
                p.IDLoaiPhong = int.Parse(dt.Rows[i]["ID_LP"].ToString());
                p.DongiaPhong1 = Double.Parse(dt.Rows[i]["DONGIA_LP"].ToString());
                p.DongiaGio1 = double.Parse(dt.Rows[i]["DONGIA_TIME_LP"].ToString());
                p.TenLoaiPhong = dt.Rows[i]["TEN_LP"].ToString();
                p.SoTang = dt.Rows[i]["TEN_TANG"].ToString();
                p.TenTrangThai = dt.Rows[i]["TEN_TT"].ToString();
                ltsphong.Add(p);
            }
            KetNoi.Dongketnoi();
            return ltsphong;
        }
        public static List<Phong_DTO> LayDSPHongAll_TheoTen (string tenphong)
        {
            string sTruyVan = "select * from phong p, loaiphong lp, tang t, TRANGTHAI_PHONG ttp where p.id_lp = lp.id_lp and p.id_tang = t.id_tang and ttp.ID_TT = p.ID_TT and p.TENPHONG like N'%"+tenphong+"%'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Phong_DTO> ltsphong = new List<Phong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Phong_DTO p = new Phong_DTO();
                p.IDPhong = int.Parse(dt.Rows[i]["ID_PHONG"].ToString());
                p.TenPhong = dt.Rows[i]["TENPHONG"].ToString();
                p.IDTrangThai = int.Parse(dt.Rows[i]["ID_TT"].ToString());
                p.IDTang = int.Parse(dt.Rows[i]["ID_TANG"].ToString());
                p.IDLoaiPhong = int.Parse(dt.Rows[i]["ID_LP"].ToString());
                p.DongiaPhong1 = Double.Parse(dt.Rows[i]["DONGIA_LP"].ToString());
                p.DongiaGio1 = double.Parse(dt.Rows[i]["DONGIA_TIME_LP"].ToString());
                p.TenLoaiPhong = dt.Rows[i]["TEN_LP"].ToString();
                p.SoTang = dt.Rows[i]["TEN_TANG"].ToString();
                p.TenTrangThai = dt.Rows[i]["TEN_TT"].ToString();
                ltsphong.Add(p);
            }
            return ltsphong;
        }


        public static List<Phong_DTO> LayDSPHongAll_ChuyenPhong()
        {
            string sTruyVan = "select * from phong p, loaiphong lp, tang t , TRANGTHAI_PHONG TTP where p.id_lp = lp.id_lp and p.id_tang = t.id_tang and p.id_tt = TTP.ID_TT and p.id_tt=1";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Phong_DTO> ltsphong = new List<Phong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Phong_DTO p = new Phong_DTO();
                p.IDPhong = int.Parse(dt.Rows[i]["ID_PHONG"].ToString());
                p.TenPhong = dt.Rows[i]["TENPHONG"].ToString();
                p.IDTrangThai = int.Parse(dt.Rows[i]["ID_TT"].ToString());
                p.IDTang = int.Parse(dt.Rows[i]["ID_TANG"].ToString());
                p.IDLoaiPhong = int.Parse(dt.Rows[i]["ID_LP"].ToString());
                p.DongiaPhong1 = Double.Parse(dt.Rows[i]["DONGIA_LP"].ToString());
                p.DongiaGio1 = double.Parse(dt.Rows[i]["DONGIA_TIME_LP"].ToString());
                p.TenLoaiPhong = dt.Rows[i]["TEN_LP"].ToString();
                p.SoTang = dt.Rows[i]["TEN_TANG"].ToString();
                p.TenTrangThai = dt.Rows[i]["TEN_TT"].ToString();
                ltsphong.Add(p);
            }
            return ltsphong;
        }
        public static List<Phong_DTO> TimDSPHongtheoIDLoaiphong(string tenloai)
        {
            string sTruyVan = "select p.* from PHONG p , LOAIPHONG lp where p.ID_LP = lp.ID_LP and lp.TEN_LP ='" + tenloai+"'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Phong_DTO> ltsphong = new List<Phong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Phong_DTO p = new Phong_DTO();
                p.IDPhong = int.Parse(dt.Rows[i]["ID_PHONG"].ToString());
                p.TenPhong = dt.Rows[i]["TENPHONG"].ToString();
                p.IDTrangThai = int.Parse(dt.Rows[i]["ID_TT"].ToString());
                p.IDTang = int.Parse(dt.Rows[i]["ID_TANG"].ToString());
                p.IDLoaiPhong = int.Parse(dt.Rows[i]["ID_LP"].ToString());
                p.DongiaPhong1 = Double.Parse(dt.Rows[i]["DONGIA_LP"].ToString());
                p.TenLoaiPhong = dt.Rows[i]["TEN_LP"].ToString();
                ltsphong.Add(p);
            }
            return ltsphong;
        }
        public static List<Phong_DTO> TimDSPHongtheotentrangthai(string tentrangthai)
        {
            string sTruyVan = "select p.* from PHONG p , TRANGTHAI_PHONG tt where p.ID_TT = tt.ID_TT and tt.TEN_TT like '" + tentrangthai + "'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Phong_DTO> ltsphong = new List<Phong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Phong_DTO p = new Phong_DTO();
                p.IDPhong = int.Parse(dt.Rows[i]["ID_PHONG"].ToString());
                p.TenPhong = dt.Rows[i]["TENPHONG"].ToString();
                p.IDTrangThai = int.Parse(dt.Rows[i]["ID_TT"].ToString());
                p.IDTang = int.Parse(dt.Rows[i]["ID_TANG"].ToString());
                p.IDLoaiPhong = int.Parse(dt.Rows[i]["ID_LP"].ToString());
                p.DongiaPhong1 = Double.Parse(dt.Rows[i]["DONGIA_LP"].ToString()); 
                p.TenLoaiPhong = dt.Rows[i]["TEN_LP"].ToString();
                ltsphong.Add(p);
            }
            return ltsphong;
        }
        public static List<TrangThai_Phong_DTO> LayDanhSachTrangThai()
        {
            string sTruyVan = "select * from TRANGTHAI_PHONG where ID_TT not like '4' and ID_TT not like '5'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TrangThai_Phong_DTO> ltsphong = new List<TrangThai_Phong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TrangThai_Phong_DTO p = new TrangThai_Phong_DTO();
                p.IDTTPhong = int.Parse(dt.Rows[i]["ID_TT"].ToString());
                p.TenTTPhong = dt.Rows[i]["TEN_TT"].ToString();
                ltsphong.Add(p);
            }
            return ltsphong;
        }
    }
}
