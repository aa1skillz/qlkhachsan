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
  public  class BUS_Khach
    {
      DAL_Khach khach = new DAL_Khach();
        public DataTable getKhach()
      {
          return khach.getKhach();
      }
      public string tuTangMK()
        {
            return khach.TuTangMKhach();
        }
      public bool themKhach(DTO_Khach obj)
      {
          return khach.themKhach(obj);
      }
      public bool suaKhach(DTO_Khach obj)
      {
          return khach.suaKhach(obj);
      }
      public bool xoaKhach(DTO_Khach obj)
      {
          return khach.xoaKhach(obj);
      }
    }
}
