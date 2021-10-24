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
                    "select NgayTao, MaNguoiDung , ct.MaDonHang as MaDon, ct.MaSach as MaSach, s.TenSach as TenSach, SoLuong, giabia, giaban from DONHANG dh, Sach s, ChiTietDonHang ct where ct.MaDonHang = dh.MaDonHang and ct.MaSach = s.MaSach");

            cbo_MaDon.DataSource = adoUtils.GetDataTable("select MaDonHang from DonHang ");
            cbo_MaNguoiDung.DataSource = adoUtils.GetDataTable("select MaNguoiDung from NguoiDung");
        }

        private void BindingData()
        {
        }

        private void btn_TimSach_Click(object sender, EventArgs e)
        {
            string search_key = txt_TimSach.Text;
            string prepare = "select MASACH, TENSACH from Sach where MaSach='{}' or TenSach = '{}';";
            string sql = String.Format(prepare, search_key);
            data_Sach.DataSource = adoUtils.GetDataTable(sql);
        }

        private void btn_TaoDon_Click(object sender, EventArgs e)
        {
            // string[] list_item = txt_DanhSach.Text.Split('\n');
            // string[] list_amount = txt_SoLuong.Text.Split('\n');
            // string maDonHang = txt_MaDon.Text;
            // Dictionary<string, int> mapDictionary = new Dictionary<string, int>();
            //
            // for (var i = 0; i < list_item.Length; i++)
            // {
            //     if ((list_item[i].Trim() != "") && (list_amount[i].Trim() != ""))
            //     {
            //         string item = list_item[i].Trim();
            //         int amount = Int32.Parse(list_amount[i].Trim());
            //         string prepare = "insert into ChiTietDonHang values ('{0}','{1}',{2})";
            //         string sql = String.Format(prepare, maDonHang, item, amount);
            //         adoUtils.Excute(sql);
            //     }
            //
            // }
            //
            // LoadDataToForm();
        }

        private void btn_TimDon_Click(object sender, EventArgs e)
        {
            // string maDon = txt_MaDon.Text;
            // string maND = txt_MaNguoiDung.Text;
            // string sql =
            //     "select NgayTao, MaNguoiDung , ct.MaDonHang as MaDon, ct.MaSach as MaSach, s.TenSach as TenSach, SoLuong, giabia, giaban from DONHANG dh, Sach s, ChiTietDonHang ct where ct.MaDonHang = dh.MaDonHang and ct.MaSach = s.MaSach where true";
            // if (maDon != "")
            // {
            //     sql = sql + "and MaDon = '" + maDon + "'";
            // }
            // if (maND != "")
            // {
            //     sql = sql + "and MaNguoiDung = '" + maND + "'";
            // }
            //
            // data_DonHang.DataSource = adoUtils.GetDataTable(sql);
        }

        private void btn_XoaDon_Click(object sender, EventArgs e)
        {
            // string maDon = txt_MaDon.Text;
            // if (maDon == "")
            // {
            //     return;
            // }
            //
            // if (MessageBox.Show("xóa đơn: " + maDon) == DialogResult.OK)
            // {
            //     string prepare = "delete from ChiTietDonHang where MaDonHang = '{0}'";
            //     string sql = String.Format(prepare, maDon);
            //     adoUtils.Excute(sql);
            // }
            //
            // LoadDataToForm();
        }
    }
}
