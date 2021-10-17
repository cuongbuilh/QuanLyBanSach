using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanSach.entity;

namespace QuanLyBanSach.DAO
{
    class NguoiDungDAO : AbstractDAO
    {
        public DataTable GetDataTable()
        {
            return Lay_DulieuBang("select * from NguoiDung");
        }

        public void insert(NguoiDung nguoiDung)
        {
            string prepare = "insert into NguoiDung values = {{0}, '{1}', '{2}, '{3}', '{4}', '{5}'}";
            string sql = String.Format(prepare, nguoiDung.getMaNguoiDung(), nguoiDung.getTenNguoiDung(), nguoiDung.getsoDienThoai(), nguoiDung.getemail(), nguoiDung.getdiaChi(), nguoiDung.getngayDangKy());
            ThucThi(sql);
        }

        public void delete(int maNguoiDung)
        {
            // todo-list
            string prepare = "delete from NguoiDung where MaNguoiDung = {0}";
            string sql = String.Format(prepare, maNguoiDung);
            ThucThi(sql);
        }

        public void update(NguoiDung nguoiDung)
        {
            // todo-list
            string prepare = "update NguoiDung set TenNguoiDung = '{0}', email = '{1}', ngayDangKy = '{2}', soDienThoai = '{3}', diaChi = '{4}' where maNguoiDung = {5}";
            string sql = String.Format(prepare, nguoiDung.getTenNguoiDung(), nguoiDung.getemail(), nguoiDung.getMaNguoiDung(), nguoiDung.getsoDienThoai(), nguoiDung.getdiaChi(), nguoiDung.getngayDangKy());
            ThucThi(sql);
        }

        // return true if exists
        public bool isIDExists(int id)
        {
            // todo-list
            string prepare = "select * from NguoiDung where maNguoiDung = {0}";
            string sql = String.Format(prepare, id);
            return DocDuLieu(sql).Read();
        }
    }
}
