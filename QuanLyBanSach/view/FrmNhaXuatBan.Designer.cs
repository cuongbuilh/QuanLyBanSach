
namespace QuanLyBanSach.view
{
    partial class FrmNhaXuatBan
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
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_TenNXB = new System.Windows.Forms.TextBox();
            this.lbl_MaNXB = new System.Windows.Forms.Label();
            this.view_NhaXuatBan = new System.Windows.Forms.DataGridView();
            this.txt_MaNXB = new System.Windows.Forms.TextBox();
            this.lbl_NhaXuatBan = new System.Windows.Forms.Label();
            this.lbl_TenNXB = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.view_NhaXuatBan)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(605, 225);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(110, 46);
            this.btn_Sua.TabIndex = 13;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(605, 290);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(110, 46);
            this.btn_Xoa.TabIndex = 14;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(605, 158);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(110, 46);
            this.btn_Luu.TabIndex = 15;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(605, 93);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(110, 46);
            this.btn_Them.TabIndex = 16;
            this.btn_Them.Text = "Thêm ";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_TenNXB
            // 
            this.txt_TenNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNXB.Location = new System.Drawing.Point(254, 154);
            this.txt_TenNXB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TenNXB.Name = "txt_TenNXB";
            this.txt_TenNXB.Size = new System.Drawing.Size(282, 32);
            this.txt_TenNXB.TabIndex = 12;
            // 
            // lbl_MaNXB
            // 
            this.lbl_MaNXB.AutoSize = true;
            this.lbl_MaNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNXB.Location = new System.Drawing.Point(62, 107);
            this.lbl_MaNXB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MaNXB.Name = "lbl_MaNXB";
            this.lbl_MaNXB.Size = new System.Drawing.Size(94, 26);
            this.lbl_MaNXB.TabIndex = 11;
            this.lbl_MaNXB.Text = "Mã NXB";
            // 
            // view_NhaXuatBan
            // 
            this.view_NhaXuatBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_NhaXuatBan.Location = new System.Drawing.Point(40, 258);
            this.view_NhaXuatBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.view_NhaXuatBan.Name = "view_NhaXuatBan";
            this.view_NhaXuatBan.RowHeadersWidth = 51;
            this.view_NhaXuatBan.RowTemplate.Height = 24;
            this.view_NhaXuatBan.Size = new System.Drawing.Size(528, 151);
            this.view_NhaXuatBan.TabIndex = 10;
            // 
            // txt_MaNXB
            // 
            this.txt_MaNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNXB.Location = new System.Drawing.Point(254, 102);
            this.txt_MaNXB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_MaNXB.Name = "txt_MaNXB";
            this.txt_MaNXB.Size = new System.Drawing.Size(282, 32);
            this.txt_MaNXB.TabIndex = 9;
            // 
            // lbl_NhaXuatBan
            // 
            this.lbl_NhaXuatBan.AutoSize = true;
            this.lbl_NhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NhaXuatBan.Location = new System.Drawing.Point(284, 22);
            this.lbl_NhaXuatBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NhaXuatBan.Name = "lbl_NhaXuatBan";
            this.lbl_NhaXuatBan.Size = new System.Drawing.Size(201, 36);
            this.lbl_NhaXuatBan.TabIndex = 7;
            this.lbl_NhaXuatBan.Text = "Nhà Xuất Bản";
            // 
            // lbl_TenNXB
            // 
            this.lbl_TenNXB.AutoSize = true;
            this.lbl_TenNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenNXB.Location = new System.Drawing.Point(62, 158);
            this.lbl_TenNXB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TenNXB.Name = "lbl_TenNXB";
            this.lbl_TenNXB.Size = new System.Drawing.Size(100, 26);
            this.lbl_TenNXB.TabIndex = 17;
            this.lbl_TenNXB.Text = "Tên NXB";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(62, 212);
            this.lbl_DiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(79, 26);
            this.lbl_DiaChi.TabIndex = 19;
            this.lbl_DiaChi.Text = "Địa chỉ";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Location = new System.Drawing.Point(254, 207);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(282, 32);
            this.txt_DiaChi.TabIndex = 18;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(605, 354);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(110, 46);
            this.btn_Thoat.TabIndex = 20;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // FrmNhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 466);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.lbl_DiaChi);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.lbl_TenNXB);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_TenNXB);
            this.Controls.Add(this.lbl_MaNXB);
            this.Controls.Add(this.view_NhaXuatBan);
            this.Controls.Add(this.txt_MaNXB);
            this.Controls.Add(this.lbl_NhaXuatBan);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmNhaXuatBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà Xuất Bản";
            this.Load += new System.EventHandler(this.FrmNhaXuatBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_NhaXuatBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_TenNXB;
        private System.Windows.Forms.Label lbl_MaNXB;
        private System.Windows.Forms.DataGridView view_NhaXuatBan;
        private System.Windows.Forms.TextBox txt_MaNXB;
        private System.Windows.Forms.Label lbl_NhaXuatBan;
        private System.Windows.Forms.Label lbl_TenNXB;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Button btn_Thoat;
    }
}