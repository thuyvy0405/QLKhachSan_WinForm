using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_themphong : Form
    {
        private frm_Phong frmphong;
        private Phong_DTO phongdto;
        private int chon;
        public frm_themphong(int chon ,frm_Phong frmphong, Phong_DTO phong)
        {
            InitializeComponent();
            this.chon = chon;
            this.frmphong = frmphong;
            this.phongdto = phong;
        }
        public frm_themphong(int chon, frm_Phong frmphong)
        {
            InitializeComponent();
            this.chon = chon;
            this.frmphong = frmphong;
        }

        private void btn_themmoiphong_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_tenphong.Text != "")
                {
                    if (chon == 2)
                    {
                        if (MessageBox.Show("Bạn có muốn cập nhật lại thông tin phòng không ?", "XÁC NHẬN CẬP NHẬT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Phong_DTO phongcapnhat = new Phong_DTO();
                            phongcapnhat.IDPhong = phongdto.IDPhong;
                            phongcapnhat.TenPhong = txt_tenphong.Text.Trim().ToUpper();
                            phongcapnhat.IDTang = int.Parse(cbb_tang.SelectedValue.ToString());
                            phongcapnhat.IDTrangThai = int.Parse(cbb_trangthai.SelectedValue.ToString());
                            phongcapnhat.IDLoaiPhong = int.Parse(cbb_loaiphong.SelectedValue.ToString());
                            if (Phong_BUS.Update(phongcapnhat))
                            {
                                MessageBox.Show("Đã cập nhật thông tin phòng.", "THÔNG BÁO");
                                frmphong.LoadPhongAuTo();
                            }
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn có muốn thêm mới phòng không ?", "XÁC NHẬN THÊM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Phong_DTO phongcapnhat = new Phong_DTO();
                            phongcapnhat.TenPhong = txt_tenphong.Text.Trim().ToUpper();
                            phongcapnhat.IDTang = int.Parse(cbb_tang.SelectedValue.ToString());
                            phongcapnhat.IDTrangThai = int.Parse(cbb_trangthai.SelectedValue.ToString());
                            phongcapnhat.IDLoaiPhong = int.Parse(cbb_loaiphong.SelectedValue.ToString());
                            if (Phong_BUS.add(phongcapnhat))
                            {
                                MessageBox.Show("Đã thêm mới phòng", "THÔNG BÁO");
                                frmphong.LoadPhongAuTo();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Tên phòng không được bỏ trống", "THÔNG BÁO");
                    txt_tenphong.Focus();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void frm_themphong_Load(object sender, EventArgs e)
        {
            LoadCbb_loaiphong();
            LoadCbb_Tang();
            LoadCbb_trangthai();
            if (chon == 2)
            {
                this.Text = "CẬP NHẬT PHÒNG";
                btn_themmoiphong.Text = "Cập nhật";
                label2.Text = "CẬP NHẬT THÔNG TIN PHÒNG";
                txt_tenphong.Text = phongdto.TenPhong;
                cbb_trangthai.Text = phongdto.TenTrangThai;
                cbb_tang.Text = phongdto.SoTang;
                cbb_loaiphong.Text = phongdto.TenLoaiPhong;
            }  
        }
        private void LoadCbb_trangthai()
        {
            List<TrangThai_Phong_DTO> list = Phong_BUS.LayDanhSachTrangThai();
            cbb_trangthai.DataSource = list;
        }
        private void LoadCbb_loaiphong()
        {
            List<Loai_Phong_DTO> list = LoaiPhong_BUS.LayDSLOAIPHONG();
            cbb_loaiphong.DataSource = list;
        }
        private void LoadCbb_Tang()
        {
            List<Tang_DTO> list = Phong_BUS.LayDanhSachTang();
            cbb_tang.DataSource = list;
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_themtang_Click(object sender, EventArgs e)
        {
            frm_tang tang = new frm_tang();
            tang.ShowDialog();  
        }

        private void btn_themloaiphong_Click(object sender, EventArgs e)
        {
            frm_CapNhat_LoaiPhong capNhat_LoaiPhong = new frm_CapNhat_LoaiPhong(3);
            capNhat_LoaiPhong.ShowDialog();
        }

        private void cbb_trangthai_DropDown(object sender, EventArgs e)
        {
            LoadCbb_trangthai();
        }

        private void cbb_tang_DropDown(object sender, EventArgs e)
        {
            LoadCbb_Tang();
        }

        private void cbb_loaiphong_DropDown(object sender, EventArgs e)
        {
            LoadCbb_loaiphong();
        }
    }
}
