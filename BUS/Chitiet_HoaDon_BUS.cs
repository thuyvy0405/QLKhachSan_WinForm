using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Chitiet_HoaDon_BUS
    {
        public static List<ChiTiet_HD_DTO> LayDSCTHD()
        {
            return Chitiet_HoaDon_DAO.LayDSHoadon();
        }
        public static bool add(ChiTiet_HD_DTO ct)
        {
            return Chitiet_HoaDon_DAO.add(ct);
        }
        public static bool Update(ChiTiet_HD_DTO ct)
        {
            return Chitiet_HoaDon_DAO.update(ct);
        }
        public static bool Delete(ChiTiet_HD_DTO ct)
        {
            return Chitiet_HoaDon_DAO.Delete(ct);
        }
        public static List<ChiTiet_HD_DTO> TimCTHDtheoIDHD(int ma)
        {
            return Chitiet_HoaDon_DAO.TimCTHDtheoIDHD(ma);
        }
        public static List<ChiTiet_HD_DTO> TimCTHDtheIDDATPHONG(int ma)
        {
            return Chitiet_HoaDon_DAO.TimCTHDtheoIDDatPhong(ma);
        }
        public static List<ChiTiet_HD_DTO> TimCTHDtheoNgaySDDV(DateTime ngay)
        {
            return Chitiet_HoaDon_DAO.TimCTHDtheoNgaySD(ngay);
        }
    }
}
