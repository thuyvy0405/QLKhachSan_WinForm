using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Loai_DV_BUS
    {
        public static List<Loai_DichVu_DTO> LayDSLOAIDV()
        {
            return LoaiDV_DAO.LayDSLoaiDV();
        }
        public static bool add(Loai_DichVu_DTO lp)
        {
            return LoaiDV_DAO.add(lp);
        }
        public static bool Update(Loai_DichVu_DTO lp)
        {
            return LoaiDV_DAO.update(lp);
        }
    }
}
