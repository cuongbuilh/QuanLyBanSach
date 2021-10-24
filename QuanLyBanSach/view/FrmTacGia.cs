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
        public FrmTacGia()
        {
            InitializeComponent();
        }

        private void FrmTacGia_Load(object sender, EventArgs e)
        {
            LoadDataToForm();
            BindingData();
        }


    }
}
