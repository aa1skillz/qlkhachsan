using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BUS
{
   public class BUS_TimKiemPhong
    {
       DAL_TimKiemPhong tkp = new DAL_TimKiemPhong();

       public DataTable getMa()
       {
           return tkp.getMaPhong();
       }

       public DataTable getPhong()
       {
           return tkp.getLoaiPhong();
       }
       public DataTable tktM(string ma)
       {
           return tkp.TTPtheoMa(ma);
       }
       public DataTable tktT(string ten)
       {
           return tkp.TTPtheoLoai(ten);
       }
    }
}
