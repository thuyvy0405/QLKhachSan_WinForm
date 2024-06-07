using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_themdichvu_datphong : Form
    {
        public frm_themdichvu_datphong()
        {
            InitializeComponent();
        }
        private frm_chitietdatphong frm_Chitietdatphong;
        DataGridView dgvdichvu;
        private int iddatphong;
        public frm_themdichvu_datphong(frm_chitietdatphong frm_Chitietdatphong, DataGridView dgvdichvu, int iddatphong)
        {
            InitializeComponent();
            this.frm_Chitietdatphong = frm_Chitietdatphong;
            this.dgvdichvu = dgvdichvu;
            this.iddatphong = iddatphong;
        }
        private DatPhong_DichVu_DTO dpdv;

        public DatPhong_DichVu_DTO Dpdv { get => dpdv; set => dpdv = value; }
        public int Vitrirow { get => vitrirow; set => vitrirow = value; }
        public int Soluongdaco1 { get => Soluongdaco; set => Soluongdaco = value; }

        public void LoadDichVu()
        {
            List<DichVu_DTO> listdv = DichVu_BUS.LayDSDichVu();
            dgv_dichvu.DataSource = listdv;
        }
        private void LoadPhongDat()
        {
            List<ChiTiet_DatPhong_DTO> listDP = Chitiet_DatPhong_BUS.LayCT_DATPHONG_THEOID(iddatphong);
           
             cbb_phongdat.ValueMember = "IDPhong";
            cbb_phongdat.DisplayMember = "TenPhong";
            cbb_phongdat.DataSource = listDP;
        }


        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataTable dt;
        private void frm_themdichvu_datphong_Load(object sender, EventArgs e)
        {
            LoadDichVu();
            LoadPhongDat();
            cbb_chontimkiem.SelectedIndex = 0;
        }

        private void dgv_dichvu_Click(object sender, EventArgs e)
        {
            if (dgv_dichvu.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedrow = dgv_dichvu.CurrentRow;
                double dongia = Double.Parse(selectedrow.Cells[3].Value.ToString());
                txt_thanhtien.Text = (dongia * Double.Parse(numericUpDown_soluong.Value.ToString())).ToString();
            }
        }

        private void numericUpDown_soluong_ValueChanged(object sender, EventArgs e)
        {
            if (dgv_dichvu.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedrow = dgv_dichvu.CurrentRow;
                double dongia = Double.Parse(selectedrow.Cells[3].Value.ToString());
                txt_thanhtien.Text = (dongia * Double.Parse(numericUpDown_soluong.Value.ToString())).ToString();
            }
        }
        private List<DatPhong_DichVu_DTO> list = new List<DatPhong_DichVu_DTO>();
        private int vitrirow;
        private int Soluongdaco;

        private bool CheckIDDV(string IDDV, string ID_phong)
        {
            foreach (DataGridViewRow row in dgvdichvu.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null && row.Cells[3].Value != null && row.Cells[4].Value != null && row.Cells[5].Value != null && row.Cells[6].Value != null)
                {
                    if (row.Cells[1].Value.ToString() == IDDV && row.Cells[0].Value.ToString() == ID_phong)
                    {
                        Soluongdaco = int.Parse(row.Cells[3].Value.ToString());
                        vitrirow = row.Index;
                        return false;
                    }
                }
            }
            return true;
        }
        private void btnthemdv_Click(object sender, EventArgs e)
        {
            if(cbb_phongdat.Text =="")
            {
                MessageBox.Show("Vui lòng chọn phòng cần sử dụng dịch vụ");
                cbb_phongdat.Focus();
                return;
            }    
            try
            {   
                if (txt_thanhtien.Text != "")
                {
                    if (dgv_dichvu.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedrow = dgv_dichvu.CurrentRow;
                        DatPhong_DichVu_DTO dpdv = new DatPhong_DichVu_DTO();
                        string idphong = cbb_phongdat.SelectedValue.ToString();
                        dpdv.IDDP = iddatphong;
                        dpdv.ID_PHONG1 = int.Parse(idphong);
                        dpdv.IDDV = int.Parse(selectedrow.Cells[0].Value.ToString());
                        dpdv.SoluongDV = int.Parse(numericUpDown_soluong.Value.ToString());
                        dpdv.DongiaDV = double.Parse(selectedrow.Cells[3].Value.ToString());
                        dpdv.ThanhtienDV = double.Parse(txt_thanhtien.Text);
                        dpdv.TenDV = selectedrow.Cells[1].Value.ToString();
                        dpdv.NgaySD_DV = DateTime.Now;
                        if (CheckIDDV(dpdv.IDDV.ToString(), dpdv.ID_PHONG1.ToString()))
                        {
                            if (DatPhong_DichVu_BUS.add(dpdv))
                            {
                                frm_Chitietdatphong.LoadDanhSachDichVu_Dat();
                                frm_Chitietdatphong.ShowTienThanhToan();
                            }
                            else
                            {
                                MessageBox.Show("Lỗi không thể lưu dịch vụ. Vui lòng thử lại.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Dịch vụ này đã có trong phòng bạn muốn cập nhật số lượng không ?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                frm_capnhatsoluongdichvu cnsldichvu = new frm_capnhatsoluongdichvu(frm_Chitietdatphong, dpdv, dgvdichvu, Soluongdaco, Vitrirow);
                                cnsldichvu.Show();
                            }
                        }
                    }

                }

                else
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ trong bảng dịch vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void cbb_phongdat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_timkiem.Text != "Nhập ở đây để tìm" && txt_timkiem.Text != " ")
                {
                    if (cbb_chontimkiem.SelectedIndex == 0)// tìm kiếm theo id dịch vụ
                    {
                        List<DichVu_DTO> listdv = DichVu_BUS.TimDVtheoIDDV(txt_timkiem.Text);
                        dgv_dichvu.DataSource = listdv;
                    }
                    else if (cbb_chontimkiem.SelectedIndex == 1)// tên dịch vụ
                    {
                        List<DichVu_DTO> listdv = DichVu_BUS.TimDVtheoTenDV(txt_timkiem.Text);
                        dgv_dichvu.DataSource = listdv;
                    }
                    else// tên loại dịch vụ
                    {
                        List<DichVu_DTO> listdv = DichVu_BUS.TimDVtheoLoaiDV(txt_timkiem.Text);
                        dgv_dichvu.DataSource = listdv;
                    }
                }
                else
                {
                    LoadDichVu();
                }
            }
            catch
            { }
        }

        private void txt_timkiem_Click(object sender, EventArgs e)
        {
            if(txt_timkiem.Text== "Nhập ở đây để tìm")
                txt_timkiem.Clear();
        }

        private void txt_timkiem_Leave(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "")
                txt_timkiem.Text = "Nhập ở đây để tìm";
        }
    }
}
