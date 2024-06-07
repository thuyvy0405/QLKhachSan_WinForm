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
    public class Chitiet_HoaDon_DAO
    {
        static SqlConnection con;
        public static List<ChiTiet_HD_DTO> LayDSHoadon()
        {
            string sTruyVan = "SELECT HD.ID_HDTT, HD.ID_DATPHONG, P.TENPHONG, DV.TEN_DV, DPDV.NGAYSUDUNG  ,DPDV.SL_CT, DPDV.DONGIA_CT, DPDV.THANHTIEN_CT FROM HD_THANHTOAN HD, DATPHONG DP, CT_DatPhong CTDP, DATPHONG_DICHVU DPDV, DICHVU DV, PHONG P " +
                "WHERE HD.ID_DATPHONG = DP.ID_DATPHONG AND DP.ID_DATPHONG = CTDP.ID_DATPHONG " +
                "AND CTDP.ID_DATPHONG = DPDV.ID_DATPHONG AND DPDV.ID_DV = DV.ID_DV AND CTDP.ID_PHONG = P.ID_PHONG AND DPDV.ID_PHONG = P.ID_PHONG";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChiTiet_HD_DTO> ltsCThoaDon = new List<ChiTiet_HD_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTiet_HD_DTO ct = new ChiTiet_HD_DTO();
                ct.IDHD = int.Parse(dt.Rows[i]["ID_HDTT"].ToString());
                ct.IDDP = int.Parse(dt.Rows[i]["ID_DATPHONG"].ToString());
                ct.TenPhong = dt.Rows[i]["TENPHONG"].ToString();
                ct.TenDV = dt.Rows[i]["TEN_DV"].ToString();
                ct.NgaySD_DV = DateTime.Parse(dt.Rows[i]["NGAYSUDUNG"].ToString());
                ct.Soluong_CT1 = int.Parse(dt.Rows[i]["SL_CT"].ToString());
                ct.Dongia_CT1 = float.Parse(dt.Rows[i]["DONGIA_CT"].ToString());
                ct.Thanhtien_CT = float.Parse(dt.Rows[i]["THANHTIEN_CT"].ToString());
                ltsCThoaDon.Add(ct);
            }
            return ltsCThoaDon;
        }
        public static bool add(ChiTiet_HD_DTO hd)
        {
            string sTruyVan = string.Format(@"insert into DATPHONG_DICHVU values('{0}','{1}',N'{2}',N'{3}','{4}','{5}','{6}',{7},{8})",
                hd.IDHD ,hd.IDDP, hd.ID_PHONG1 , hd.IDDV,hd.NgaySD_DV,hd.Soluong_CT1, hd.Dongia_CT1, hd.Thanhtien_CT);
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            KetNoi.Dongketnoi();
            return kq;

        }
        public static bool update(ChiTiet_HD_DTO hd)
        {
            string sTruyVan = "update DATPHONG_DICHVU set ID_DV = '" + hd.IDDV + "', SL_CT = '" + hd.Soluong_CT1 + "', DONGIA_CT = '" + hd.Dongia_CT1 + "', THANHTIEN_CT = '" + hd.Thanhtien_CT + "'" +
                    "' where ID_HDTT = '" + hd.IDHD + "' and ID_DATPHONG ='" + hd.IDDP+"'";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static bool Delete(ChiTiet_HD_DTO hd)
        {
            string sTruyVan = " delete DATPHONG_DICHVU where ID_HDTT = '" + hd.IDHD + "' and ID_DATPHONG ='" + hd.IDDP + "'";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static List<ChiTiet_HD_DTO> TimCTHDtheoIDHD(int maHD)
        {
            string sTruyVan = string.Format(@"SELECT HD.ID_HDTT, HD.ID_DATPHONG, P.TENPHONG, DV.TEN_DV, DPDV.NGAYSUDUNG ,DPDV.SL_CT, DPDV.DONGIA_CT, DPDV.THANHTIEN_CT FROM HD_THANHTOAN HD, DATPHONG DP, CT_DatPhong CTDP, DATPHONG_DICHVU DPDV, DICHVU DV, PHONG P
                        WHERE HD.ID_DATPHONG = DP.ID_DATPHONG AND DP.ID_DATPHONG = CTDP.ID_DATPHONG
                        AND CTDP.ID_DATPHONG =  DPDV.ID_DATPHONG AND DPDV.ID_DV= DV.ID_DV AND CTDP.ID_PHONG = P.ID_PHONG 
                        AND DPDV.ID_PHONG = P.ID_PHONG and hd.ID_HDTT ='{0}'", maHD);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChiTiet_HD_DTO> ltsCThoaDon = new List<ChiTiet_HD_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTiet_HD_DTO ct = new ChiTiet_HD_DTO();
                ct.IDHD = int.Parse(dt.Rows[i]["ID_HDTT"].ToString());
                ct.IDDP = int.Parse(dt.Rows[i]["ID_DATPHONG"].ToString());
                ct.TenPhong = dt.Rows[i]["TENPHONG"].ToString();
                ct.TenDV = dt.Rows[i]["TEN_DV"].ToString();
                ct.NgaySD_DV = DateTime.Parse(dt.Rows[i]["NGAYSUDUNG"].ToString());
                ct.Soluong_CT1 = int.Parse(dt.Rows[i]["SL_CT"].ToString());
                ct.Dongia_CT1 = float.Parse(dt.Rows[i]["DONGIA_CT"].ToString());
                ct.Thanhtien_CT = float.Parse(dt.Rows[i]["THANHTIEN_CT"].ToString());
                ltsCThoaDon.Add(ct);
            }
            return ltsCThoaDon;
        }
        public static List<ChiTiet_HD_DTO> TimCTHDtheoIDDatPhong(int maDP)
        {
            string sTruyVan = string.Format(@"SELECT HD.ID_HDTT, HD.ID_DATPHONG, P.TENPHONG, DV.TEN_DV, DPDV.NGAYSUDUNG ,DPDV.SL_CT, DPDV.DONGIA_CT, DPDV.THANHTIEN_CT FROM HD_THANHTOAN HD, DATPHONG DP, CT_DatPhong CTDP, DATPHONG_DICHVU DPDV, DICHVU DV, PHONG P
                        WHERE HD.ID_DATPHONG = DP.ID_DATPHONG AND DP.ID_DATPHONG = CTDP.ID_DATPHONG
                        AND CTDP.ID_DATPHONG =  DPDV.ID_DATPHONG AND DPDV.ID_DV= DV.ID_DV AND CTDP.ID_PHONG = P.ID_PHONG 
                        AND DPDV.ID_PHONG = P.ID_PHONG and hd.ID_HDTT ='{1}'", maDP);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChiTiet_HD_DTO> ltsCThoaDon = new List<ChiTiet_HD_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTiet_HD_DTO ct = new ChiTiet_HD_DTO();
                ct.IDHD = int.Parse(dt.Rows[i]["ID_HDTT"].ToString());
                ct.IDDP = int.Parse(dt.Rows[i]["ID_DATPHONG"].ToString());
                ct.TenPhong = dt.Rows[i]["TENPHONG"].ToString();
                ct.TenDV = dt.Rows[i]["TEN_DV"].ToString();
                ct.NgaySD_DV = DateTime.Parse(dt.Rows[i]["NGAYSUDUNG"].ToString());
                ct.Soluong_CT1 = int.Parse(dt.Rows[i]["SL_CT"].ToString());
                ct.Dongia_CT1 = float.Parse(dt.Rows[i]["DONGIA_CT"].ToString());
                ct.Thanhtien_CT = float.Parse(dt.Rows[i]["THANHTIEN_CT"].ToString());
                ltsCThoaDon.Add(ct);
            }
            return ltsCThoaDon;
        }
        public static List<ChiTiet_HD_DTO> TimCTHDtheoPhong(string phong)
        {
            string sTruyVan = string.Format(@"SELECT HD.ID_HDTT, HD.ID_DATPHONG, P.TENPHONG, DV.TEN_DV, DPDV.NGAYSUDUNG ,DPDV.SL_CT, DPDV.DONGIA_CT, DPDV.THANHTIEN_CT FROM HD_THANHTOAN HD, DATPHONG DP, CT_DatPhong CTDP, DATPHONG_DICHVU DPDV, DICHVU DV, PHONG P
                        WHERE HD.ID_DATPHONG = DP.ID_DATPHONG AND DP.ID_DATPHONG = CTDP.ID_DATPHONG
                        AND CTDP.ID_DATPHONG =  DPDV.ID_DATPHONG AND DPDV.ID_DV= DV.ID_DV AND CTDP.ID_PHONG = P.ID_PHONG 
                        AND DPDV.ID_PHONG = P.ID_PHONG and hd.ID_HDTT ='{2}'", phong);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChiTiet_HD_DTO> ltsCThoaDon = new List<ChiTiet_HD_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTiet_HD_DTO ct = new ChiTiet_HD_DTO();
                ct.IDHD = int.Parse(dt.Rows[i]["ID_HDTT"].ToString());
                ct.IDDP = int.Parse(dt.Rows[i]["ID_DATPHONG"].ToString());
                ct.TenPhong = dt.Rows[i]["TENPHONG"].ToString();
                ct.TenDV = dt.Rows[i]["TEN_DV"].ToString();
                ct.NgaySD_DV = DateTime.Parse(dt.Rows[i]["NGAYSUDUNG"].ToString());
                ct.Soluong_CT1 = int.Parse(dt.Rows[i]["SL_CT"].ToString());
                ct.Dongia_CT1 = float.Parse(dt.Rows[i]["DONGIA_CT"].ToString());
                ct.Thanhtien_CT = float.Parse(dt.Rows[i]["THANHTIEN_CT"].ToString());
                ltsCThoaDon.Add(ct);
            }
            return ltsCThoaDon;
        }
        public static List<ChiTiet_HD_DTO> TimCTHDtheoNgaySD(DateTime ngay)
        {
            string sTruyVan = string.Format(@"SELECT HD.ID_HDTT, HD.ID_DATPHONG, P.TENPHONG, DV.TEN_DV, DPDV.NGAYSUDUNG ,DPDV.SL_CT, DPDV.DONGIA_CT, DPDV.THANHTIEN_CT FROM HD_THANHTOAN HD, DATPHONG DP, CT_DatPhong CTDP, DATPHONG_DICHVU DPDV, DICHVU DV, PHONG P
                        WHERE HD.ID_DATPHONG = DP.ID_DATPHONG AND DP.ID_DATPHONG = CTDP.ID_DATPHONG
                        AND CTDP.ID_DATPHONG =  DPDV.ID_DATPHONG AND DPDV.ID_DV= DV.ID_DV AND CTDP.ID_PHONG = P.ID_PHONG 
                        AND DPDV.ID_PHONG = P.ID_PHONG and hd.ID_HDTT ='{4}'", ngay);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChiTiet_HD_DTO> ltsCThoaDon = new List<ChiTiet_HD_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTiet_HD_DTO ct = new ChiTiet_HD_DTO();
                ct.IDHD = int.Parse(dt.Rows[i]["ID_HDTT"].ToString());
                ct.IDDP = int.Parse(dt.Rows[i]["ID_DATPHONG"].ToString());
                ct.TenPhong = dt.Rows[i]["TENPHONG"].ToString();
                ct.TenDV = dt.Rows[i]["TEN_DV"].ToString();
                ct.NgaySD_DV = DateTime.Parse(dt.Rows[i]["NGAYSUDUNG"].ToString());
                ct.Soluong_CT1 = int.Parse(dt.Rows[i]["SL_CT"].ToString());
                ct.Dongia_CT1 = float.Parse(dt.Rows[i]["DONGIA_CT"].ToString());
                ct.Thanhtien_CT = float.Parse(dt.Rows[i]["THANHTIEN_CT"].ToString());
                ltsCThoaDon.Add(ct);
            }
            return ltsCThoaDon;
        }
    
    }
}
