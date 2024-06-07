using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ADMIN_BUS
    {
        // Vy Đặng
        public static List<Admin_DTO> LayADMIN()
        {
            return ADMIN_DAO.LayADMIN();
        }
    }
}
