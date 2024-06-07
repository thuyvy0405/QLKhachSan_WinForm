using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhanQuyen_BUS
    {
        public static List<PhanQuyen_DTO> Layquyen()
        {
            return PhanQuyen_DAO.LayDSQuyen();
        }
    }
}
