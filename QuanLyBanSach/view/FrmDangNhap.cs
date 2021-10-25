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
    public partial class FrmDangNhap : Form
    {
        private ADOUtils adoUtilts;

        public FrmDangNhap()
        {
            InitializeComponent();
            adoUtilts = new ADOUtils();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txt_DangNhap;
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string username = txt_DangNhap.Text;
            string password = txt_MatKhau.Text;
            string selectFomat =
                "select * from DangNhap where BINARY_CHECKSUM(TenDangNhap) = BINARY_CHECKSUM('{0}') and BINARY_CHECKSUM(MATKHAU) = BINARY_CHECKSUM('{1}') ";
            string sql = String.Format(selectFomat, username, password);
            
            // kiểm tra đăng nhập
            bool logedIn = adoUtilts.ExcuteReader(sql).Read();

            // kiểm tra admin
            bool isAdmin = adoUtilts.ExcuteReader(sql + "and MaQuyen = 1").Read();

            if (logedIn)
            {
                if (isAdmin)
                {
                    MainForm main = new MainForm();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MainFormNguoiDung main = new MainFormNguoiDung();
                    main.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập");
            }
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            FrmDangKy dangKy = new FrmDangKy();
            dangKy.Show();
            this.Hide();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}