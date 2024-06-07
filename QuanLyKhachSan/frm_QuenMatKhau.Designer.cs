namespace QuanLyKhachSan
{
    partial class frm_QuenMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_TK = new System.Windows.Forms.Label();
            this.lb_pass = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUSERNAME = new System.Windows.Forms.TextBox();
            this.txtPASS = new System.Windows.Forms.TextBox();
            this.txtXACTHUCPASS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi Mật Khẩu";
            // 
            // lb_TK
            // 
            this.lb_TK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_TK.AutoSize = true;
            this.lb_TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TK.Location = new System.Drawing.Point(32, 161);
            this.lb_TK.Name = "lb_TK";
            this.lb_TK.Size = new System.Drawing.Size(103, 20);
            this.lb_TK.TabIndex = 2;
            this.lb_TK.Text = "UserName :";
            this.lb_TK.Click += new System.EventHandler(this.lb_TK_Click);
            // 
            // lb_pass
            // 
            this.lb_pass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_pass.AutoSize = true;
            this.lb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pass.Location = new System.Drawing.Point(27, 190);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(108, 20);
            this.lb_pass.TabIndex = 2;
            this.lb_pass.Text = "Passwword :";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLuu.Image = global::QuanLyKhachSan.Properties.Resources.shield_check1;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(134, 268);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLuu.Size = new System.Drawing.Size(205, 50);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu Thay Đổi";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImage = global::QuanLyKhachSan.Properties.Resources._18;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(164, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 105);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xác thực pass :";
            // 
            // txtUSERNAME
            // 
            this.txtUSERNAME.Enabled = false;
            this.txtUSERNAME.Location = new System.Drawing.Point(191, 161);
            this.txtUSERNAME.Name = "txtUSERNAME";
            this.txtUSERNAME.Size = new System.Drawing.Size(241, 26);
            this.txtUSERNAME.TabIndex = 4;
            // 
            // txtPASS
            // 
            this.txtPASS.Location = new System.Drawing.Point(191, 190);
            this.txtPASS.Name = "txtPASS";
            this.txtPASS.Size = new System.Drawing.Size(241, 26);
            this.txtPASS.TabIndex = 4;
            // 
            // txtXACTHUCPASS
            // 
            this.txtXACTHUCPASS.Location = new System.Drawing.Point(191, 218);
            this.txtXACTHUCPASS.Name = "txtXACTHUCPASS";
            this.txtXACTHUCPASS.Size = new System.Drawing.Size(241, 26);
            this.txtXACTHUCPASS.TabIndex = 4;
            // 
            // frm_QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 332);
            this.Controls.Add(this.txtXACTHUCPASS);
            this.Controls.Add(this.txtPASS);
            this.Controls.Add(this.txtUSERNAME);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.lb_TK);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_QuenMatKhau";
            this.Text = "Quên mật khẩu";
            this.Load += new System.EventHandler(this.frm_QuenMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_TK;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUSERNAME;
        private System.Windows.Forms.TextBox txtPASS;
        private System.Windows.Forms.TextBox txtXACTHUCPASS;
    }
}