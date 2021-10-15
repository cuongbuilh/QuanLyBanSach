using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.entity
{
    class DonHang
    {
        private int maDonHang;
        private int maNguoiDung;
        private DateTime ngayTao;

        public int getmaDonHang()
        {
            return maDonHang;
        }

        public void setmaDonHang(int maDonHang)
        {
            this.maDonHang = maDonHang;
        }

        public int getMaNguoiDung()
        {
            return maNguoiDung;
        }

        public void setMaNguoiDung(int maNguoiDung)
        {
            this.maNguoiDung = maNguoiDung;
        }

        public DateTime getngayTao()
        {
            return ngayTao;
        }

        public void setngayTao(DateTime ngayTao)
        {
            this.ngayTao = ngayTao;
        }

    }
}
