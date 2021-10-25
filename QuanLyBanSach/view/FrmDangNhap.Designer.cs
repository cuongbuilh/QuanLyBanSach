
namespace QuanLyBanSach.view
{
    partial class FrmDangNhap
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
            this.lbl_DangNhap = new System.Windows.Forms.Label();
            this.lbl_TenDangNhap = new System.Windows.Forms.Label();
            this.lbl_MatKhau = new System.Windows.Forms.Label();
            this.txt_DangNhap = new System.Windows.Forms.TextBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_DangNhap
            // 
            this.lbl_DangNhap.AutoSize = true;
            this.lbl_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_DangNhap.Location = new System.Drawing.Point(157, 7);
            this.lbl_DangNhap.Name = "lbl_DangNhap";
            this.lbl_DangNhap.Size = new System.Drawing.Size(161, 33);
            this.lbl_DangNhap.TabIndex = 0;
            this.lbl_DangNhap.Text = "Đăng Nhập";
            // 
            // lbl_TenDangNhap
            // 
            this.lbl_TenDangNhap.AutoSize = true;
            this.lbl_TenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TenDangNhap.Location = new System.Drawing.Point(12, 75);
            this.lbl_TenDangNhap.Name = "lbl_TenDangNhap";
            this.lbl_TenDangNhap.Size = new System.Drawing.Size(163, 25);
            this.lbl_TenDangNhap.TabIndex = 1;
            this.lbl_TenDangNhap.Text = "Tên đăng nhập:";
            // 
            // lbl_MatKhau
            // 
            this.lbl_MatKhau.AutoSize = true;
            this.lbl_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MatKhau.Location = new System.Drawing.Point(65, 112);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(110, 25);
            this.lbl_MatKhau.TabIndex = 1;
            this.lbl_MatKhau.Text = "Mật Khẩu:";
            // 
            // txt_DangNhap
            // 
            this.txt_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_DangNhap.Location = new System.Drawing.Point(190, 75);
            this.txt_DangNhap.Name = "txt_DangNhap";
            this.txt_DangNhap.Size = new System.Drawing.Size(190, 31);
            this.txt_DangNhap.TabIndex = 1;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MatKhau.Location = new System.Drawing.Point(190, 112);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(190, 31);
            this.txt_MatKhau.TabIndex = 2;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DangNhap.Location = new System.Drawing.Point(270, 162);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(127, 40);
            this.btn_DangNhap.TabIndex = 3;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thoat.Location = new System.Drawing.Point(406, 9);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 39);
            this.btn_Thoat.TabIndex = 3;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DangKy.Location = new System.Drawing.Point(70, 162);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(127, 40);
            this.btn_DangKy.TabIndex = 3;
            this.btn_DangKy.Text = "Đăng ký";
            this.btn_DangKy.UseVisualStyleBackColor = true;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 229);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_DangNhap);
            this.Controls.Add(this.lbl_MatKhau);
            this.Controls.Add(this.lbl_TenDangNhap);
            this.Controls.Add(this.lbl_DangNhap);
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.FrmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DangNhap;
        private System.Windows.Forms.Label lbl_TenDangNhap;
        private System.Windows.Forms.Label lbl_MatKhau;
        private System.Windows.Forms.TextBox txt_DangNhap;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_DangKy;
    }
}