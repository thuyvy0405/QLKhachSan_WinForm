using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DatPhong_BUS
    {
        public static List<Phong_DTO> LayDSPhongTrong()
        {
            return DatPhong_DAO.LayDSPhongTrong();
        }
        public static List<Phong_DTO> LayDSPhongChon()
        {
            return DatPhong_DAO.LayDSPhongCHON();
        }
        public static List<DatPhong_DTO> LayDSDatPhong()
        {
            return DatPhong_DAO.LayDSDatPhong();
        }
        public static List<DatPhong_DTO> TimDPtheoMaDP(string ma)
        {
            return DatPhong_DAO.TimPhongtheomaDP(ma);
        }
        public static List<DatPhong_DTO> TimDPtheoNgaylap(string ngay)
        {
            return DatPhong_DAO.TimPhongtheoNgayLap(ngay);
        }
        public static List<DatPhong_DTO> TimDPtheoTenKH(string ten)
        {
            return DatPhong_DAO.TimPhongtheoTenKH(ten);
        }
        public static bool add(DatPhong_DTO dp)
        {
            return DatPhong_DAO.add(dp);
        }
        public static bool Update(DatPhong_DTO dp)
        {
            return DatPhong_DAO.update(dp);
        }
        public static bool Delete(DatPhong_DTO dp)
        {
            return DatPhong_DAO.Delete(dp);
        }
        public static KhachHang_DTO TimKH_ThuePhong(string ma)
        {
            return DatPhong_DAO.TimKH_ThuePhong(ma);
        }
        public static KhachHang_DTO TimKH_DatPhong(string ma)
        {
            return DatPhong_DAO.TimKH_DatPhong(ma);
        }
        public static bool HuyDatPhong_KH(int ID_DATPHONG, int ID_PHONG)
        {
            return DatPhong_DAO.HuyDatPhong_KH(ID_DATPHONG, ID_PHONG);
        }
        public static List<DatPhong_DTO> DemSoLuongPhongDat(int ID_DATPHONG)
        {
            return DatPhong_DAO.DemSoLuongPhongDat(ID_DATPHONG);
        }
        public static bool ChuyenPhong(int id_datphong, int id_phong, int id_phongchuyen)
        {
            return DatPhong_DAO.ChuyenPhong(id_datphong, id_phong, id_phongchuyen);
        }
        public static bool CapNhatTrangthaiDatPhong(DatPhong_DTO dp)
        {
            return DatPhong_DAO.CapNhatTrangthaiDatPhong(dp);
        }
        public static bool CapNhatTrangthaiDatPhong_Dangthue(int IDDatPhong)
        {
            return DatPhong_DAO.CapNhatTrangthaiDatPhong_Dangthue(IDDatPhong);
        }
        public static DatPhong_DTO LayTrangThaiDatPhong(int iddatphong)
        {
            return DatPhong_DAO.LayTrangThaiDatPhong(iddatphong);
        }
    }
}
