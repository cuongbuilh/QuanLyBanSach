using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanSach.entity;

namespace QuanLyBanSach.DAO
{
    class NhaXuatBanDAO : AbstractDAO
    {
        public DataTable GetDatatable()
        {
            // todo-list
            return Lay_DulieuBang("select * from NhaXuatBan");
        }

        public void Insert(NhaXuatBan nhaXuatBan)
        {
            // todo-list
            string prepare = "insert into NhaXuatBan values={{0},'{1}','{2}'}";
            string sql = String.Format(prepare, nhaXuatBan.getMaNXB(), nhaXuatBan.getTenNXB(), nhaXuatBan.getDiachi());
            ThucThi(sql);
        }

        public void Delete(int maNXB)
        {
            // todo-list
            string prepare = "delete from NhaXuatBan where MaNXB = {0}";
            string sql = String.Format(prepare, maNXB);
            ThucThi(sql);
        }

        public void Update(NhaXuatBan nhaXuatBan)
        {
            // todo-list
            string prepare = "update TacGia set TenTacGia = '{0}', MoTa = '{1}' where MaTacGia = {2}";
            string sql = String.Format(prepare, nhaXuatBan.getTenNXB(), nhaXuatBan.getDiachi(), nhaXuatBan.getMaNXB());
            ThucThi(sql);
        }

        // return true if exists
        public bool IsIDExists(int id)
        {
            // todo-list
            string prepare = "select * from TacGia where maNXB = {0}";
            string sql = String.Format(prepare, id);
            return DocDuLieu(sql).Read();
        }
    }
}
