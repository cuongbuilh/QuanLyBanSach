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
            adoUtils = new ADOUtils;
        }


    }
}
