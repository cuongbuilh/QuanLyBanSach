using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanSach.entity;

namespace QuanLyBanSach.DAO
{
    class TacGiaDAO : AbstractDAO
    {
        public DataTable GetDatatable()
        {
            // todo-list
            return Lay_DulieuBang("select * from TacGia");
        }

        public void Insert(TacGia tacGia)
        {
            // todo-list
            string prepare = "insert into TacGia values={{0},'{1}','{2}'}";
            string sql = String.Format(prepare, tacGia.getMaTacGia(), tacGia.getTenTacGia(), tacGia.getMota());
            ThucThi(sql);
        }

        public void Delete(int maTacGia)
        {
            // todo-list
            string prepare = "delete from TacGia where MaTacGia = {0}";
            string sql = String.Format(prepare, maTacGia);
            ThucThi(sql);
        }

        public void Update(TacGia tacGia)
        {
            // todo-list
            string prepare = "update TacGia set TenTacGia = '{0}', MoTa = '{1}' where MaTacGia = {2}";
            string sql = String.Format(prepare, tacGia.getTenTacGia(), tacGia.getMota(), tacGia.getMaTacGia());
            ThucThi(sql);
        }

        // return true if exists
        public bool IsIDExists(int id)
        {
            // todo-list
            string prepare = "select * from TacGia where id = {0}";
            string sql = String.Format(prepare, id);
            return DocDuLieu(sql).Read();
        }

    }
}
