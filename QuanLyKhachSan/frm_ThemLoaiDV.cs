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
    public partial class frm_ThemLoaiDV : Form
    {
        public frm_ThemLoaiDV()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Loai_DichVu_DTO ldv = new Loai_DichVu_DTO();
                if (txt_tenloai.Text != "")
                {
                    ldv.TenLoaiDV = txt_tenloai.Text;
                    Loai_DV_BUS.add(ldv);
                    MessageBox.Show("Thêm loại thành công !", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Chưa nhập tên loại!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống !" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_tenloai.Text = "";
            this.Close();
        }
    }
}
