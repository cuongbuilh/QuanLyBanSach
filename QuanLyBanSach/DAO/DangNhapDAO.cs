using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBanSach.entity;

namespace QuanLyBanSach.DAO
{
    class DangNhapDAO:AbstractDAO
    {
        public DataTable GetDatatable()
        {
            // todo-list
            return Lay_DulieuBang("select * from DangNhap");
        }

        // return true if exists
        public bool Login(DangNhap dangNhap)
        {
            // todo-list
            string prepare = "select * from DangNhap where TenDangNhap = '{0}' and MatKhau = '{1}'";
            string sql = String.Format(prepare, dangNhap.getTenDangNhap(), dangNhap.getMatKhau());
            return DocDuLieu(sql).Read();
        }

        public void Update(DangNhap dangNhap)
        {
            // todo-list
            string prepare = "update DangNhap set MatKhau = '{0}' where TenDangNhap = '{1}' ";
            string sql = String.Format(prepare, dangNhap.getMatKhau(), dangNhap.getTenDangNhap());
            ThucThi(sql);
        }

       
    }
}
