using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
 public   class BUS_LoaiPhong
    {
     DAL_LoaiPhong lp = new DAL_LoaiPhong();
     public DataTable getLP()
     {
         return lp.getLP();
     }

     public bool ktMLP(string ma)
     {
         return lp.ktMa(ma);
     }
     public bool them(DTO_LoaiPhong obj)
     {
         return lp.them(obj);
     }
     public bool capnhat(DTO_LoaiPhong obj)
     {
         return lp.capnhat(obj);
     }
     public bool xoa(DTO_LoaiPhong obj)
     {
         return lp.xoa(obj);
     }
    }
}
