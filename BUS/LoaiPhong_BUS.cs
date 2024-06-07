using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiPhong_BUS
    {
        public static List<Loai_Phong_DTO> LayDSLOAIPHONG()
        {
            return LoaiPhong_DAO.LayDSLoaiPhong();
        }
        public static bool add(Loai_Phong_DTO lp)
        {
            return LoaiPhong_DAO.add(lp);
        }
        public static bool Update(Loai_Phong_DTO lp)
        {
            return LoaiPhong_DAO.update(lp);
        }
        public static bool Dalete(Loai_Phong_DTO lp)
        {
            return LoaiPhong_DAO.Delete(lp);
        }
        public static List<Loai_Phong_DTO> TimLoaiPhongtheoIDLoai(int id)
        {
            return LoaiPhong_DAO.TimLoaiPhongtheoMaLP(id);
        }
        public static List<Loai_Phong_DTO> TimLoaiPhongtheoTenLoai(string ten)
        {
            return LoaiPhong_DAO.TimLoaiPhongtheoTenLoai(ten);
        }
        public static Loai_Phong_DTO TimLoai_PhongtheoTenLoai(string ten)
        {
            return LoaiPhong_DAO.TimLoai_PhongtheoTenLoai(ten);
        }
    }
}
