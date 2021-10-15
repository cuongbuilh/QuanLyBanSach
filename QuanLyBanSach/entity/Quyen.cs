using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.entity
{
    class Quyen
    {
        private int maQuyen;
        private string tenQuyen;

        public int getMaQuyen()
        {
            return maQuyen;
        }

        public void setMaQuyen(int maQuyen)
        {
            this.maQuyen = maQuyen;
        }

        public string getTenQuyen()
        {
            return tenQuyen;
        }

        public void setTenQuyen(string tenQuyen)
        {
            this.tenQuyen = tenQuyen;
        }
    }
}
