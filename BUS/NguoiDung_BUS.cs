using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NguoiDung_BUS
    {
        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
        public static List<NguoiDung_DTO> LayDSNguoiDung()
        {
            return NguoiDung_DAO.LayDSNguoiDung();
        }
        public static bool add(NguoiDung_DTO nd)
        {
            MD5 md5Hash = MD5.Create();
            string matkhau_mahoa = NguoiDung_BUS.GetMd5Hash(md5Hash, nd.Password);
            nd.Password = matkhau_mahoa;
            return NguoiDung_DAO.add(nd);
        }
        public static bool Update(NguoiDung_DTO nd)
        {
            MD5 md5Hash = MD5.Create();
            string matkhau_mahoa = NguoiDung_BUS.GetMd5Hash(md5Hash, nd.Password);
            nd.Password = matkhau_mahoa;
            return NguoiDung_DAO.update(nd);
        }
        public static bool UpdateMatKHau(NguoiDung_DTO nd)
        {
            MD5 md5Hash = MD5.Create();
            string matkhau_mahoa = NguoiDung_BUS.GetMd5Hash(md5Hash, nd.Password);
            nd.Password = matkhau_mahoa;
            return NguoiDung_DAO.updateMatKhau(nd);
        }
        public static bool Delete(NguoiDung_DTO nd)
        {
            return NguoiDung_DAO.Delete(nd);
        }
        public static List<NguoiDung_DTO> TimNguoidungtheIDNV(int ma)
        {
            return NguoiDung_DAO.TimPhongtheoMaNV(ma);
        }
        public static List<NguoiDung_DTO> TimNguoidungtheTenNV(string ten)
        {
            return NguoiDung_DAO.TimPhongtheoTenNV(ten);
        }
        public static List<NguoiDung_DTO> TimNguoidungtheTenQuyen(string ten)
        {
            return NguoiDung_DAO.TimPhongtheoQuyen(ten);
        }
        public static bool CheckUSer(string user)
        {
            return NguoiDung_DAO.USERName(user);
        }
        public static NguoiDung_DTO checkTK(string user, string pass)
        {
            MD5 md5Hash = MD5.Create();
            string matkhauMH = NguoiDung_BUS.GetMd5Hash(md5Hash, pass);
            return NguoiDung_DAO.checkTK(user, matkhauMH);
        }
        public static Admin_DTO checkAdmin(string user, string pass)
        {
            MD5 md5Hash = MD5.Create();
            string matkhauMH = NguoiDung_BUS.GetMd5Hash(md5Hash, pass);
            return NguoiDung_DAO.checAdmin(user, matkhauMH);
        }
    }
}
