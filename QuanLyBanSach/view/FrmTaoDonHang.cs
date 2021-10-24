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
    public partial class FrmTaoDonHang : Form
    {
        private ADOUtils adoUtils;
        public FrmTaoDonHang()
        {
            InitializeComponent();
            adoUtils = new ADOUtils();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmTaoDonHang_Load(object sender, EventArgs e)
        {
            LoadDataToForm();
            BindingData();
        }

        private void LoadDataToForm()
        {
            data_Sach.DataSource = adoUtils.GetDataTable("select MASACH, TENSACH from ");
        }

        private void BindingData()
        {
        }


    }
}
