using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVien_BUS
    {
        public static List<NhanVien_DTO> LayDSNhanvien()
        {
            return NhanVien_DAO.LayDSNhanVien();
        }
        public static bool add(NhanVien_DTO nv)
        {
            return NhanVien_DAO.add(nv);
        }
        public static bool Update(NhanVien_DTO nv)
        {
            return NhanVien_DAO.update(nv);
        }
        public static bool Delete(NhanVien_DTO nv)
        {
            return NhanVien_DAO.Delete(nv);
        }
        public static List<NhanVien_DTO> LayNhanvienTheoIDNV(string ma)
        {
            return NhanVien_DAO.TimNhanVienTheoMa(ma);
        }
        public static NhanVien_DTO LayNhanvienTheoIDNV1(string ma)
        {
            return NhanVien_DAO.TimNhanVienTheoMa1(ma);
        }
        public static List<NhanVien_DTO> LayNhanvienTheoten(string ten)
        {
            return NhanVien_DAO.TimNhanVienTheoTen(ten);
        }
        public static List<NhanVien_DTO> LayNhanvienTheoCCCD(string CCCD)
        {
            return NhanVien_DAO.TimNhanVienTheoCCCD(CCCD);
        }
        public static List<NhanVien_DTO> LayNhanvienTheoSDT(string sdt)
        {
            return NhanVien_DAO.TimNhanVienTheoSDT(sdt);
        }
        public static bool CheckCCCD(string cccd)
        {
            return NhanVien_DAO.CheckCCCD(cccd);
        }
        public static bool Checksdt(string sdt)
        {
            return NhanVien_DAO.CheckSDT(sdt);
        }

    }
}
