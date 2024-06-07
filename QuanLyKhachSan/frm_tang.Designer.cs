namespace QuanLyKhachSan
{
    partial class frm_tang
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
            this.btn_them = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tentang = new System.Windows.Forms.TextBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.dgv_tang = new System.Windows.Forms.DataGridView();
            this.iDtangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tangDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tangDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_them
            // 
            this.btn_them.Image = global::QuanLyKhachSan.Properties.Resources.plus__1_;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(334, 12);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(115, 35);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập tầng: ";
            // 
            // txt_tentang
            // 
            this.txt_tentang.Location = new System.Drawing.Point(98, 18);
            this.txt_tentang.Name = "txt_tentang";
            this.txt_tentang.Size = new System.Drawing.Size(230, 26);
            this.txt_tentang.TabIndex = 2;
            // 
            // btn_sua
            // 
            this.btn_sua.Image = global::QuanLyKhachSan.Properties.Resources.settings;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(463, 12);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(132, 35);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Cập nhật";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btndong
            // 
            this.btndong.Image = global::QuanLyKhachSan.Properties.Resources.Screenshot_20221102_080018;
            this.btndong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndong.Location = new System.Drawing.Point(601, 10);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(128, 35);
            this.btndong.TabIndex = 1;
            this.btndong.Text = "Đóng";
            this.btndong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // dgv_tang
            // 
            this.dgv_tang.AutoGenerateColumns = false;
            this.dgv_tang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tang.BackgroundColor = System.Drawing.Color.White;
            this.dgv_tang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDtangDataGridViewTextBoxColumn,
            this.tenTangDataGridViewTextBoxColumn});
            this.dgv_tang.DataSource = this.tangDTOBindingSource;
            this.dgv_tang.Location = new System.Drawing.Point(12, 53);
            this.dgv_tang.MultiSelect = false;
            this.dgv_tang.Name = "dgv_tang";
            this.dgv_tang.ReadOnly = true;
            this.dgv_tang.RowHeadersWidth = 62;
            this.dgv_tang.RowTemplate.Height = 28;
            this.dgv_tang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tang.Size = new System.Drawing.Size(717, 348);
            this.dgv_tang.TabIndex = 3;
            // 
            // iDtangDataGridViewTextBoxColumn
            // 
            this.iDtangDataGridViewTextBoxColumn.DataPropertyName = "IDtang";
            this.iDtangDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDtangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDtangDataGridViewTextBoxColumn.Name = "iDtangDataGridViewTextBoxColumn";
            this.iDtangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenTangDataGridViewTextBoxColumn
            // 
            this.tenTangDataGridViewTextBoxColumn.DataPropertyName = "TenTang";
            this.tenTangDataGridViewTextBoxColumn.HeaderText = "Số Tầng";
            this.tenTangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenTangDataGridViewTextBoxColumn.Name = "tenTangDataGridViewTextBoxColumn";
            this.tenTangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tangDTOBindingSource
            // 
            this.tangDTOBindingSource.DataSource = typeof(DTO.Tang_DTO);
            // 
            // frm_tang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 416);
            this.Controls.Add(this.dgv_tang);
            this.Controls.Add(this.txt_tentang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_tang";
            this.Text = "QUẢN LÝ TẦNG";
            this.Load += new System.EventHandler(this.frm_tang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tangDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tentang;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.DataGridView dgv_tang;
        private System.Windows.Forms.BindingSource tangDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDtangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTangDataGridViewTextBoxColumn;
    }
}