
namespace QuanLyBanSach.view
{
    partial class FrmDangKy
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
            this.lbl_DangKy = new System.Windows.Forms.Label();
            this.lbl_TenNguoiDung = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_SoDienThoai = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_TenDangNhap = new System.Windows.Forms.Label();
            this.lbl_MatKhau = new System.Windows.Forms.Label();
            this.txt_TenNguoiDung = new System.Windows.Forms.TextBox();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_DangKy
            // 
            this.lbl_DangKy.AutoSize = true;
            this.lbl_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_DangKy.Location = new System.Drawing.Point(229, 44);
            this.lbl_DangKy.Name = "lbl_DangKy";
            this.lbl_DangKy.Size = new System.Drawing.Size(264, 33);
            this.lbl_DangKy.TabIndex = 0;
            this.lbl_DangKy.Text = "Đăng ký thành viên";
            // 
            // lbl_TenNguoiDung
            // 
            this.lbl_TenNguoiDung.AutoSize = true;
            this.lbl_TenNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TenNguoiDung.Location = new System.Drawing.Point(60, 113);
            this.lbl_TenNguoiDung.Name = "lbl_TenNguoiDung";
            this.lbl_TenNguoiDung.Size = new System.Drawing.Size(174, 25);
            this.lbl_TenNguoiDung.TabIndex = 1;
            this.lbl_TenNguoiDung.Text = "Tên Người Dùng:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Email.Location = new System.Drawing.Point(370, 207);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(71, 25);
            this.lbl_Email.TabIndex = 1;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_SoDienThoai
            // 
            this.lbl_SoDienThoai.AutoSize = true;
            this.lbl_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_SoDienThoai.Location = new System.Drawing.Point(60, 207);
            this.lbl_SoDienThoai.Name = "lbl_SoDienThoai";
            this.lbl_SoDienThoai.Size = new System.Drawing.Size(60, 25);
            this.lbl_SoDienThoai.TabIndex = 1;
            this.lbl_SoDienThoai.Text = "SĐT:";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(60, 159);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(88, 25);
            this.lbl_DiaChi.TabIndex = 1;
            this.lbl_DiaChi.Text = "Địa Chỉ:";
            // 
            // lbl_TenDangNhap
            // 
            this.lbl_TenDangNhap.AutoSize = true;
            this.lbl_TenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TenDangNhap.Location = new System.Drawing.Point(60, 258);
            this.lbl_TenDangNhap.Name = "lbl_TenDangNhap";
            this.lbl_TenDangNhap.Size = new System.Drawing.Size(169, 25);
            this.lbl_TenDangNhap.TabIndex = 1;
            this.lbl_TenDangNhap.Text = "Tên Đăng Nhập:";
            // 
            // lbl_MatKhau
            // 
            this.lbl_MatKhau.AutoSize = true;
            this.lbl_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MatKhau.Location = new System.Drawing.Point(60, 305);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(110, 25);
            this.lbl_MatKhau.TabIndex = 1;
            this.lbl_MatKhau.Text = "Mật Khẩu:";
            // 
            // txt_TenNguoiDung
            // 
            this.txt_TenNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenNguoiDung.Location = new System.Drawing.Point(248, 105);
            this.txt_TenNguoiDung.Name = "txt_TenNguoiDung";
            this.txt_TenNguoiDung.Size = new System.Drawing.Size(431, 31);
            this.txt_TenNguoiDung.TabIndex = 2;
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SoDienThoai.Location = new System.Drawing.Point(126, 204);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(220, 31);
            this.txt_SoDienThoai.TabIndex = 2;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_DiaChi.Location = new System.Drawing.Point(248, 155);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(431, 31);
            this.txt_DiaChi.TabIndex = 3;
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Email.Location = new System.Drawing.Point(448, 205);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(231, 31);
            this.txt_Email.TabIndex = 4;
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenDangNhap.Location = new System.Drawing.Point(248, 255);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(430, 31);
            this.txt_TenDangNhap.TabIndex = 5;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MatKhau.Location = new System.Drawing.Point(248, 304);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(429, 31);
            this.txt_MatKhau.TabIndex = 6;
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DangKy.Location = new System.Drawing.Point(169, 367);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(156, 35);
            this.btn_DangKy.TabIndex = 7;
            this.btn_DangKy.Text = "Đăng Ký";
            this.btn_DangKy.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thoat.Location = new System.Drawing.Point(412, 367);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(156, 35);
            this.btn_Thoat.TabIndex = 7;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // FrmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_TenDangNhap);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txt_SoDienThoai);
            this.Controls.Add(this.txt_TenNguoiDung);
            this.Controls.Add(this.lbl_MatKhau);
            this.Controls.Add(this.lbl_TenDangNhap);
            this.Controls.Add(this.lbl_DiaChi);
            this.Controls.Add(this.lbl_SoDienThoai);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_TenNguoiDung);
            this.Controls.Add(this.lbl_DangKy);
            this.Name = "FrmDangKy";
            this.Text = "Đăng Ký Thành Viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DangKy;
        private System.Windows.Forms.Label lbl_TenNguoiDung;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_SoDienThoai;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_TenDangNhap;
        private System.Windows.Forms.Label lbl_MatKhau;
        private System.Windows.Forms.TextBox txt_TenNguoiDung;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_TenDangNhap;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.Button btn_Thoat;
    }
}