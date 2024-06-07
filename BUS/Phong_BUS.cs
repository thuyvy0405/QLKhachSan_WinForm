using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Phong_BUS
    {
        public static List<Phong_DTO> LayDSPHONG()
        {
            return Phong_DAO.LayDSPHong();
        }
        public static List<Phong_DTO> LayPHONG()
        {
            return Phong_DAO.Layphong();
        }
        public static List<Tang_DTO> LayDanhSachTang()
        {
            return Phong_DAO.LayDanhSachTang();
        }
        public static bool add(Phong_DTO p)
        {
            return Phong_DAO.add(p);
        }
        public static bool Update(Phong_DTO p)
        {
            return Phong_DAO.update(p);
        }
        public static bool UpdateTrangThaiPhong_Dat(Phong_DTO p)
        {
            return Phong_DAO.updateTrangThai_Dat(p);
        }
        public static bool UpdateTrangThaiPhong_Thue(Phong_DTO p)
        {
            return Phong_DAO.updateTrangThai_Thue(p);
        }
        public static bool UpdateTrangThaiPhong_trangthai(Phong_DTO p, int tragthai)
        {
            return Phong_DAO.updateTrangThai_phong(p, tragthai);
        }
        public static bool Dalete(Phong_DTO p)
        {
            return Phong_DAO.Delete(p);
        }
        public static List<Phong_DTO> TimPhongtheoMaP(string ma)
        {
            return Phong_DAO.TimPhongtheoMaP(ma);
        }
        public static List<Phong_DTO> TimPhongtheoLoaiP(string Loai)
        {
            return Phong_DAO.TimPhongtheoLoaiphong(Loai);
        }
        public static List<Phong_DTO> TimPhongtheoTang(string tang)
        {
            return Phong_DAO.TimPhongtheoTang(tang);
        }
        public static List<Phong_DTO> TimPhongtheoTrangThai(string tt)
        {
            return Phong_DAO.TimPhongtheoTrangThai(tt);
        }
        public static Phong_DTO TimPhongtheoID(string ma)
        {
            return Phong_DAO.TimPhongtheoID(ma);
        }
        public static Phong_DTO TimPhongTheoTen(string tenphong)
        {
            return Phong_DAO.TimPhongtheoTen(tenphong);
        }
        public static List<Phong_DTO> LayDSPHongAll()
        {
            return Phong_DAO.LayDSPHongAll();
        }
        public static List<Phong_DTO> LayDSPHongAll_TheoDieuKien(int id_loai, int id_trangthai)
        {
            return Phong_DAO.LayDSPHongAll_TheoDieuKien(id_loai, id_trangthai);

        }
        public static List<Phong_DTO> LayDSPHongAll_TheoTen(string tenphong)
        {
            return Phong_DAO.LayDSPHongAll_TheoTen(tenphong);

        }
        public static List<Phong_DTO> LayDSPHongAll_ChuyenPhong()
        {
            return Phong_DAO.LayDSPHongAll_ChuyenPhong();

        }
        public static List<Phong_DTO> TimDSPHongIDLoaiphong(string tenphong)
        {
            return Phong_DAO.TimDSPHongtheoIDLoaiphong(tenphong);
        }
        public static List<Phong_DTO> TimDSPHongtentrangthai(string trangthai)
        {
            return Phong_DAO.TimDSPHongtheotentrangthai(trangthai);
        }
        public static List<TrangThai_Phong_DTO> LayDanhSachTrangThai()
        {
            return Phong_DAO.LayDanhSachTrangThai();
        }
        
    }
}
