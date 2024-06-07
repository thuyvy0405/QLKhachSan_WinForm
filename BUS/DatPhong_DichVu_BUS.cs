using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class DatPhong_DichVu_BUS
    {
        public static List<DatPhong_DichVu_DTO> LayDSDichVu_DatPhong(int ID_DATPHONG)
        {
            return DatPhong_DichVu_DAO.LayDanhSachDichVuDatPhongTheoIDDP(ID_DATPHONG);
        }
        public static bool add(DatPhong_DichVu_DTO ct)
        {
            return DatPhong_DichVu_DAO.add(ct);
        }
        public static bool Update(DatPhong_DichVu_DTO ct)
        {
            return DatPhong_DichVu_DAO.update(ct);
        }
        public static bool update_PhongSaukhichuyen(DatPhong_DichVu_DTO ct, int id_phongchuyen)
        {
            return DatPhong_DichVu_DAO.update_PhongSaukhichuyen(ct, id_phongchuyen );
        }
        public static bool Delete(DatPhong_DichVu_DTO ct)
        {
            return DatPhong_DichVu_DAO.Delete(ct);
        }
    }
}
