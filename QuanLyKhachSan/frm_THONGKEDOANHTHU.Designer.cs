namespace QuanLyKhachSan
{
    partial class frm_THONGKEDOANHTHU
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new QuanLyKhachSan.DataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_xem = new System.Windows.Forms.Button();
            this.dateTime_ketthuc = new System.Windows.Forms.DateTimePicker();
            this.dateTime_batdau = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable3TableAdapter1 = new QuanLyKhachSan.DataSet1TableAdapters.DataTable3TableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable3TableAdapter = new QuanLyKhachSan.DataSet1TableAdapters.DataTable3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable3BindingSource
            // 
            this.DataTable3BindingSource.DataMember = "DataTable3";
            this.DataTable3BindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_xem);
            this.panel1.Controls.Add(this.dateTime_ketthuc);
            this.panel1.Controls.Add(this.dateTime_batdau);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 126);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(16, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(356, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chọn thời gian để thống kê doanh thu khách sạn!";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(443, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "THỐNG KÊ DOANH THU KHÁCH SẠN";
            // 
            // btn_xem
            // 
            this.btn_xem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_xem.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_xem.Image = global::QuanLyKhachSan.Properties.Resources.task__1_;
            this.btn_xem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xem.Location = new System.Drawing.Point(609, 48);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(316, 41);
            this.btn_xem.TabIndex = 3;
            this.btn_xem.Text = "Xem và Xuất File Báo Cáo Doanh Thu";
            this.btn_xem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xem.UseVisualStyleBackColor = false;
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // dateTime_ketthuc
            // 
            this.dateTime_ketthuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTime_ketthuc.CustomFormat = "";
            this.dateTime_ketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_ketthuc.Location = new System.Drawing.Point(448, 55);
            this.dateTime_ketthuc.Name = "dateTime_ketthuc";
            this.dateTime_ketthuc.Size = new System.Drawing.Size(144, 26);
            this.dateTime_ketthuc.TabIndex = 2;
            // 
            // dateTime_batdau
            // 
            this.dateTime_batdau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTime_batdau.CustomFormat = "";
            this.dateTime_batdau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_batdau.Location = new System.Drawing.Point(244, 55);
            this.dateTime_batdau.Name = "dateTime_batdau";
            this.dateTime_batdau.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTime_batdau.Size = new System.Drawing.Size(145, 26);
            this.dateTime_batdau.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đến :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời Gian :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataTable2BindingSource
            // 
            this.DataTable2BindingSource.DataMember = "DataTable2";
            this.DataTable2BindingSource.DataSource = this.DataSet1;
            // 
            // dataTable3TableAdapter1
            // 
            this.dataTable3TableAdapter1.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable3BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyKhachSan.baocaodoanhthu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 126);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1075, 482);
            this.reportViewer1.TabIndex = 1;
            // 
            // DataTable3TableAdapter
            // 
            this.DataTable3TableAdapter.ClearBeforeFill = true;
            // 
            // frm_THONGKEDOANHTHU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 608);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_THONGKEDOANHTHU";
            this.Text = "THỐNG KÊ DOANH THU";
            this.Load += new System.EventHandler(this.frm_THONGKEDOANHTHU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.DateTimePicker dateTime_ketthuc;
        private System.Windows.Forms.DateTimePicker dateTime_batdau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource DataTable2BindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.DataTable3TableAdapter dataTable3TableAdapter1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable3BindingSource;
        private DataSet1TableAdapters.DataTable3TableAdapter DataTable3TableAdapter;
        private System.Windows.Forms.Label label4;
    }
}