using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.entity
{
    class ChiTietDonHang
    {
        private int maDonHang;
        private int maSach;
        private int soLuong;

        public int getMaDonHang()
        {
            return maDonHang;
        }

        public void setMaDonHang(int maDonHang)
        {
            this.maDonHang = maDonHang;
        }

        public int getMaSach()
        {
            return maSach;
        }

        public void setMaSach(int maSach)
        {
            this.maSach = maSach;
        }

        public int getSoLuong()
        {
            return soLuong;
        }

        public void setSoLuong(int soLuong)
        {
            this.soLuong = soLuong;
        }
    }
}
