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
            data_Sach.DataSource = adoUtils.GetDataTable("select MASACH, TENSACH from Sach");
            data_DonHang.DataSource =
                adoUtils.GetDataTable(
                    "select NgayTao, MaNguoiDung , ct.MaDonHang as MaDon, ct.MaSach as MaSach, s.TenSach as TenSach, SoLuong, giabia, giaban from DONHANG dh, Sach s, ChiTietDonHang ct where ct.MaDonHang = dh.MaDonHang ct.MaSach = s.MaSach");


        }

        private void BindingData()
        {
            txt_MaDon.Clear();
            txt_MaDon.DataBindings.Add("Text", data_DonHang.DataSource, "MaDon");

            txt_MaNguoiDung.Clear();
            txt_MaNguoiDung.DataBindings.Add("Text", data_DonHang.DataSource, "MaNguoiDung");
        }

        private void btn_TimSach_Click(object sender, EventArgs e)
        {

        }
    }
}
