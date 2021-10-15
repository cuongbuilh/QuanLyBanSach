using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.entity
{
    class NguoiDung
    {
        private int maNguoiDung;
        private string tenNguoiDung;
        private string email;
        private DateTime ngayDangKy;
        private string soDienThoai;
        private string diaChi;

        public int getMaNguoiDung()
        {
            return maNguoiDung;
        }

        public void setMaNguoiDung(int maNguoiDung)
        {
            this.maNguoiDung = maNguoiDung;
        }

        public string getTenNguoiDung()
        {
            return tenNguoiDung;
        }

        public void setTenNguoiDung(string tenNguoiDung)
        {
            this.tenNguoiDung = tenNguoiDung;
        }

        public string getemail()
        {
            return email;
        }

        public void setemail(string email)
        {
            this.email = email;
        }

        public DateTime getngayDangKy()
        {
            return ngayDangKy;
        }

        public void setngayDangKy(DateTime ngayDangKy)
        {
            this.ngayDangKy = ngayDangKy;
        }

        public string getsoDienThoai()
        {
            return soDienThoai;
        }

        public void setsoDienThoat(string soDienThoai)
        {
            this.soDienThoai = soDienThoai;
        }

        public string getdiaChi()
        {
            return diaChi;
        }

        public void setdiaChi(string diaChi)
        {
            this.diaChi = diaChi;
        }
    }
}
