using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.entity
{
    class Sach
    {
        private int maSach;
        private string tenSach;
        private int maNXB;
        private int maTacGia;
        private int giaBia;
        private int giaBan;
        private DateTime namXuatBan;
        private int maLoai;

        //Ma sach
        public int getMaSach()
        {
            return maSach;
        }

        public void setMaSach(int maSach)
        {
            this.maSach = maSach;
        }

        //Ten sach
        public string getTenSach()
        {
            return tenSach;
        }

        public void setTenSach(string tenSach)
        {
            this.tenSach = tenSach;
        }

        //Nha xuat ban
        public int getMaNXB()
        {
            return maNXB;
        }

        public void setMaNXB(int maNXB)
        {
            this.maNXB = maNXB;
        }

        //Ma tac gia
        public int getMaTacGia()
        {
            return maTacGia;
        }

        public void setMaTacGia(int maTacGia)
        {
            this.maTacGia = maTacGia;
        }

        //Gia Bia
        public int getGiaBia()
        {
            return giaBia;
        }

        public void setGiaBia(int giaBia)
        {
            this.giaBia = giaBia;
        }

        //Gia Ban
        public int getGiaBan()
        {
            return giaBan;
        }

        public void setGiaBan(int giaBan)
        {
            this.giaBan = giaBan;
        }
        //Nam Xuat Ban
        public DateTime getNamXuatBan()
        {
            return namXuatBan;
        }

        public void setNamXuatBan(int namXuatBan)
        {
            this.namXuatBan = namXuatBan;
        }
        //Ma loai
        public int getMaLoai()
        {
            return maLoai;
        }

        public void setMaLoai(int maLoai)
        {
            this.maLoai = maLoai;
        }
    }
}
