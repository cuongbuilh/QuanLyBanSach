using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.entity
{
    class NhaXuatBan
    {
        private int maNXB;
        private string tenNXB;
        private string diachi;

        public int getMaNXB()
        {
            return maNXB;
        }
        public void setMaNXB(int maNXB)
        {
            this.maNXB = maNXB;
        }

        public string getTenNXB()
        {
            return tenNXB;
        }
        public void setTenNXB(string tenNXB)
        {
            this.tenNXB = tenNXB;
        }

        public string getDiachi()
        {
            return diachi;
        }
        public void setDiachi(string diachi)
        {
            this.diachi = diachi;
        }

    }
}
