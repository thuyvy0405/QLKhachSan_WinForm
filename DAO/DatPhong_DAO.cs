using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DAO
{
    public class DatPhong_DAO
    {
        static SqlConnection con;
        public static List<Phong_DTO> LayDSPhongTrong()
        {
            string sTruyVan = "select p.TENPHONG, lp.TEN_LP,tg.TEN_TANG from PHONG p, LOAIPHONG lp , TRANGTHAI_PHONG tt , TANG tg where p.ID_LP = lp.ID_LP and p.ID_TANG = tg.ID_TANG and p.ID_TT= tt.ID_TT and tt.TEN_TT = N'Phòng Trống'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Phong_DTO> ltsDSPhongTRONG = new List<Phong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Phong_DTO p = new Phong_DTO();
                p.TenPhong = dt.Rows[i]["TENPHONG"].ToString();
                p.TenLoaiPhong = dt.Rows[i]["TEN_LP"].ToString();
                p.SoTang = dt.Rows[i]["TEN_TANG"].ToString();
                ltsDSPhongTRONG.Add(p);
            }
            return ltsDSPhongTRONG;
        }
        public static List<Phong_DTO> LayDSPhongCHON()
        {
            string sTruyVan = "select p.TENPHONG, lp.TEN_LP,tg.TEN_TANG " +
                "from PHONG p, LOAIPHONG lp , TRANGTHAI_PHONG tt , TANG tg" +
                "where p.ID_LP = lp.ID_LP and p.ID_TANG = tg.ID_TANG and p.ID_TT= tt.ID_TT'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Phong_DTO> ltsDSPhongCHON= new List<Phong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Phong_DTO p = new Phong_DTO();
                p.TenPhong = dt.Rows[i]["TENPHONG"].ToString();
                p.TenLoaiPhong = dt.Rows[i]["TEN_LP"].ToString();
                p.SoTang = dt.Rows[i]["TEN_TANG"].ToString();
                ltsDSPhongCHON.Add(p);
            }
            return ltsDSPhongCHON;
        }
        public static List<DatPhong_DTO> LayDSDatPhong()
        {
            string sTruyVan = "select dp.ID_DATPHONG , kh.HOTEN_KH , dp.NgaylapPhieuDP, tt.Ten_TTDP from DATPHONG dp, KHang kh , TRANGTHAI_DP tt where dp.ID_KH = kh.ID_KH and tt.ID_TTDP = dp.ID_TTDP";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DatPhong_DTO> ltsDSDatPhong = new List<DatPhong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DatPhong_DTO Dp = new DatPhong_DTO();
                Dp.IDDatPhong =int.Parse( dt.Rows[i]["ID_DATPHONG"].ToString());
                Dp.TenKH = dt.Rows[i]["HOTEN_KH"].ToString();
                Dp.NgaylapphieuDP = DateTime.Parse(dt.Rows[i]["NgaylapPhieuDP"].ToString());
                Dp.Tranthai = dt.Rows[i]["Ten_TTDP"].ToString();
                ltsDSDatPhong.Add(Dp);
            }
            return ltsDSDatPhong;
        }
        public static bool add(DatPhong_DTO dp)
        {
            string sTruyVan = string.Format(@"insert into DATPHONG values({0},'{1}',{2})",
                dp.IDKH , dp.NgaylapphieuDP,dp.ID_trangthai1);
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            KetNoi.Dongketnoi();
            return kq;

        }
        public static bool CapNhatTrangthaiDatPhong(DatPhong_DTO dp)
        {
            string sTruyVan = string.Format(@"update datphong set ID_TTDP = 3 where ID_DATPHONG = {0}",
                dp.IDDatPhong);
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            KetNoi.Dongketnoi();
            return kq;

        }
        public static bool CapNhatTrangthaiDatPhong_Dangthue(int IDDatPhong)
        {
            string sTruyVan = string.Format(@"update datphong set ID_TTDP = 2 where ID_DATPHONG = {0}",
                IDDatPhong);
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            KetNoi.Dongketnoi();
            return kq;

        }
        public static bool HuyDatPhong_KH(int dp, int ID_PHONG)
        {
            string sTruyVan = string.Format("delete CT_DATPHONG where ID_DATPHONG = "+dp+" and ID_PHONG = "+ ID_PHONG + "" +
                "UPDATE PHONG SET ID_TT = 1 WHERE ID_PHONG = "+ ID_PHONG + "");
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            KetNoi.Dongketnoi();
            return kq;
        }
        public static bool update(DatPhong_DTO dp)
        {
            string sTruyVan = "update DATPHONG set ID_KH = '" + dp.IDKH+ "', NgaylapPhieuDP = '" +dp.NgaylapphieuDP + "'"+
                    "' where ID_DATPHONG = '" + dp.IDDatPhong + "'";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static bool Delete(DatPhong_DTO dp)
        {
            string sTruyVan = "delete DATPHONG where ID_DATPHONG = '" + dp.IDDatPhong + "'";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static List<DatPhong_DTO> TimPhongtheomaDP(string ma)
        {
            string sTruyVan = "select * from DATPHONG dp, KHang kh where dp.ID_KH = kh.ID_KH and dp.ID_DATPHONG = '"+ma+"'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DatPhong_DTO> ltsDSDatPhong = new List<DatPhong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DatPhong_DTO Dp = new DatPhong_DTO();
                Dp.IDDatPhong = int.Parse(dt.Rows[i]["ID_DATPHONG"].ToString());
                Dp.TenKH = dt.Rows[i]["HOTEN_KH"].ToString();
                Dp.NgaylapphieuDP = DateTime.Parse(dt.Rows[i]["NgaylapPhieuDP"].ToString());
                Dp.Tranthai = dt.Rows[i]["Ten_TTDP"].ToString();
                ltsDSDatPhong.Add(Dp);
            }
            return ltsDSDatPhong;
        }


        public static List<DatPhong_DTO> TimPhongtheoTenKH(string ten)
        {
            string sTruyVan = "select dp.ID_DATPHONG , kh.HOTEN_KH , dp.NgaylapPhieuDP from DATPHONG dp, KHang kh where dp.ID_KH = kh.ID_KH and kh.HOTEN_KH like N'%"+ten+"%'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DatPhong_DTO> ltsDSDatPhong = new List<DatPhong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DatPhong_DTO Dp = new DatPhong_DTO();
                Dp.IDDatPhong = int.Parse(dt.Rows[i]["ID_DATPHONG"].ToString());
                Dp.TenKH = dt.Rows[i]["HOTEN_KH"].ToString();
                Dp.NgaylapphieuDP = DateTime.Parse(dt.Rows[i]["NgaylapPhieuDP"].ToString());
                ltsDSDatPhong.Add(Dp);
            }
            return ltsDSDatPhong;
        }
        public static List<DatPhong_DTO> TimPhongtheoNgayLap(string ngay)
        {
            string sTruyVan = "select dp.ID_DATPHONG , kh.HOTEN_KH , dp.NgaylapPhieuDP from DATPHONG dp, KHang kh where dp.ID_KH = kh.ID_KH and dp.NgaylapPhieuDP between '" + ngay + " 00:00:00' and  '"+ngay+" 23:59:59'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DatPhong_DTO> ltsDSDatPhong = new List<DatPhong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DatPhong_DTO Dp = new DatPhong_DTO();
                Dp.IDDatPhong = int.Parse(dt.Rows[i]["ID_DATPHONG"].ToString());
                Dp.TenKH = dt.Rows[i]["HOTEN_KH"].ToString();
                Dp.NgaylapphieuDP = DateTime.Parse(dt.Rows[i]["NgaylapPhieuDP"].ToString());
                ltsDSDatPhong.Add(Dp);
            }
            return ltsDSDatPhong;
        }
        public static List<DatPhong_DTO> DemSoLuongPhongDat(int ID_DATPHONG)
        {
            string sTruyVan = "select * from CT_DATPHONG where ID_DATPHONG = "+ID_DATPHONG+"";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DatPhong_DTO> ltsDSDatPhong = new List<DatPhong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DatPhong_DTO Dp = new DatPhong_DTO();
                Dp.IDDatPhong = int.Parse(dt.Rows[i]["ID_DATPHONG"].ToString());
                //Dp.TenKH = dt.Rows[i]["HOTEN_KH"].ToString();
                //Dp.NgaylapphieuDP = DateTime.Parse(dt.Rows[i]["NgaylapPhieuDP"].ToString());
                ltsDSDatPhong.Add(Dp);
            }
            return ltsDSDatPhong;
        }

        public static KhachHang_DTO TimKH_ThuePhong(string ma)
        {
            string sTruyVan = "SELECT top 1 KHang.*, PHONG.ID_PHONG, KHang.ID_KH, PHONG.ID_TT, DATPHONG.ID_DATPHONG, CT_DatPhong.NGAYTRA, CT_DATPHONG.NGAYDAT   FROM   KHang INNER JOIN DATPHONG ON KHang.ID_KH = DATPHONG.ID_KH INNER JOIN CT_DatPhong ON DATPHONG.ID_DATPHONG = CT_DatPhong.ID_DATPHONG INNER JOIN PHONG ON CT_DatPhong.ID_PHONG = PHONG.ID_PHONG WHERE  (PHONG.ID_TT = 4 ) and phong.ID_PHONG = " + ma+" ORDER BY DATPHONG.ID_DATPHONG DESC";

            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
                KhachHang_DTO Dp = new KhachHang_DTO();
                Dp.TenKH = dt.Rows[0]["HOTEN_KH"].ToString();
                Dp.SDT_Kh = dt.Rows[0]["SDT_KH"].ToString();
                Dp.IDKH = int.Parse(dt.Rows[0]["ID_KH"].ToString());
                Dp.Id_datphongphong = int.Parse(dt.Rows[0]["ID_DATPHONG"].ToString());
                Dp.Ngaytraphong = DateTime.Parse(dt.Rows[0]["NGAYTRA"].ToString());
                Dp.Ngaydatphong = DateTime.Parse(dt.Rows[0]["NGAYDAT"].ToString());

            return Dp;
        }
        public static KhachHang_DTO TimKH_DatPhong(string ma)
        {
            string sTruyVan = "SELECT top 1 KHang.*, PHONG.ID_PHONG, KHang.ID_KH, PHONG.ID_TT, DATPHONG.ID_DATPHONG, CT_DatPhong.NGAYTRA, CT_DATPHONG.NGAYDAT , PHONG.ID_PHONG  FROM   KHang INNER JOIN DATPHONG ON KHang.ID_KH = DATPHONG.ID_KH INNER JOIN CT_DatPhong ON DATPHONG.ID_DATPHONG = CT_DatPhong.ID_DATPHONG INNER JOIN PHONG ON CT_DatPhong.ID_PHONG = PHONG.ID_PHONG WHERE  (PHONG.ID_TT = 5 ) and phong.ID_PHONG = " + ma + " ORDER BY DATPHONG.ID_DATPHONG DESC";

            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            KhachHang_DTO Dp = new KhachHang_DTO();
            Dp.TenKH = dt.Rows[0]["HOTEN_KH"].ToString();
            Dp.SDT_Kh = dt.Rows[0]["SDT_KH"].ToString();
            Dp.IDKH = int.Parse(dt.Rows[0]["ID_KH"].ToString());
            Dp.Id_datphongphong = int.Parse(dt.Rows[0]["ID_DATPHONG"].ToString());
            Dp.Ngaytraphong = DateTime.Parse(dt.Rows[0]["NGAYTRA"].ToString());
            Dp.Ngaydatphong = DateTime.Parse(dt.Rows[0]["NGAYDAT"].ToString());
            Dp.Id_phong = int.Parse(dt.Rows[0]["ID_PHONG"].ToString());
            return Dp;
        }
        public static bool ChuyenPhong(int id_datphong, int id_phong,int  id_phongchuyen)
        {
            string sTruyVan = "update CT_DatPhong set ID_PHONG = "+ id_phongchuyen + " where ID_DATPHONG = "+ id_datphong + " and ID_PHONG = "+ id_phong + "";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static DatPhong_DTO LayTrangThaiDatPhong(int id_datphong)
        {
            string sTruyVan = "select dp.*, tt.Ten_TTDP from DATPHONG dp, TRANGTHAI_DP tt WHERE tt.ID_TTDP = dp.ID_TTDP and dp.ID_DATPHONG= " + id_datphong+"";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            DatPhong_DTO Dp = new DatPhong_DTO();
            Dp.IDDatPhong = int.Parse(dt.Rows[0]["ID_DATPHONG"].ToString());
            Dp.NgaylapphieuDP = DateTime.Parse(dt.Rows[0]["NgaylapPhieuDP"].ToString());
            Dp.Tranthai = dt.Rows[0]["Ten_TTDP"].ToString();
            Dp.ID_trangthai1 = int.Parse(dt.Rows[0]["ID_TTDP"].ToString());
            return Dp;
        }
        
    }
}
