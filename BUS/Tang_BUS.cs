using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Tang_BUS
    {
        public static List<Tang_DTO> LayDSTANG()
        {
            return Tang_DAO.LayDSTANG();
        }
        public static bool add(Tang_DTO lp)
        {
            return Tang_DAO.add(lp);
        }
        public static bool Update(Tang_DTO lp)
        {
            return Tang_DAO.update(lp);
        }
    }
}
