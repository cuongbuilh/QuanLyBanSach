using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanSach.entity;

namespace QuanLyBanSach.DAO
{
    class SachDAO : AbstractDAO
    {
        public DataTable GetDatatable()
        {
            // todo-list
            return Lay_DulieuBang("select * from Sach");
        }
        public void Insert(Sach sach)
        {
            // todo-list
            string prepare = "insert into Sach values={{0},'{1}',{2},{3},{4},{5},'{6}',{7}";
            string sql = String.Format(prepare, sach.getMaSach(), sach.getTenSach(), sach.getMaNXB(), sach.getMaTacGia(),sach.getGiaBia(),sach.getGiaBan(),sach.getNamXuatBan(), sach.getMaLoai());
            ThucThi(sql);
        }
        public void Delete(int maSach)
        {
            // todo-list
            string prepare = "delete from Sach where MaSach = {0}";
            string sql = String.Format(prepare, maSach);
            ThucThi(sql);
        }
        public void Update(Sach sach)
        {
            // todo-list
            string prepare = "update Sach set TenSach = '{0}', MaNXB = {1}, MaTacGia = {2}, GiaBia = {3}, GiaBan = {4}, NamXuatBan = '{5}', MaLoai = {6} where MaSach = {7}";
            string sql = String.Format(prepare, sach.getTenSach(), sach.getMaNXB(), sach.getMaTacGia(), sach.getGiaBia(), sach.getGiaBan(), sach.getNamXuatBan(), sach.getMaLoai(), sach.getMaSach());
            ThucThi(sql);
        }
        public bool IsIDExists(int id)
        {
            // todo-list
            string prepare = "select * from Sach where MaSach = {0}";
            string sql = String.Format(prepare, id);
            return DocDuLieu(sql).Read();
        }
    }
}
