using BUS;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyKhachSan
{
    public partial class frm_DatPhong : Form
    {
        private int vitri;
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        DatPhong_DTO dp = new DatPhong_DTO();
        ChiTiet_DatPhong_DTO ctdp = new ChiTiet_DatPhong_DTO();
        private float dongiangay, dongiagio;
        private frm_Phong frm_Phong;
        private frm_DS_DatPhong frmdsdp;

        public frm_DatPhong(frm_Phong frm_Phong)
        {
            InitializeComponent();
            this.frm_Phong = frm_Phong;
        }
        public frm_DatPhong(frm_DS_DatPhong frmđsdp)
        {
            InitializeComponent();
            this.frmdsdp = frmđsdp;
        }
        public frm_DatPhong()
        {
            InitializeComponent();
        }
        private void DatPhong_Load(object sender, EventArgs e)
        {
            LoadDSPhongTRONG();
            cbb_chon.SelectedIndex = 0;
        }

        private void LoadDSPhongTRONG()
        {
            List<Phong_DTO> lstDSPhongTrong = DatPhong_BUS.LayDSPhongTrong();
            dgv_PhongTrong.DataSource = lstDSPhongTrong;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_Hoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_SDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_CCCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_DCHi_TextChanged(object sender, EventArgs e)
        {

        }
        KhachHang_DTO kh = new KhachHang_DTO();
        private void btn_TimKH_Click(object sender, EventArgs e)
        {
            try
            {
               if (cbb_chon.SelectedIndex == 0)
                {
                    kh = KhachHang_BUS.TimKhachhangtheoCCCD(txt_TimKH.Text);
                    if (kh != null)
                    {
                        txt_Hoten.Text = kh.TenKH;
                        txt_SDT.Text = kh.SDT_Kh;
                        txt_CCCD.Text = kh.CCCD_KH;
                        txt_Email.Text = kh.Email_KH;
                        txt_DCHi.Text = kh.Dchi_KH;
                        cbb_Gioitinh.Text = kh.Phai;
                        lb_tb_KHdaco.Visible = true;
                        lb_tb_Khchuaco.Visible = false;
                    }
                    else
                    {
                        txt_CCCD.Text = txt_TimKH.Text;
                        lb_tb_Khchuaco.Visible = true;
                        lb_tb_KHdaco.Visible = false;
                    }    
                }
                else 
                {
                   kh= KhachHang_BUS.TimKhachhangtheoSDT(txt_TimKH.Text);
                    if (kh != null)
                    {
                        txt_Hoten.Text = kh.TenKH;
                        txt_SDT.Text = kh.SDT_Kh;
                        txt_CCCD.Text = kh.CCCD_KH;
                        txt_Email.Text = kh.Email_KH;
                        txt_DCHi.Text = kh.Dchi_KH;
                        cbb_Gioitinh.Text = kh.Phai;
                        lb_tb_KHdaco.Visible = true;
                        lb_tb_Khchuaco.Visible = false;
                    }
                    else
                    {
                        txt_SDT.Text = txt_TimKH.Text;
                        lb_tb_Khchuaco.Visible = true;
                        lb_tb_KHdaco.Visible = false;
                    }
                }
                

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi!", "Thông báo ");
            }
        }

        private void txt_TimKH_Leave(object sender, EventArgs e)
        {
            if (txt_TimKH.Text != "")
            {

            }
            else
                txt_TimKH.Text = "Nhập để tìm kiếm";
        }

        private void txt_TimKH_Click(object sender, EventArgs e)
        {
            if (txt_TimKH.Text == "Nhập để tìm kiếm")
                txt_TimKH.Clear();
        }

        private void txt_Hoten_Leave(object sender, EventArgs e)
        {
            if (txt_TimKH.Text != "")
            {

            }
            else
                txt_TimKH.Text = "Nhập họ tên";
        }

        private void txt_Hoten_Click(object sender, EventArgs e)
        {
            if (txt_Hoten.Text == "Nhập họ tên")
                txt_Hoten.Clear();
        }

        private void txt_SDT_Leave(object sender, EventArgs e)
        {
            if (txt_SDT.Text != "")
            {

            }
            else
                txt_SDT.Text = "Nhập số điện thoại";
        }

        private void txt_SDT_Click(object sender, EventArgs e)
        {
            if (txt_SDT.Text == "Nhập số điện thoại")
                txt_SDT.Clear();
        }

        private void txt_CCCD_Click(object sender, EventArgs e)
        {
            if (txt_CCCD.Text == "Nhập cccd")
                txt_CCCD.Clear();
        }

        private void txt_CCCD_Leave(object sender, EventArgs e)
        {
            if (txt_CCCD.Text != "")
            {

            }
            else
                txt_CCCD.Text = "Nhập cccd";
        }

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            if (txt_Email.Text != "")
            {

            }
            else
                txt_Email.Text = "Nhập email";

        }

        private void txt_Email_Click(object sender, EventArgs e)
        {
            if (txt_Email.Text == "Nhập email")
                txt_Email.Clear();
        }

        private void txt_DCHi_Leave(object sender, EventArgs e)
        {
            if (txt_DCHi.Text != "")
            {

            }
            else
                txt_DCHi.Text = "Nhập địa chỉ";
        }

        private void txt_DCHi_Click(object sender, EventArgs e)
        {
            if (txt_DCHi.Text == "Nhập địa chỉ")
                txt_DCHi.Clear();
        }

        private void dgv_PhongTrong_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                {
                    if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y))
                    {
                        DragDropEffects dropEffect = dgv_PhongTrong.DoDragDrop(dgv_PhongTrong.Rows[rowIndexFromMouseDown], DragDropEffects.Copy);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thao quá nhanh. Vui lòng thử lại." + ex.Message, "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        private void dgv_PhongTrong_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                rowIndexFromMouseDown = dgv_PhongTrong.HitTest(e.X, e.Y).RowIndex;
                if (rowIndexFromMouseDown != -1)
                {
                    Size dragSize = SystemInformation.DragSize;
                    dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
                }
                else
                    dragBoxFromMouseDown = Rectangle.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao quá nhanh . Vui lòng thử lại." + ex.Message, "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        private void dgv_phongChon_DragOver(object sender, DragEventArgs e)
        {
            try
            {
                e.Effect = DragDropEffects.Copy;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao quá nhanh . Vui lòng thử lại." + ex.Message, "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }
        private bool check_Phong(string id)
        {
            if (dgv_phongChon.Rows.Count > 0)
            {
                try
                {
                    for (int i = 0; i < dgv_phongChon.RowCount - 1; i++)
                    {
                        if (id == (string)dgv_phongChon.Rows[i].Cells[0].Value)
                        {
                            vitri = i;
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
            return true;
        }
        private bool SoSanhNgay(string ngaybd, string ngaykt,string t1, string t2)
        {
            DateTime dt1 = DateTime.Parse(ngaybd);
            DateTime dt2 = DateTime.Parse(ngaykt);
            DateTime s1 = DateTime.Parse(t1);
            DateTime s2 = DateTime.Parse(t2);
            if (dt1 > dt2)
             {
                 return false;
             }
            if(dt1 == dt2)
             {
                 if (s1.Hour >= s2.Hour)
                 {
                     return false;
                 }
             }
            return true;
        }
        private void dgv_phongChon_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                DataGridViewRow row = (DataGridViewRow)e.Data.GetData(typeof(DataGridViewRow)); // Lấy dữ liệu dòng dssp
                if ((string)row.Cells[0].Value != null && (string)row.Cells[1].Value != null && (string)row.Cells[2].Value != null)// nếu tất cả các cell khác null
                {
                    if (check_Phong((string)row.Cells[0].Value))
                    {
                        if (CheckNgayLonHon(DateTime.Parse(date_NgayStart.Text + " " + Time_start.Text), DateTime.Parse(date_NgayEnd.Text + " " + Time_End.Text)))
                        {
                            dgv_phongChon.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, date_NgayStart.Text + " " + Time_start.Text, date_NgayEnd.Text + " " + Time_End.Text);
                        }
                    }
                    else
                    {
                        dgv_phongChon.Rows[vitri].Selected = false;
                        MessageBox.Show("Phòng đã tồn tại trong danh sách chọn.", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao quá nhanh . Vui lòng thử lại." + ex.Message, "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }

}

        private void dgv_phongChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                try
                {
                     DataGridViewRow rowToMove = dgv_phongChon.CurrentRow;
                     if (rowToMove.Cells[0].Value != null && rowToMove.Cells[1].Value != null && rowToMove.Cells[2].Value != null && (string)rowToMove.Cells[3].Value != null && (string)rowToMove.Cells[4].Value != null)
                     {
                         foreach (DataGridViewRow row in dgv_PhongTrong.Rows)
                     {     
                             if ((string)row.Cells[0].Value == (string)dgv_phongChon.Rows[dgv_phongChon.CurrentRow.Index].Cells[0].Value)
                             {
                                 dgv_phongChon.Rows.Remove(dgv_phongChon.CurrentRow);
                                 break;
                             }
                         }
                     }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thao quá nhanh . Vui lòng thử lại." + ex.Message, "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
            }
        }
        private void ADDDSDatPhong()
        {
            KhachHang_DTO kh = new KhachHang_DTO();        
            kh= KhachHang_BUS.TimKhachhangtheoCCCD(txt_CCCD.Text);
            DatPhong_DTO dp = new DatPhong_DTO();
            dp.IDKH = kh.IDKH;
            dp.NgaylapphieuDP = DateTime.Now;
            if (DateTime.Parse(date_NgayStart.Text + " " + Time_start.Text) >= DateTime.Now)
            {
                dp.ID_trangthai1 = 1;
            }
            else
                dp.ID_trangthai1 = 2;
            DatPhong_BUS.add(dp);
        }
        private void ADDChitietDP()
        {
            foreach (DataGridViewRow row in dgv_phongChon.Rows)
            {
                ChiTiet_DatPhong_DTO ctdp = new ChiTiet_DatPhong_DTO();
                HoaDon_DTO HD = HoaDon_BUS.TimHDtheoID();
                ctdp.IDDatPhong = HD.IDDatphong;
                ctdp.IDPhong = row.Cells[0].RowIndex;
                ctdp.Ngaydat =DateTime.Parse( date_NgayStart.Text + " " + Time_start.Text);
                ctdp.Ngaytra = DateTime.Parse(date_NgayEnd.Text + " " + Time_End.Text);
                Chitiet_DatPhong_BUS.add(ctdp);
            }
            
        }    

        private bool Check_thongtinkhachhang()
        {
            if (txt_Hoten.Text == "Nhập họ tên" &&
            txt_SDT.Text == "Nhập số điện thoại" &&
            txt_CCCD.Text == "Nhập CCCD" &&
            cbb_Gioitinh.Text == "Chọn giới tính")
            {
                if (MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)

              return false;
            }
            return true;
        }
        private bool CheckNgayLonHon(DateTime t1, DateTime t2)
        {
            int days = GetDaysBetween(DateTime.Now, t1);
            TimeSpan ts = DateTime.Now - t1;
            float minites = (float)ts.TotalMinutes;
            if (t1 == t2)
            {
                MessageBox.Show("Vui lòng chọn lại thời gian đặt phòng. Ngày đặt và ngày trả không được bằng nhau!", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                Time_start.Focus();
                return false;
            }
            if (t1 < DateTime.Now  && minites >3)
            {
                MessageBox.Show("Ngày bắt đầu không được nhỏ hơn ngày hiện tại.", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                date_NgayStart.Focus();
                return false;
            }
            if (t1 > t2)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc.", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                date_NgayStart.Focus();
                return false;
            }
            return true;
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            KhachHang_DTO kh1;
            if (cbb_chon.SelectedIndex == 0)
            {
                kh1 = KhachHang_BUS.TimKhachhangtheoCCCD(txt_TimKH.Text);
            }
            else
            {
                kh1 = KhachHang_BUS.TimKhachhangtheoSDT(txt_TimKH.Text);
            }
            try
                {
                if (Check_thongtinkhachhang())
                {
                    if (kh1 == null)
                    {
                        kh1 = new KhachHang_DTO();
                        kh1.TenKH = txt_Hoten.Text.Trim();
                        kh1.SDT_Kh = txt_SDT.Text.Trim();
                        kh1.CCCD_KH = txt_CCCD.Text.Trim();
                        if (txt_Email.Text != "Nhập email")
                            kh1.Email_KH = txt_Email.Text.Trim();
                        else
                            kh1.Email_KH = "";
                        if (txt_DCHi.Text != "Nhập địa chỉ")
                            kh1.Dchi_KH = txt_DCHi.Text.Trim();
                        else
                            kh1.Dchi_KH = "";
                        kh1.Phai = cbb_Gioitinh.Text.Trim();
                        if (KhachHang_BUS.add(kh1))
                            MessageBox.Show("Hệ thống đã tự động thêm mới khách hàng.", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        else
                        {
                            MessageBox.Show("Vui lòng kiểm tra lại các trường thông tin của khách hàng. (Số điện thoại hoặc CCCD)! ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            return;
                        }

                    }
                    if (CheckNgayLonHon(DateTime.Parse(date_NgayStart.Text + " " + Time_start.Text), DateTime.Parse(date_NgayEnd.Text + " " + Time_End.Text)))
                    {
                        if (MessageBox.Show("Bạn có chắc muốn lưu phiếu đặt phòng? ", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                bool thanhcong = false;
                                ADDDSDatPhong();
                                foreach (DataGridViewRow row in dgv_phongChon.Rows)
                                {
                                    if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null && row.Cells[3].Value != null && row.Cells[4].Value != null)
                                    {
                                        Phong_DTO p = Phong_BUS.TimPhongTheoTen(row.Cells[0].Value.ToString());
                                        ChiTiet_DatPhong_DTO ctdp = new ChiTiet_DatPhong_DTO();
                                        HoaDon_DTO HD = HoaDon_BUS.TimHDtheoID();// Lấy đặt phòng vừa mới tạo thành công
                                        ctdp.IDDatPhong = HD.IDDatphong;// Gán 
                                        ctdp.IDPhong = p.IDPhong;
                                        ctdp.Ngaydat = DateTime.Parse(date_NgayStart.Text + " " + Time_start.Text);
                                        if (ctdp.Ngaydat <= DateTime.Now)
                                        {
                                            Phong_BUS.UpdateTrangThaiPhong_Thue(p);
                                        }
                                        else
                                        {
                                            Phong_BUS.UpdateTrangThaiPhong_Dat(p);
                                        }
                                        ctdp.Ngaytra = DateTime.Parse(date_NgayEnd.Text + " " + Time_End.Text);
                                        int days = GetDaysBetween(ctdp.Ngaydat, ctdp.Ngaytra);// lấy số ngày đặt của khách
                                                                                              // MessageBox.Show(days.ToString());
                                        float hours = (float)(ctdp.Ngaytra - ctdp.Ngaydat).TotalHours % 24; // Lấy phần dư số giờ
                                                                                                        //  MessageBox.Show(hours.ToString());
                                        Loai_Phong_DTO loaiphong = LoaiPhong_BUS.TimLoai_PhongtheoTenLoai(row.Cells[1].Value.ToString());
                                        // MessageBox.Show(loaiphong.DongiaLP_ngay.ToString());
                                        ctdp.Thanhtien = (loaiphong.Dongia_Time_LP * hours) + (loaiphong.DongiaLP_ngay * days);
                                        // MessageBox.Show(ctdp.Thanhtien.ToString());
                                        thanhcong = Chitiet_DatPhong_BUS.add(ctdp);
                                    }
                                }
                                if (thanhcong)
                                    if (MessageBox.Show("Lưu thành công! Bạn có thể muốn tiếp tục đặt phòng!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                                    {
                                        LoadDSPhongTRONG();
                                        dgv_phongChon.Rows.Clear();
                                        if (frm_Phong != null)
                                            frm_Phong.LoadPhongAuTo();// Cập nhật lại trạng thái phòng 
                                        if (frmdsdp != null)
                                            frmdsdp.LOADDSDP();// cap nhật lại danh sách dặt phòng
                                    }
                                    else
                                    {
                                        LoadDSPhongTRONG();
                                        dgv_phongChon.Rows.Clear();
                                        if (frm_Phong != null)
                                            frm_Phong.LoadPhongAuTo();// Cập nhật lại trạng thái phòng 
                                        if (frmdsdp != null)
                                            frmdsdp.LOADDSDP();// cap nhật lại danh sách dặt phòng
                                        this.Close();
                                    }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi không lưu thành công !" + ex.Message);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao quá nhanh. Vui lòng thử lại." + ex.Message, "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        public int GetDaysBetween(DateTime n1, DateTime n2)
        {
            TimeSpan ts = n2 - n1;
            return (int)ts.TotalDays;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbb_chon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    
    }
}
