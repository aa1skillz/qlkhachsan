using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class DTO_PhieuThue
    {
        private string maphieuthue;

        public string Maphieuthue
        {
            get { return maphieuthue; }
            set { maphieuthue = value; }
        }
        private string maphong;

        public string Maphong
        {
            get { return maphong; }
            set { maphong = value; }
        }
        private string makhach;

        public string Makhach
        {
            get { return makhach; }
            set { makhach = value; }
        }
        private DateTime ngaythue;

        public DateTime Ngaythue
        {
            get { return ngaythue; }
            set { ngaythue = value; }
        }
        private DateTime ngaytra;

        public DateTime Ngaytra
        {
            get { return ngaytra; }
            set { ngaytra = value; }
        }
        private int soluongnguoi;

        public int Soluongnguoi
        {
            get { return soluongnguoi; }
            set { soluongnguoi = value; }
        }
        private DateTime ngaylap;

        public DateTime Ngaylap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }
        private string manhanvien;

        public string Manhanvien
        {
            get { return manhanvien; }
            set { manhanvien = value; }
        }
    }
}
