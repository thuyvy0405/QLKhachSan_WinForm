using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TienNghi_BUS
    {
        public static List<TienNghi_DTO> LayDSTienNghi()
        {
            return TienNghi_DAO.LayDSTienNghi();
        }
        public static bool add(TienNghi_DTO tn)
        {
            return TienNghi_DAO.add(tn);
        }
        public static bool Update(TienNghi_DTO tn)
        {
            return TienNghi_DAO.update(tn);
        }
        public static bool Delete(TienNghi_DTO tn)
        {
            return TienNghi_DAO.Delete(tn);
        }
        public static List<TienNghi_DTO> TimTNtheoIDTN(string ma)
        {
            return TienNghi_DAO.TimTNTheoMa(ma);
        }
        public static List<TienNghi_DTO> TimTNtheoTenTN(string ten)
        {
            return TienNghi_DAO.TimTNTheoTen(ten);
        }

    }
}
