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
    public partial class frm_CapNhat_LoaiPhong : Form
    {
        private int chon;
        private Loai_Phong_DTO loai_Phong;
        private frm_Phong frmphong;
        public frm_CapNhat_LoaiPhong(int chon, Loai_Phong_DTO loaiphong, frm_Phong frmphong)
        {
            InitializeComponent();
            this.chon = chon;
            this.loai_Phong = loaiphong;
            this.frmphong = frmphong;
        }
        public frm_CapNhat_LoaiPhong(int chon, frm_Phong phong)
        {
            InitializeComponent();
            this.chon = chon;
            this.frmphong = phong;

        }
        public frm_CapNhat_LoaiPhong(int chon)
        {
            InitializeComponent();
            this.chon = chon;
        }
        private void LoadDL()
        {
            Loai_Phong_DTO lp = new Loai_Phong_DTO();
            lp.TenLoaiP = txt_tenLoai.Text;
            lp.SoNguoi = int.Parse(nume_songuoi.Value.ToString());
            lp.SoGiuong = int.Parse(numer_sogiuong.Value.ToString());
            lp.Dongia_Time_LP = float.Parse(txt_dongiaGio.Text);
            lp.DongiaLP_ngay = float.Parse(txt_dongiaNgay.Text);
        }
        private void Updateloaiphong()
        {
            try
            {
                if (  txt_idloai.Text!="" && txt_tenLoai.Text != "" && txt_dongiaGio.Text != "" && txt_dongiaNgay.Text != "")
                {
                    Loai_Phong_DTO loaiphong = new Loai_Phong_DTO();
                    loaiphong.IDLoaiP = int.Parse(txt_idloai.Text);
                    loaiphong.TenLoaiP = txt_tenLoai.Text.Trim();
                    loaiphong.SoNguoi = int.Parse(nume_songuoi.Value.ToString());
                    loaiphong.SoGiuong = int.Parse(numer_sogiuong.Value.ToString());
                    loaiphong.Dongia_Time_LP = float.Parse(txt_dongiaGio.Text);
                    loaiphong.DongiaLP_ngay = float.Parse(txt_dongiaNgay.Text);
                    if (LoaiPhong_BUS.Update(loaiphong))
                    {
                        MessageBox.Show("Cập nhật thành công", "THÔNG BÁO");
                        frmphong.loadLoaiPhong();
                    }
                    else
                        MessageBox.Show("Cập nhật KHÔNG thành công", "THÔNG BÁO");

                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ dữ liệu loại phòng cần cập nhật", "THÔNG BÁO");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        
             private void ThemMoiLoaiphong_themphong()
        {
            try
            {
                if (txt_tenLoai.Text != "" && txt_dongiaGio.Text != "" && txt_dongiaNgay.Text != "")
                {
                    Loai_Phong_DTO loaiphong = new Loai_Phong_DTO();
                    loaiphong.TenLoaiP = txt_tenLoai.Text.Trim();
                    loaiphong.SoNguoi = nume_songuoi.Bottom;
                    loaiphong.SoGiuong = numer_sogiuong.Bottom;
                    loaiphong.Dongia_Time_LP = float.Parse(txt_dongiaGio.Text);
                    loaiphong.DongiaLP_ngay = float.Parse(txt_dongiaNgay.Text);
                    if (LoaiPhong_BUS.add(loaiphong))
                    {
                        MessageBox.Show("Thêm mới thành công", "THÔNG BÁO");
                    }
                    else
                    {
                        MessageBox.Show("Thêm KHÔNG thành công", "THÔNG BÁO");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ dữ liệu loại phòng", "THÔNG BÁO");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void ThemMoiLoaiphong()
        {
            try
            {
                if (txt_tenLoai.Text != "" && txt_dongiaGio.Text != "" && txt_dongiaNgay.Text != "")
                {
                    Loai_Phong_DTO loaiphong = new Loai_Phong_DTO();
                    loaiphong.TenLoaiP = txt_tenLoai.Text.Trim();
                    loaiphong.SoNguoi = nume_songuoi.Bottom;
                    loaiphong.SoGiuong = numer_sogiuong.Bottom;
                    loaiphong.Dongia_Time_LP = float.Parse(txt_dongiaGio.Text);
                    loaiphong.DongiaLP_ngay = float.Parse(txt_dongiaNgay.Text);
                    if (LoaiPhong_BUS.add(loaiphong))
                    {
                        MessageBox.Show("Thêm mới thành công", "THÔNG BÁO");
                        frmphong.loadLoaiPhong();
                    }
                    else
                    {
                        MessageBox.Show("Thêm KHÔNG thành công", "THÔNG BÁO");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ dữ liệu loại phòng","THÔNG BÁO");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }    

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            if (chon == 2)
            {
                if (MessageBox.Show("Bạn muốn cập nhật ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Updateloaiphong();
                }
            }
            else if(chon ==1)
            {
                if (MessageBox.Show("Bạn muốn thêm mới ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ThemMoiLoaiphong();
                }
            }    
            else
            {
                if (MessageBox.Show("Bạn muốn thêm mới ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ThemMoiLoaiphong_themphong();
                }
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn hủy ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                this.Close();
            }    
        }

        private void frm_CapNhat_LoaiPhong_Load(object sender, EventArgs e)
        {
            if(chon ==2)// cập nhật
            {
                txt_idloai.Text = loai_Phong.IDLoaiP.ToString();
                txt_tenLoai.Text = loai_Phong.TenLoaiP.ToString();
                nume_songuoi.Value = loai_Phong.SoNguoi;
                numer_sogiuong.Value = loai_Phong.SoGiuong;
                txt_dongiaGio.Text = loai_Phong.Dongia_Time_LP.ToString();
                txt_dongiaNgay.Text = loai_Phong.DongiaLP_ngay.ToString();
            }
            else// thêm mới
            {
                txt_idloai.Enabled = false;
                btn_capnhat.Text = "Thêm mới";
                this.Text = "THÊM MỚI LOẠI PHÒNG";
                label1.Text = "THÊM MỚI LOẠI PHÒNG";
            }
        }
    }
}
