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
    public partial class FrmTacGia : Form
    {
        private ADOUtils adoUtils;
        public FrmTacGia()
        {
            InitializeComponent();
            adoUtils = new ADOUtils();
        }

        private void FrmTacGia_Load(object sender, EventArgs e)
        {
            LoadDataToForm();

            txt_MaTacGia.Enabled = false;

            btn_Luu.Enabled = false;
        }

        private void LoadDataToForm()
        {
            view_TacGia.DataSource = adoUtils.GetDataTable("select * from TACGIA");
            BindingData();
        }

        private void BindingData()
        {
            txt_MaTacGia.Clear();
            txt_MaTacGia.DataBindings.Clear();
            txt_MaTacGia.DataBindings.Add("Text", view_TacGia.DataSource, "MATACGIA");

            txt_TenTacGia.Clear();
            txt_TenTacGia.DataBindings.Clear();
            txt_TenTacGia.DataBindings.Add("Text", view_TacGia.DataSource, "TENTACGIA");

            txt_MoTa.Clear();
            txt_MoTa.DataBindings.Clear();
            txt_MoTa.DataBindings.Add("Text", view_TacGia.DataSource, "MOTA");

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txt_MaTacGia.Text = "";
            txt_TenTacGia.Text = "";
            txt_MoTa.Text = "";
            btn_Luu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maTacGia = txt_MaTacGia.Text;
            string tenTacGia = txt_TenTacGia.Text;
            string moTa = txt_MoTa.Text;


            string prepare =
                "insert into TACGIA(TenTacGia, MoTa) values ('{0}', '{1}');";
            string sql = String.Format(prepare, tenTacGia, moTa);

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
            int maTacGia = Int32.Parse(txt_MaTacGia.Text);
            string tenTacGia = txt_TenTacGia.Text;
            string moTa = txt_MoTa.Text;


            string prepapre =
                "update TACGIA set TenTacGia = '{0}', MoTa = '{1}' where MaTacGia = {2} ;";
            string sql = String.Format(prepapre, tenTacGia, moTa, maTacGia);

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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tenTacGia = txt_TenTacGia.Text;
            string prepare = "delete from TACGIA where TenTacGia = '{0}'";
            string sql = String.Format(prepare, tenTacGia);

            DialogResult confirmDialogResult = MessageBox.Show("bạn muốn xóa tác giả " + tenTacGia, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
