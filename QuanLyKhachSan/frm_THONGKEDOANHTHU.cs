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
    public partial class frm_THONGKEDOANHTHU : Form
    {
        private string tennv;
        public frm_THONGKEDOANHTHU(String tennv)
        {
            this.tennv = tennv;
            InitializeComponent();
        }

        private void frm_THONGKEDOANHTHU_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] reports = new Microsoft.Reporting.WinForms.ReportParameter[]
           {
                new Microsoft.Reporting.WinForms. ReportParameter("nguoilap", tennv)
           };
            // TODO: This line of code loads data into the 'DataSet1.DataTable3' table. You can move, or remove it, as needed.
            this.DataTable3TableAdapter.Fill(this.DataSet1.DataTable3, DateTime.Parse(dateTime_batdau.Text + " 00:00:00"), DateTime.Parse(dateTime_ketthuc.Text + " 23:59:59"));
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.LocalReport.SetParameters(reports);
            this.reportViewer1.RefreshReport();
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] reports = new Microsoft.Reporting.WinForms.ReportParameter[]
           {
                new Microsoft.Reporting.WinForms. ReportParameter("nguoilap",tennv)
           };
            // TODO: This line of code loads data into the 'DataSet1.DataTable3' table. You can move, or remove it, as needed.
            this.DataTable3TableAdapter.Fill(this.DataSet1.DataTable3, DateTime.Parse(dateTime_batdau.Text + " 00:00:00"), DateTime.Parse(dateTime_ketthuc.Text + " 23:59:59"));
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.LocalReport.SetParameters(reports);
            this.reportViewer1.RefreshReport();
        
    }

        private void btn_xuatfile_Click(object sender, EventArgs e)
        {

        }
    }
}
