using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBanSach.entity;

namespace QuanLyBanSach.DAO
{
    class TheLoaiDAO : AbstractDAO
    {
        public DataTable GetDatatable()
        {
            // todo-list
            return Lay_DulieuBang("select * from TheLoai");
        }

        public void Insert(TheLoai theLoai)
        {
            // todo-list
            string prepare = "insert into TheLoai values={{0},'{1}'}";
            string sql = String.Format(prepare, theLoai.getMaLoai(), theLoai.getTenTenTheLoai());
            ThucThi(sql);
        }

        public void Delete(int maLoai)
        {
            // todo-list
            string prepare = "delete from TheLoai where MaLoai = {0}";
            string sql = String.Format(prepare, maLoai);
            ThucThi(sql);
        }

        public void Update(TheLoai theLoai)
        {
            // todo-list
            string prepare = "update TheLoai set TenLoai = '{0}' where MaLoai = {1}";
            string sql = String.Format(prepare, theLoai.getTenLoai(), theLoai.getMaLoai());
            ThucThi(sql);
        }

        // return true if exists
        public bool IsIDExists(int id)
        {
            // todo-list
            string prepare = "select * from MaLoai where id = {0}";
            string sql = String.Format(prepare, id);
            return DocDuLieu(sql).Read();
        }

    }
}
