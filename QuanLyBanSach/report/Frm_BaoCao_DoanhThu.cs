using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace QuanLyBanSach.report
{
    public partial class Frm_BaoCao_DoanhThu : Form
    {
        public Frm_BaoCao_DoanhThu()
        {
            InitializeComponent();
        }

        private void Frm_BaoCao_DoanhThu_Load(object sender, EventArgs e)
        {
            BC_DoanhThu bc = new BC_DoanhThu();
            bc.SetDatabaseLogon("sa","Admin1234", "101.96.66.219,8013", "QLSach");
            crv.ReportSource = bc;
            crv.RefreshReport();
        }
    }
}
