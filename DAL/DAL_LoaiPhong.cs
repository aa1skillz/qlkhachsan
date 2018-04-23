using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
  public  class DAL_LoaiPhong:DAL_KetNoi
    {
      public DataTable getLP()
      {
          return Table("SP_LOAIPHONG_Xem",1);
      }
      public bool ktMa(string ma)
      {   int paraNumber = 1;
          string[] paraName = new string[paraNumber];
          object[] values = new object[paraNumber];
          paraName[0] = "MALP";
          values[0] = ma;
          DataTable dt = Table("SP_LOAIPHONG_KT",paraName, values, paraNumber);
          if (dt.Rows.Count > 0)
              return true;
          return false;
      }
      public bool them(DTO_LoaiPhong obj)
      {
          int paraNumber = 3;
          string[] paraName = new string[paraNumber];
          object[] values = new object[paraNumber];
          paraName[0] = "MALOAIPHONG";
          paraName[1] = "TENLOAIPHONG";
          paraName[2] = "DONGIA";
          values[0] = obj.Maloaiphong;
          values[1] = obj.Tenloaiphong;
          values[2] = obj.Dongia;
          return Update("SP_LOAIPHONG_Them", paraName, values, paraNumber);
      }

      public bool capnhat(DTO_LoaiPhong obj)
      {
          int paraNumber = 3;
          string[] paraName = new string[paraNumber];
          object[] values = new object[paraNumber];
          paraName[0] = "MALOAIPHONG";
          paraName[1] = "TENLOAIPHONG";
          paraName[2] = "DONGIA";
          values[0] = obj.Maloaiphong;
          values[1] = obj.Tenloaiphong;
          values[2] = obj.Dongia;
          return Update("SP_LOAIPHONG_Sua", paraName, values, paraNumber);
      }

      public bool xoa(DTO_LoaiPhong obj)
      {
          int paraNumber = 1;
          string[] paraName = new string[paraNumber];
          object[] values = new object[paraNumber];
          paraName[0] = "MALOAIPHONG";
          values[0] = obj.Maloaiphong;
          return Update("SP_LOAIPHONG_Xoa", paraName, values, paraNumber);
      }
    }
}
