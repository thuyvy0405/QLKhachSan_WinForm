using BUS;
using DTO;
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
    public partial class frm_Phong : Form
    {
        private NguoiDung_DTO nguoidung;
        Timer MyTimer = new Timer();
        public frm_Phong()
        {
            InitializeComponent();
        }

        private void frm_Phong_Load(object sender, EventArgs e)
        {
            try
            {
                loadLoaiPhong();
                if (cbb_loaiphong.Items.Count > 0)
                    cbb_loaiphong.SelectedIndex = 1;
                flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
                LoadPhongAuTo();
                MyTimer.Interval = (1 * 60 * 1000); // 45 mins
                MyTimer.Tick += new EventHandler(MyTimer_Tick);
                MyTimer.Start();
                flowLayoutPanel1.ContextMenu = CreateContextMenu_Themphong();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
          
        }
        private void Check_NgayDenNhan()
        {
            try
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                bool capnhattrngahthai = false;
                if (listphong == null) return;
                foreach (Phong_DTO p in listphong)
                {
                    kh = DatPhong_BUS.TimKH_DatPhong(p.IDPhong.ToString());
                    if (kh != null)
                    {
                        if (p.IDPhong == kh.Id_phong)
                        {
                            int days = GetDaysBetween(DateTime.Now, kh.Ngaydatphong);
                            TimeSpan ts = kh.Ngaydatphong - DateTime.Now;
                            float hours = (float)ts.TotalHours;
                            float minites = (float)ts.TotalMinutes;
                            float remainder = hours % 24;
                            // MessageBox.Show(days.ToString() + " " + hours.ToString() + " " + minites.ToString() + " " + remainder.ToString());
                            if (days < 1 && minites < -30)
                            {
                                if (DatPhong_BUS.HuyDatPhong_KH(kh.Id_datphongphong, p.IDPhong))
                                {
                                    capnhattrngahthai = true;
                                    MessageBox.Show("Đã cập nhật lại trạng thái phòng TRỐNG cho " + p.TenPhong + "\n"
                                        + "LÝ DO: QUÁ 30 PHÚT KHÁCH KHÔNG ĐẾN NHẬN", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
                if (capnhattrngahthai)
                {
                    DatPhong_DTO dp = new DatPhong_DTO();
                    dp.IDDatPhong = kh.Id_datphongphong;
                    DatPhong_BUS.Delete(dp);
                }
            }
            catch { }

        }
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            Check_NgayDenNhan();
            LoadPhongAuTo();
        }
        List<Phong_DTO> listphong;

        public NguoiDung_DTO Nguoidung { get => nguoidung; set => nguoidung = value; }

        private ContextMenu CreateContextMenu_PhongTrong(Phong_DTO phongdto)
        {
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Cập nhật phòng", delegate (object sender, EventArgs e)
            {
                itemCNP_Click(sender, e, phongdto);
            });
            cm.MenuItems.Add("Đặt phòng", new EventHandler(itemDP_Click));
            cm.MenuItems.Add("Xóa phòng", delegate (object sender, EventArgs e)
            {
                itemXoa_Click(sender, e, phongdto);
            });
            return cm;
        }
        private ContextMenu CreateContextMenu_Themphong()
        {
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Thêm phòng", new EventHandler(itemThemPhong_Click));
            cm.MenuItems.Add("Làm mới", new EventHandler(itemLamMoi_Click));
            return cm;
        }
        private ContextMenu CreateContextMenu_PhongCoKHachO(int id_datphong, KhachHang_DTO khthue, Phong_DTO phongdto)
        {
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Chi tiết đặt phòng", delegate (object sender, EventArgs e)
            {
                item_xemctdp_Click(sender, e, id_datphong, khthue.TenKH);
            });
            cm.MenuItems.Add("Chuyển phòng", delegate (object sender, EventArgs e)
            {
                item_xemcp_Click(sender, e, id_datphong, phongdto, khthue);
            });
            return cm;
        }
        private ContextMenu CreateContextMenu_PhongKhachDat( Phong_DTO p, KhachHang_DTO khdat)
        {
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Nhận phòng", delegate (object sender, EventArgs e)
            {
                ChiTiet_DatPhong_DTO ctdp = new ChiTiet_DatPhong_DTO();
                ctdp.IDDatPhong = khdat.Id_datphongphong;
                ctdp.Ngaydat = khdat.Ngaydatphong;
                ctdp.Ngaytra = khdat.Ngaytraphong;
                ctdp.IDPhong = p.IDPhong;
                ctdp.TenLoaiP = p.TenLoaiPhong;
                itemNhanphong_Click(sender, e, ctdp);
            });
            cm.MenuItems.Add("Hủy đặt phòng", delegate (object sender, EventArgs e)
            {
                itemHuyDatPhong_Click(sender, e, khdat.Id_datphongphong, p);
            });
            return cm;
        }
        private ContextMenu CreateContextMenu_PhongSuachua_Dondep(Phong_DTO phongdto)
        {
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Cập nhật phòng", delegate (object sender, EventArgs e)
            {
                itemCNP_Click(sender, e, phongdto);
            });
            cm.MenuItems.Add("Xóa phòng", delegate (object sender, EventArgs e)
            {
                itemXoa_Click(sender, e, phongdto);
            }); return cm;
        }
        private void itemDP_Click(object sender, EventArgs e)
        {
            frm_DatPhong dp = new frm_DatPhong(this);
            dp.ShowDialog();
        }
        private void itemCNP_Click(object sender, EventArgs e, Phong_DTO phongdto)
        {
            frm_themphong dp = new frm_themphong(2,  this,phongdto);
            dp.ShowDialog();
        }
        private void itemLamMoi_Click(object sender, EventArgs e)
        {
            LoadPhongAuTo();
        }
        private void itemThemPhong_Click(object sender, EventArgs e)
        {
            frm_themphong themphong = new frm_themphong(1, this);
            themphong.ShowDialog();
        }
        private void item_xemcp_Click(object sender, EventArgs e, int id_datphong, Phong_DTO phongdto, KhachHang_DTO khthue)
        {
            frm_chuyenphong chuyenphong = new frm_chuyenphong(id_datphong, phongdto, this, khthue);
            chuyenphong.ShowDialog();
        }
        private void item_xemctdp_Click(object sender, EventArgs e, int id_datphong, string tenkh)
        {
            frm_chitietdatphong chitietdatphong = new frm_chitietdatphong(id_datphong, tenkh, this, nguoidung);
            chitietdatphong.ShowDialog();
        }
        private void itemTTP_Click(object sender, EventArgs e)
        {

        }
        private void itemXoa_Click(object sender, EventArgs e,Phong_DTO p)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa phòng không?","XÁC NHẬN XÓA",MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
               if( Phong_BUS.Dalete(p))
                {
                    MessageBox.Show("Xóa phòng thành công.","THÔNG BÁO");
                    LoadPhongAuTo();
                }    
            }    
        }
        private void itemNhanphong_Click(object sender, EventArgs e, ChiTiet_DatPhong_DTO ctdp)
        {
            try
            {
                int days = GetDaysBetween(DateTime.Now, ctdp.Ngaydat);
                TimeSpan ts = ctdp.Ngaydat - DateTime.Now;
                float hours = (float)ts.TotalHours;
                float gionguyen = (int)ts.TotalHours;
                float minites = (float)ts.TotalMinutes;
                float remainder = hours % 24;
                // MessageBox.Show(days.ToString() + " " + hours.ToString() + " " + minites.ToString() + " " + remainder.ToString());
                if (days == 0 && minites < 2 && minites >= 0)
                {
                    Phong_DTO p = new Phong_DTO(); p.IDPhong = ctdp.IDPhong;
                    if (Phong_BUS.UpdateTrangThaiPhong_Thue(p))
                    {
                        MessageBox.Show("Nhận phòng thành công", "THÔNG BÁO");
                        LoadPhongAuTo();
                    }
                    else
                        MessageBox.Show("LỖI: NHẬN PHÒNG CHO KHÁCH HÀNG KHÔNG THÀNH CÔNG. VUI LÒNG THỬ LẠI", "THÔNG BÁO");
                }
                else if (days >= 0)
                {
                    if (MessageBox.Show("Ngày đặt phòng của khách hàng còn " + days.ToString() + " ngày " + gionguyen.ToString() + " giờ. Bạn có muốn nhận phòng cho khách ở thời gian hiện tại hay không ?", "XÁC NHẬN NHẬN PHÒNG", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ctdp.Ngaydat = DateTime.Now;//set thời gian đặt phòng bằng thời gian hện tại
                        int ngaythue = GetDaysBetween(ctdp.Ngaydat, ctdp.Ngaytra);// lấy số ngày thuê của khách
                        float giothue = (float)(ctdp.Ngaytra - ctdp.Ngaydat).TotalHours % 24; // lấy số giờ thuê
                        Loai_Phong_DTO loaiphong = LoaiPhong_BUS.TimLoai_PhongtheoTenLoai(ctdp.TenLoaiP);
                        ctdp.Thanhtien = (loaiphong.Dongia_Time_LP * hours) + (loaiphong.DongiaLP_ngay * days);
                        if (Chitiet_DatPhong_BUS.CapNhat_NhanPhong(ctdp))
                        {
                            Phong_DTO p = new Phong_DTO(); p.IDPhong = ctdp.IDPhong;
                            if (Phong_BUS.UpdateTrangThaiPhong_Thue(p))
                            {
                                MessageBox.Show("Nhận phòng thành công", "THÔNG BÁO");
                                LoadPhongAuTo();
                            }
                        }
                        else
                            MessageBox.Show("LỖI: NHẬN PHÒNG CHO KHÁCH HÀNG KHÔNG THÀNH CÔNG. VUI LÒNG THỬ LẠI", "THÔNG BÁO");
                    }
                }
            }
            catch { }
        }
        private void itemHuyDatPhong_Click(object sender, EventArgs e, int ID_Datphong, Phong_DTO p)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn hủy đặt phòng không ?", "XÁC NHẬN HỦY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (DatPhong_BUS.HuyDatPhong_KH(ID_Datphong, p.IDPhong))
                    {
                        DatPhong_DTO dp = new DatPhong_DTO(); dp.IDDatPhong = ID_Datphong;
                        MessageBox.Show("Hủy đặt phòng thành công.", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (DatPhong_BUS.DemSoLuongPhongDat(ID_Datphong) == null)
                            DatPhong_BUS.Delete(dp);
                        LoadPhongAuTo();
                    }
                    else
                        MessageBox.Show("Lỗi. Vui lòng thử lại.", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
            }
            catch { }
        }
        private int checkTrangthai()
        {
            int trangthai = 1;
            if (rad_tt_trong.Checked)
                trangthai = 1;
            else if (rad_tt_dánguachua.Checked)
                trangthai = 2;
            else if (rad_tt_chuadon.Checked)
                trangthai = 3;
            else if (rad_tt_thuephong.Checked)
                trangthai = 4;
            else
                trangthai = 5;
            return trangthai;
        }    
        public void LoadPhongAuTo() // LOAD phòng TỰ ĐỘNG BẰNG CODE
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                listphong = new List<Phong_DTO>();
                if (check_chontimkiem.Checked)
                {
                    listphong = Phong_BUS.LayDSPHongAll_TheoDieuKien(int.Parse(cbb_loaiphong.SelectedValue.ToString()), checkTrangthai());
                }
                else
                    listphong = Phong_BUS.LayDSPHongAll();
                int i = 1;
                if (listphong == null)
                {
                    return;
                }
                foreach (Phong_DTO phongdto in listphong)
                {
                    if (phongdto.IDTrangThai == 1)//phong trong
                    {
                        Button PHONG = new Button();
                        PHONG = new System.Windows.Forms.Button();
                        PHONG.BackColor = System.Drawing.Color.White;
                        PHONG.ContextMenu = CreateContextMenu_PhongTrong(phongdto);
                        PHONG.Image = System.Drawing.Image.FromFile(@"D:\DABC_LTQL\phongchuadat.png");
                        PHONG.ImageAlign = ContentAlignment.BottomLeft;
                        PHONG.TextAlign = ContentAlignment.MiddleRight;
                        //PHONG.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        PHONG.Name = phongdto.IDPhong.ToString();
                        PHONG.TabIndex = i;
                        string tienphong = phongdto.DongiaPhong1.ToString("c", new CultureInfo("vi-VN"));
                        string tienphonggio = phongdto.DongiaGio1.ToString("c", new CultureInfo("vi-VN"));
                        PHONG.Text = "Phòng: " + phongdto.TenPhong.ToString() + "\n" +
                            "Giá ngày: " + tienphong + "\n" +
                            "Giá giờ: " + tienphonggio + "\n" +
                            "Loại: " + phongdto.TenLoaiPhong.ToString() + "\n" +
                            "Tầng: " + phongdto.SoTang.ToString();

                        PHONG.ForeColor = Color.Teal;
                        //  PHONG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                        PHONG.Size = new System.Drawing.Size(200, 130);
                        PHONG.TabIndex = i;
                        flowLayoutPanel1.Controls.Add(PHONG);
                        flowLayoutPanel1.Update();
                    }
                    else if (phongdto.IDTrangThai == 2)//phong đag sửa chữa
                    {
                        Button PHONG = new Button();
                        PHONG = new System.Windows.Forms.Button();
                        PHONG.BackColor = System.Drawing.Color.GreenYellow;
                        PHONG.ContextMenu = CreateContextMenu_PhongSuachua_Dondep(phongdto);
                        PHONG.Image = System.Drawing.Image.FromFile(@"D:\DABC_LTQL\phongdangsuachua.png");
                        PHONG.ImageAlign = ContentAlignment.BottomLeft;
                        PHONG.TextAlign = ContentAlignment.MiddleRight;
                        //PHONG.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        PHONG.Name = phongdto.IDPhong.ToString();
                        PHONG.TabIndex = i;
                        string tienphong = phongdto.DongiaPhong1.ToString("c", new CultureInfo("vi-VN"));
                        string tienphonggio = phongdto.DongiaGio1.ToString("c", new CultureInfo("vi-VN"));
                        PHONG.Text = "Phòng: " + phongdto.TenPhong.ToString() + "\n" +
                            "Giá ngày: " + tienphong + "\n" +
                            "Giá giờ: " + tienphonggio + "\n" +
                            "Loại: " + phongdto.TenLoaiPhong.ToString() + "\n" +
                            "Tầng: " + phongdto.SoTang.ToString();
                        PHONG.ForeColor = Color.Teal;
                        //  PHONG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                        PHONG.Size = new System.Drawing.Size(200, 130);
                        PHONG.TabIndex = i;
                        flowLayoutPanel1.Controls.Add(PHONG);
                        flowLayoutPanel1.Update();
                    }
                    else if (phongdto.IDTrangThai == 3)//phong chưa dọn dẹp
                    {
                        Button PHONG = new Button();
                        PHONG = new System.Windows.Forms.Button();
                        PHONG.ContextMenu = CreateContextMenu_PhongSuachua_Dondep(phongdto);
                        PHONG.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                        PHONG.Image = System.Drawing.Image.FromFile(@"D:\DABC_LTQL\phongchuadon.png");
                        PHONG.ImageAlign = ContentAlignment.BottomLeft;
                        PHONG.TextAlign = ContentAlignment.MiddleRight;
                        //PHONG.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        PHONG.Name = phongdto.IDPhong.ToString();
                        PHONG.TabIndex = i;
                        string tienphong = phongdto.DongiaPhong1.ToString("c", new CultureInfo("vi-VN"));
                        string tienphonggio = phongdto.DongiaGio1.ToString("c", new CultureInfo("vi-VN"));
                        PHONG.Text = "Phòng: " + phongdto.TenPhong.ToString() + "\n" +
                            "Giá ngày: " + tienphong + "\n" +
                            "Giá giờ: " + tienphonggio + "\n" +
                            "Loại: " + phongdto.TenLoaiPhong.ToString() + "\n" +
                            "Tầng: " + phongdto.SoTang.ToString();

                        PHONG.ForeColor = Color.Teal;
                        //  PHONG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                        PHONG.Size = new System.Drawing.Size(200, 130);
                        PHONG.TabIndex = i;
                        flowLayoutPanel1.Controls.Add(PHONG);
                        flowLayoutPanel1.Update();
                    }

                    else if (phongdto.IDTrangThai == 4)// phong da co khach DAG O
                    {
                        KhachHang_DTO kh_thue = DatPhong_BUS.TimKH_ThuePhong(phongdto.IDPhong.ToString());
                        Button PHONG = new Button();
                        PHONG = new System.Windows.Forms.Button();
                        PHONG.BackColor = System.Drawing.Color.BlueViolet;
                        PHONG.ContextMenu = CreateContextMenu_PhongCoKHachO(kh_thue.Id_datphongphong, kh_thue, phongdto);
                        PHONG.Image = System.Drawing.Image.FromFile(@"D:\DABC_LTQL\phongcokhacho.png");
                        PHONG.ImageAlign = ContentAlignment.BottomLeft;
                        PHONG.TextAlign = ContentAlignment.TopRight;
                        PHONG.ForeColor = Color.Black;
                        PHONG.Name = phongdto.IDPhong.ToString();
                        PHONG.TabIndex = i;
                        //  string tienphong = phongdto.DongiaPhong1.ToString("c", new CultureInfo("vi-VN"));
                        int days = GetDaysBetween(DateTime.Now, kh_thue.Ngaytraphong);
                        TimeSpan ts = kh_thue.Ngaytraphong - DateTime.Now;
                        float hours = (float)ts.TotalHours;
                        float minites = (float)ts.TotalMinutes;
                        float remainder = hours % 24;
                        if (days <= 0 && remainder <= 12)
                        {
                            PHONG.BackColor = Color.DarkBlue;
                            PHONG.ForeColor = Color.Black;
                        }
                        else
                        {
                            PHONG.ForeColor = Color.Black;

                        }
                        //PHONG.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        if ((int)(remainder) > 0)
                        {

                            PHONG.Text = "Phòng: " + phongdto.TenPhong.ToString() + "\n" +
                            kh_thue.TenKH + "\n"
                            + "SĐT: " + kh_thue.SDT_Kh + "\n"
                            + "Còn: " + days + " ngày " + (int)remainder + " giờ.";
                        }
                        else
                        {
                            PHONG.Text = "Phòng: " + phongdto.TenPhong.ToString() + "\n" +
                            kh_thue.TenKH + "\n"
                            + "SĐT: " + kh_thue.SDT_Kh + "\n"
                            + "Còn: " + days + " ngày " + (int)minites + " phút.";
                        }
                        //  PHONG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                        PHONG.Size = new System.Drawing.Size(200, 130);
                        PHONG.TabIndex = i;
                        flowLayoutPanel1.Controls.Add(PHONG);
                        flowLayoutPanel1.Update();

                    }
                    else if (phongdto.IDTrangThai == 5)// phong da co khach dat
                    {
                        KhachHang_DTO kh_dat = DatPhong_BUS.TimKH_DatPhong(phongdto.IDPhong.ToString());
                        Button PHONG = new Button();
                        PHONG = new System.Windows.Forms.Button();
                        PHONG.ContextMenu = CreateContextMenu_PhongKhachDat(phongdto, kh_dat);
                        PHONG.BackColor = System.Drawing.Color.MediumPurple;
                        PHONG.Image = System.Drawing.Image.FromFile(@"D:\DABC_LTQL\phongdadat.png");
                        PHONG.ImageAlign = ContentAlignment.BottomLeft;
                        PHONG.TextAlign = ContentAlignment.TopRight;
                        PHONG.ForeColor = Color.Black;
                        PHONG.Name = phongdto.IDPhong.ToString();
                        PHONG.TabIndex = i;
                        //  string tienphong = phongdto.DongiaPhong1.ToString("c", new CultureInfo("vi-VN"));
                        PHONG.ForeColor = Color.White;
                        PHONG.Text = "Phòng: " + phongdto.TenPhong.ToString() + "\n" +
                            kh_dat.TenKH + "\n"
                            + "SĐT: " + kh_dat.SDT_Kh + "\n"
                            + "Ngày đến nhận:\n" + kh_dat.Ngaydatphong + "";
                        //  PHONG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                        PHONG.Size = new System.Drawing.Size(200, 130);
                        PHONG.TabIndex = i;
                        flowLayoutPanel1.Controls.Add(PHONG);
                        flowLayoutPanel1.Update();

                    }
                    i++;
                }
            }
            catch { }
        }
        public void LoadPhongAuTo_TheoTen() // LOAD phong TỰ ĐỘNG BẰNG CODE theo tên phòng
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                listphong = new List<Phong_DTO>();
                listphong = Phong_BUS.LayDSPHongAll_TheoTen(txt_timphong.Text.Trim().ToUpper());
                int i = 1;
                if (listphong == null)
                {
                    return;
                }
                foreach (Phong_DTO phongdto in listphong)
                {
                    if (phongdto.IDTrangThai == 1)//phong trong
                    {
                        Button PHONG = new Button();
                        PHONG = new System.Windows.Forms.Button();
                        PHONG.BackColor = System.Drawing.Color.White;
                        PHONG.ContextMenu = CreateContextMenu_PhongTrong(phongdto);
                        PHONG.Image = System.Drawing.Image.FromFile(@"D:\DABC_LTQL\phongchuadat.png");
                        PHONG.ImageAlign = ContentAlignment.BottomLeft;
                        PHONG.TextAlign = ContentAlignment.MiddleRight;
                        //PHONG.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        PHONG.Name = phongdto.IDPhong.ToString();
                        PHONG.TabIndex = i;
                        string tienphong = phongdto.DongiaPhong1.ToString("c", new CultureInfo("vi-VN"));
                        string tienphonggio = phongdto.DongiaGio1.ToString("c", new CultureInfo("vi-VN"));
                        PHONG.Text = "Phòng: " + phongdto.TenPhong.ToString() + "\n" +
                            "Giá ngày: " + tienphong + "\n" +
                            "Giá giờ: " + tienphonggio + "\n" +
                            "Loại: " + phongdto.TenLoaiPhong.ToString() + "\n" +
                            "Tầng: " + phongdto.SoTang.ToString();

                        PHONG.ForeColor = Color.Teal;
                        //  PHONG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                        PHONG.Size = new System.Drawing.Size(200, 130);
                        PHONG.TabIndex = i;
                        flowLayoutPanel1.Controls.Add(PHONG);
                        flowLayoutPanel1.Update();
                    }
                    else if (phongdto.IDTrangThai == 2)//phong đag sửa chữa
                    {
                        Button PHONG = new Button();
                        PHONG = new System.Windows.Forms.Button();
                        PHONG.BackColor = System.Drawing.Color.GreenYellow;
                        PHONG.ContextMenu = CreateContextMenu_PhongSuachua_Dondep(phongdto);
                        PHONG.Image = System.Drawing.Image.FromFile(@"D:\DABC_LTQL\phongdangsuachua.png");
                        PHONG.ImageAlign = ContentAlignment.BottomLeft;
                        PHONG.TextAlign = ContentAlignment.MiddleRight;
                        //PHONG.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        PHONG.Name = phongdto.IDPhong.ToString();
                        PHONG.TabIndex = i;
                        string tienphong = phongdto.DongiaPhong1.ToString("c", new CultureInfo("vi-VN"));
                        string tienphonggio = phongdto.DongiaGio1.ToString("c", new CultureInfo("vi-VN"));
                        PHONG.Text = "Phòng: " + phongdto.TenPhong.ToString() + "\n" +
                            "Giá ngày: " + tienphong + "\n" +
                            "Giá giờ: " + tienphonggio + "\n" +
                            "Loại: " + phongdto.TenLoaiPhong.ToString() + "\n" +
                            "Tầng: " + phongdto.SoTang.ToString();
                        PHONG.ForeColor = Color.Teal;
                        //  PHONG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                        PHONG.Size = new System.Drawing.Size(200, 130);
                        PHONG.TabIndex = i;
                        flowLayoutPanel1.Controls.Add(PHONG);
                        flowLayoutPanel1.Update();
                    }
                    else if (phongdto.IDTrangThai == 3)//phong chưa dọn dẹp
                    {
                        Button PHONG = new Button();
                        PHONG = new System.Windows.Forms.Button();
                        PHONG.ContextMenu = CreateContextMenu_PhongSuachua_Dondep(phongdto);
                        PHONG.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                        PHONG.Image = System.Drawing.Image.FromFile(@"D:\DABC_LTQL\phongchuadon.png");
                        PHONG.ImageAlign = ContentAlignment.BottomLeft;
                        PHONG.TextAlign = ContentAlignment.MiddleRight;
                        //PHONG.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        PHONG.Name = phongdto.IDPhong.ToString();
                        PHONG.TabIndex = i;
                        string tienphong = phongdto.DongiaPhong1.ToString("c", new CultureInfo("vi-VN"));
                        string tienphonggio = phongdto.DongiaGio1.ToString("c", new CultureInfo("vi-VN"));
                        PHONG.Text = "Phòng: " + phongdto.TenPhong.ToString() + "\n" +
                            "Giá ngày: " + tienphong + "\n" +
                            "Giá giờ: " + tienphonggio + "\n" +
                            "Loại: " + phongdto.TenLoaiPhong.ToString() + "\n" +
                            "Tầng: " + phongdto.SoTang.ToString();

                        PHONG.ForeColor = Color.Teal;
                        //  PHONG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                        PHONG.Size = new System.Drawing.Size(200, 130);
                        PHONG.TabIndex = i;
                        flowLayoutPanel1.Controls.Add(PHONG);
                        flowLayoutPanel1.Update();
                    }

                    else if (phongdto.IDTrangThai == 4)// phong da co khach DAG O
                    {
                        KhachHang_DTO kh_thue = DatPhong_BUS.TimKH_ThuePhong(phongdto.IDPhong.ToString());
                        Button PHONG = new Button();
                        PHONG = new System.Windows.Forms.Button();
                        PHONG.BackColor = System.Drawing.Color.BlueViolet;
                        PHONG.ContextMenu = CreateContextMenu_PhongCoKHachO(kh_thue.Id_datphongphong, kh_thue, phongdto);
                        PHONG.Image = System.Drawing.Image.FromFile(@"D:\DABC_LTQL\phongcokhacho.png");
                        PHONG.ImageAlign = ContentAlignment.BottomLeft;
                        PHONG.TextAlign = ContentAlignment.TopRight;
                        PHONG.ForeColor = Color.Black;
                        PHONG.Name = phongdto.IDPhong.ToString();
                        PHONG.TabIndex = i;
                        //  string tienphong = phongdto.DongiaPhong1.ToString("c", new CultureInfo("vi-VN"));
                        int days = GetDaysBetween(DateTime.Now, kh_thue.Ngaytraphong);
                        TimeSpan ts = kh_thue.Ngaytraphong - DateTime.Now;
                        float hours = (float)ts.TotalHours;
                        float minites = (float)ts.TotalMinutes;
                        float remainder = hours % 24;
                        if (days <= 0 && remainder <= 12)
                        {
                            PHONG.BackColor = Color.DarkBlue;
                            PHONG.ForeColor = Color.Black;
                        }
                        else
                        {
                            PHONG.ForeColor = Color.Black;

                        }
                        //PHONG.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        if ((int)(remainder) > 0)
                        {

                            PHONG.Text = "Phòng: " + phongdto.TenPhong.ToString() + "\n" +
                            kh_thue.TenKH + "\n"
                            + "SĐT: " + kh_thue.SDT_Kh + "\n"
                            + "Còn: " + days + " ngày " + (int)remainder + " giờ.";
                        }
                        else
                        {
                            PHONG.Text = "Phòng: " + phongdto.TenPhong.ToString() + "\n" +
                            kh_thue.TenKH + "\n"
                            + "SĐT: " + kh_thue.SDT_Kh + "\n"
                            + "Còn: " + days + " ngày " + (int)minites + " phút.";
                        }
                        //  PHONG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                        PHONG.Size = new System.Drawing.Size(200, 130);
                        PHONG.TabIndex = i;
                        flowLayoutPanel1.Controls.Add(PHONG);
                        flowLayoutPanel1.Update();

                    }
                    else if (phongdto.IDTrangThai == 5)// phong da co khach dat
                    {
                        KhachHang_DTO kh_dat = DatPhong_BUS.TimKH_DatPhong(phongdto.IDPhong.ToString());
                        Button PHONG = new Button();
                        PHONG = new System.Windows.Forms.Button();
                        PHONG.ContextMenu = CreateContextMenu_PhongKhachDat(phongdto, kh_dat);
                        PHONG.BackColor = System.Drawing.Color.MediumPurple;
                        PHONG.Image = System.Drawing.Image.FromFile(@"D:\DABC_LTQL\phongdadat.png");
                        PHONG.ImageAlign = ContentAlignment.BottomLeft;
                        PHONG.TextAlign = ContentAlignment.TopRight;
                        PHONG.ForeColor = Color.Black;
                        PHONG.Name = phongdto.IDPhong.ToString();
                        PHONG.TabIndex = i;
                        //  string tienphong = phongdto.DongiaPhong1.ToString("c", new CultureInfo("vi-VN"));
                        PHONG.ForeColor = Color.White;
                        PHONG.Text = "Phòng: " + phongdto.TenPhong.ToString() + "\n" +
                            kh_dat.TenKH + "\n"
                            + "SĐT: " + kh_dat.SDT_Kh + "\n"
                            + "Ngày đến nhận:\n" + kh_dat.Ngaydatphong + "";
                        //  PHONG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                        PHONG.Size = new System.Drawing.Size(200, 130);
                        PHONG.TabIndex = i;
                        flowLayoutPanel1.Controls.Add(PHONG);
                        flowLayoutPanel1.Update();

                    }
                    i++;
                }
            }
            catch { }
        }

        public int GetDaysBetween(DateTime n1, DateTime n2)
        {
            TimeSpan ts = n2 - n1;
            return (int)ts.TotalDays;
        }





        private void btn_themphong_Click(object sender, EventArgs e)
        {
            try
            {
                frm_themphong themphong = new frm_themphong(1, this);
                themphong.ShowDialog();
            }
            catch { }
        }

        private void btn_timphong_Click(object sender, EventArgs e)
        {

        }

        private void txt_timphong_Click(object sender, EventArgs e)
        {
            if (txt_timphong.Text == "Nhập phòng để tìm")
                txt_timphong.Clear();
        }

        private void txt_timphong_Leave(object sender, EventArgs e)
        {
            if (txt_timphong.Text != "")
            {

            }
            else
                txt_timphong.Text = "Nhập phòng để tìm";
        }

        public void loadLoaiPhong()
        {
            try
            {
                List<Loai_Phong_DTO> loaiphong = LoaiPhong_BUS.LayDSLOAIPHONG();
                dgv_loaiPhong.DataSource = loaiphong;
                cbb_loaiphong.DataSource = loaiphong;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_sualoai_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_loaiPhong.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedrow = dgv_loaiPhong.CurrentRow;
                    Loai_Phong_DTO loaiphong = new Loai_Phong_DTO();
                    loaiphong.IDLoaiP = int.Parse(selectedrow.Cells[0].Value.ToString());
                    loaiphong.SoNguoi = int.Parse(selectedrow.Cells[2].Value.ToString());
                    loaiphong.SoGiuong = int.Parse(selectedrow.Cells[3].Value.ToString());
                    loaiphong.DongiaLP_ngay = float.Parse(selectedrow.Cells[5].Value.ToString());
                    loaiphong.Dongia_Time_LP = float.Parse(selectedrow.Cells[4].Value.ToString());
                    loaiphong.TenLoaiP = selectedrow.Cells[1].Value.ToString();
                    frm_CapNhat_LoaiPhong f1 = new frm_CapNhat_LoaiPhong(2, loaiphong, this);
                    f1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn phòng cần cập nhật trong danh sách", "THÔNG BÁO");
                    dgv_loaiPhong.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_themloaiphong_Click(object sender, EventArgs e)
        {
            frm_CapNhat_LoaiPhong f1 = new frm_CapNhat_LoaiPhong(1, this);
            f1.ShowDialog();
        }

        private void btn_xoaloai_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_loaiPhong.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedrow = dgv_loaiPhong.CurrentRow;
                    Loai_Phong_DTO loaiphong = new Loai_Phong_DTO();
                    loaiphong.IDLoaiP = int.Parse(selectedrow.Cells[0].Value.ToString());
                    if (MessageBox.Show("Bạn có chắc xóa loại phòng: " + selectedrow.Cells[1].Value.ToString() + " không ?", "XÁC NHẬN XÓA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (LoaiPhong_BUS.Dalete(loaiphong))
                        {
                            MessageBox.Show("Xóa thành công", "THÔNG BÁO");
                            loadLoaiPhong();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn phòng cần xóa trong danh sách", "THÔNG BÁO");
                    dgv_loaiPhong.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_thoatLoai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_timphong_Click_1(object sender, EventArgs e)
        {
            if(txt_timphong.Text == "Nhập phòng để tìm")
            {
                LoadPhongAuTo();
            }    
            else if(txt_timphong.Text == " ")
            {
                LoadPhongAuTo();
            }
            else
            {
                LoadPhongAuTo_TheoTen();         
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyTimer.Stop();
            this.Close();
        }

        private void txt_timphong_Click_1(object sender, EventArgs e)
        {
            if (txt_timphong.Text == "Nhập phòng để tìm")
                txt_timphong.Clear();
        }

        private void txt_timphong_Leave_1(object sender, EventArgs e)
        {
            if (txt_timphong.Text == "")
            {
                txt_timphong.Text = "Nhập phòng để tìm";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadPhongAuTo();
        }

        private void check_chontimkiem_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (check_chontimkiem.Checked)
                {
                    panel_trangthai.Enabled = true;
                    panel_loaiphong.Enabled = true;
                    LoadPhongAuTo();
                }
                else
                {
                    panel_trangthai.Enabled = false;
                    panel_loaiphong.Enabled = false;
                    LoadPhongAuTo();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rad_tt_trong_CheckedChanged(object sender, EventArgs e)
        {
            check_chontimkiem_CheckedChanged(sender, e);
        }

        private void rad_tt_thuephong_CheckedChanged(object sender, EventArgs e)
        {
            check_chontimkiem_CheckedChanged(sender, e);
        }

        private void rad_tt_datphong_CheckedChanged(object sender, EventArgs e)
        {
            check_chontimkiem_CheckedChanged(sender, e);
        }

        private void rad_tt_chuadon_CheckedChanged(object sender, EventArgs e)
        {
            check_chontimkiem_CheckedChanged(sender, e);
        }

        private void rad_tt_dánguachua_CheckedChanged(object sender, EventArgs e)
        {
            check_chontimkiem_CheckedChanged(sender, e);
        }


        private void cbb_loaiphong_SelectedValueChanged(object sender, EventArgs e)
        {
            check_chontimkiem_CheckedChanged(sender, e);
        }

        private void txt_timphong_TextChanged(object sender, EventArgs e)
        {
            if (txt_timphong.Text == "Nhập phòng để tìm")
                LoadPhongAuTo();
        }

        private void cbb_loaiphong_DropDown(object sender, EventArgs e)
        {
            loadLoaiPhong();
        }
    }
}
