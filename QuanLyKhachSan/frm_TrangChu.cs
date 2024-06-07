using DTO;
using Microsoft.SqlServer.Management.HadrModel;
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
    public partial class frm_TrangChu : Form
    {
         private NguoiDung_DTO nguoidung;
        private Admin_DTO admin;
        public frm_TrangChu()
        {
            InitializeComponent();
        }
        public frm_TrangChu(NguoiDung_DTO ng)
        {
            InitializeComponent();
            this.nguoidung = ng;
        }
        public frm_TrangChu(Admin_DTO ng)
        {
            InitializeComponent();
            this.admin = ng;
        }
        private void Openformchild(Form childForm)
        {

            bool IsOpen = false;
            foreach (Form frm in Application.OpenForms)
            {
                if (childForm.Text == frm.Text)
                {
                    IsOpen = true;
                    lb_tenform.Text = frm.Text;
                    frm.BringToFront();
                    break;
                }
            }
            if (IsOpen == false)
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panel_Home.Controls.Add(childForm);
                panel_Home.Tag = childForm;
                lb_tenform.Text = childForm.Text;
                childForm.BringToFront();
                childForm.Show();
            }

        }
        private void btn_AnForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_formnho_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                btn_formLon.BringToFront();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btn_thugon_Click(object sender, EventArgs e)
        {
            btn_phongto.BringToFront();
            btn_thugon.SendToBack();
      
            if (this.WindowState == FormWindowState.Maximized)
                panel_Menu.Size = new Size(228, 900);
            else
                panel_Menu.Size = new Size(228, 700);
            lb_banquyen.Visible = true;
            pictureBox_anh.Visible = true;
            lb_manv.Visible = true;
            lb_tenNV.Visible = true;
            lb_Quyen.Visible = true;
        }

        private void btn_phongto_Click(object sender, EventArgs e)
        {
            btn_phongto.SendToBack();
            btn_thugon.BringToFront();
            if (this.WindowState == FormWindowState.Maximized)
                panel_Menu.Size = new Size(70, 900);
            else
                panel_Menu.Size = new Size(70, 700);
            lb_banquyen.Visible = false;
            pictureBox_anh.Visible = false;
            lb_manv.Visible = false;
            lb_tenNV.Visible = false;
            lb_Quyen.Visible = false;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không ? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                frm_DangNhap f1 = new frm_DangNhap();
                f1.Show();
            }       
        }
        Form currentFomchild;
        private void Openformchild_DASHBOARD(Form childForm)
        {

            frm_dashboard kh = new frm_dashboard();
            if (currentFomchild != null)
            {
                currentFomchild.Close();
            }
            currentFomchild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Home.Controls.Add(childForm);
            panel_Home.Tag = childForm;
            lb_tenform.Text = childForm.Text;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_formLon_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                btn_formnho.BringToFront();
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_EXIT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
        
        private void btn_p_Click(object sender, EventArgs e)
        {
            frm_Phong phong = new frm_Phong();
            Openformchild(phong);
            if(nguoidung != null)
            {
                phong.Nguoidung= nguoidung;
            }   
            else
            {
                phong.Nguoidung = nguoidung;
            }
        }

        private void btn_Trangchu_Click(object sender, EventArgs e)
        {
            Openformchild_DASHBOARD(new frm_dashboard());
        }

        private void btn_DatPhong_Click(object sender, EventArgs e)
        {
            Openformchild(new frm_DS_DatPhong(nguoidung));
        }


        private void btn_dichVu_Click(object sender, EventArgs e)
        {
            Openformchild(new frm_DSDichVu());
        }

        private void btn_TienNghi_Click(object sender, EventArgs e)
        {
            Openformchild(new frm_TienNghi());
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            Openformchild(new frm_NhanVien());
        }

        private void frm_TrangChu_Load(object sender, EventArgs e)
        {
            if (nguoidung != null)
            {
                lb_manv.Text += "  " + nguoidung.IDNguoiDung.ToString();
                lb_tenNV.Text = nguoidung.TenNV;
                lb_Quyen.Text = nguoidung.TenQuyen;
                btn_Trangchu_Click(sender, e);
                if (nguoidung.TenQuyen.ToLower() == "lễ tân" )
                {
                    btn_dichVu.Enabled = false;
                    btn_DV.Enabled = false;
                    btn_TienNghi.Enabled = false;
                    btn_TN.Enabled = false;
                    btn_NhanVien.Enabled = false;
                    btn_NV.Enabled = false;
                    btn_giaodich1.Enabled = false;
                    btn_giaodich2.Enabled = false;
                }
            }
            else
            {
                lb_manv.Text += "  " + admin.Usename.ToString();
                lb_tenNV.Text = admin.Usename;
                lb_Quyen.Text = admin.TenQuyen;
                btn_Trangchu_Click(sender, e);
            }
        }

        private void btn_TC_Click(object sender, EventArgs e)
        {
            btn_Trangchu_Click(sender, e);
        }

        private void btn_DP_Click(object sender, EventArgs e)
        {
            btn_DatPhong_Click(sender, e);
        }

        private void btn_Phong_Click(object sender, EventArgs e)
        {
            btn_p_Click(sender, e);
        }

        private void btn_KH_Click(object sender, EventArgs e)
        {
            btn_khachhang_Click(sender, e);
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            Openformchild(new frm_khachHang());
        }

        private void btn_DV_Click(object sender, EventArgs e)
        {
            btn_dichVu_Click(sender, e);
        }

        private void btn_TN_Click(object sender, EventArgs e)
        {
            btn_TienNghi_Click(sender, e);
        }

        private void btn_NV_Click(object sender, EventArgs e)
        {
            btn_NhanVien_Click(sender, e);
        }

        private void btn_giaodich2_Click(object sender, EventArgs e)
        {
            Openformchild(new frm_GiaoDich(nguoidung));

        }

        private void btn_giaodich1_Click(object sender, EventArgs e)
        {
            btn_giaodich2_Click(sender, e);
        }

        private void btn_AnForm_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_hethong_Click(object sender, EventArgs e)
        {
            if (nguoidung != null)
            {
                frm_hethong hethong = new frm_hethong(nguoidung); hethong.ShowDialog();
            }
            else
            {
                frm_hethong hethong = new frm_hethong(); hethong.ShowDialog();
            }
        }
    }
}
