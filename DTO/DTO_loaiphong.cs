using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_LoaiPhong
    {
        private string maloaiphong;

        public string Maloaiphong
        {
            get { return maloaiphong; }
            set { maloaiphong = value; }
        }
        private string tenloaiphong;

        public string Tenloaiphong
        {
            get { return tenloaiphong; }
            set { tenloaiphong = value; }
        }
        private float dongia;

        public float Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }
    }
}
