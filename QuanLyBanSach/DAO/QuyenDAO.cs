using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanSach.entity;


namespace QuanLyBanSach.DAO
{
    class QuyenDAO : AbstractDAO
    {
        public DataTable GetDataTable()
        {
            return Lay_DulieuBang("select * from Quyen");
        }

        public void Insert(Quyen quyen)
        {
            string prepare = "insert into Quyen values={{0},'{1}'}";
            string sql = String.Format(prepare, quyen.getMaQuyen(), quyen.getTenQuyen());
            ThucThi(sql);
        }
        public void Delete(int maQuyen)
        {
            // todo-list
            string prepare = "delete from Quyen where MaQuyen = {0}";
            string sql = String.Format(prepare, maQuyen);
            ThucThi(sql);
        }
        public void Update(Quyen quyen)
        {
            // todo-list
            string prepare = "update Quyen set TenQuyen = '{0}' where MaQuyen = {1}";
            string sql = String.Format(prepare, quyen.getTenQuyen(), quyen.getMaQuyen());
            ThucThi(sql);
        }
        public bool IsIDExists(int id)
        {
            // todo-list
            string prepare = "select * from Quyen where MaQuyen = {0}";
            string sql = String.Format(prepare, id);
            return DocDuLieu(sql).Read();
        }
    }
}
