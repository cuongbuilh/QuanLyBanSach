using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.entity
{
    class TheLoai
    {
        private int maLoai;
        private string tenLoai;

        //Ma loai
        public int getMaLoai()
        {
            return maLoai;
        }

        public void setMaLoai(int maLoai)
        {
            this.maLoai = maLoai;
        }

        //Ten loai
        public string getTenLoai()
        {
            return tenLoai;
        }

        public void setTenLoai(string tenLoai)
        {
            this.tenLoai = tenLoai;
        }
    }
}
