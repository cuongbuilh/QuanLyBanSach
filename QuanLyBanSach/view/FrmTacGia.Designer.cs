
namespace QuanLyBanSach.view
{
    partial class FrmTacGia
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.lbl_TacGia = new System.Windows.Forms.Label();
            this.lbl_MaTacGia = new System.Windows.Forms.Label();
            this.lbl_TenTacGia = new System.Windows.Forms.Label();
            this.lbl_MoTa = new System.Windows.Forms.Label();
            this.view_TacGia = new System.Windows.Forms.DataGridView();
            this.txt_MaTacGia = new System.Windows.Forms.TextBox();
            this.txt_TenTacGia = new System.Windows.Forms.TextBox();
            this.txt_MoTa = new System.Windows.Forms.TextBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.view_TacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(636, 49);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(118, 52);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbl_TacGia
            // 
            this.lbl_TacGia.AutoSize = true;
            this.lbl_TacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TacGia.Location = new System.Drawing.Point(339, 9);
            this.lbl_TacGia.Name = "lbl_TacGia";
            this.lbl_TacGia.Size = new System.Drawing.Size(95, 25);
            this.lbl_TacGia.TabIndex = 1;
            this.lbl_TacGia.Text = "TÁC GIẢ";
            // 
            // lbl_MaTacGia
            // 
            this.lbl_MaTacGia.AutoSize = true;
            this.lbl_MaTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaTacGia.Location = new System.Drawing.Point(60, 57);
            this.lbl_MaTacGia.Name = "lbl_MaTacGia";
            this.lbl_MaTacGia.Size = new System.Drawing.Size(118, 25);
            this.lbl_MaTacGia.TabIndex = 1;
            this.lbl_MaTacGia.Text = "Mã tác giả:";
            // 
            // lbl_TenTacGia
            // 
            this.lbl_TenTacGia.AutoSize = true;
            this.lbl_TenTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenTacGia.Location = new System.Drawing.Point(60, 112);
            this.lbl_TenTacGia.Name = "lbl_TenTacGia";
            this.lbl_TenTacGia.Size = new System.Drawing.Size(125, 25);
            this.lbl_TenTacGia.TabIndex = 1;
            this.lbl_TenTacGia.Text = "Tên tác giả:";
            // 
            // lbl_MoTa
            // 
            this.lbl_MoTa.AutoSize = true;
            this.lbl_MoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MoTa.Location = new System.Drawing.Point(60, 171);
            this.lbl_MoTa.Name = "lbl_MoTa";
            this.lbl_MoTa.Size = new System.Drawing.Size(72, 25);
            this.lbl_MoTa.TabIndex = 1;
            this.lbl_MoTa.Text = "Mô tả:";
            // 
            // view_TacGia
            // 
            this.view_TacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_TacGia.Location = new System.Drawing.Point(78, 212);
            this.view_TacGia.Name = "view_TacGia";
            this.view_TacGia.Size = new System.Drawing.Size(508, 208);
            this.view_TacGia.TabIndex = 2;
            // 
            // txt_MaTacGia
            // 
            this.txt_MaTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaTacGia.Location = new System.Drawing.Point(212, 57);
            this.txt_MaTacGia.Name = "txt_MaTacGia";
            this.txt_MaTacGia.Size = new System.Drawing.Size(374, 31);
            this.txt_MaTacGia.TabIndex = 3;
            // 
            // txt_TenTacGia
            // 
            this.txt_TenTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenTacGia.Location = new System.Drawing.Point(212, 109);
            this.txt_TenTacGia.Name = "txt_TenTacGia";
            this.txt_TenTacGia.Size = new System.Drawing.Size(374, 31);
            this.txt_TenTacGia.TabIndex = 3;
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MoTa.Location = new System.Drawing.Point(212, 165);
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(374, 31);
            this.txt_MoTa.TabIndex = 3;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(636, 127);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(118, 52);
            this.btn_Luu.TabIndex = 0;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(636, 212);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(118, 52);
            this.btn_Sua.TabIndex = 0;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(636, 290);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(118, 52);
            this.btn_Xoa.TabIndex = 0;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(636, 368);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(118, 52);
            this.btn_Thoat.TabIndex = 0;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // FrmTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_MoTa);
            this.Controls.Add(this.txt_TenTacGia);
            this.Controls.Add(this.txt_MaTacGia);
            this.Controls.Add(this.view_TacGia);
            this.Controls.Add(this.lbl_MoTa);
            this.Controls.Add(this.lbl_TenTacGia);
            this.Controls.Add(this.lbl_MaTacGia);
            this.Controls.Add(this.lbl_TacGia);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Them);
            this.Name = "FrmTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTacGia";
            this.Load += new System.EventHandler(this.FrmTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_TacGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label lbl_TacGia;
        private System.Windows.Forms.Label lbl_MaTacGia;
        private System.Windows.Forms.Label lbl_TenTacGia;
        private System.Windows.Forms.Label lbl_MoTa;
        private System.Windows.Forms.DataGridView view_TacGia;
        private System.Windows.Forms.TextBox txt_MaTacGia;
        private System.Windows.Forms.TextBox txt_TenTacGia;
        private System.Windows.Forms.TextBox txt_MoTa;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Thoat;
    }
}