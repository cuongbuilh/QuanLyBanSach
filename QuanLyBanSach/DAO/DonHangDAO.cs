using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBanSach.entity;


namespace QuanLyBanSach.DAO
{
    class DonHangDAO : AbstractDAO
    {
        public DataTable getDatatable()
        {
            // todo-list
            return Lay_DulieuBang("select * from DonHang");
        }

        public void insert(DonHang donHang)
        {
            // todo-list
            string prepare = "insert into DonHang values={{0},'{1}','{2}'}";
            string sql = String.Format(prepare, donHang.getmaDonHang(), donHang.getMaNguoiDung(), donHang.getngayTao());
            ThucThi(sql);
        }

        public void delete(int maDonHang)
        {
            // todo-list
            string prepare = "delete from DonHang where MaDonHang = {0}";
            string sql = String.Format(prepare, maDonHang);
            ThucThi(sql);
        }

        public void update(DonHang donHang)
        {
            // todo-list
            string prepare = "update DonHang set MaNguoiDung = '{0}', NgayTao = '{1}' where MaDonHang = {2}";
            string sql = String.Format(prepare, donHang.getMaNguoiDung(), donHang.getngayTao(), donHang.getmaDonHang());
            ThucThi(sql);
        }

        // return true if exists
        public bool isIDExists(int id)
        {
            // todo-list
            string prepare = "select * from DonHang where MaDonHang = {0}";
            string sql = String.Format(prepare, id);
            return DocDuLieu(sql).Read();
        }

    }
}
