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

    }
}
