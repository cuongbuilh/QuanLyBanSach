using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanSach.entity;

namespace QuanLyBanSach.DAO
{
    class DangKyDAO : AbstractDAO
    {
        class DangNhapDAO : AbstractDAO
        {
            public DataTable GetDatatable()
            {
                // todo-list
                return Lay_DulieuBang(
                    "select * from DangNhap, NguoiDung where DangNhap.MaNguoiDung = NguoiDung.MaNguoiDung");
            }
            public void Insert(DangNhap dangNhap, NguoiDung nguoiDung)
            {
                // todo-list
                NguoiDungDAO nguoiDungDAO = new NguoiDungDAO();
                nguoiDungDAO.Insert(nguoiDung);
                string prepare = "insert into DangNhap values={'{0}','{1}',{2},{3}}";
                string sql = String.Format(prepare, dangNhap.getTenDangNhap(), dangNhap.getMatKhau(),
                    nguoiDung.getMaNguoiDung(), dangNhap.getMaQuyen());
                ThucThi(sql);
            }

            public void Delete(int maNguoiDung)
            {
                // todo-list
                string prepare = "delete from NguoiDung where TenDangNhap = {0}";
                string sql = String.Format(prepare, maNguoiDung);
                ThucThi(sql);
            }

            public void Update(DangNhap dangNhap)
            {
                // mã tác giả không được thay đổi
                // todo-list
                string prepare = "update DangNhap set MatKhau = '{0}' where TenDangNhap = '{1}'";
                string sql = String.Format(prepare, dangNhap.getMatKhau(), dangNhap.getTenDangNhap());
                ThucThi(sql);
            }

            // return true if exists
            public bool IsIDExists(string ten)
            {
                // todo-list
                string prepare = "select * from DangNhap where TenDangNhap = '{0}'";
                string sql = String.Format(prepare, ten);
                return DocDuLieu(sql).Read();
            }
        }
    }
}