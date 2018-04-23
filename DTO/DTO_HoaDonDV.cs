using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_HoaDonDV
    {
        private string madichvu;

        public string Madichvu
        {
            get { return madichvu; }
            set { madichvu = value; }
        }
        private string maphieuthue;

        public string Maphieuthue
        {
            get { return maphieuthue; }
            set { maphieuthue = value; }
        }
        private int soluongdv;

        public int Soluongdv
        {
            get { return soluongdv; }
            set { soluongdv = value; }
        }
        private DateTime ngaysudung;

        public DateTime Ngaysudung
        {
            get { return ngaysudung; }
            set { ngaysudung = value; }
        }
        private string tinhtrang;

        public string Tinhtrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value; }
        }
    }
}
