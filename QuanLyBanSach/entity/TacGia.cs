using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.entity
{
    class TacGia
    {
        private int maTacGia;
        private string tenTacGia;
        private string mota;

        public int getMaTacGia()
        {
            return maTacGia;
        }

        public void setMaTacGia(int maTacGia)
        {
            this.maTacGia = maTacGia;
        }

        public string getTenNXB()
        {
            return tenTacGia;
        }
        public void setTenNXB(string tenTacGia)
        {
            this.tenTacGia = tenTacGia;
        }

        public string getMota()
        {
            return mota;
        }
        public void setMota(string mota)
        {
            this.mota = mota;
        }
    }
}
