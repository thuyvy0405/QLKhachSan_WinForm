using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhachHang_BUS
    {
        public static List<KhachHang_DTO> LayDSKhachHang()
        {
            return KhachHang_DAO.LayDSKhachHang();
        }
        public static bool add(KhachHang_DTO kh)
        {
            return KhachHang_DAO.add(kh);
        }
        public static bool Update(KhachHang_DTO kh)
        {
            return KhachHang_DAO.update(kh);
        }
        public static bool Delete(KhachHang_DTO kh)
        {
            return KhachHang_DAO.Delete(kh);
        }
        public static List<KhachHang_DTO> TimKHtheoMa(string makh)
        {
            return KhachHang_DAO.TimKHTheoMaKH(makh);
        }
        public static List<KhachHang_DTO> TimKHtheoCCCD(string cccd)
        {
            return KhachHang_DAO.TimKHTheoCCCD(cccd);
        }
        public static List<KhachHang_DTO> TimKHtheoTenkh(string tenkh)
        {
            return KhachHang_DAO.TimKhachhangTheoTen(tenkh);
        }
        public static List<KhachHang_DTO> TimKHtheoSDT(string sdt)
        {
            return KhachHang_DAO.TimKHTheoSDT(sdt);
        }
        public static KhachHang_DTO TimKhachhangtheoID(string ma)
        {
            return KhachHang_DAO.TimKhachhangTheoMaKH(ma);
        }
        public static KhachHang_DTO TimKhachhangtheoten(string ten)
        {
            return KhachHang_DAO.TimKhachhangTheoTenKH(ten);
        }
        public static KhachHang_DTO TimKhachhangtheoCCCD(string CCCD)
        {
            return KhachHang_DAO.TimKhachhangTheoCCCD(CCCD);
        }
        public static KhachHang_DTO TimKhachhangtheoSDT(string SDT)
        {
            return KhachHang_DAO.TimKhachhangTheoSDT(SDT);
        }
        public static bool CheckSDT(string sdt)
        {
            return KhachHang_DAO.CheckSDT(sdt);
        }
        public static bool CheckCCCD(string cccd)
        {
            return KhachHang_DAO.CheckCCCD(cccd);
        }
    }
}
