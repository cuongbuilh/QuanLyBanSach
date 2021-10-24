using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyBanSach.Utils;


namespace QuanLyBanSach.view
{
    public partial class FrmSach : Form
    {
        private ADOUtils adoUtilts;

        public FrmSach()
        {
            InitializeComponent();
            adoUtilts = new ADOUtils();
        }

        private void btn_SuaSach_Click(object sender, EventArgs e)
        {
            string maSach = txt_MaSach.Text;
            string tenSach = txt_TenSach.Text;
            string maNXB = txt_MaNXB.Text;
            string maTacGia = txt_MaTacGia.Text;
            string giaBia = txt_GiaBia.Text;
            string giaBan = txt_GiaBan.Text;
            string namXuatBan = txt_NSX.Text;
            string maLoai = txt_MaLoai.Text;


            string prepapre =
                "update Sach set TenSach = '{0}',  MaNXB= '{1}', MaTacGia ='{2}', GiaBia='{3}', GiaBan='{4}', NamXuatBan = '{5}', MaLoai = '{6}' where MaSach='{7}' ;";

            string sql = String.Format(prepapre, tenSach, maNXB, maTacGia, giaBia, giaBan, namXuatBan, maLoai, maSach);

            try
            {
                adoUtilts.Excute(sql);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            LoadDataToForm();
        }

        private void FrmSach_Load(object sender, EventArgs e)
        {
            LoadDataToForm();
            BindingData();
            btn_LuuSach.Enabled = false;
        }

        private void btn_ThoatSach_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadDataToForm()
        {
            view_Sach.DataSource = adoUtilts.GetDataTable("select * from Sach");

        }
        private void BindingData()
        {
            txt_MaSach.Clear();
            txt_MaSach.DataBindings.Add("Text", view_Sach.DataSource, "MaSach");

            txt_TenSach.Clear();
            txt_TenSach.DataBindings.Add("Text", view_Sach.DataSource, "TenSach");

            txt_MaNXB.Clear();
            txt_MaNXB.DataBindings.Add("Text", view_Sach.DataSource, "MaNXB");

            txt_MaTacGia.Clear();
            txt_MaTacGia.DataBindings.Add("Text", view_Sach.DataSource, "MaTacGia");

            txt_GiaBia.Clear();
            txt_GiaBia.DataBindings.Add("Text", view_Sach.DataSource, "GiaBia");

            txt_GiaBan.Clear();
            txt_GiaBan.DataBindings.Add("Text", view_Sach.DataSource, "GiaBan");

            txt_NSX.Clear();
            txt_NSX.DataBindings.Add("Text", view_Sach.DataSource, "NamXuatBan");

            txt_MaLoai.Clear();
            txt_MaLoai.DataBindings.Add("Text", view_Sach.DataSource, "MaLoai");

           
        }

        private void btn_ThemSach_Click(object sender, EventArgs e)
        {
            txt_MaSach.Text = "";
            txt_TenSach.Text = "";
            txt_MaNXB.Text = "";
            txt_MaTacGia.Text = "";
            txt_GiaBia.Text = "";
            txt_GiaBan.Text = "";
            txt_NSX.Text = "";
            txt_MaLoai.Text = "";
            btn_LuuSach.Enabled = true;
        }

        private void btn_XoaSach_Click(object sender, EventArgs e)
        {
            string maSach = txt_MaSach.Text;
            string prepare = "delete from Sach where MaSach = '{0}'";
            string sql = String.Format(prepare, maSach);

            DialogResult confirmDialogResult = MessageBox.Show("bạn muốn xóa sách " + maSach);
            if (confirmDialogResult == DialogResult.OK)
            {
                try
                {
                    adoUtilts.Excute(sql);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            LoadDataToForm();
        }

        private void btn_LuuSach_Click(object sender, EventArgs e)
        {
            string maSach = txt_MaSach.Text;
            string tenSach = txt_TenSach.Text;
            string maNXB = txt_MaNXB.Text;
            string maTacGia = txt_MaTacGia.Text;
            string giaBia = txt_GiaBia.Text;
            string giaBan = txt_GiaBan.Text;
            string namXuatBan = txt_NSX.Text;
            string maLoai = txt_MaLoai.Text;


            string prepare =
                "insert into Sach values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');";
            string sql = String.Format(prepare, maSach, tenSach, maNXB, maTacGia, giaBia, giaBan, namXuatBan, maLoai);

            try
            {
                adoUtilts.Excute(sql);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            LoadDataToForm();
            btn_LuuSach.Enabled = false;
        }

        private void btn_TimKiemSach_Click(object sender, EventArgs e)
        {
            string timkiem = txt_TimKiem.Text;
            string where = "";
            if (rdo_MaSach.Checked)
            {
                where = where + "where MaSach = '" + timkiem + "';";

            }
            else
            {
                where = where + "where TenSach = '" + timkiem + "';";
            }
            string sql = "select * from Sach" + where;
            view_Sach.DataSource = adoUtilts.GetDataTable(sql);
        }
    }
}
