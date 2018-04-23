using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO;

namespace BUS
{
   public class BUS_DichVu
    {
       DAL_DichVu dv = new DAL_DichVu();
       public DataTable getThongTinDV()
       {
           return dv.getThongTinDV();
       }
       public bool ktMDV(string ma)
       {
           return dv.ktTM(ma);
       }

       public DataTable getMaDV(string TDV)
       {
           return dv.getMDV(TDV);
       }
       public bool them(DTO_DichVu obj)
       {
           return dv.themDV(obj);
       }
       public bool capnhat(DTO_DichVu obj)
       {
           return dv.capnhatDV(obj);
       }
       public bool xoa(DTO_DichVu obj)
       {
           return dv.xoaDV(obj);
       }
    }
}
