using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanSach.Utils;
using System.Data.SqlClient;

namespace QuanLyBanSach.view
{
    public partial class FrmDangKy : Form
    {
        private ADOUtils adoUtilts;
        public FrmDangKy()
        {
            InitializeComponent();
            adoUtilts = new ADOUtils();
        }

        private void FrmDangKy_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txt_TenDangNhap;
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            string tennguoidung = txt_TenNguoiDung.Text;
            string diachi = txt_DiaChi.Text;
            string sdt = txt_SoDienThoai.Text;
            string email = txt_Email.Text;
            string tendangnhap = txt_TenDangNhap.Text;
            string matkhau = txt_MatKhau.Text;

            string nguoidung =
                "insert into NguoiDung values ('{0}', '{1}', '{2}', '{3}', '{4}');";
            string sql = String.Format(nguoidung, tennguoidung, diachi, email, sdt);
            string dangnhap =
                "insert into NguoiDung values ('{0}', '{1}')";
            string sql1 = String.Format(dangnhap, tendangnhap);

            try {
                adoUtilts.Excute(sql);
                adoUtilts.Excute(sql1);

                MessageBox.Show("Đăng ký thành công");
                FrmDangNhap frmDangNhap = new FrmDangNhap();
                frmDangNhap.Show();
                this.Hide();
            }catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            
     
        }


        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            FrmDangNhap dangNhap = new FrmDangNhap();
            dangNhap.Show();
            this.Hide();
        }
    }
}
