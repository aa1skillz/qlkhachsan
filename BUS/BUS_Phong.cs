using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BUS
{   
   public class BUS_Phong
    {
        DAL_Phong Phong = new DAL_Phong();
       public bool capnhatphong(DTO_Phong obj)
        {
            return Phong.CapNhatPhong(obj);
        }
        public DataTable GetPhong()
        {
            return Phong.GetPhong();
        }
       public DataTable getTinhTrang(string maphong)
        {
            return Phong.getTinhTrang(maphong);
        }
        public DataTable GetTenPhong()
        {
            return Phong.getTenphong();
        }
       public string tutangMPhong()
        {
            return Phong.TuTangMPhong();
        }

       public bool themPhong(DTO_Phong obj)
       {
           return Phong.themPhong(obj);
       }
       public bool suaPhong(DTO_Phong obj)
       {
           return Phong.suaPhong(obj);
       }
       public bool xoaPhong(DTO_Phong obj)
       {
           return Phong.xoaPhong(obj);
       }
    }
}
