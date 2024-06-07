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
    public partial class frm_capnhatthoigiantraphong : Form
    {
        private List<ChiTiet_DatPhong_DTO> ctdp;
        private frm_chitietdatphong frmctdp;
        private frm_Phong frm_Phong;
        public frm_capnhatthoigiantraphong(List<ChiTiet_DatPhong_DTO> ctdp, frm_chitietdatphong frmctdp, frm_Phong frm_Phong)
        {
            InitializeComponent();
            this.ctdp = ctdp;
            this.frmctdp = frmctdp;
            this.frm_Phong = frm_Phong;
        }

        private void frm_capnhatthoigiantraphong_Load(object sender, EventArgs e)
        {
            date_NgayStart.Text = ctdp[0].Ngaydat.ToString();
            Time_start.Text = ctdp[0].Ngaydat.ToString();
            date_NgayEnd.Text = ctdp[0].Ngaytra.ToString();
            Time_End.Text = ctdp[0].Ngaytra.ToString();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            bool thanhcong = false;
            if (GetDaysBetween(DateTime.Now, DateTime.Parse(date_NgayEnd.Text + " " + Time_End.Text)) < 0)
            {
                MessageBox.Show("Ngày trả không hợp lệ.");
                return;
            }
            foreach (ChiTiet_DatPhong_DTO ctdp in ctdp)
            {
                ctdp.Ngaytra = DateTime.Parse(date_NgayEnd.Text + " " + Time_End.Text);
                int days = GetDaysBetween(ctdp.Ngaydat, ctdp.Ngaytra);// lấy số ngày đặt của khách
                                                                  // MessageBox.Show(days.ToString());
                float hours = (float)(ctdp.Ngaytra - ctdp.Ngaydat).TotalHours % 24; // Lấy phần dư số giờ
                                                                                    //  MessageBox.Show(hours.ToString());
                Loai_Phong_DTO loaiphong = LoaiPhong_BUS.TimLoai_PhongtheoTenLoai(ctdp.TenLoaiP);
                // MessageBox.Show(loaiphong.DongiaLP_ngay.ToString());
                ctdp.Thanhtien = (loaiphong.Dongia_Time_LP * hours) + (loaiphong.DongiaLP_ngay * days);
                // MessageBox.Show(ctdp.Thanhtien.ToString());
                thanhcong = Chitiet_DatPhong_BUS.update_thoigiantraphong(ctdp);
            }
            if (thanhcong)
            {
                MessageBox.Show("Đã cập nhật thời gian trả phòng.");
                frmctdp.LoadDanhSachPhongDat();
                frmctdp.ShowTienThanhToan();
                if(frm_Phong != null)
                    frm_Phong.LoadPhongAuTo();
            }
            else
                MessageBox.Show("Cập nhật thời gian trả phòng KHÔNG thành công.");


        }
        public int GetDaysBetween(DateTime n1, DateTime n2)
        {
            TimeSpan ts = n2 - n1;
            return (int)ts.TotalDays;
        }

        private void check_ngahientai_CheckedChanged(object sender, EventArgs e)
        {
            if(check_ngahientai.Checked)
            {
                date_NgayEnd.Text = DateTime.Now.ToString();
                Time_End.Text = DateTime.Now.ToString();
            }    
            else
            {
                date_NgayEnd.Text = ctdp[0].Ngaytra.ToString();
                Time_End.Text = ctdp[0].Ngaytra.ToString();
            }    
        }
    }
}
