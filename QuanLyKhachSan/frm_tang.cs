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
    public partial class frm_tang : Form
    {
        public frm_tang()
        {
            InitializeComponent();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dgv_tang.SelectedRows.Count > 0)
            {
                Tang_DTO tang = new Tang_DTO();
                tang.IDtang = int.Parse(dgv_tang.CurrentRow.Cells[0].Value.ToString());
                tang.TenTang = txt_tentang.Text.Trim().ToUpper();
                if (Tang_BUS.Update(tang))
                    MessageBox.Show("Đã cập nhật thành công");
                frm_tang_Load(sender, e);
            }
            else
                MessageBox.Show("Vui lòng chọn tầng cần cập nhật!");
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_tentang.Text != "")
            {
                Tang_DTO tang = new Tang_DTO();
                tang.TenTang = txt_tentang.Text.Trim().ToUpper();
                if(Tang_BUS.add(tang))
                    MessageBox.Show("Thêm mới thành công");
                frm_tang_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên tầng!");
                txt_tentang.Focus();
            }
        }

        private void frm_tang_Load(object sender, EventArgs e)
        {
            List<Tang_DTO> tang_DTOs = Tang_BUS.LayDSTANG();
            dgv_tang.DataSource = tang_DTOs;
        }
    }
}
