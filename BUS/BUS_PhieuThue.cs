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
   public class BUS_PhieuThue
    {
       DAL_PhieuThue phieuthue = new DAL_PhieuThue();
       public bool themPhieuThue(DTO_PhieuThue obj)
       {
           return phieuthue.themPhieuThue(obj);
       }
       public string tutangMPT()
       {
           return phieuthue.TuTangMPT();
       }
    }
}
