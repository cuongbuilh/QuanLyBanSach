using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.entity
{
    class DangNhap
    {
        private string tenDangNhap;
        private string matKhau;
        private int maNguoiDung;
        private int maQuyen;


        public string getTenDangNhap()
        {
            return tenDangNhap;
        }

        public void setTenDangNhap(string tenDangNhap)
        {
            this.tenDangNhap = tenDangNhap;
        }


        public string getMatKhau()
        {
            return matKhau;
        }

        public void setMatKhau(string matKhau)
        {
            this.matKhau = matKhau;
        }

        public int getMaNguoiDung()
        {
            return maNguoiDung;
        }

        public void setMaNguoiDung(int maNguoiDung)
        {
            this.maNguoiDung = maNguoiDung;
        }
        public int getMaQuyen()
        {
            return maQuyen;
        }

        public void setMaQuyen(int maQuyen)
        {
            this.maQuyen = maQuyen;
        }
    }


}
