
namespace QuanLyBanSach.view
{
    partial class FrmQuyen
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
            this.lbl_TaoQuyen = new System.Windows.Forms.Label();
            this.lbl_MaQuyen = new System.Windows.Forms.Label();
            this.lbl_TenQuyen = new System.Windows.Forms.Label();
            this.btn_ThemQuyen = new System.Windows.Forms.Button();
            this.btn_LuuQuyen = new System.Windows.Forms.Button();
            this.btn_SuaQuyen = new System.Windows.Forms.Button();
            this.btn_XoaQuyen = new System.Windows.Forms.Button();
            this.btn_ThoatQuyen = new System.Windows.Forms.Button();
            this.view_Quyen = new System.Windows.Forms.DataGridView();
            this.txt_MaQuyen = new System.Windows.Forms.TextBox();
            this.txt_TenQuyen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.view_Quyen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TaoQuyen
            // 
            this.lbl_TaoQuyen.AutoSize = true;
            this.lbl_TaoQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TaoQuyen.Location = new System.Drawing.Point(476, 9);
            this.lbl_TaoQuyen.Name = "lbl_TaoQuyen";
            this.lbl_TaoQuyen.Size = new System.Drawing.Size(132, 44);
            this.lbl_TaoQuyen.TabIndex = 0;
            this.lbl_TaoQuyen.Text = "Quyền";
            this.lbl_TaoQuyen.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_MaQuyen
            // 
            this.lbl_MaQuyen.AutoSize = true;
            this.lbl_MaQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MaQuyen.Location = new System.Drawing.Point(24, 86);
            this.lbl_MaQuyen.Name = "lbl_MaQuyen";
            this.lbl_MaQuyen.Size = new System.Drawing.Size(153, 32);
            this.lbl_MaQuyen.TabIndex = 1;
            this.lbl_MaQuyen.Text = "Mã Quyền:";
            // 
            // lbl_TenQuyen
            // 
            this.lbl_TenQuyen.AutoSize = true;
            this.lbl_TenQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TenQuyen.Location = new System.Drawing.Point(24, 143);
            this.lbl_TenQuyen.Name = "lbl_TenQuyen";
            this.lbl_TenQuyen.Size = new System.Drawing.Size(163, 32);
            this.lbl_TenQuyen.TabIndex = 2;
            this.lbl_TenQuyen.Text = "Tên Quyền:";
            // 
            // btn_ThemQuyen
            // 
            this.btn_ThemQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThemQuyen.Location = new System.Drawing.Point(841, 111);
            this.btn_ThemQuyen.Name = "btn_ThemQuyen";
            this.btn_ThemQuyen.Size = new System.Drawing.Size(141, 64);
            this.btn_ThemQuyen.TabIndex = 3;
            this.btn_ThemQuyen.Text = "Thêm";
            this.btn_ThemQuyen.UseVisualStyleBackColor = true;
            // 
            // btn_LuuQuyen
            // 
            this.btn_LuuQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_LuuQuyen.Location = new System.Drawing.Point(841, 197);
            this.btn_LuuQuyen.Name = "btn_LuuQuyen";
            this.btn_LuuQuyen.Size = new System.Drawing.Size(141, 64);
            this.btn_LuuQuyen.TabIndex = 4;
            this.btn_LuuQuyen.Text = "Lưu";
            this.btn_LuuQuyen.UseVisualStyleBackColor = true;
            // 
            // btn_SuaQuyen
            // 
            this.btn_SuaQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_SuaQuyen.Location = new System.Drawing.Point(841, 288);
            this.btn_SuaQuyen.Name = "btn_SuaQuyen";
            this.btn_SuaQuyen.Size = new System.Drawing.Size(141, 64);
            this.btn_SuaQuyen.TabIndex = 5;
            this.btn_SuaQuyen.Text = "Sửa";
            this.btn_SuaQuyen.UseVisualStyleBackColor = true;
            // 
            // btn_XoaQuyen
            // 
            this.btn_XoaQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_XoaQuyen.Location = new System.Drawing.Point(841, 377);
            this.btn_XoaQuyen.Name = "btn_XoaQuyen";
            this.btn_XoaQuyen.Size = new System.Drawing.Size(141, 64);
            this.btn_XoaQuyen.TabIndex = 6;
            this.btn_XoaQuyen.Text = "Xóa";
            this.btn_XoaQuyen.UseVisualStyleBackColor = true;
            // 
            // btn_ThoatQuyen
            // 
            this.btn_ThoatQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThoatQuyen.Location = new System.Drawing.Point(841, 468);
            this.btn_ThoatQuyen.Name = "btn_ThoatQuyen";
            this.btn_ThoatQuyen.Size = new System.Drawing.Size(141, 64);
            this.btn_ThoatQuyen.TabIndex = 7;
            this.btn_ThoatQuyen.Text = "Thoát";
            this.btn_ThoatQuyen.UseVisualStyleBackColor = true;
            // 
            // view_Quyen
            // 
            this.view_Quyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_Quyen.Location = new System.Drawing.Point(12, 294);
            this.view_Quyen.Name = "view_Quyen";
            this.view_Quyen.RowHeadersWidth = 51;
            this.view_Quyen.RowTemplate.Height = 24;
            this.view_Quyen.Size = new System.Drawing.Size(726, 238);
            this.view_Quyen.TabIndex = 8;
            // 
            // txt_MaQuyen
            // 
            this.txt_MaQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaQuyen.Location = new System.Drawing.Point(203, 80);
            this.txt_MaQuyen.Name = "txt_MaQuyen";
            this.txt_MaQuyen.Size = new System.Drawing.Size(315, 38);
            this.txt_MaQuyen.TabIndex = 9;
            // 
            // txt_TenQuyen
            // 
            this.txt_TenQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenQuyen.Location = new System.Drawing.Point(203, 143);
            this.txt_TenQuyen.Name = "txt_TenQuyen";
            this.txt_TenQuyen.Size = new System.Drawing.Size(315, 38);
            this.txt_TenQuyen.TabIndex = 10;
            // 
            // FrmQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 627);
            this.Controls.Add(this.txt_TenQuyen);
            this.Controls.Add(this.txt_MaQuyen);
            this.Controls.Add(this.view_Quyen);
            this.Controls.Add(this.btn_ThoatQuyen);
            this.Controls.Add(this.btn_XoaQuyen);
            this.Controls.Add(this.btn_SuaQuyen);
            this.Controls.Add(this.btn_LuuQuyen);
            this.Controls.Add(this.btn_ThemQuyen);
            this.Controls.Add(this.lbl_TenQuyen);
            this.Controls.Add(this.lbl_MaQuyen);
            this.Controls.Add(this.lbl_TaoQuyen);
            this.Name = "FrmQuyen";
            this.Text = "FrmQuyen";
            ((System.ComponentModel.ISupportInitialize)(this.view_Quyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TaoQuyen;
        private System.Windows.Forms.Label lbl_MaQuyen;
        private System.Windows.Forms.Label lbl_TenQuyen;
        private System.Windows.Forms.Button btn_ThemQuyen;
        private System.Windows.Forms.Button btn_LuuQuyen;
        private System.Windows.Forms.Button btn_SuaQuyen;
        private System.Windows.Forms.Button btn_XoaQuyen;
        private System.Windows.Forms.Button btn_ThoatQuyen;
        private System.Windows.Forms.DataGridView view_Quyen;
        private System.Windows.Forms.TextBox txt_MaQuyen;
        private System.Windows.Forms.TextBox txt_TenQuyen;
    }
}