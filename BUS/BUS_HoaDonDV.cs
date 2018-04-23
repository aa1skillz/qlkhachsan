using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
   public class BUS_HoaDonDV
    {
       DAL_HoaDonDV hoadondv = new DAL_HoaDonDV();
       public DataTable getHDDV(string maphong)
       {
           return hoadondv.getDVSD(maphong);
       }

       public bool them(DTO_HoaDonDV obj)
       {
           return hoadondv.them(obj);
       }

       public bool capnhat(string maphong,string tinhtrang)
       {
           return hoadondv.capnhat(maphong,tinhtrang);
       }
       public DataTable getTenDV()
       {
           return hoadondv.getTenDV();
       }
       public DataTable xemDV(string mapt)
       {
           return hoadondv.XEM(mapt);
       }
       public string makhachtheomaphong(string maphong)
       {
           return hoadondv.makhachtheomaphong(maphong);
       }

           public string maphieuthuetheomakhach(string makhach)
       {
           return hoadondv.maphieuthuetheomakhach(makhach);
       }
       public DataTable xemHDTR(string ma)
       {
           return hoadondv.xemHoaDonTheoMaPT(ma);
       }
    }
}
