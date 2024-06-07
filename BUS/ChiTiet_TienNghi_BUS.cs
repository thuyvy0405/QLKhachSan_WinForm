using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTiet_TienNghi_BUS
    {
        public static List<Chitiet_TienNghi_DTO> LayCTTienNghi()
        {
            return Chitiet_TienNghi_DAO.LayChitietTiennghi();
        }
        public static bool add(Chitiet_TienNghi_DTO tn)
        {
            return Chitiet_TienNghi_DAO.add(tn);
        }
        public static bool Update(Chitiet_TienNghi_DTO tn)
        {
            return Chitiet_TienNghi_DAO.update(tn);
        }
        public static bool Delete(Chitiet_TienNghi_DTO tn)
        {
            return Chitiet_TienNghi_DAO.Delete(tn);
        }
        public static List<Chitiet_TienNghi_DTO> TimCTTNtheoTenTN(string ten)
        {
            return Chitiet_TienNghi_DAO.TimTNtheoTenTN(ten);
        }
        public static List<Chitiet_TienNghi_DTO> TimTNtheoNgay(DateTime thgian)
        {
            return Chitiet_TienNghi_DAO.TimTNtheoTHGiANSD(thgian);
        }
        public static List<Chitiet_TienNghi_DTO> TimTNtheoTenphong(string phong)
        {
            return Chitiet_TienNghi_DAO.TimTNtheoTenPhong(phong);
        }
    }
}
