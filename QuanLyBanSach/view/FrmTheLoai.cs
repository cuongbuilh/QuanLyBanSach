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
    public partial class FrmTheLoai : Form
    {
        private ADOUtils adoUtils;
        public FrmTheLoai()
        {
            InitializeComponent();
            adoUtils = new ADOUtils();
        }

        private void FrmTheLoai_Load(object sender, EventArgs e)
        {
            LoadDataToForm();
            BindingData();

            //btn_Luu.Enabled = false;
        }

        private void LoadDataToForm()
        {
            view_TheLoai.DataSource = adoUtils.GetDataTable("select * from THELOAI");
            
        }

        private void BindingData()
        {
            txt_MaLoai.Clear();
            txt_MaLoai.DataBindings.Add("Text", view_TheLoai.DataSource, "MALOAI");

            txt_TenLoai.Clear();
            txt_TenLoai.DataBindings.Add("Text", view_TheLoai.DataSource, "TENLOAI");

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txt_MaLoai.Text = "";
            txt_TenLoai.Text = "";
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string maLoai = txt_MaLoai.Text;
            string tenLoai = txt_TenLoai.Text;
            

            string prepare =
                "insert into THELOAI values ('{0}', '{1}');";
            string sql = String.Format(prepare, maLoai, tenLoai);

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
            string maLoai = txt_MaLoai.Text;
            string tenLoai = txt_TenLoai.Text;
            

            string prepapre = "update THELOAI set TENLOAI='{0}' where MALOAI='{1}';";
            string sql = String.Format(prepapre, tenLoai, maLoai);

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
            string maLoai = txt_MaLoai.Text;
            string prepare = "delete from THELOAI where MALOAI = '{0}'";
            string sql = String.Format(prepare, maLoai);

            DialogResult confirmDialogResult = MessageBox.Show("bạn muốn xóa mã loại? " + maLoai);
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
