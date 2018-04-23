using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
   public class BUS_TKKhach
    {
       DAL_TimKiemKhach tkk = new DAL_TimKiemKhach();
       public DataTable Ma()
       {
           return tkk.MaKhach();
       }
       public DataTable tktM(string ma)
       {
           return tkk.TTKtheoMa(ma);
       }
       public DataTable tktT(string ten)
       {
           return tkk.TTKtheoTen(ten);
       }
    }
}
