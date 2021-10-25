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
            int maSach = Int32.Parse(txt_MaSach.Text);
            string tenSach = txt_TenSach.Text;
            string maNXB = (string)cbo_MaNXB.SelectedValue;
            string maTacGia = (string)cbo_MaTG.SelectedValue;
            string giaBia = txt_GiaBia.Text;
            string giaBan = txt_GiaBan.Text;
            string namXuatBan = txt_NSX.Text;
            string maLoai = (string)cbo_MaLoai.SelectedValue;

            string prepapre =
                "update Sach set TenSach = '{0}',  MaNXB= {1}, MaTacGia ={2}, GiaBia={3}, GiaBan={4}, NamXuatBan = {5}, MaLoai = {6} where MaSach={7} ;";

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
            txt_MaSach.Enabled = false;
            rdo_TenSach.Checked = true;
        }

        private void btn_ThoatSach_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadDataToForm()
        {
            cbo_MaLoai.DataSource = adoUtilts.GetDataTable("select * from TheLoai");
            cbo_MaLoai.DisplayMember = "TenLoai";
            cbo_MaLoai.ValueMember = "MaLoai";
            cbo_MaNXB.DataSource = adoUtilts.GetDataTable("select * from NhaXuatBan");
            cbo_MaNXB.DisplayMember = "TenNXB";
            cbo_MaNXB.ValueMember = "MaNXB";
            cbo_MaTG.DataSource = adoUtilts.GetDataTable("select * from TacGia");
            cbo_MaTG.DisplayMember = "TenTacGia";
            cbo_MaTG.ValueMember = "MaTacGia";
            view_Sach.DataSource = adoUtilts.GetDataTable("select * from Sach");
            BindingData();
        }
        private void BindingData()
        {
            txt_MaSach.DataBindings.Clear();
            txt_MaSach.DataBindings.Add("Text", view_Sach.DataSource, "MaSach");

            txt_TenSach.DataBindings.Clear();
            txt_TenSach.DataBindings.Add("Text", view_Sach.DataSource, "TenSach");

            //cbo_MaNXB.DataBindings.Clear();
            //cbo_MaNXB.Add()

            //cbo_MaTG.DataBindings.Clear();
            //cbo_MaTG.DataBindings.Add( view_Sach.DataSource);

            txt_GiaBia.DataBindings.Clear();
            txt_GiaBia.DataBindings.Add("Text", view_Sach.DataSource, "GiaBia");

            txt_GiaBan.DataBindings.Clear();
            txt_GiaBan.DataBindings.Add("Text", view_Sach.DataSource, "GiaBan");

            txt_NSX.DataBindings.Clear();
            txt_NSX.DataBindings.Add("Text", view_Sach.DataSource, "NamXuatBan");

            //cbo_MaLoai.DataBindings.Clear();
            //cbo_MaLoai.DataBindings.Add("Text", view_Sach.DataSource, "MaLoai");
        }

        private void btn_ThemSach_Click(object sender, EventArgs e)
        {
            txt_MaSach.Text = "";
            txt_TenSach.Text = "";
            cbo_MaNXB.Text = "";
            cbo_MaTG.Text = "";
            txt_GiaBia.Text = "";
            txt_GiaBan.Text = "";
            txt_NSX.Text = "";
            cbo_MaLoai.Text = "";
            btn_LuuSach.Enabled = true;
        }

        private void btn_XoaSach_Click(object sender, EventArgs e)
        {
            int maSach = int.Parse(txt_MaSach.Text);
            string prepare = "delete from Sach where MaSach = {0}";
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
            string tenSach = txt_TenSach.Text;
            int maNXB = (int)cbo_MaNXB.SelectedValue;
            int maTacGia = (int)cbo_MaTG.SelectedValue;
            string giaBia = txt_GiaBia.Text;
            string giaBan = txt_GiaBan.Text;
            string namXuatBan = txt_NSX.Text;
            int maLoai = (int)cbo_MaLoai.SelectedValue;


            string prepare =
                "insert into sach(TenSach, MaNXB, MaTacGia ,GiaBia, GiaBan , NamXuatBan, MaLoai) values ('{0}', {1}, {2}, {3},{4}, {5}, {6});";
            string sql = String.Format(prepare, tenSach, maNXB, maTacGia, giaBia, giaBan, namXuatBan, maLoai);

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

            if (timkiem == "")
            {
                LoadDataToForm();
                return;
            }


            string where = "";
            if (rdo_MaSach.Checked)
            {
                where = where + " where MaSach = " + timkiem + ";";

            }
            else
            {
                where = where + " where TenSach = '" + timkiem + "';";
            }
            string sql = "select * from Sach" + where;
            view_Sach.DataSource = adoUtilts.GetDataTable(sql);
        }

        private void lbl_MaTacGia_Click(object sender, EventArgs e)
        {

        }
    }
}
