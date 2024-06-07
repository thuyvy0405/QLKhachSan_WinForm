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
    public class ChiTiet_DatPhong_DAO
    {
        static SqlConnection con;
        public static List<ChiTiet_DatPhong_DTO> LayChitietDP()
        {
            string sTruyVan = "select dp.ID_DATPHONG, p.TENPHONG, lp.TEN_LP, ctdp.NGAYDAT , ctdp.NGAYTRA from DATPHONG dp, CT_DatPhong ctdp, PHONG p, LOAIPHONG lp, KHang kh where dp.ID_DATPHONG = ctdp.ID_DATPHONG and ctdp.ID_PHONG = p.ID_PHONG and p.ID_LP = lp.ID_LP ";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChiTiet_DatPhong_DTO> ltschitietDP= new List<ChiTiet_DatPhong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTiet_DatPhong_DTO ctdp = new ChiTiet_DatPhong_DTO();
                ctdp.IDDatPhong = int.Parse(dt.Rows[i]["ID_DATPHONG"].ToString());
                ctdp.TenPhong = dt.Rows[i]["TENPHONG"].ToString();
                ctdp.TenLoaiP = dt.Rows[i]["TEN_LP"].ToString();
                ctdp.Ngaydat =DateTime.Parse( dt.Rows[i]["NGAYDAT"].ToString());
                ctdp.Ngaytra =DateTime.Parse( dt.Rows[i]["NGAYTRA"].ToString());
                ctdp.Thanhtien = double.Parse(dt.Rows[i]["THANHTIEN_PHONG"].ToString());
                ltschitietDP.Add(ctdp);
            }
            return ltschitietDP;
        }
        public static List<ChiTiet_DatPhong_DTO> LayChitietDP_THEOID(int ID_DATPHONG)
        {
            string sTruyVan = "SELECT * FROM CT_DatPhong dp, PHONG p, LOAIPHONG lp WHERE  dp.ID_DATPHONG = "+ID_DATPHONG+"  AND dp.ID_PHONG = p.ID_PHONG and lp.ID_LP = p.ID_LP";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChiTiet_DatPhong_DTO> ltschitietDP = new List<ChiTiet_DatPhong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTiet_DatPhong_DTO ctdp = new ChiTiet_DatPhong_DTO();
                ctdp.IDDatPhong = int.Parse(dt.Rows[i]["ID_DATPHONG"].ToString());
                ctdp.IDPhong = int.Parse(dt.Rows[i]["ID_PHONG"].ToString());
                ctdp.TenPhong = dt.Rows[i]["TENPHONG"].ToString();
                ctdp.TenLoaiP = dt.Rows[i]["TEN_LP"].ToString();
                ctdp.Ngaydat = DateTime.Parse(dt.Rows[i]["NGAYDAT"].ToString());
                ctdp.Ngaytra = DateTime.Parse(dt.Rows[i]["NGAYTRA"].ToString());
                ctdp.Thanhtien = double.Parse(dt.Rows[i]["THANHTIEN_PHONG"].ToString());
                ltschitietDP.Add(ctdp);
            }
            return ltschitietDP;
        }
        public static bool add(ChiTiet_DatPhong_DTO ctdp)
        {
            string sTruyVan = string.Format(@"insert into CT_DatPhong values({0},{1},'{2}','{3}', {4})",
               ctdp.IDDatPhong, ctdp.IDPhong ,ctdp.Ngaydat, ctdp.Ngaytra, ctdp.Thanhtien);
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            KetNoi.Dongketnoi();
            return kq;

        }
        public static bool update(ChiTiet_DatPhong_DTO dp)
        {
            string sTruyVan = "update CT_DatPhong set ID_PHONG = '" + dp.IDPhong + "',NGAYDAT = '" + dp.Ngaydat+ "',NGAYTRA = '" + dp.Ngaytra + "'" +
                    "' where ID_DATPHONG = '" + dp.IDDatPhong+"'";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static bool update_saukhichuyephong(ChiTiet_DatPhong_DTO dp)
        {
            string sTruyVan = "update CT_DatPhong set THANHTIEN_PHONG = "+dp.Thanhtien+" where ID_DATPHONG = "+dp.IDDatPhong+" and ID_PHONG = "+dp.IDPhong+"";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static bool update_thoigiantraphong(ChiTiet_DatPhong_DTO dp)
        {
            string sTruyVan = "update CT_DatPhong set NGAYTRA ='"+dp.Ngaytra+"', THANHTIEN_PHONG = " + dp.Thanhtien + " where ID_DATPHONG = " + dp.IDDatPhong + " and ID_PHONG = " + dp.IDPhong + "";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static bool CapNhat_NhanPhong(ChiTiet_DatPhong_DTO dp)
        {
            string sTruyVan = "update CT_DatPhong set NGAYDAT ='"+dp.Ngaydat+"' , THANHTIEN_PHONG = "+dp.Thanhtien+" where ID_DATPHONG = "+dp.IDDatPhong+ " and ID_PHONG =  "+dp.IDPhong+"";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static bool Delete(ChiTiet_DatPhong_DTO dp)
        {
            string sTruyVan = " delete CT_DatPhong where ID_DATPHONG = '" + dp.IDDatPhong + "'";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static List<ChiTiet_DatPhong_DTO> TimCTDPTheoIDDP(int ma)
        {
            string sTruyVan = string.Format(@"select dp.ID_DATPHONG, p.TENPHONG, lp.TEN_LP, ctdp.NGAYDAT , ctdp.NGAYTRA"" +
                ""from DATPHONG dp, CT_DatPhong ctdp, PHONG p, LOAIPHONG lp, KHang kh"" +
                ""where dp.ID_DATPHONG = ctdp.ID_DATPHONG and ctdp.ID_PHONG = p.ID_PHONG and p.ID_LP = lp.ID_LP and dp.ID_DATPHONG ='{0}'", ma);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChiTiet_DatPhong_DTO> ltschitietDP = new List<ChiTiet_DatPhong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTiet_DatPhong_DTO ctdp = new ChiTiet_DatPhong_DTO();
                ctdp.IDDatPhong = int.Parse(dt.Rows[i]["ID_DATPHONG"].ToString());
                ctdp.TenPhong = dt.Rows[i]["TENPHONG"].ToString();
                ctdp.TenLoaiP = dt.Rows[i]["TEN_LP"].ToString();
                ctdp.Ngaydat = DateTime.Parse(dt.Rows[i]["NGAYDAT"].ToString());
                ctdp.Ngaytra = DateTime.Parse(dt.Rows[i]["NGAYTRA"].ToString());
                ltschitietDP.Add(ctdp);
            }
            return ltschitietDP;
        }
        public static List<ChiTiet_DatPhong_DTO> TimCTDPTheoTenPhong(string tenphong)
        {
            string sTruyVan = string.Format(@"select dp.ID_DATPHONG, p.TENPHONG, lp.TEN_LP, ctdp.NGAYDAT , ctdp.NGAYTRA +
                from DATPHONG dp, CT_DatPhong ctdp, PHONG p, LOAIPHONG lp, KHang kh +
                where dp.ID_DATPHONG = ctdp.ID_DATPHONG and ctdp.ID_PHONG = p.ID_PHONG and p.ID_LP = lp.ID_LP and p.TENPHONG ='{1}'", tenphong);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChiTiet_DatPhong_DTO> ltschitietDP = new List<ChiTiet_DatPhong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTiet_DatPhong_DTO ctdp = new ChiTiet_DatPhong_DTO();
                ctdp.IDDatPhong = int.Parse(dt.Rows[i]["ID_DATPHONG"].ToString());
                ctdp.TenPhong = dt.Rows[i]["TENPHONG"].ToString();
                ctdp.TenLoaiP = dt.Rows[i]["TEN_LP"].ToString();
                ctdp.Ngaydat = DateTime.Parse(dt.Rows[i]["NGAYDAT"].ToString());
                ctdp.Ngaytra = DateTime.Parse(dt.Rows[i]["NGAYTRA"].ToString());
                ltschitietDP.Add(ctdp);
            }
            return ltschitietDP;
        }
        public static List<ChiTiet_DatPhong_DTO> TimCTDPTheoTenLoaiPhong(string tenloaiphong)
        {
            string sTruyVan = string.Format(@"select dp.ID_DATPHONG, p.TENPHONG, lp.TEN_LP, ctdp.NGAYDAT , ctdp.NGAYTRA +
                from DATPHONG dp, CT_DatPhong ctdp, PHONG p, LOAIPHONG lp, KHang kh +
                where dp.ID_DATPHONG = ctdp.ID_DATPHONG and ctdp.ID_PHONG = p.ID_PHONG and p.ID_LP = lp.ID_LP and lp.TEN_LP ='{2}'", tenloaiphong);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChiTiet_DatPhong_DTO> ltschitietDP = new List<ChiTiet_DatPhong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTiet_DatPhong_DTO ctdp = new ChiTiet_DatPhong_DTO();
                ctdp.IDDatPhong = int.Parse(dt.Rows[i]["ID_DATPHONG"].ToString());
                ctdp.TenPhong = dt.Rows[i]["TENPHONG"].ToString();
                ctdp.TenLoaiP = dt.Rows[i]["TEN_LP"].ToString();
                ctdp.Ngaydat = DateTime.Parse(dt.Rows[i]["NGAYDAT"].ToString());
                ctdp.Ngaytra = DateTime.Parse(dt.Rows[i]["NGAYTRA"].ToString());
                ltschitietDP.Add(ctdp);
            }
            return ltschitietDP;
        }
        public static List<ChiTiet_DatPhong_DTO> TimCTDPTheoNgayDatPhong(DateTime ngaydat)
        {
            string sTruyVan = string.Format(@"select dp.ID_DATPHONG, p.TENPHONG, lp.TEN_LP, ctdp.NGAYDAT , ctdp.NGAYTRA +
                from DATPHONG dp, CT_DatPhong ctdp, PHONG p, LOAIPHONG lp, KHang kh +
                where dp.ID_DATPHONG = ctdp.ID_DATPHONG and ctdp.ID_PHONG = p.ID_PHONG and p.ID_LP = lp.ID_LP and ctdp.NGAYDAT  ='{3}'", ngaydat);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChiTiet_DatPhong_DTO> ltschitietDP = new List<ChiTiet_DatPhong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTiet_DatPhong_DTO ctdp = new ChiTiet_DatPhong_DTO();
                ctdp.IDDatPhong = int.Parse(dt.Rows[i]["ID_DATPHONG"].ToString());
                ctdp.TenPhong = dt.Rows[i]["TENPHONG"].ToString();
                ctdp.TenLoaiP = dt.Rows[i]["TEN_LP"].ToString();
                ctdp.Ngaydat = DateTime.Parse(dt.Rows[i]["NGAYDAT"].ToString());
                ctdp.Ngaytra = DateTime.Parse(dt.Rows[i]["NGAYTRA"].ToString());
                ltschitietDP.Add(ctdp);
            }
            return ltschitietDP;
        }
        public static List<ChiTiet_DatPhong_DTO> TimCTDPTheoNgayTraPhong(DateTime ngaytra)
        {
            string sTruyVan = string.Format(@"select dp.ID_DATPHONG, p.TENPHONG, lp.TEN_LP, ctdp.NGAYDAT , ctdp.NGAYTRA +
                from DATPHONG dp, CT_DatPhong ctdp, PHONG p, LOAIPHONG lp, KHang kh +
                where dp.ID_DATPHONG = ctdp.ID_DATPHONG and ctdp.ID_PHONG = p.ID_PHONG and p.ID_LP = lp.ID_LP and ctdp.NGAYTRA  ='{4}'", ngaytra);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChiTiet_DatPhong_DTO> ltschitietDP = new List<ChiTiet_DatPhong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTiet_DatPhong_DTO ctdp = new ChiTiet_DatPhong_DTO();
                ctdp.IDDatPhong = int.Parse(dt.Rows[i]["ID_DATPHONG"].ToString());
                ctdp.TenPhong = dt.Rows[i]["TENPHONG"].ToString();
                ctdp.TenLoaiP = dt.Rows[i]["TEN_LP"].ToString();
                ctdp.Ngaydat = DateTime.Parse(dt.Rows[i]["NGAYDAT"].ToString());
                ctdp.Ngaytra = DateTime.Parse(dt.Rows[i]["NGAYTRA"].ToString());
                ltschitietDP.Add(ctdp);
            }
            return ltschitietDP;
        }
    }
}
