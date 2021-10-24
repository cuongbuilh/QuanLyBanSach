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
    public partial class FrmNhaXuatBan : Form
    {

        private ADOUtils adoUtils;
        public FrmNhaXuatBan()
        {
            InitializeComponent();
            adoUtils = new ADOUtils();
        }

        private void FrmNhaXuatBan_Load(object sender, EventArgs e)
        {
            LoadDataToForm();
            BindingData();

            //btn_Luu.Enabled = false;
        }

        private void LoadDataToForm()
        {
            view_NhaXuatBan.DataSource = adoUtils.GetDataTable("select * from NhaXuatBan");
        }

        private void BindingData()
        {
            txt_TenNXB.Clear();
            txt_TenNXB.DataBindings.Add("Text", view_NhaXuatBan.DataSource, "TenNXB");

            txt_MaNXB.Clear();
            txt_MaNXB.DataBindings.Add("Text", view_NhaXuatBan.DataSource, "MaNXB");

            txt_DiaChi.Clear();
            txt_DiaChi.DataBindings.Add("Text", view_NhaXuatBan.DataSource, "DiaChi");
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txt_MaNXB.Text = "";
            txt_TenNXB.Text = "";
            txt_DiaChi.Text = "";
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string maNXB = txt_MaNXB.Text;
            string tenNXB = txt_TenNXB.Text;
            string diaChi = txt_DiaChi.Text;

            string prepare =
                "insert into NguoiDung values ('{0}', '{1}', '{2}');";
            string sql = String.Format(prepare, maNXB, tenNXB, diaChi);

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
            string maNXB = txt_MaNXB.Text;
            string tenNXB = txt_TenNXB.Text;
            string diaChi = txt_DiaChi.Text;

            string prepapre =
                "update NguoiDung set TenNXB = '{0}', DiaChi = '{1}' where MaNXB='{2}' ;";

            string sql = String.Format(prepapre, maNXB, tenNXB, diaChi);

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
            string maNXB = txt_MaNXB.Text;
            string prepare = "delete from NhaXuatBan where MaNXB = '{0}'";
            string sql = String.Format(prepare, maNXB);

            DialogResult confirmDialogResult = MessageBox.Show("Bạn muốn xóa mã NXB " + maNXB);
            if (confirmDialogResult == DialogResult.OK)
            {
                try
                {
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
