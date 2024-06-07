using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace DAO
{
    public class DichVu_DAO
    {
        static SqlConnection con;
        public static List<DichVu_DTO> LayDSDichVu()
        {
            string sTruyVan = "select dv.ID_DV , dv.TEN_DV , ldv.TEN_LDV , dv.DONGIA_DV, dv.GHICHU_DV from DICHVU dv, LOAI_DV ldv where dv.ID_LDV = ldv.ID_LDV ";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DichVu_DTO> ltsDSDichVu = new List<DichVu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DichVu_DTO dv = new DichVu_DTO();
                dv.IDDV = int.Parse(dt.Rows[i]["ID_DV"].ToString());
                dv.TenDV = dt.Rows[i]["TEN_DV"].ToString();
                dv.TenLoaiDV = dt.Rows[i]["TEN_LDV"].ToString();
                dv.DongiaDV =SqlMoney.Parse( dt.Rows[i]["DONGIA_DV"].ToString());
                dv.GhiCHu= dt.Rows[i]["GHICHU_DV"].ToString();
                ltsDSDichVu.Add(dv);
            }
            return ltsDSDichVu;
        }
        public static bool add(DichVu_DTO dv)
        {
            string sTruyVan = string.Format(@"insert into DICHVU values(N'{0}',{1},{2},N'{3}')",
               dv.TenDV,dv.IDLoaiDV , dv.DongiaDV, dv.GhiCHu);
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            KetNoi.Dongketnoi();
            return kq;

        }
        public static bool update(DichVu_DTO dv)
        {
            string sTruyVan = "update DICHVU set TEN_DV =N'"+dv.TenDV+"', ID_LDV=2, DONGIA_DV="+dv.DongiaDV.ToString()+", GHICHU_DV=N'"+dv.GhiCHu+"' where ID_DV = "+dv.IDDV+"";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static bool Delete(DichVu_DTO dv)
        {
            string sTruyVan = " delete DICHVU where ID_DV = '" + dv.IDDV + "'";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static List<DichVu_DTO> TimCTDPTheoIDDV(string ma)
        {
            string sTruyVan = string.Format(@"select dv.ID_DV , dv.TEN_DV , ldv.TEN_LDV , dv.DONGIA_DV, dv.GHICHU_DV from DICHVU dv, LOAI_DV ldv where dv.ID_LDV = ldv.ID_LDV and dv.ID_DV = {0}", ma);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DichVu_DTO> ltsDSDichVu = new List<DichVu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DichVu_DTO dv = new DichVu_DTO();
                dv.IDDV = int.Parse(dt.Rows[i]["ID_DV"].ToString());
                dv.TenDV = dt.Rows[i]["TEN_DV"].ToString();
                dv.TenLoaiDV = dt.Rows[i]["TEN_LDV"].ToString();
                dv.DongiaDV = SqlMoney.Parse(dt.Rows[i]["DONGIA_DV"].ToString());
                dv.GhiCHu = dt.Rows[i]["GHICHU_DV"].ToString();
                ltsDSDichVu.Add(dv);
            }
            return ltsDSDichVu;
        }
        public static List<DichVu_DTO> TimCTDPTheoTenDV(string tenDV)
        {
            string sTruyVan = string.Format(@"select dv.ID_DV , dv.TEN_DV , ldv.TEN_LDV , dv.DONGIA_DV, dv.GHICHU_DV from DICHVU dv, LOAI_DV ldv where dv.ID_LDV = ldv.ID_LDV and dv.TEN_DV LIKE N'%{0}%'", tenDV);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DichVu_DTO> ltsDSDichVu = new List<DichVu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DichVu_DTO dv = new DichVu_DTO();
                dv.IDDV = int.Parse(dt.Rows[i]["ID_DV"].ToString());
                dv.TenDV = dt.Rows[i]["TEN_DV"].ToString();
                dv.TenLoaiDV = dt.Rows[i]["TEN_LDV"].ToString();
                dv.DongiaDV = SqlMoney.Parse(dt.Rows[i]["DONGIA_DV"].ToString());
                dv.GhiCHu = dt.Rows[i]["GHICHU_DV"].ToString();
                ltsDSDichVu.Add(dv);
            }
            return ltsDSDichVu;
        }
        public static List<DichVu_DTO> TimCTDPTheoLoaiDV(string LoaiDV)
        {
            string sTruyVan = string.Format(@"select dv.ID_DV , dv.TEN_DV , ldv.TEN_LDV , dv.DONGIA_DV, dv.GHICHU_DV from DICHVU dv, LOAI_DV ldv where dv.ID_LDV = ldv.ID_LDV and  ldv.TEN_LDV LIKE N'%{0}%' ", LoaiDV);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DichVu_DTO> ltsDSDichVu = new List<DichVu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DichVu_DTO dv = new DichVu_DTO();
                dv.IDDV = int.Parse(dt.Rows[i]["ID_DV"].ToString());
                dv.TenDV = dt.Rows[i]["TEN_DV"].ToString();
                dv.TenLoaiDV = dt.Rows[i]["TEN_LDV"].ToString();
                dv.DongiaDV = SqlMoney.Parse(dt.Rows[i]["DONGIA_DV"].ToString());
                dv.GhiCHu = dt.Rows[i]["GHICHU_DV"].ToString();
                ltsDSDichVu.Add(dv);
            }
            return ltsDSDichVu;
        }
    }
}
