namespace QuanLyKhachSan
{
    partial class frm_DS_DatPhong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_DSdatphong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.qLKSDataSet = new QuanLyKhachSan.QLKSDataSet();
            this.dATPHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dATPHONGTableAdapter = new QuanLyKhachSan.QLKSDataSetTableAdapters.DATPHONGTableAdapter();
            this.dateTime_ngaylap = new System.Windows.Forms.DateTimePicker();
            this.cbb_Chon = new System.Windows.Forms.ComboBox();
            this.txt_Tìm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_DatPhong = new System.Windows.Forms.Button();
            this.datPhongDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDatPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaylapphieuDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tranthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSdatphong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATPHONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datPhongDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.dgv_DSdatphong);
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 508);
            this.panel1.TabIndex = 0;
            // 
            // dgv_DSdatphong
            // 
            this.dgv_DSdatphong.AllowUserToAddRows = false;
            this.dgv_DSdatphong.AllowUserToDeleteRows = false;
            this.dgv_DSdatphong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DSdatphong.AutoGenerateColumns = false;
            this.dgv_DSdatphong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSdatphong.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DSdatphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSdatphong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDatPhongDataGridViewTextBoxColumn,
            this.tenKHDataGridViewTextBoxColumn,
            this.NgaylapphieuDP,
            this.Tranthai});
            this.dgv_DSdatphong.DataSource = this.datPhongDTOBindingSource;
            this.dgv_DSdatphong.Location = new System.Drawing.Point(12, 15);
            this.dgv_DSdatphong.Name = "dgv_DSdatphong";
            this.dgv_DSdatphong.ReadOnly = true;
            this.dgv_DSdatphong.RowHeadersWidth = 62;
            this.dgv_DSdatphong.RowTemplate.Height = 28;
            this.dgv_DSdatphong.Size = new System.Drawing.Size(951, 481);
            this.dgv_DSdatphong.TabIndex = 0;
            this.dgv_DSdatphong.DoubleClick += new System.EventHandler(this.dgv_DSdatphong_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH ĐẶT PHÒNG";
            // 
            // qLKSDataSet
            // 
            this.qLKSDataSet.DataSetName = "QLKSDataSet";
            this.qLKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dATPHONGBindingSource
            // 
            this.dATPHONGBindingSource.DataMember = "DATPHONG";
            this.dATPHONGBindingSource.DataSource = this.qLKSDataSet;
            // 
            // dATPHONGTableAdapter
            // 
            this.dATPHONGTableAdapter.ClearBeforeFill = true;
            // 
            // dateTime_ngaylap
            // 
            this.dateTime_ngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_ngaylap.Location = new System.Drawing.Point(12, 11);
            this.dateTime_ngaylap.Name = "dateTime_ngaylap";
            this.dateTime_ngaylap.Size = new System.Drawing.Size(177, 26);
            this.dateTime_ngaylap.TabIndex = 2;
            this.dateTime_ngaylap.ValueChanged += new System.EventHandler(this.dateTime_ngaylap_ValueChanged);
            // 
            // cbb_Chon
            // 
            this.cbb_Chon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_Chon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Chon.FormattingEnabled = true;
            this.cbb_Chon.Items.AddRange(new object[] {
            "Tìm Theo ID Đặt Phòng",
            "Tìm Theo Tên Khách hàng"});
            this.cbb_Chon.Location = new System.Drawing.Point(284, 12);
            this.cbb_Chon.Name = "cbb_Chon";
            this.cbb_Chon.Size = new System.Drawing.Size(187, 28);
            this.cbb_Chon.TabIndex = 5;
            // 
            // txt_Tìm
            // 
            this.txt_Tìm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Tìm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tìm.Location = new System.Drawing.Point(477, 8);
            this.txt_Tìm.Multiline = true;
            this.txt_Tìm.Name = "txt_Tìm";
            this.txt_Tìm.Size = new System.Drawing.Size(235, 34);
            this.txt_Tìm.TabIndex = 6;
            this.txt_Tìm.Text = "Nhập điều kiện để tìm kiếm";
            this.txt_Tìm.Click += new System.EventHandler(this.txt_Tìm_Click);
            this.txt_Tìm.TextChanged += new System.EventHandler(this.txt_Tìm_TextChanged);
            this.txt_Tìm.Leave += new System.EventHandler(this.txt_Tìm_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chọn:";
            // 
            // btn_Tim
            // 
            this.btn_Tim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Tim.BackgroundImage = global::QuanLyKhachSan.Properties.Resources.Screenshot_2023_04_12_040044;
            this.btn_Tim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Tim.Location = new System.Drawing.Point(713, 4);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(50, 39);
            this.btn_Tim.TabIndex = 7;
            this.btn_Tim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.BackColor = System.Drawing.Color.Salmon;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Exit.Image = global::QuanLyKhachSan.Properties.Resources.exit;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(909, 8);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Exit.Size = new System.Drawing.Size(64, 35);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_DatPhong
            // 
            this.btn_DatPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DatPhong.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_DatPhong.Image = global::QuanLyKhachSan.Properties.Resources.calendar_check__1_;
            this.btn_DatPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DatPhong.Location = new System.Drawing.Point(762, 4);
            this.btn_DatPhong.Name = "btn_DatPhong";
            this.btn_DatPhong.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_DatPhong.Size = new System.Drawing.Size(141, 43);
            this.btn_DatPhong.TabIndex = 3;
            this.btn_DatPhong.Text = "ĐẶT PHÒNG";
            this.btn_DatPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DatPhong.UseVisualStyleBackColor = false;
            this.btn_DatPhong.Click += new System.EventHandler(this.btn_DatPhong_Click);
            // 
            // datPhongDTOBindingSource
            // 
            this.datPhongDTOBindingSource.DataSource = typeof(DTO.DatPhong_DTO);
            // 
            // iDDatPhongDataGridViewTextBoxColumn
            // 
            this.iDDatPhongDataGridViewTextBoxColumn.DataPropertyName = "IDDatPhong";
            this.iDDatPhongDataGridViewTextBoxColumn.HeaderText = "ID Đặt Phòng";
            this.iDDatPhongDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDatPhongDataGridViewTextBoxColumn.Name = "iDDatPhongDataGridViewTextBoxColumn";
            this.iDDatPhongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenKHDataGridViewTextBoxColumn
            // 
            this.tenKHDataGridViewTextBoxColumn.DataPropertyName = "TenKH";
            this.tenKHDataGridViewTextBoxColumn.HeaderText = "Tên Khách Hàng";
            this.tenKHDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenKHDataGridViewTextBoxColumn.Name = "tenKHDataGridViewTextBoxColumn";
            this.tenKHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NgaylapphieuDP
            // 
            this.NgaylapphieuDP.DataPropertyName = "NgaylapphieuDP";
            this.NgaylapphieuDP.HeaderText = "Ngày Lập ";
            this.NgaylapphieuDP.MinimumWidth = 8;
            this.NgaylapphieuDP.Name = "NgaylapphieuDP";
            this.NgaylapphieuDP.ReadOnly = true;
            // 
            // Tranthai
            // 
            this.Tranthai.DataPropertyName = "Tranthai";
            this.Tranthai.HeaderText = "Tranthai";
            this.Tranthai.MinimumWidth = 8;
            this.Tranthai.Name = "Tranthai";
            this.Tranthai.ReadOnly = true;
            // 
            // frm_DS_DatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(975, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.txt_Tìm);
            this.Controls.Add(this.cbb_Chon);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_DatPhong);
            this.Controls.Add(this.dateTime_ngaylap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_DS_DatPhong";
            this.Text = "DANH SÁCH ĐẶT PHÒNG";
            this.Load += new System.EventHandler(this.frm_DS_DatPhong_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSdatphong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATPHONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datPhongDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_DSdatphong;
        private System.Windows.Forms.Label label1;
        private QLKSDataSet qLKSDataSet;
        private System.Windows.Forms.BindingSource dATPHONGBindingSource;
        private QLKSDataSetTableAdapters.DATPHONGTableAdapter dATPHONGTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTime_ngaylap;
        private System.Windows.Forms.Button btn_DatPhong;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ComboBox cbb_Chon;
        private System.Windows.Forms.TextBox txt_Tìm;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource datPhongDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDatPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaylapphieuDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tranthai;
    }
}