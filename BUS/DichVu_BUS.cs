using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DichVu_BUS
    {
        public static List<DichVu_DTO> LayDSDichVu()
        {
            return DichVu_DAO.LayDSDichVu();
        }
        public static bool add(DichVu_DTO dv)
        {
            return DichVu_DAO.add(dv);
        }
        public static bool Update(DichVu_DTO dv)
        {
            return DichVu_DAO.update(dv);
        }
        public static bool Delete(DichVu_DTO dv)
        {
            return DichVu_DAO.Delete(dv);
        }
        public static List<DichVu_DTO> TimDVtheoIDDV(string ma)
        {
            return DichVu_DAO.TimCTDPTheoIDDV(ma);
        }
        public static List<DichVu_DTO> TimDVtheoTenDV(string tendv)
        {
            return DichVu_DAO.TimCTDPTheoTenDV(tendv);
        }
        public static List<DichVu_DTO> TimDVtheoLoaiDV(string loaidv)
        {
            return DichVu_DAO.TimCTDPTheoLoaiDV(loaidv);
        }
    }
}
