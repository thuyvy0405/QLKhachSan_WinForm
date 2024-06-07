namespace QuanLyKhachSan
{
    partial class frm_themdichvu_datphong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnthemdv = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.dgv_dichvu = new System.Windows.Forms.DataGridView();
            this.iDDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiaDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiCHuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dichVuDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.numericUpDown_soluong = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.cbb_phongdat = new System.Windows.Forms.ComboBox();
            this.chiTietDatPhongDTOBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietDatPhongDTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietDatPhongDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_chontimkiem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dichvu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_soluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDatPhongDTOBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDatPhongDTOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDatPhongDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthemdv
            // 
            this.btnthemdv.Image = global::QuanLyKhachSan.Properties.Resources.plus__1_;
            this.btnthemdv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthemdv.Location = new System.Drawing.Point(530, 12);
            this.btnthemdv.Name = "btnthemdv";
            this.btnthemdv.Size = new System.Drawing.Size(114, 36);
            this.btnthemdv.TabIndex = 4;
            this.btnthemdv.Text = "Thêm";
            this.btnthemdv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthemdv.UseVisualStyleBackColor = true;
            this.btnthemdv.Click += new System.EventHandler(this.btnthemdv_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.BackColor = System.Drawing.Color.Salmon;
            this.btnhuy.Image = global::QuanLyKhachSan.Properties.Resources.trash;
            this.btnhuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhuy.Location = new System.Drawing.Point(651, 12);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(103, 36);
            this.btnhuy.TabIndex = 4;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnhuy.UseVisualStyleBackColor = false;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // dgv_dichvu
            // 
            this.dgv_dichvu.AllowUserToAddRows = false;
            this.dgv_dichvu.AllowUserToDeleteRows = false;
            this.dgv_dichvu.AutoGenerateColumns = false;
            this.dgv_dichvu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dichvu.BackgroundColor = System.Drawing.Color.White;
            this.dgv_dichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dichvu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDVDataGridViewTextBoxColumn,
            this.tenDVDataGridViewTextBoxColumn,
            this.tenLoaiDVDataGridViewTextBoxColumn,
            this.dongiaDVDataGridViewTextBoxColumn,
            this.ghiCHuDataGridViewTextBoxColumn});
            this.dgv_dichvu.DataSource = this.dichVuDTOBindingSource;
            this.dgv_dichvu.Location = new System.Drawing.Point(11, 102);
            this.dgv_dichvu.MultiSelect = false;
            this.dgv_dichvu.Name = "dgv_dichvu";
            this.dgv_dichvu.ReadOnly = true;
            this.dgv_dichvu.RowHeadersWidth = 62;
            this.dgv_dichvu.RowTemplate.Height = 28;
            this.dgv_dichvu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dichvu.Size = new System.Drawing.Size(743, 279);
            this.dgv_dichvu.TabIndex = 5;
            this.dgv_dichvu.Click += new System.EventHandler(this.dgv_dichvu_Click);
            // 
            // iDDVDataGridViewTextBoxColumn
            // 
            this.iDDVDataGridViewTextBoxColumn.DataPropertyName = "IDDV";
            this.iDDVDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDVDataGridViewTextBoxColumn.Name = "iDDVDataGridViewTextBoxColumn";
            this.iDDVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenDVDataGridViewTextBoxColumn
            // 
            this.tenDVDataGridViewTextBoxColumn.DataPropertyName = "TenDV";
            this.tenDVDataGridViewTextBoxColumn.HeaderText = "TÊN DV";
            this.tenDVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenDVDataGridViewTextBoxColumn.Name = "tenDVDataGridViewTextBoxColumn";
            this.tenDVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenLoaiDVDataGridViewTextBoxColumn
            // 
            this.tenLoaiDVDataGridViewTextBoxColumn.DataPropertyName = "TenLoaiDV";
            this.tenLoaiDVDataGridViewTextBoxColumn.HeaderText = "TÊN LOẠI DỊCH VU";
            this.tenLoaiDVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenLoaiDVDataGridViewTextBoxColumn.Name = "tenLoaiDVDataGridViewTextBoxColumn";
            this.tenLoaiDVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dongiaDVDataGridViewTextBoxColumn
            // 
            this.dongiaDVDataGridViewTextBoxColumn.DataPropertyName = "DongiaDV";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Format = "N1";
            this.dongiaDVDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dongiaDVDataGridViewTextBoxColumn.HeaderText = "ĐƠN GIÁ DỊCH VỤ";
            this.dongiaDVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dongiaDVDataGridViewTextBoxColumn.Name = "dongiaDVDataGridViewTextBoxColumn";
            this.dongiaDVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ghiCHuDataGridViewTextBoxColumn
            // 
            this.ghiCHuDataGridViewTextBoxColumn.DataPropertyName = "GhiCHu";
            this.ghiCHuDataGridViewTextBoxColumn.HeaderText = "GHI CHÚ";
            this.ghiCHuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ghiCHuDataGridViewTextBoxColumn.Name = "ghiCHuDataGridViewTextBoxColumn";
            this.ghiCHuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dichVuDTOBindingSource
            // 
            this.dichVuDTOBindingSource.DataSource = typeof(DTO.DichVu_DTO);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(223, 60);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(291, 26);
            this.txt_timkiem.TabIndex = 6;
            this.txt_timkiem.Text = "Nhập ở đây để tìm";
            this.txt_timkiem.Click += new System.EventHandler(this.txt_timkiem_Click);
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            this.txt_timkiem.Leave += new System.EventHandler(this.txt_timkiem_Leave);
            // 
            // numericUpDown_soluong
            // 
            this.numericUpDown_soluong.Location = new System.Drawing.Point(106, 22);
            this.numericUpDown_soluong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_soluong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_soluong.Name = "numericUpDown_soluong";
            this.numericUpDown_soluong.Size = new System.Drawing.Size(106, 26);
            this.numericUpDown_soluong.TabIndex = 8;
            this.numericUpDown_soluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_soluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_soluong.ValueChanged += new System.EventHandler(this.numericUpDown_soluong_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Thành tiền:";
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Enabled = false;
            this.txt_thanhtien.Location = new System.Drawing.Point(324, 22);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(190, 26);
            this.txt_thanhtien.TabIndex = 10;
            // 
            // cbb_phongdat
            // 
            this.cbb_phongdat.DataSource = this.chiTietDatPhongDTOBindingSource2;
            this.cbb_phongdat.DisplayMember = "TenPhong";
            this.cbb_phongdat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_phongdat.FormattingEnabled = true;
            this.cbb_phongdat.Location = new System.Drawing.Point(629, 60);
            this.cbb_phongdat.Name = "cbb_phongdat";
            this.cbb_phongdat.Size = new System.Drawing.Size(125, 28);
            this.cbb_phongdat.TabIndex = 11;
            this.cbb_phongdat.ValueMember = "IDPhong";
            this.cbb_phongdat.SelectedIndexChanged += new System.EventHandler(this.cbb_phongdat_SelectedIndexChanged);
            // 
            // chiTietDatPhongDTOBindingSource2
            // 
            this.chiTietDatPhongDTOBindingSource2.DataSource = typeof(DTO.ChiTiet_DatPhong_DTO);
            // 
            // chiTietDatPhongDTOBindingSource1
            // 
            this.chiTietDatPhongDTOBindingSource1.DataSource = typeof(DTO.ChiTiet_DatPhong_DTO);
            // 
            // chiTietDatPhongDTOBindingSource
            // 
            this.chiTietDatPhongDTOBindingSource.DataSource = typeof(DTO.ChiTiet_DatPhong_DTO);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chọn phòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tìm theo:";
            // 
            // cbb_chontimkiem
            // 
            this.cbb_chontimkiem.FormattingEnabled = true;
            this.cbb_chontimkiem.Items.AddRange(new object[] {
            "ID",
            "TÊN DỊCH VỤ",
            "LOẠI DỊCH VỤ"});
            this.cbb_chontimkiem.Location = new System.Drawing.Point(106, 58);
            this.cbb_chontimkiem.Name = "cbb_chontimkiem";
            this.cbb_chontimkiem.Size = new System.Drawing.Size(103, 28);
            this.cbb_chontimkiem.TabIndex = 11;
            this.cbb_chontimkiem.SelectedIndexChanged += new System.EventHandler(this.cbb_phongdat_SelectedIndexChanged);
            // 
            // frm_themdichvu_datphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(766, 388);
            this.Controls.Add(this.cbb_chontimkiem);
            this.Controls.Add(this.cbb_phongdat);
            this.Controls.Add(this.txt_thanhtien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_soluong);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.dgv_dichvu);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnthemdv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_themdichvu_datphong";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM DỊCH VỤ PHÒNG";
            this.Load += new System.EventHandler(this.frm_themdichvu_datphong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dichvu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dichVuDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_soluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDatPhongDTOBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDatPhongDTOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDatPhongDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthemdv;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.DataGridView dgv_dichvu;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.NumericUpDown numericUpDown_soluong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.BindingSource dichVuDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiaDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiCHuDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbb_phongdat;
        private System.Windows.Forms.BindingSource chiTietDatPhongDTOBindingSource;
        private System.Windows.Forms.BindingSource chiTietDatPhongDTOBindingSource1;
        private System.Windows.Forms.BindingSource chiTietDatPhongDTOBindingSource2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_chontimkiem;
    }
}