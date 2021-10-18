
namespace QuanLyBanSach.view
{
    partial class FrmSach
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
            this.lbl_Sach = new System.Windows.Forms.Label();
            this.gr_Sach = new System.Windows.Forms.GroupBox();
            this.btn_ThemSach = new System.Windows.Forms.Button();
            this.btn_SuaSach = new System.Windows.Forms.Button();
            this.btn_LuuSach = new System.Windows.Forms.Button();
            this.btn_XoaSach = new System.Windows.Forms.Button();
            this.btn_ThoatSach = new System.Windows.Forms.Button();
            this.btn_TimKiemSach = new System.Windows.Forms.Button();
            this.view_Sach = new System.Windows.Forms.DataGridView();
            this.rdo_MaSach = new System.Windows.Forms.RadioButton();
            this.rdo_TenSach = new System.Windows.Forms.RadioButton();
            this.lbl_MaSach = new System.Windows.Forms.Label();
            this.lbl_TenSach = new System.Windows.Forms.Label();
            this.txt_MaSach = new System.Windows.Forms.TextBox();
            this.txt_TenSach = new System.Windows.Forms.TextBox();
            this.txt_MaNXB = new System.Windows.Forms.TextBox();
            this.txt_MaTacGia = new System.Windows.Forms.TextBox();
            this.txt_GiaBia = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txt_NSX = new System.Windows.Forms.TextBox();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_MaNXB = new System.Windows.Forms.Label();
            this.lbl_MaTacGia = new System.Windows.Forms.Label();
            this.lbl_GiaBia = new System.Windows.Forms.Label();
            this.lbl_GiaBan = new System.Windows.Forms.Label();
            this.lbl_NSX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaLoai = new System.Windows.Forms.TextBox();
            this.gr_Sach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_Sach)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Sach
            // 
            this.lbl_Sach.AutoSize = true;
            this.lbl_Sach.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Sach.Location = new System.Drawing.Point(493, 35);
            this.lbl_Sach.Name = "lbl_Sach";
            this.lbl_Sach.Size = new System.Drawing.Size(106, 44);
            this.lbl_Sach.TabIndex = 0;
            this.lbl_Sach.Text = "Sách";
            // 
            // gr_Sach
            // 
            this.gr_Sach.Controls.Add(this.txt_MaLoai);
            this.gr_Sach.Controls.Add(this.label1);
            this.gr_Sach.Controls.Add(this.lbl_NSX);
            this.gr_Sach.Controls.Add(this.lbl_GiaBan);
            this.gr_Sach.Controls.Add(this.lbl_GiaBia);
            this.gr_Sach.Controls.Add(this.lbl_MaTacGia);
            this.gr_Sach.Controls.Add(this.lbl_MaNXB);
            this.gr_Sach.Controls.Add(this.txt_NSX);
            this.gr_Sach.Controls.Add(this.textBox6);
            this.gr_Sach.Controls.Add(this.txt_GiaBia);
            this.gr_Sach.Controls.Add(this.txt_MaTacGia);
            this.gr_Sach.Controls.Add(this.txt_MaNXB);
            this.gr_Sach.Controls.Add(this.txt_TenSach);
            this.gr_Sach.Controls.Add(this.txt_MaSach);
            this.gr_Sach.Controls.Add(this.lbl_TenSach);
            this.gr_Sach.Controls.Add(this.lbl_MaSach);
            this.gr_Sach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gr_Sach.Location = new System.Drawing.Point(28, 101);
            this.gr_Sach.Name = "gr_Sach";
            this.gr_Sach.Size = new System.Drawing.Size(660, 491);
            this.gr_Sach.TabIndex = 1;
            this.gr_Sach.TabStop = false;
            this.gr_Sach.Text = "Thông tin Sách";
            // 
            // btn_ThemSach
            // 
            this.btn_ThemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThemSach.Location = new System.Drawing.Point(707, 118);
            this.btn_ThemSach.Name = "btn_ThemSach";
            this.btn_ThemSach.Size = new System.Drawing.Size(173, 54);
            this.btn_ThemSach.TabIndex = 2;
            this.btn_ThemSach.Text = "Thêm";
            this.btn_ThemSach.UseVisualStyleBackColor = true;
            // 
            // btn_SuaSach
            // 
            this.btn_SuaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_SuaSach.Location = new System.Drawing.Point(913, 118);
            this.btn_SuaSach.Name = "btn_SuaSach";
            this.btn_SuaSach.Size = new System.Drawing.Size(173, 54);
            this.btn_SuaSach.TabIndex = 3;
            this.btn_SuaSach.Text = "Sửa";
            this.btn_SuaSach.UseVisualStyleBackColor = true;
            this.btn_SuaSach.Click += new System.EventHandler(this.btn_SuaSach_Click);
            // 
            // btn_LuuSach
            // 
            this.btn_LuuSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_LuuSach.Location = new System.Drawing.Point(707, 216);
            this.btn_LuuSach.Name = "btn_LuuSach";
            this.btn_LuuSach.Size = new System.Drawing.Size(173, 54);
            this.btn_LuuSach.TabIndex = 4;
            this.btn_LuuSach.Text = "Lưu";
            this.btn_LuuSach.UseVisualStyleBackColor = true;
            // 
            // btn_XoaSach
            // 
            this.btn_XoaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_XoaSach.Location = new System.Drawing.Point(913, 216);
            this.btn_XoaSach.Name = "btn_XoaSach";
            this.btn_XoaSach.Size = new System.Drawing.Size(173, 54);
            this.btn_XoaSach.TabIndex = 5;
            this.btn_XoaSach.Text = "Xóa";
            this.btn_XoaSach.UseVisualStyleBackColor = true;
            // 
            // btn_ThoatSach
            // 
            this.btn_ThoatSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThoatSach.Location = new System.Drawing.Point(913, 312);
            this.btn_ThoatSach.Name = "btn_ThoatSach";
            this.btn_ThoatSach.Size = new System.Drawing.Size(173, 54);
            this.btn_ThoatSach.TabIndex = 6;
            this.btn_ThoatSach.Text = "Thoát";
            this.btn_ThoatSach.UseVisualStyleBackColor = true;
            // 
            // btn_TimKiemSach
            // 
            this.btn_TimKiemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TimKiemSach.Location = new System.Drawing.Point(28, 598);
            this.btn_TimKiemSach.Name = "btn_TimKiemSach";
            this.btn_TimKiemSach.Size = new System.Drawing.Size(175, 54);
            this.btn_TimKiemSach.TabIndex = 7;
            this.btn_TimKiemSach.Text = "Tìm Kiếm";
            this.btn_TimKiemSach.UseVisualStyleBackColor = true;
            // 
            // view_Sach
            // 
            this.view_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_Sach.Location = new System.Drawing.Point(28, 672);
            this.view_Sach.Name = "view_Sach";
            this.view_Sach.RowHeadersWidth = 51;
            this.view_Sach.RowTemplate.Height = 24;
            this.view_Sach.Size = new System.Drawing.Size(999, 128);
            this.view_Sach.TabIndex = 8;
            // 
            // rdo_MaSach
            // 
            this.rdo_MaSach.AutoSize = true;
            this.rdo_MaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdo_MaSach.Location = new System.Drawing.Point(707, 600);
            this.rdo_MaSach.Name = "rdo_MaSach";
            this.rdo_MaSach.Size = new System.Drawing.Size(147, 36);
            this.rdo_MaSach.TabIndex = 9;
            this.rdo_MaSach.TabStop = true;
            this.rdo_MaSach.Text = "Mã Sách";
            this.rdo_MaSach.UseVisualStyleBackColor = true;
            // 
            // rdo_TenSach
            // 
            this.rdo_TenSach.AutoSize = true;
            this.rdo_TenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdo_TenSach.Location = new System.Drawing.Point(913, 600);
            this.rdo_TenSach.Name = "rdo_TenSach";
            this.rdo_TenSach.Size = new System.Drawing.Size(157, 36);
            this.rdo_TenSach.TabIndex = 10;
            this.rdo_TenSach.TabStop = true;
            this.rdo_TenSach.Text = "Tên Sách";
            this.rdo_TenSach.UseVisualStyleBackColor = true;
            // 
            // lbl_MaSach
            // 
            this.lbl_MaSach.AutoSize = true;
            this.lbl_MaSach.Location = new System.Drawing.Point(32, 56);
            this.lbl_MaSach.Name = "lbl_MaSach";
            this.lbl_MaSach.Size = new System.Drawing.Size(126, 32);
            this.lbl_MaSach.TabIndex = 0;
            this.lbl_MaSach.Text = "Mã Sách";
            // 
            // lbl_TenSach
            // 
            this.lbl_TenSach.AutoSize = true;
            this.lbl_TenSach.Location = new System.Drawing.Point(32, 109);
            this.lbl_TenSach.Name = "lbl_TenSach";
            this.lbl_TenSach.Size = new System.Drawing.Size(136, 32);
            this.lbl_TenSach.TabIndex = 1;
            this.lbl_TenSach.Text = "Tên Sách";
            // 
            // txt_MaSach
            // 
            this.txt_MaSach.Location = new System.Drawing.Point(259, 56);
            this.txt_MaSach.Name = "txt_MaSach";
            this.txt_MaSach.Size = new System.Drawing.Size(346, 38);
            this.txt_MaSach.TabIndex = 2;
            // 
            // txt_TenSach
            // 
            this.txt_TenSach.Location = new System.Drawing.Point(260, 109);
            this.txt_TenSach.Name = "txt_TenSach";
            this.txt_TenSach.Size = new System.Drawing.Size(346, 38);
            this.txt_TenSach.TabIndex = 3;
            // 
            // txt_MaNXB
            // 
            this.txt_MaNXB.Location = new System.Drawing.Point(260, 167);
            this.txt_MaNXB.Name = "txt_MaNXB";
            this.txt_MaNXB.Size = new System.Drawing.Size(345, 38);
            this.txt_MaNXB.TabIndex = 4;
            // 
            // txt_MaTacGia
            // 
            this.txt_MaTacGia.Location = new System.Drawing.Point(261, 220);
            this.txt_MaTacGia.Name = "txt_MaTacGia";
            this.txt_MaTacGia.Size = new System.Drawing.Size(345, 38);
            this.txt_MaTacGia.TabIndex = 5;
            // 
            // txt_GiaBia
            // 
            this.txt_GiaBia.Location = new System.Drawing.Point(261, 274);
            this.txt_GiaBia.Name = "txt_GiaBia";
            this.txt_GiaBia.Size = new System.Drawing.Size(344, 38);
            this.txt_GiaBia.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(262, 327);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(344, 38);
            this.textBox6.TabIndex = 7;
            // 
            // txt_NSX
            // 
            this.txt_NSX.Location = new System.Drawing.Point(263, 382);
            this.txt_NSX.Name = "txt_NSX";
            this.txt_NSX.Size = new System.Drawing.Size(343, 38);
            this.txt_NSX.TabIndex = 8;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TimKiem.Location = new System.Drawing.Point(291, 607);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(343, 38);
            this.txt_TimKiem.TabIndex = 11;
            // 
            // lbl_MaNXB
            // 
            this.lbl_MaNXB.AutoSize = true;
            this.lbl_MaNXB.Location = new System.Drawing.Point(32, 167);
            this.lbl_MaNXB.Name = "lbl_MaNXB";
            this.lbl_MaNXB.Size = new System.Drawing.Size(119, 32);
            this.lbl_MaNXB.TabIndex = 9;
            this.lbl_MaNXB.Text = "Mã NXB";
            // 
            // lbl_MaTacGia
            // 
            this.lbl_MaTacGia.AutoSize = true;
            this.lbl_MaTacGia.Location = new System.Drawing.Point(32, 223);
            this.lbl_MaTacGia.Name = "lbl_MaTacGia";
            this.lbl_MaTacGia.Size = new System.Drawing.Size(160, 32);
            this.lbl_MaTacGia.TabIndex = 10;
            this.lbl_MaTacGia.Text = "Mã Tác Giả";
            // 
            // lbl_GiaBia
            // 
            this.lbl_GiaBia.AutoSize = true;
            this.lbl_GiaBia.Location = new System.Drawing.Point(32, 280);
            this.lbl_GiaBia.Name = "lbl_GiaBia";
            this.lbl_GiaBia.Size = new System.Drawing.Size(109, 32);
            this.lbl_GiaBia.TabIndex = 11;
            this.lbl_GiaBia.Text = "Giá Bìa";
            // 
            // lbl_GiaBan
            // 
            this.lbl_GiaBan.AutoSize = true;
            this.lbl_GiaBan.Location = new System.Drawing.Point(32, 330);
            this.lbl_GiaBan.Name = "lbl_GiaBan";
            this.lbl_GiaBan.Size = new System.Drawing.Size(118, 32);
            this.lbl_GiaBan.TabIndex = 12;
            this.lbl_GiaBan.Text = "Giá Bán";
            // 
            // lbl_NSX
            // 
            this.lbl_NSX.AutoSize = true;
            this.lbl_NSX.Location = new System.Drawing.Point(32, 382);
            this.lbl_NSX.Name = "lbl_NSX";
            this.lbl_NSX.Size = new System.Drawing.Size(188, 32);
            this.lbl_NSX.TabIndex = 13;
            this.lbl_NSX.Text = "Năm sản xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã Loại";
            // 
            // txt_MaLoai
            // 
            this.txt_MaLoai.Location = new System.Drawing.Point(263, 441);
            this.txt_MaLoai.Name = "txt_MaLoai";
            this.txt_MaLoai.Size = new System.Drawing.Size(342, 38);
            this.txt_MaLoai.TabIndex = 15;
            // 
            // FrmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 812);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.rdo_TenSach);
            this.Controls.Add(this.rdo_MaSach);
            this.Controls.Add(this.view_Sach);
            this.Controls.Add(this.btn_TimKiemSach);
            this.Controls.Add(this.btn_LuuSach);
            this.Controls.Add(this.btn_ThoatSach);
            this.Controls.Add(this.btn_XoaSach);
            this.Controls.Add(this.btn_SuaSach);
            this.Controls.Add(this.btn_ThemSach);
            this.Controls.Add(this.gr_Sach);
            this.Controls.Add(this.lbl_Sach);
            this.Name = "FrmSach";
            this.Text = "FrmSach";
            this.gr_Sach.ResumeLayout(false);
            this.gr_Sach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_Sach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Sach;
        private System.Windows.Forms.GroupBox gr_Sach;
        private System.Windows.Forms.Label lbl_TenSach;
        private System.Windows.Forms.Label lbl_MaSach;
        private System.Windows.Forms.Button btn_ThemSach;
        private System.Windows.Forms.Button btn_SuaSach;
        private System.Windows.Forms.Button btn_LuuSach;
        private System.Windows.Forms.Button btn_XoaSach;
        private System.Windows.Forms.Button btn_ThoatSach;
        private System.Windows.Forms.Button btn_TimKiemSach;
        private System.Windows.Forms.DataGridView view_Sach;
        private System.Windows.Forms.RadioButton rdo_MaSach;
        private System.Windows.Forms.RadioButton rdo_TenSach;
        private System.Windows.Forms.TextBox txt_NSX;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txt_GiaBia;
        private System.Windows.Forms.TextBox txt_MaTacGia;
        private System.Windows.Forms.TextBox txt_MaNXB;
        private System.Windows.Forms.TextBox txt_TenSach;
        private System.Windows.Forms.TextBox txt_MaSach;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label lbl_NSX;
        private System.Windows.Forms.Label lbl_GiaBan;
        private System.Windows.Forms.Label lbl_GiaBia;
        private System.Windows.Forms.Label lbl_MaTacGia;
        private System.Windows.Forms.Label lbl_MaNXB;
        private System.Windows.Forms.TextBox txt_MaLoai;
        private System.Windows.Forms.Label label1;
    }
}