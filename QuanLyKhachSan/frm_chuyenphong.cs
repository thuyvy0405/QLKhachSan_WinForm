using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_chuyenphong : Form
    {
        private int id_datphong;
        private frm_Phong frm_Phong;
        private Phong_DTO phongdto;
        private KhachHang_DTO khthue;
        public frm_chuyenphong()
        {
            InitializeComponent();
        }

        private void frm_chuyenphong_Load(object sender, EventArgs e)
        {
            LoadDSPhong();
        }

        public frm_chuyenphong(int id_datphong, Phong_DTO phongdto, frm_Phong frm_Phong,KhachHang_DTO khthue)
        {
            InitializeComponent();
            this.id_datphong = id_datphong;
            this.frm_Phong = frm_Phong;
            this.phongdto = phongdto;
            this.khthue = khthue;
        }

        private void btn_chuyenphong_Click(object sender, EventArgs e)
        {
            if (dgv_danhsachphong.SelectedRows.Count > 0)
            {
                
                DataGridViewRow row = dgv_danhsachphong.CurrentRow;
                if (MessageBox.Show("Bạn có muốn chuyển phòng " + phongdto.TenPhong + " sang phòng " + row.Cells[1].Value.ToString() + " không ?", "Xác nhận thanh toán đặt phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DatPhong_BUS.ChuyenPhong(id_datphong, phongdto.IDPhong, int.Parse(row.Cells[0].Value.ToString()));
                    Phong_DTO phongchuyen = new Phong_DTO(); phongchuyen.IDPhong = int.Parse(row.Cells[0].Value.ToString());
                    Phong_DTO phong = new Phong_DTO(); phong.IDPhong = phongdto.IDPhong;
                    Phong_BUS.UpdateTrangThaiPhong_trangthai(phongchuyen, 4);
                    Phong_BUS.UpdateTrangThaiPhong_trangthai(phong, 1);
                    DatPhong_DichVu_DTO dpdv = new DatPhong_DichVu_DTO();dpdv.IDDP = id_datphong; dpdv.ID_PHONG1 = phongdto.IDPhong;
                    DatPhong_DichVu_BUS.update_PhongSaukhichuyen(dpdv, int.Parse(dgv_danhsachphong.CurrentRow.Cells[0].Value.ToString()));
                    CapNhatTienPhong();
                    frm_Phong.LoadPhongAuTo();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng bạn cần chuyển.", "THÔNG BÁO");
            }
        }

        private void LoadDSPhong()
        {
            List<Phong_DTO> listPhong = Phong_BUS.LayDSPHongAll_ChuyenPhong();
            dgv_danhsachphong.DataSource = listPhong;
        }
        private void CapNhatTienPhong()
        {
            ChiTiet_DatPhong_DTO ctdp = new ChiTiet_DatPhong_DTO();
            int days = GetDaysBetween(khthue.Ngaydatphong, khthue.Ngaytraphong);// lấy số ngày đặt của khách
            float hours = (float)(khthue.Ngaytraphong - khthue.Ngaydatphong).TotalHours % 24; // Lấy phần dư số giờ
            Loai_Phong_DTO loaiphong = LoaiPhong_BUS.TimLoai_PhongtheoTenLoai(dgv_danhsachphong.CurrentRow.Cells[3].Value.ToString()); ;
            ctdp.IDDatPhong = id_datphong;
            ctdp.IDPhong = int.Parse(dgv_danhsachphong.CurrentRow.Cells[0].Value.ToString());
            ctdp.Thanhtien = (loaiphong.Dongia_Time_LP * hours) + (loaiphong.DongiaLP_ngay * days);
            if(Chitiet_DatPhong_BUS.update_saukhichuyephong(ctdp))
            {
                MessageBox.Show("Đã chuyển phòng thành công.", "THÔNG BÁO");
            }    
        }
        public int GetDaysBetween(DateTime n1, DateTime n2)
        {
            TimeSpan ts = n2 - n1;
            return (int)ts.TotalDays;
        }

    }
}
