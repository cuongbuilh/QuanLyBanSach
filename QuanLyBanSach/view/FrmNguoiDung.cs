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

namespace QuanLyBanSach.view
{
    public partial class FrmNguoiDung : Form
    {
        private ADOUtils adoUtils;
        public FrmNguoiDung()
        {
            InitializeComponent();
            adoUtils = new ADOUtils();
        }

        private void FrmNguoiDung_Load(object sender, EventArgs e)
        {
            LoadDataToForm();
            BindingData();

            txt_MaNguoiDung.Enabled = false;

            btn_Luu.Enabled = false;
        }
        private void LoadDataToForm()
        {
            view_NguoiDung.DataSource = adoUtils.GetDataTable("select * from NguoiDung");
            BindingData();
        }

        private void BindingData()
        {

            txt_MaNguoiDung.Clear();
            txt_MaNguoiDung.DataBindings.Clear();
            txt_MaNguoiDung.DataBindings.Add("Text", view_NguoiDung.DataSource, "MaNguoiDung");

            txt_TenNguoiDung.Clear();
            txt_TenNguoiDung.DataBindings.Clear();
            txt_TenNguoiDung.DataBindings.Add("Text", view_NguoiDung.DataSource, "TenNguoiDung");

            txt_Email.Clear();
            txt_Email.DataBindings.Clear();
            txt_Email.DataBindings.Add("Text", view_NguoiDung.DataSource, "Email");

            txt_NgayDangKy.Clear();
            txt_NgayDangKy.DataBindings.Clear();
            txt_NgayDangKy.DataBindings.Add("Text", view_NguoiDung.DataSource, "NgayDangKy");

            txt_SoDienThoai.Clear();
            txt_SoDienThoai.DataBindings.Clear();
            txt_SoDienThoai.DataBindings.Add("Text", view_NguoiDung.DataSource, "SDT");

            txt_DiaChi.Clear();
            txt_DiaChi.DataBindings.Clear();
            txt_DiaChi.DataBindings.Add("Text", view_NguoiDung.DataSource, "DiaChi");
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txt_MaNguoiDung.Text = "";
            txt_TenNguoiDung.Text = "";
            txt_Email.Text = "";
            txt_NgayDangKy.Text = "";
            txt_SoDienThoai.Text = "";
            txt_DiaChi.Text = "";
            btn_Luu.Enabled = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string maNguoiDung = txt_MaNguoiDung.Text;
            string tenNguoiDung = txt_TenNguoiDung.Text;
            string email = txt_Email.Text;
            DateTime dateTimeNow = DateTime.Now;
           // string ngayDangKy = txt_NgayDangKy.Text;
            string soDienThoai = txt_SoDienThoai.Text;
            string diaChi = txt_DiaChi.Text;

            string prepare =
                "insert into NguoiDung values ('{0}', '{1}', '{2}', '{3}');";
            string sql = String.Format(prepare, tenNguoiDung, email, dateTimeNow, soDienThoai, diaChi);

            try
            {
                adoUtils.Excute(sql);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            LoadDataToForm();
            btn_Luu.Enabled = false;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            int maNguoiDung = Int32.Parse(txt_MaNguoiDung.Text);
            string tenNguoiDung = txt_TenNguoiDung.Text;
            string email = txt_Email.Text;
            string ngayDangKy = txt_NgayDangKy.Text;
            string soDienThoai = txt_SoDienThoai.Text;
            string diaChi = txt_DiaChi.Text;

            string prepapre =
                "update NguoiDung set TenNguoiDung = '{0}', Email = '{1}', NgayDangKy = '{2}', SoDienThoai='{3}', DiaChi='{4}'  where MaNguoiDung='{5}' ;";

            string sql = String.Format(prepapre, tenNguoiDung, email, ngayDangKy, soDienThoai, diaChi, maNguoiDung);

            try
            {
                adoUtils.Excute(sql);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            LoadDataToForm();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int maNguoiDung = Int32.Parse(txt_MaNguoiDung.Text);
            string prepare = "delete from NguoiDung where MaNguoiDung = '{0}'";
            string sql = String.Format(prepare, maNguoiDung);

            DialogResult confirmDialogResult = MessageBox.Show("Bạn muốn xóa mã người dùng " + maNguoiDung);
            if (confirmDialogResult == DialogResult.OK)
            {
                try
                {
                    adoUtils.Disconnect();
                    adoUtils.Connect();
                    adoUtils.Excute(sql);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            LoadDataToForm();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
