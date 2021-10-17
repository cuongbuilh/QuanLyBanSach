using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBanSach.entity;

namespace QuanLyBanSach.DAO
{
    class ChiTietDonHangDAO :  AbstractDAO
    {
        public DataTable GetDatatable()
        {
            // todo-list
            return Lay_DulieuBang("select * from ChiTietDonHang");
        }

        public void Insert(ChiTietDonHang chiTietDonHang)
        {
            // todo-list
            string prepare = "insert into ChiTietDonHang values={{0},'{1}','{2}'}";
            string sql = String.Format(prepare, chiTietDonHang.getMaDonHang(), chiTietDonHang.getMaSach(), chiTietDonHang.getSoLuong());
            ThucThi(sql);
        }

        public void Delete(int maDonHang, int maSach)
        {
            // todo-list
            string prepare = "delete from ChiTietDonHang where MaDonHang = {0} and MaSach = {1}";
            string sql = String.Format(prepare, maDonHang, maSach);
            ThucThi(sql);
        }

        public void Update(ChiTietDonHang chiTietDonHang)
        {
            // todo-list
            string prepare = "update ChiTietDonHang set SoLuong = '{0}' where MaDonHang = {1} and MaSach = {2}";
            string sql = String.Format(prepare, chiTietDonHang.getSoLuong(), chiTietDonHang.getMaDonHang(), chiTietDonHang.getMaSach());
            ThucThi(sql);
        }

        // return true if exists
        public bool IsIDExists(int maDonHang, int maSach)
        {
            // todo-list
            string prepare = "select * from ChiTietDonHang where MaDonHang = {0} and MaSach = {1}";
            string sql = String.Format(prepare, maDonHang, maSach);
            return DocDuLieu(sql).Read();
        }
    }
}
