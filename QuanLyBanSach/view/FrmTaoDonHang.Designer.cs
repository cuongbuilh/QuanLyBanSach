
namespace QuanLyBanSach.view
{
    partial class FrmTaoDonHang
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.data_Sach = new System.Windows.Forms.DataGridView();
            this.data_DonHang = new System.Windows.Forms.DataGridView();
            this.btn_TaoDon = new System.Windows.Forms.Button();
            this.btn_TimSach = new System.Windows.Forms.Button();
            this.txt_TimSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_TimDon = new System.Windows.Forms.Button();
            this.btn_XoaDon = new System.Windows.Forms.Button();
            this.txt_DanhSach = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.txt_MaNguooiDung = new System.Windows.Forms.TextBox();
            this.txt_MaDon = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_Sach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_DonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(282, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(208, 36);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Tạo Đơn Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(398, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số Lượng";
            // 
            // data_Sach
            // 
            this.data_Sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Sach.Location = new System.Drawing.Point(22, 285);
            this.data_Sach.Name = "data_Sach";
            this.data_Sach.Size = new System.Drawing.Size(220, 150);
            this.data_Sach.TabIndex = 3;
            // 
            // data_DonHang
            // 
            this.data_DonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_DonHang.Location = new System.Drawing.Point(273, 285);
            this.data_DonHang.Name = "data_DonHang";
            this.data_DonHang.Size = new System.Drawing.Size(515, 150);
            this.data_DonHang.TabIndex = 4;
            // 
            // btn_TaoDon
            // 
            this.btn_TaoDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoDon.Location = new System.Drawing.Point(605, 112);
            this.btn_TaoDon.Name = "btn_TaoDon";
            this.btn_TaoDon.Size = new System.Drawing.Size(165, 45);
            this.btn_TaoDon.TabIndex = 5;
            this.btn_TaoDon.Text = "Tạo Đơn Hàng";
            this.btn_TaoDon.UseVisualStyleBackColor = true;
            this.btn_TaoDon.Click += new System.EventHandler(this.btn_TaoDon_Click);
            // 
            // btn_TimSach
            // 
            this.btn_TimSach.Location = new System.Drawing.Point(167, 243);
            this.btn_TimSach.Name = "btn_TimSach";
            this.btn_TimSach.Size = new System.Drawing.Size(75, 23);
            this.btn_TimSach.TabIndex = 6;
            this.btn_TimSach.Text = "Tìm Sách";
            this.btn_TimSach.UseVisualStyleBackColor = true;
            this.btn_TimSach.Click += new System.EventHandler(this.btn_TimSach_Click);
            // 
            // txt_TimSach
            // 
            this.txt_TimSach.Location = new System.Drawing.Point(22, 243);
            this.txt_TimSach.Name = "txt_TimSach";
            this.txt_TimSach.Size = new System.Drawing.Size(139, 20);
            this.txt_TimSach.TabIndex = 7;
            this.txt_TimSach.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(490, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đơn Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã Đơn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã ND";
            // 
            // btn_TimDon
            // 
            this.btn_TimDon.Location = new System.Drawing.Point(713, 219);
            this.btn_TimDon.Name = "btn_TimDon";
            this.btn_TimDon.Size = new System.Drawing.Size(75, 23);
            this.btn_TimDon.TabIndex = 6;
            this.btn_TimDon.Text = "Tìm Đơn";
            this.btn_TimDon.UseVisualStyleBackColor = true;
            this.btn_TimDon.Click += new System.EventHandler(this.btn_TimDon_Click);
            // 
            // btn_XoaDon
            // 
            this.btn_XoaDon.Location = new System.Drawing.Point(713, 248);
            this.btn_XoaDon.Name = "btn_XoaDon";
            this.btn_XoaDon.Size = new System.Drawing.Size(75, 23);
            this.btn_XoaDon.TabIndex = 6;
            this.btn_XoaDon.Text = "Xóa đơn";
            this.btn_XoaDon.UseVisualStyleBackColor = true;
            this.btn_XoaDon.Click += new System.EventHandler(this.btn_XoaDon_Click);
            // 
            // txt_DanhSach
            // 
            this.txt_DanhSach.Location = new System.Drawing.Point(66, 97);
            this.txt_DanhSach.Multiline = true;
            this.txt_DanhSach.Name = "txt_DanhSach";
            this.txt_DanhSach.Size = new System.Drawing.Size(200, 85);
            this.txt_DanhSach.TabIndex = 9;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(343, 97);
            this.txt_SoLuong.Multiline = true;
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(200, 85);
            this.txt_SoLuong.TabIndex = 9;
            // 
            // txt_MaNguooiDung
            // 
            this.txt_MaNguooiDung.Location = new System.Drawing.Point(526, 241);
            this.txt_MaNguooiDung.Name = "txt_MaNguooiDung";
            this.txt_MaNguooiDung.Size = new System.Drawing.Size(154, 20);
            this.txt_MaNguooiDung.TabIndex = 10;
            // 
            // txt_MaDon
            // 
            this.txt_MaDon.Location = new System.Drawing.Point(305, 241);
            this.txt_MaDon.Name = "txt_MaDon";
            this.txt_MaDon.Size = new System.Drawing.Size(160, 20);
            this.txt_MaDon.TabIndex = 10;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(728, 0);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 11;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // FrmTaoDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.txt_MaDon);
            this.Controls.Add(this.txt_MaNguooiDung);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.txt_DanhSach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_TimSach);
            this.Controls.Add(this.btn_XoaDon);
            this.Controls.Add(this.btn_TimDon);
            this.Controls.Add(this.btn_TimSach);
            this.Controls.Add(this.btn_TaoDon);
            this.Controls.Add(this.data_DonHang);
            this.Controls.Add(this.data_Sach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Title);
            this.Name = "FrmTaoDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTaoDonHang";
            this.Load += new System.EventHandler(this.FrmTaoDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Sach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_DonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView data_Sach;
        private System.Windows.Forms.DataGridView data_DonHang;
        private System.Windows.Forms.Button btn_TaoDon;
        private System.Windows.Forms.Button btn_TimSach;
        private System.Windows.Forms.TextBox txt_TimSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_TimDon;
        private System.Windows.Forms.Button btn_XoaDon;
        private System.Windows.Forms.TextBox txt_DanhSach;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.TextBox txt_MaNguooiDung;
        private System.Windows.Forms.TextBox txt_MaDon;
        private System.Windows.Forms.Button btn_thoat;
    }
}