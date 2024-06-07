namespace QuanLyKhachSan
{
    partial class frm_hethong
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
            this.btn_saoluu = new System.Windows.Forms.Button();
            this.btn_phuchoi = new System.Windows.Forms.Button();
            this.btn_doimatkhau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_saoluu
            // 
            this.btn_saoluu.Location = new System.Drawing.Point(33, 24);
            this.btn_saoluu.Name = "btn_saoluu";
            this.btn_saoluu.Size = new System.Drawing.Size(140, 45);
            this.btn_saoluu.TabIndex = 0;
            this.btn_saoluu.Text = "Sao lưu dữ liệu";
            this.btn_saoluu.UseVisualStyleBackColor = true;
            this.btn_saoluu.Click += new System.EventHandler(this.btn_saoluu_Click);
            // 
            // btn_phuchoi
            // 
            this.btn_phuchoi.Location = new System.Drawing.Point(198, 24);
            this.btn_phuchoi.Name = "btn_phuchoi";
            this.btn_phuchoi.Size = new System.Drawing.Size(140, 45);
            this.btn_phuchoi.TabIndex = 0;
            this.btn_phuchoi.Text = "Phục hồi dữ liệu ";
            this.btn_phuchoi.UseVisualStyleBackColor = true;
            this.btn_phuchoi.Click += new System.EventHandler(this.btn_phuchoi_Click);
            // 
            // btn_doimatkhau
            // 
            this.btn_doimatkhau.Location = new System.Drawing.Point(369, 24);
            this.btn_doimatkhau.Name = "btn_doimatkhau";
            this.btn_doimatkhau.Size = new System.Drawing.Size(140, 45);
            this.btn_doimatkhau.TabIndex = 0;
            this.btn_doimatkhau.Text = "Đổi mật khẩu";
            this.btn_doimatkhau.UseVisualStyleBackColor = true;
            this.btn_doimatkhau.Click += new System.EventHandler(this.btn_doimatkhau_Click);
            // 
            // frm_hethong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 87);
            this.Controls.Add(this.btn_doimatkhau);
            this.Controls.Add(this.btn_phuchoi);
            this.Controls.Add(this.btn_saoluu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_hethong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG";
            this.Load += new System.EventHandler(this.frm_hethong_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_saoluu;
        private System.Windows.Forms.Button btn_phuchoi;
        private System.Windows.Forms.Button btn_doimatkhau;
    }
}