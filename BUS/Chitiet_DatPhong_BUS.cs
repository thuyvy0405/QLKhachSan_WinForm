using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Chitiet_DatPhong_BUS
    {
        public static List<ChiTiet_DatPhong_DTO> LayCT_DATPHONG()
        {
            return ChiTiet_DatPhong_DAO.LayChitietDP();
        }
        
         public static bool CapNhat_NhanPhong(ChiTiet_DatPhong_DTO ctdp)
        {
            return ChiTiet_DatPhong_DAO.CapNhat_NhanPhong(ctdp);
        }
        public static List<ChiTiet_DatPhong_DTO> LayCT_DATPHONG_THEOID(int ID_DATPHONG)
        {
            return ChiTiet_DatPhong_DAO.LayChitietDP_THEOID(ID_DATPHONG);
        }
        
              public static bool update_thoigiantraphong(ChiTiet_DatPhong_DTO ctdp)
        {
            return ChiTiet_DatPhong_DAO.update_thoigiantraphong(ctdp);
        }
        public static bool add(ChiTiet_DatPhong_DTO ctdp)
        {
            return ChiTiet_DatPhong_DAO.add(ctdp);
        }
        public static bool Update(ChiTiet_DatPhong_DTO ctdp)
        {
            return ChiTiet_DatPhong_DAO.update(ctdp);
        }
        public static bool update_saukhichuyephong(ChiTiet_DatPhong_DTO ctdp)
        {
            return ChiTiet_DatPhong_DAO.update_saukhichuyephong(ctdp);
        }
        
        public static bool Delete(ChiTiet_DatPhong_DTO ctdp)
        {
            return ChiTiet_DatPhong_DAO.Delete(ctdp);
        }
        public static List<ChiTiet_DatPhong_DTO> TimCTDPtheoIDDP(int ma)
        {
            return ChiTiet_DatPhong_DAO.TimCTDPTheoIDDP(ma);
        }
        public static List<ChiTiet_DatPhong_DTO> TimCTDPtheoTenPhong(string ten)
        {
            return ChiTiet_DatPhong_DAO.TimCTDPTheoTenPhong(ten);
        }
        public static List<ChiTiet_DatPhong_DTO> TimCTDPtheoTenLoaiPhong(string ten)
        {
            return ChiTiet_DatPhong_DAO.TimCTDPTheoTenLoaiPhong(ten);
        }
        public static List<ChiTiet_DatPhong_DTO> TimCTDPtheoNgayDATPHONG(DateTime ngay)
        {
            return ChiTiet_DatPhong_DAO.TimCTDPTheoNgayDatPhong(ngay);
        }
        public static List<ChiTiet_DatPhong_DTO> TimCTDPtheoNgayTraPHONG(DateTime ngay)
        {
            return ChiTiet_DatPhong_DAO.TimCTDPTheoNgayTraPhong(ngay);
        }
    }
}
