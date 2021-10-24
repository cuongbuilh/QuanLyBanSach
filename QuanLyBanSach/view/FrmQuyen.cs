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
    public partial class FrmQuyen : Form
    {
        private ADOUtils adoUtilts;
        public FrmQuyen()
        {
            InitializeComponent();
            adoUtilts = new ADOUtils();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmQuyen_Load(object sender, EventArgs e)
        {
            LoadDataToForm();
            BindingData();

            btn_LuuQuyen.Enabled = false;
        }

        private void btn_ThoatQuyen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadDataToForm()
        {
            view_Quyen.DataSource = adoUtilts.GetDataTable("select * from Quyen");
        }
        private void BindingData()
        {
            txt_MaQuyen.Clear();
            txt_MaQuyen.DataBindings.Add("Text", view_Quyen.DataSource, "TenQuyen");

            txt_TenQuyen.Clear();
            txt_TenQuyen.DataBindings.Add("Text", view_Quyen.DataSource, "MaQuyen");

            
        }

        private void btn_ThemQuyen_Click(object sender, EventArgs e)
        {
            txt_TenQuyen.Text = "";
            txt_MaQuyen.Text = "";
            btn_LuuQuyen.Enabled = true;
        }

        private void btn_LuuQuyen_Click(object sender, EventArgs e)
        {
            string maQuyen = txt_MaQuyen.Text;
            string tenQuyen = txt_TenQuyen.Text;

            string prepare =
                "insert into Quyen values ('{0}', '{1}');";
            string sql = String.Format(prepare, maQuyen, tenQuyen);

            try
            {
                adoUtilts.Excute(sql);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            LoadDataToForm();
            btn_LuuQuyen.Enabled = false;
        }

        private void btn_SuaQuyen_Click(object sender, EventArgs e)
        {
            string maQuyen = txt_MaQuyen.Text;
            string tenQuyen = txt_TenQuyen.Text;

            string prepapre =
                "update Quyen set TenSach = '{0}' where MaSach='{1}' ;";

            string sql = String.Format(prepapre, tenQuyen, maQuyen);

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

        private void btn_XoaQuyen_Click(object sender, EventArgs e)
        {
            string maQuyen = txt_MaQuyen.Text;
            string prepare = "delete from Quyen where MaSach = '{0}'";
            string sql = String.Format(prepare, maQuyen);

            DialogResult confirmDialogResult = MessageBox.Show("bạn muốn xóa mã quyền " + maQuyen);
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
    }
}
