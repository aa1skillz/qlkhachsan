using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class DTO_Khach
    {
        private string makhach;

        public string Makhach
        {
            get { return makhach; }
            set { makhach = value; }
        }
        private string tenkhach;

        public string Tenkhach
        {
            get { return tenkhach; }
            set { tenkhach = value; }
        }
        private DateTime ngaysinh;

        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        private string gioitinh;

        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        private string cmnd;

        public string Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
        private string diachi;

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        private string quoctich;

        public string Quoctich
        {
            get { return quoctich; }
            set { quoctich = value; }
        }


    }
}
