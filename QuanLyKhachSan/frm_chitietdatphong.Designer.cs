namespace QuanLyKhachSan
{
    partial class frm_chitietdatphong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_danhsachdichvu = new System.Windows.Forms.DataGridView();
            this.iDPHONG1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiaDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtienDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySDDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datPhongDichVuDTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_danhsachphongdat = new System.Windows.Forms.DataGridView();
            this.iDPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaydatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaytraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietDatPhongDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_iddatphong = new System.Windows.Forms.Label();
            this.txttenkh = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_capnhatphieudatphong = new System.Windows.Forms.Button();
            this.txt_tongtien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datPhongDichVuDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachdichvu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datPhongDichVuDTOBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachphongdat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDatPhongDTOBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datPhongDichVuDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_danhsachdichvu
            // 
            this.dgv_danhsachdichvu.AllowUserToDeleteRows = false;
            this.dgv_danhsachdichvu.AutoGenerateColumns = false;
            this.dgv_danhsachdichvu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_danhsachdichvu.BackgroundColor = System.Drawing.Color.White;
            this.dgv_danhsachdichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachdichvu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPHONG1DataGridViewTextBoxColumn,
            this.iDDVDataGridViewTextBoxColumn,
            this.tenDVDataGridViewTextBoxColumn,
            this.soluongDVDataGridViewTextBoxColumn,
            this.dongiaDVDataGridViewTextBoxColumn,
            this.thanhtienDVDataGridViewTextBoxColumn,
            this.ngaySDDVDataGridViewTextBoxColumn});
            this.dgv_danhsachdichvu.DataSource = this.datPhongDichVuDTOBindingSource1;
            this.dgv_danhsachdichvu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_danhsachdichvu.Location = new System.Drawing.Point(3, 22);
            this.dgv_danhsachdichvu.MultiSelect = false;
            this.dgv_danhsachdichvu.Name = "dgv_danhsachdichvu";
            this.dgv_danhsachdichvu.ReadOnly = true;
            this.dgv_danhsachdichvu.RowHeadersWidth = 62;
            this.dgv_danhsachdichvu.RowTemplate.Height = 28;
            this.dgv_danhsachdichvu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_danhsachdichvu.Size = new System.Drawing.Size(600, 477);
            this.dgv_danhsachdichvu.TabIndex = 0;
            this.dgv_danhsachdichvu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachdichvu_CellContentClick);
            this.dgv_danhsachdichvu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_danhsachdichvu_MouseClick);
            // 
            // iDPHONG1DataGridViewTextBoxColumn
            // 
            this.iDPHONG1DataGridViewTextBoxColumn.DataPropertyName = "ID_PHONG1";
            this.iDPHONG1DataGridViewTextBoxColumn.HeaderText = "ID PHÒNG";
            this.iDPHONG1DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDPHONG1DataGridViewTextBoxColumn.Name = "iDPHONG1DataGridViewTextBoxColumn";
            this.iDPHONG1DataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPHONG1DataGridViewTextBoxColumn.Width = 115;
            // 
            // iDDVDataGridViewTextBoxColumn
            // 
            this.iDDVDataGridViewTextBoxColumn.DataPropertyName = "IDDV";
            this.iDDVDataGridViewTextBoxColumn.HeaderText = "ID DỊCH VỤ";
            this.iDDVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDVDataGridViewTextBoxColumn.Name = "iDDVDataGridViewTextBoxColumn";
            this.iDDVDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDVDataGridViewTextBoxColumn.Width = 123;
            // 
            // tenDVDataGridViewTextBoxColumn
            // 
            this.tenDVDataGridViewTextBoxColumn.DataPropertyName = "TenDV";
            this.tenDVDataGridViewTextBoxColumn.HeaderText = "TÊN DỊCH VỤ";
            this.tenDVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenDVDataGridViewTextBoxColumn.Name = "tenDVDataGridViewTextBoxColumn";
            this.tenDVDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenDVDataGridViewTextBoxColumn.Width = 115;
            // 
            // soluongDVDataGridViewTextBoxColumn
            // 
            this.soluongDVDataGridViewTextBoxColumn.DataPropertyName = "SoluongDV";
            dataGridViewCellStyle1.Format = "N0";
            this.soluongDVDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.soluongDVDataGridViewTextBoxColumn.HeaderText = "SỐ LƯỢNG";
            this.soluongDVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soluongDVDataGridViewTextBoxColumn.Name = "soluongDVDataGridViewTextBoxColumn";
            this.soluongDVDataGridViewTextBoxColumn.ReadOnly = true;
            this.soluongDVDataGridViewTextBoxColumn.Width = 119;
            // 
            // dongiaDVDataGridViewTextBoxColumn
            // 
            this.dongiaDVDataGridViewTextBoxColumn.DataPropertyName = "DongiaDV";
            dataGridViewCellStyle2.Format = "N0";
            this.dongiaDVDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dongiaDVDataGridViewTextBoxColumn.HeaderText = "ĐƠN GIÁ";
            this.dongiaDVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dongiaDVDataGridViewTextBoxColumn.Name = "dongiaDVDataGridViewTextBoxColumn";
            this.dongiaDVDataGridViewTextBoxColumn.ReadOnly = true;
            this.dongiaDVDataGridViewTextBoxColumn.Width = 105;
            // 
            // thanhtienDVDataGridViewTextBoxColumn
            // 
            this.thanhtienDVDataGridViewTextBoxColumn.DataPropertyName = "ThanhtienDV";
            dataGridViewCellStyle3.Format = "N0";
            this.thanhtienDVDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.thanhtienDVDataGridViewTextBoxColumn.HeaderText = "THÀNH TIỀN";
            this.thanhtienDVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.thanhtienDVDataGridViewTextBoxColumn.Name = "thanhtienDVDataGridViewTextBoxColumn";
            this.thanhtienDVDataGridViewTextBoxColumn.ReadOnly = true;
            this.thanhtienDVDataGridViewTextBoxColumn.Width = 129;
            // 
            // ngaySDDVDataGridViewTextBoxColumn
            // 
            this.ngaySDDVDataGridViewTextBoxColumn.DataPropertyName = "NgaySD_DV";
            this.ngaySDDVDataGridViewTextBoxColumn.HeaderText = "NGÀY SỬ DỤNG";
            this.ngaySDDVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngaySDDVDataGridViewTextBoxColumn.Name = "ngaySDDVDataGridViewTextBoxColumn";
            this.ngaySDDVDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngaySDDVDataGridViewTextBoxColumn.Width = 156;
            // 
            // datPhongDichVuDTOBindingSource1
            // 
            this.datPhongDichVuDTOBindingSource1.DataSource = typeof(DTO.DatPhong_DichVu_DTO);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.dgv_danhsachdichvu);
            this.groupBox1.Location = new System.Drawing.Point(9, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 502);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH CÁC DỊCH VỤ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.dgv_danhsachphongdat);
            this.groupBox2.Location = new System.Drawing.Point(621, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 502);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DANH SÁCH PHÒNG ĐẶT";
            // 
            // dgv_danhsachphongdat
            // 
            this.dgv_danhsachphongdat.AutoGenerateColumns = false;
            this.dgv_danhsachphongdat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_danhsachphongdat.BackgroundColor = System.Drawing.Color.White;
            this.dgv_danhsachphongdat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachphongdat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPhongDataGridViewTextBoxColumn,
            this.tenPhongDataGridViewTextBoxColumn,
            this.ngaydatDataGridViewTextBoxColumn,
            this.ngaytraDataGridViewTextBoxColumn,
            this.tenLoaiPDataGridViewTextBoxColumn,
            this.thanhtienDataGridViewTextBoxColumn});
            this.dgv_danhsachphongdat.DataSource = this.chiTietDatPhongDTOBindingSource;
            this.dgv_danhsachphongdat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_danhsachphongdat.Location = new System.Drawing.Point(3, 22);
            this.dgv_danhsachphongdat.MultiSelect = false;
            this.dgv_danhsachphongdat.Name = "dgv_danhsachphongdat";
            this.dgv_danhsachphongdat.ReadOnly = true;
            this.dgv_danhsachphongdat.RowHeadersWidth = 62;
            this.dgv_danhsachphongdat.RowTemplate.Height = 28;
            this.dgv_danhsachphongdat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_danhsachphongdat.Size = new System.Drawing.Size(622, 477);
            this.dgv_danhsachphongdat.TabIndex = 0;
            this.dgv_danhsachphongdat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_danhsachphongdat_MouseClick);
            // 
            // iDPhongDataGridViewTextBoxColumn
            // 
            this.iDPhongDataGridViewTextBoxColumn.DataPropertyName = "IDPhong";
            this.iDPhongDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDPhongDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDPhongDataGridViewTextBoxColumn.Name = "iDPhongDataGridViewTextBoxColumn";
            this.iDPhongDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPhongDataGridViewTextBoxColumn.Width = 62;
            // 
            // tenPhongDataGridViewTextBoxColumn
            // 
            this.tenPhongDataGridViewTextBoxColumn.DataPropertyName = "TenPhong";
            this.tenPhongDataGridViewTextBoxColumn.HeaderText = "PHÒNG";
            this.tenPhongDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenPhongDataGridViewTextBoxColumn.Name = "tenPhongDataGridViewTextBoxColumn";
            this.tenPhongDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenPhongDataGridViewTextBoxColumn.Width = 103;
            // 
            // ngaydatDataGridViewTextBoxColumn
            // 
            this.ngaydatDataGridViewTextBoxColumn.DataPropertyName = "Ngaydat";
            this.ngaydatDataGridViewTextBoxColumn.HeaderText = "NGÀY ĐẶT";
            this.ngaydatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngaydatDataGridViewTextBoxColumn.Name = "ngaydatDataGridViewTextBoxColumn";
            this.ngaydatDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngaydatDataGridViewTextBoxColumn.Width = 127;
            // 
            // ngaytraDataGridViewTextBoxColumn
            // 
            this.ngaytraDataGridViewTextBoxColumn.DataPropertyName = "Ngaytra";
            this.ngaytraDataGridViewTextBoxColumn.HeaderText = "NGÀY TRẢ";
            this.ngaytraDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngaytraDataGridViewTextBoxColumn.Name = "ngaytraDataGridViewTextBoxColumn";
            this.ngaytraDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngaytraDataGridViewTextBoxColumn.Width = 127;
            // 
            // tenLoaiPDataGridViewTextBoxColumn
            // 
            this.tenLoaiPDataGridViewTextBoxColumn.DataPropertyName = "TenLoaiP";
            this.tenLoaiPDataGridViewTextBoxColumn.HeaderText = "LOẠI PHÒNG";
            this.tenLoaiPDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenLoaiPDataGridViewTextBoxColumn.Name = "tenLoaiPDataGridViewTextBoxColumn";
            this.tenLoaiPDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenLoaiPDataGridViewTextBoxColumn.Width = 144;
            // 
            // thanhtienDataGridViewTextBoxColumn
            // 
            this.thanhtienDataGridViewTextBoxColumn.DataPropertyName = "Thanhtien";
            dataGridViewCellStyle4.Format = "N0";
            this.thanhtienDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.thanhtienDataGridViewTextBoxColumn.HeaderText = "THÀNH TIỀN";
            this.thanhtienDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.thanhtienDataGridViewTextBoxColumn.Name = "thanhtienDataGridViewTextBoxColumn";
            this.thanhtienDataGridViewTextBoxColumn.ReadOnly = true;
            this.thanhtienDataGridViewTextBoxColumn.Width = 140;
            // 
            // chiTietDatPhongDTOBindingSource
            // 
            this.chiTietDatPhongDTOBindingSource.DataSource = typeof(DTO.ChiTiet_DatPhong_DTO);
            // 
            // txt_iddatphong
            // 
            this.txt_iddatphong.AutoSize = true;
            this.txt_iddatphong.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_iddatphong.Location = new System.Drawing.Point(6, 29);
            this.txt_iddatphong.Name = "txt_iddatphong";
            this.txt_iddatphong.Size = new System.Drawing.Size(139, 19);
            this.txt_iddatphong.TabIndex = 3;
            this.txt_iddatphong.Text = "-ID ĐẶT PHÒNG: ";
            // 
            // txttenkh
            // 
            this.txttenkh.AutoSize = true;
            this.txttenkh.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenkh.Location = new System.Drawing.Point(294, 29);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(164, 19);
            this.txttenkh.TabIndex = 3;
            this.txttenkh.Text = "-TÊN KHÁCH HÀNG:";
            this.txttenkh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.MintCream;
            this.groupBox3.Controls.Add(this.txt_iddatphong);
            this.groupBox3.Controls.Add(this.txttenkh);
            this.groupBox3.Location = new System.Drawing.Point(9, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(870, 62);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "THÔNG TIN ĐẶT PHÒNG";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.btn_capnhatphieudatphong);
            this.panel1.Controls.Add(this.txt_tongtien);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_dong);
            this.panel1.Controls.Add(this.btn_thanhtoan);
            this.panel1.Location = new System.Drawing.Point(921, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 121);
            this.panel1.TabIndex = 5;
            // 
            // btn_capnhatphieudatphong
            // 
            this.btn_capnhatphieudatphong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_capnhatphieudatphong.Enabled = false;
            this.btn_capnhatphieudatphong.Image = global::QuanLyKhachSan.Properties.Resources.edit__1_;
            this.btn_capnhatphieudatphong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_capnhatphieudatphong.Location = new System.Drawing.Point(16, 79);
            this.btn_capnhatphieudatphong.Name = "btn_capnhatphieudatphong";
            this.btn_capnhatphieudatphong.Size = new System.Drawing.Size(186, 39);
            this.btn_capnhatphieudatphong.TabIndex = 10;
            this.btn_capnhatphieudatphong.Text = "Chỉnh sửa";
            this.btn_capnhatphieudatphong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_capnhatphieudatphong.UseVisualStyleBackColor = false;
            this.btn_capnhatphieudatphong.Click += new System.EventHandler(this.btn_capnhatphieudatphong_Click);
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.AutoSize = true;
            this.txt_tongtien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongtien.ForeColor = System.Drawing.Color.Red;
            this.txt_tongtien.Location = new System.Drawing.Point(146, 10);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(96, 20);
            this.txt_tongtien.TabIndex = 6;
            this.txt_tongtien.Text = "10000000 đ";
            this.txt_tongtien.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "TỔNG TIỀN:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_dong
            // 
            this.btn_dong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dong.BackColor = System.Drawing.Color.Red;
            this.btn_dong.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dong.Image = global::QuanLyKhachSan.Properties.Resources.times_hexagon__1_;
            this.btn_dong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dong.Location = new System.Drawing.Point(215, 35);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(98, 38);
            this.btn_dong.TabIndex = 8;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dong.UseVisualStyleBackColor = false;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click_1);
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_thanhtoan.BackColor = System.Drawing.Color.LightGreen;
            this.btn_thanhtoan.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thanhtoan.Image = global::QuanLyKhachSan.Properties.Resources.file_invoice_dollar;
            this.btn_thanhtoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thanhtoan.Location = new System.Drawing.Point(16, 38);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(186, 38);
            this.btn_thanhtoan.TabIndex = 9;
            this.btn_thanhtoan.Text = "Thanh toán";
            this.btn_thanhtoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thanhtoan.UseVisualStyleBackColor = false;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(505, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "CHI TIẾT ĐẶT PHÒNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(15, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(478, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "* Nếu chưa tới thời gian trả phòng có thể cập nhật lại thời gian trả phòng cho kh" +
    "ách hàng.";
            // 
            // datPhongDichVuDTOBindingSource
            // 
            this.datPhongDichVuDTOBindingSource.DataSource = typeof(DTO.DatPhong_DichVu_DTO);
            // 
            // frm_chitietdatphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1261, 643);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_chitietdatphong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHI TIẾT ĐẶT PHÒNG";
            this.Load += new System.EventHandler(this.frm_chitietdatphong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachdichvu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datPhongDichVuDTOBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachphongdat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDatPhongDTOBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datPhongDichVuDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_danhsachdichvu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txt_iddatphong;
        private System.Windows.Forms.Label txttenkh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource chiTietDatPhongDTOBindingSource;
        private System.Windows.Forms.BindingSource datPhongDichVuDTOBindingSource;
        public System.Windows.Forms.DataGridView dgv_danhsachphongdat;
        private System.Windows.Forms.BindingSource datPhongDichVuDTOBindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt_tongtien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPHONG1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiaDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtienDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySDDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaydatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaytraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtienDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_capnhatphieudatphong;
    }
}