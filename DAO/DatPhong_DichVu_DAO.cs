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
    public class DatPhong_DichVu_DAO
    {
        static SqlConnection con;
        public static List<DatPhong_DichVu_DTO> LayDanhSachDichVuDatPhongTheoIDDP(int ID_DATPHONG)
        {
            string sTruyVan = "select P.ID_PHONG, DV.ID_DV, DPDV.SL_CT, DPDV.DONGIA_CT, DPDV.THANHTIEN_CT, DV.TEN_DV, DPDV.NGAYSUDUNG from DATPHONG_DICHVU DPDV, PHONG P, DICHVU DV WHERE DPDV.ID_DATPHONG = "+ ID_DATPHONG +"  AND DPDV.ID_PHONG = P.ID_PHONG AND DPDV.ID_DV = DV.ID_DV";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DatPhong_DichVu_DTO> ltsCThoaDon = new List<DatPhong_DichVu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DatPhong_DichVu_DTO ct = new DatPhong_DichVu_DTO();
                ct.ID_PHONG1 =int.Parse( dt.Rows[i]["ID_PHONG"].ToString());
                ct.IDDV = int.Parse(dt.Rows[i]["ID_DV"].ToString());
                ct.NgaySD_DV = DateTime.Parse(dt.Rows[i]["NGAYSUDUNG"].ToString());
                ct.SoluongDV = int.Parse(dt.Rows[i]["SL_CT"].ToString());
                ct.DongiaDV = double.Parse(dt.Rows[i]["DONGIA_CT"].ToString());
                ct.ThanhtienDV = double.Parse(dt.Rows[i]["THANHTIEN_CT"].ToString());
                ct.TenDV = dt.Rows[i]["TEN_DV"].ToString();
            ltsCThoaDon.Add(ct);
            }
            return ltsCThoaDon;
        }
        public static bool add(DatPhong_DichVu_DTO hd)
        {
            string sTruyVan = string.Format("insert into DATPHONG_DICHVU values({0},{1},{2},'{3}',{4},{5},{6})",
                 hd.IDDP, hd.ID_PHONG1, hd.IDDV, hd.NgaySD_DV, hd.SoluongDV, hd.DongiaDV, hd.ThanhtienDV);
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            KetNoi.Dongketnoi();
            return kq;
        }
        public static bool update(DatPhong_DichVu_DTO hd)
        {
            string sTruyVan = "update DATPHONG_DICHVU set SL_CT = " + hd.SoluongDV + ", DONGIA_CT = " + hd.DongiaDV + ", THANHTIEN_CT = " + hd.ThanhtienDV + "" +
                    " where ID_DATPHONG = " + hd.IDDP + " and ID_PHONG =" + hd.ID_PHONG1 + " AND ID_DV = "+hd.IDDV+"";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static bool update_PhongSaukhichuyen(DatPhong_DichVu_DTO hd, int id_phongchuyen)
        {
            string sTruyVan = "update DATPHONG_DICHVU set ID_PHONG = "+id_phongchuyen+" where ID_DATPHONG = "+hd.IDDP+" and ID_PHONG = "+hd.ID_PHONG1+"";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }


        public static bool Delete(DatPhong_DichVu_DTO hd)
        {
            string sTruyVan = " delete DATPHONG_DICHVU where ID_DATPHONG = " + hd.IDDP + " and ID_PHONG =" + hd.ID_PHONG1 + " AND ID_DV = "+hd.IDDV+"";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
    }
}
