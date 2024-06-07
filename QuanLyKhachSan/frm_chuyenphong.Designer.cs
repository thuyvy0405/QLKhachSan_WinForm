namespace QuanLyKhachSan
{
    partial class frm_chuyenphong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_danhsachphong = new System.Windows.Forms.DataGridView();
            this.iDPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTrangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiaPhong1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiaGio1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongDTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_chuyenphong = new System.Windows.Forms.Button();
            this.phongDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachphong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongDTOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgv_danhsachphong);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(924, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phòng trống";
            // 
            // dgv_danhsachphong
            // 
            this.dgv_danhsachphong.AutoGenerateColumns = false;
            this.dgv_danhsachphong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_danhsachphong.BackgroundColor = System.Drawing.Color.White;
            this.dgv_danhsachphong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_danhsachphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachphong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPhongDataGridViewTextBoxColumn,
            this.tenPhongDataGridViewTextBoxColumn,
            this.tenTrangThaiDataGridViewTextBoxColumn,
            this.tenLoaiPhongDataGridViewTextBoxColumn,
            this.soTangDataGridViewTextBoxColumn,
            this.dongiaPhong1DataGridViewTextBoxColumn,
            this.dongiaGio1DataGridViewTextBoxColumn});
            this.dgv_danhsachphong.DataSource = this.phongDTOBindingSource1;
            this.dgv_danhsachphong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_danhsachphong.Location = new System.Drawing.Point(3, 22);
            this.dgv_danhsachphong.MultiSelect = false;
            this.dgv_danhsachphong.Name = "dgv_danhsachphong";
            this.dgv_danhsachphong.ReadOnly = true;
            this.dgv_danhsachphong.RowHeadersWidth = 62;
            this.dgv_danhsachphong.RowTemplate.Height = 28;
            this.dgv_danhsachphong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_danhsachphong.Size = new System.Drawing.Size(918, 361);
            this.dgv_danhsachphong.TabIndex = 0;
            // 
            // iDPhongDataGridViewTextBoxColumn
            // 
            this.iDPhongDataGridViewTextBoxColumn.DataPropertyName = "IDPhong";
            this.iDPhongDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDPhongDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDPhongDataGridViewTextBoxColumn.Name = "iDPhongDataGridViewTextBoxColumn";
            this.iDPhongDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPhongDataGridViewTextBoxColumn.Width = 61;
            // 
            // tenPhongDataGridViewTextBoxColumn
            // 
            this.tenPhongDataGridViewTextBoxColumn.DataPropertyName = "TenPhong";
            this.tenPhongDataGridViewTextBoxColumn.HeaderText = "PHÒNG";
            this.tenPhongDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenPhongDataGridViewTextBoxColumn.Name = "tenPhongDataGridViewTextBoxColumn";
            this.tenPhongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenTrangThaiDataGridViewTextBoxColumn
            // 
            this.tenTrangThaiDataGridViewTextBoxColumn.DataPropertyName = "TenTrangThai";
            this.tenTrangThaiDataGridViewTextBoxColumn.HeaderText = "TRẠNG THÁI";
            this.tenTrangThaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenTrangThaiDataGridViewTextBoxColumn.Name = "tenTrangThaiDataGridViewTextBoxColumn";
            this.tenTrangThaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenTrangThaiDataGridViewTextBoxColumn.Width = 127;
            // 
            // tenLoaiPhongDataGridViewTextBoxColumn
            // 
            this.tenLoaiPhongDataGridViewTextBoxColumn.DataPropertyName = "TenLoaiPhong";
            this.tenLoaiPhongDataGridViewTextBoxColumn.HeaderText = "LOẠI PHÒNG";
            this.tenLoaiPhongDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenLoaiPhongDataGridViewTextBoxColumn.Name = "tenLoaiPhongDataGridViewTextBoxColumn";
            this.tenLoaiPhongDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenLoaiPhongDataGridViewTextBoxColumn.Width = 130;
            // 
            // soTangDataGridViewTextBoxColumn
            // 
            this.soTangDataGridViewTextBoxColumn.DataPropertyName = "SoTang";
            this.soTangDataGridViewTextBoxColumn.HeaderText = "TẦNG";
            this.soTangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soTangDataGridViewTextBoxColumn.Name = "soTangDataGridViewTextBoxColumn";
            this.soTangDataGridViewTextBoxColumn.ReadOnly = true;
            this.soTangDataGridViewTextBoxColumn.Width = 88;
            // 
            // dongiaPhong1DataGridViewTextBoxColumn
            // 
            this.dongiaPhong1DataGridViewTextBoxColumn.DataPropertyName = "DongiaPhong1";
            this.dongiaPhong1DataGridViewTextBoxColumn.HeaderText = "ĐƠN GIÁ NGÀY";
            this.dongiaPhong1DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dongiaPhong1DataGridViewTextBoxColumn.Name = "dongiaPhong1DataGridViewTextBoxColumn";
            this.dongiaPhong1DataGridViewTextBoxColumn.ReadOnly = true;
            this.dongiaPhong1DataGridViewTextBoxColumn.Width = 147;
            // 
            // dongiaGio1DataGridViewTextBoxColumn
            // 
            this.dongiaGio1DataGridViewTextBoxColumn.DataPropertyName = "DongiaGio1";
            this.dongiaGio1DataGridViewTextBoxColumn.HeaderText = "ĐƠN GIÁ GIỜ";
            this.dongiaGio1DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dongiaGio1DataGridViewTextBoxColumn.Name = "dongiaGio1DataGridViewTextBoxColumn";
            this.dongiaGio1DataGridViewTextBoxColumn.ReadOnly = true;
            this.dongiaGio1DataGridViewTextBoxColumn.Width = 107;
            // 
            // phongDTOBindingSource1
            // 
            this.phongDTOBindingSource1.DataSource = typeof(DTO.Phong_DTO);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHỌN PHÒNG MUỐN CHUYỂN.";
            // 
            // btn_chuyenphong
            // 
            this.btn_chuyenphong.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chuyenphong.ForeColor = System.Drawing.Color.Blue;
            this.btn_chuyenphong.Location = new System.Drawing.Point(738, 4);
            this.btn_chuyenphong.Name = "btn_chuyenphong";
            this.btn_chuyenphong.Size = new System.Drawing.Size(186, 36);
            this.btn_chuyenphong.TabIndex = 2;
            this.btn_chuyenphong.Text = "Chuyển phòng";
            this.btn_chuyenphong.UseVisualStyleBackColor = true;
            this.btn_chuyenphong.Click += new System.EventHandler(this.btn_chuyenphong_Click);
            // 
            // phongDTOBindingSource
            // 
            this.phongDTOBindingSource.DataSource = typeof(DTO.Phong_DTO);
            // 
            // frm_chuyenphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 432);
            this.Controls.Add(this.btn_chuyenphong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_chuyenphong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHUYỂN PHÒNG";
            this.Load += new System.EventHandler(this.frm_chuyenphong_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachphong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongDTOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_danhsachphong;
        private System.Windows.Forms.BindingSource phongDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTrangThaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiaPhong1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiaGio1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource phongDTOBindingSource1;
        private System.Windows.Forms.Button btn_chuyenphong;
    }
}