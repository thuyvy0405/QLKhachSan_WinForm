using BUS;
using DTO;
using Microsoft.SqlServer.Management.HadrModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_chitietdatphong : Form
    {
        public frm_chitietdatphong()
        {
            InitializeComponent();
        }
        private frm_Phong frmphong;
        private frm_DS_DatPhong frmdsdp;
        private NguoiDung_DTO nguoidung;
        private string tennv;
        public frm_chitietdatphong(int iddatphong, string tenkh, frm_Phong frmphong,NguoiDung_DTO nguoidung )
        {
            InitializeComponent();
            this.iddatphong = iddatphong;
            this.tenkh = tenkh;
            this.frmphong = frmphong;
            this.nguoidung = nguoidung;
        }

        public frm_chitietdatphong(int iddatphong, string tenkh, NguoiDung_DTO nguoidung, frm_DS_DatPhong frm_dsdp)
        {
            InitializeComponent();
            this.iddatphong = iddatphong;
            this.tenkh = tenkh;
            this.nguoidung = nguoidung;
            this.frmdsdp = frmdsdp;
        }
        private int iddatphong; private string tenkh;
        private List<DatPhong_DichVu_DTO> datPhong_DichVu_list = new List<DatPhong_DichVu_DTO>();

        private void itemThemDV_Click(object sender, EventArgs e)
        {
            frm_themdichvu_datphong themdichvu_Datphong = new frm_themdichvu_datphong(this, dgv_danhsachdichvu, iddatphong);
            themdichvu_Datphong.Show();
        }
        private void itemCapNhatThoiGianTra_Click(object sender, EventArgs e)
        {
            List<ChiTiet_DatPhong_DTO> listctdp = new List<ChiTiet_DatPhong_DTO>();
            foreach (DataGridViewRow row in dgv_danhsachphongdat.Rows)
            {
                ChiTiet_DatPhong_DTO ctdp = new ChiTiet_DatPhong_DTO();
                ctdp.IDDatPhong = iddatphong;
                ctdp.IDPhong = int.Parse(row.Cells[0].Value.ToString());
                ctdp.TenPhong = row.Cells[1].Value.ToString();
                ctdp.Ngaydat = DateTime.Parse(row.Cells[2].Value.ToString());
                ctdp.Ngaytra = DateTime.Parse(row.Cells[3].Value.ToString());
                ctdp.TenLoaiP = row.Cells[4].Value.ToString();
                ctdp.Thanhtien = double.Parse(row.Cells[5].Value.ToString());
                listctdp.Add(ctdp);
            }
            frm_capnhatthoigiantraphong cntgtp = new frm_capnhatthoigiantraphong(listctdp, this, frmphong);
            cntgtp.ShowDialog();
        }

        private void itemXoaDV_Click(object sender, EventArgs e)
        {
                DataGridViewRow rowselected = dgv_danhsachdichvu.CurrentRow;
                if (rowselected.Cells[0].Value != null && rowselected.Cells[1].Value != null && rowselected.Cells[2].Value != null && rowselected.Cells[3].Value != null && rowselected.Cells[4].Value != null && rowselected.Cells[5].Value != null && rowselected.Cells[6].Value != null)
                {
                    DatPhong_DichVu_DTO dpdv = new DatPhong_DichVu_DTO();
                    dpdv.IDDP = iddatphong;
                    dpdv.ID_PHONG1 = int.Parse(rowselected.Cells[0].Value.ToString());
                    dpdv.IDDV = int.Parse(rowselected.Cells[1].Value.ToString());
                    dpdv.SoluongDV = int.Parse(rowselected.Cells[3].Value.ToString());
                    dpdv.DongiaDV = double.Parse(rowselected.Cells[4].Value.ToString());
                    dpdv.ThanhtienDV = int.Parse(rowselected.Cells[5].Value.ToString());
                    dpdv.NgaySD_DV = DateTime.Parse(rowselected.Cells[6].Value.ToString());
                    dpdv.TenDV = rowselected.Cells[2].Value.ToString();
                    if (MessageBox.Show("Bạn có muốn xóa dịch vụ " + dpdv.TenDV + " không?", "XÁC NHẬN XÓA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (DatPhong_DichVu_BUS.Delete(dpdv))
                        {
                            LoadDanhSachDichVu_Dat();
                            ShowTienThanhToan();
                            MessageBox.Show("Đã xóa dịch vụ thành công", "THÔNG BÁO");
                        }
                        else
                            MessageBox.Show("Xóa không thành công. Vui lòng thử lại!", "THÔNG BÁO");
                    }
            }
        }

        private void itemCapNhatDV_Click(object sender, EventArgs e)
        {
                DataGridViewRow rowselected = dgv_danhsachdichvu.CurrentRow;
                if (rowselected.Cells[0].Value != null && rowselected.Cells[1].Value != null && rowselected.Cells[2].Value != null && rowselected.Cells[3].Value != null && rowselected.Cells[4].Value != null && rowselected.Cells[5].Value != null && rowselected.Cells[6].Value != null)
                {
                    DatPhong_DichVu_DTO dpdv = new DatPhong_DichVu_DTO();
                    dpdv.IDDP = iddatphong;
                    dpdv.ID_PHONG1 = int.Parse(rowselected.Cells[0].Value.ToString());
                    dpdv.IDDV = int.Parse(rowselected.Cells[1].Value.ToString());
                    dpdv.SoluongDV = int.Parse(rowselected.Cells[3].Value.ToString());
                    dpdv.DongiaDV = double.Parse(rowselected.Cells[4].Value.ToString());
                    dpdv.ThanhtienDV = int.Parse(rowselected.Cells[5].Value.ToString());
                    dpdv.NgaySD_DV = DateTime.Parse(rowselected.Cells[6].Value.ToString());
                    dpdv.TenDV = rowselected.Cells[2].Value.ToString();
                    frm_capnhatsoluongdichvu cnsldichvu = new frm_capnhatsoluongdichvu(this, dpdv, dgv_danhsachdichvu, dpdv.SoluongDV, rowselected.Index);
                    cnsldichvu.Show();
            }
        }


        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private DatPhong_DTO dp;

        private void frm_chitietdatphong_Load(object sender, EventArgs e)
        {
            if (nguoidung != null)
            {
                if (nguoidung.TenQuyen.ToLower() == "admin" || nguoidung.TenQuyen.ToLower() == "quản lý")
                    btn_capnhatphieudatphong.Enabled = true;
            }
            else
            {
                btn_capnhatphieudatphong.Enabled = true;
            }
            dp = DatPhong_BUS.LayTrangThaiDatPhong(iddatphong);
            if (dp.ID_trangthai1 == 3)
            {
                btn_thanhtoan.Text = "Đã thanh toán";
                btn_thanhtoan.Enabled = false;
            }    
            else
            {
                btn_capnhatphieudatphong.Visible = false;
            } 
            if(dp.ID_trangthai1==1)
            {
                btn_thanhtoan.Text = "Nhận Phòng";
                btn_thanhtoan.BackColor = Color.Purple;
                btn_thanhtoan.ForeColor = Color.White;
            }
            LoadDanhSachPhongDat();
            LoadDanhSachDichVu_Dat();
            txt_iddatphong.Text += " " + iddatphong.ToString();
            txttenkh.Text += " " + tenkh;
            ShowTienThanhToan();
        }
        public double ShowTienThanhToan()
        {
                double TongTienThanhToan;
                TongTienThanhToan = TongTienDV() + TongTienPhong();
                txt_tongtien.Text = TongTienThanhToan.ToString("c", new CultureInfo("vi-VN"));
                return TongTienThanhToan;
        }
        private void dgv_danhsachdichvu_MouseClick(object sender, MouseEventArgs e)
        {
            if (dp.ID_trangthai1 == 2 )
            {
                if (e.Button == MouseButtons.Right)
                {
                    ContextMenu cm = new ContextMenu();
                    cm.MenuItems.Add("Thêm dịch vụ", new EventHandler(itemThemDV_Click));
                    cm.MenuItems.Add("Chỉnh sửa", new EventHandler(itemCapNhatDV_Click));
                    cm.MenuItems.Add("Xóa", new EventHandler(itemXoaDV_Click));
                    cm.Show(dgv_danhsachdichvu, new Point(e.X, e.Y));

                }
            }

        }
        private double TongTienDV()
        {
            double tongtien = 0;
                foreach (DataGridViewRow row in dgv_danhsachdichvu.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null && row.Cells[3].Value != null && row.Cells[4].Value != null && row.Cells[5].Value != null && row.Cells[6].Value != null)
                    {
                        tongtien += double.Parse(row.Cells[5].Value.ToString());
                    }
                
            }
            return tongtien;
        }
        private double TongTienPhong()
        {
            double tongtien = 0;
                foreach (DataGridViewRow row in dgv_danhsachphongdat.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null && row.Cells[3].Value != null && row.Cells[4].Value != null && row.Cells[5].Value != null)
                    {
                        tongtien += double.Parse(row.Cells[5].Value.ToString());
                    }
                
            }
            return tongtien;
        }
        public void LoadDanhSachPhongDat()
        {
            List<ChiTiet_DatPhong_DTO> listctdp = Chitiet_DatPhong_BUS.LayCT_DATPHONG_THEOID(iddatphong);
            dgv_danhsachphongdat.DataSource = listctdp;
        }
        public void LoadDanhSachDichVu_Dat()
        {
            List<DatPhong_DichVu_DTO> listdvdp = DatPhong_DichVu_BUS.LayDSDichVu_DatPhong(iddatphong);
            dgv_danhsachdichvu.DataSource = listdvdp;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_dong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_thanhtoan_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dp.ID_trangthai1 == 2)
                {
                    if (MessageBox.Show("Bạn có muốn thanh toán phiếu đặt phòng không ?", "Xác nhận thanh toán đặt phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        HoaDon_DTO hdtt = new HoaDon_DTO();
                        hdtt.IDCty = 1;
                        if (nguoidung != null)
                            hdtt.IDNV = nguoidung.IDNV;
                        else
                            hdtt.IDNV = 1019;
                        hdtt.Tenkh = tenkh;
                        hdtt.NgayGD = DateTime.Now;
                        hdtt.TongHD = ShowTienThanhToan();
                        hdtt.IDDatphong = iddatphong;
                        if (HoaDon_BUS.add(hdtt))
                        {
                            MessageBox.Show("Đã thanh toán cho khách hàng!", "THÔNG BÁO");
                            CapNhatTrangThaiPhong();
                            DatPhong_DTO dp = new DatPhong_DTO();
                            dp.IDDatPhong = iddatphong;
                            DatPhong_BUS.CapNhatTrangthaiDatPhong(dp);
                            frm_inhoadonthanhtoan inhoadonthanhtoan = new frm_inhoadonthanhtoan(iddatphong);
                            inhoadonthanhtoan.ShowDialog();
                            if (frmphong != null)
                            {
                                frmphong.LoadPhongAuTo();
                            }
                            this.Close();
                        }
                    }
                }
                else
                {
                    try
                    {
                        ChiTiet_DatPhong_DTO ctdp = new ChiTiet_DatPhong_DTO();
                        ctdp.Ngaydat = DateTime.Parse(dgv_danhsachphongdat.Rows[0].Cells[2].Value.ToString());
                        int days = GetDaysBetween(DateTime.Now, ctdp.Ngaydat);
                        TimeSpan ts = ctdp.Ngaydat - DateTime.Now;
                        float hours = (float)ts.TotalHours;
                        float gionguyen = (int)ts.TotalHours;
                        float minites = (float)ts.TotalMinutes;
                        float remainder = hours % 24;
                        if (days == 0 && minites < 2 && minites >= 0)
                        {
                            bool trangthai = false;
                            for (int i = 0; i < dgv_danhsachphongdat.Rows.Count ; i++)
                            {
                                if (dgv_danhsachphongdat.Rows[i].Cells[0].Value.ToString() != null)
                                {
                                    Phong_DTO phong = new Phong_DTO();
                                    phong.IDPhong = int.Parse(dgv_danhsachphongdat.Rows[i].Cells[0].Value.ToString());
                                    trangthai = Phong_BUS.UpdateTrangThaiPhong_Thue(phong);
                                }
                            }
                            if (trangthai)
                            {
                                MessageBox.Show("Nhận phòng thành công", "THÔNG BÁO");
                                frmdsdp.LOADDSDP();
                                this.Close();
                            }
                            else
                                MessageBox.Show("LỖI: NHẬN PHÒNG CHO KHÁCH HÀNG KHÔNG THÀNH CÔNG. VUI LÒNG THỬ LẠI", "THÔNG BÁO");
                        }
                        else if (days >= 0)
                        {
                            bool thanhcong = false;
                            if (MessageBox.Show("Ngày đặt phòng của khách hàng còn " + days.ToString() + " ngày " + gionguyen.ToString() + " giờ. Bạn có muốn nhận phòng cho khách ở thời gian hiện tại hay không ?", "XÁC NHẬN NHẬN PHÒNG", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                ChiTiet_DatPhong_DTO ctdp1 = new ChiTiet_DatPhong_DTO();
                                ctdp1.IDDatPhong = iddatphong;
                                ctdp1.Ngaydat = DateTime.Now;//set thời gian đặt phòng bằng thời gian hện tại
                                ctdp1.Ngaytra = DateTime.Parse(dgv_danhsachphongdat.Rows[0].Cells[3].Value.ToString());
                                int ngaythue = GetDaysBetween(ctdp1.Ngaydat, ctdp1.Ngaytra);// lấy số ngày thuê của khách
                                float giothue = (float)(ctdp1.Ngaytra - ctdp1.Ngaydat).TotalHours % 24; // lấy số giờ thuê
                                for (int i = 0; i < dgv_danhsachphongdat.Rows.Count; i++)
                                {
                                    if (dgv_danhsachphongdat.Rows[i].Cells[0].Value.ToString() != null)
                                    {
                                        Loai_Phong_DTO loaiphong = LoaiPhong_BUS.TimLoai_PhongtheoTenLoai(dgv_danhsachphongdat.Rows[i].Cells[4].Value.ToString());
                                        ctdp1.Thanhtien = (loaiphong.Dongia_Time_LP * hours) + (loaiphong.DongiaLP_ngay * days);
                                        ctdp1.IDPhong = int.Parse(dgv_danhsachphongdat.Rows[i].Cells[0].Value.ToString());
                                        Chitiet_DatPhong_BUS.CapNhat_NhanPhong(ctdp1);
                                        Phong_DTO phong = new Phong_DTO();
                                        phong.IDPhong = int.Parse(dgv_danhsachphongdat.Rows[i].Cells[0].Value.ToString());
                                        thanhcong = Phong_BUS.UpdateTrangThaiPhong_Thue(phong);
                                    }
                                }
                                if (thanhcong)
                                {
                                    DatPhong_BUS.CapNhatTrangthaiDatPhong_Dangthue(iddatphong);
                                    MessageBox.Show("Nhận phòng thành công", "THÔNG BÁO");
                                    if(frmdsdp!= null)
                                        frmdsdp.LOADDSDP();
                                    this.Close();
                                }
                                else
                                    MessageBox.Show("LỖI: NHẬN PHÒNG CHO KHÁCH HÀNG KHÔNG THÀNH CÔNG. VUI LÒNG THỬ LẠI", "THÔNG BÁO");

                            }
                        }
                    }
                    catch { }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }
        public int GetDaysBetween(DateTime n1, DateTime n2)
        {
            TimeSpan ts = n2 - n1;
            return (int)ts.TotalDays;
        }

        private void CapNhatTrangThaiPhong()
        {
            foreach (DataGridViewRow row in dgv_danhsachphongdat.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null && row.Cells[3].Value != null && row.Cells[4].Value != null && row.Cells[5].Value != null)
                {
                    Phong_DTO p = new Phong_DTO();
                    p.IDPhong = int.Parse(row.Cells[0].Value.ToString());
                    Phong_BUS.UpdateTrangThaiPhong_trangthai(p, 3);
                }
            }
        }

        private void dgv_danhsachphongdat_MouseClick(object sender, MouseEventArgs e)
        {
            if (btn_thanhtoan.Text !="Đã thanh toán")
            {
                if (e.Button == MouseButtons.Right)
                {
                    ContextMenu cm = new ContextMenu();
                    cm.MenuItems.Add("Cập nhật thời gian trả phòng", new EventHandler(itemCapNhatThoiGianTra_Click));
                    cm.Show(dgv_danhsachdichvu, new Point(e.X, e.Y));
                }
            }
        }
        private void dgv_danhsachdichvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_capnhatphieudatphong_Click(object sender, EventArgs e)
        {
            if (btn_capnhatphieudatphong.Text == "Chỉnh sửa")
            {
                dp.ID_trangthai1 = 2;
                btn_capnhatphieudatphong.Text = "Lưu";
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn cập nhật lại phiếu đặt phòng không?", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    HoaDon_DTO hdtt = new HoaDon_DTO();
                    if (nguoidung != null)
                        hdtt.IDNV = nguoidung.IDNV;
                    else
                        hdtt.IDNV = 1019;
                    hdtt.NgayGD = DateTime.Now;
                    hdtt.TongHD = ShowTienThanhToan();
                    hdtt.IDDatphong = iddatphong;
                    if (HoaDon_BUS.Update(hdtt))
                    {
                        MessageBox.Show("Đã cập nhật lại phiếu đặt phòng cho khách hàng!", "THÔNG BÁO");
                        DatPhong_DTO dp = new DatPhong_DTO();
                        dp.IDDatPhong = iddatphong;
                        frm_inhoadonthanhtoan inhoadonthanhtoan = new frm_inhoadonthanhtoan(iddatphong);
                        inhoadonthanhtoan.ShowDialog();
                        if (frmphong != null)
                        {
                            frmphong.LoadPhongAuTo();
                        }
                        this.Close();
                    }
                    dp.ID_trangthai1 = 3;
                    btn_capnhatphieudatphong.Text = "Chỉnh sửa";
                }
                else
                {
                    dp.ID_trangthai1 = 3;
                    btn_capnhatphieudatphong.Text = "Chỉnh sửa";
                }    
            }
        }
    }
}
