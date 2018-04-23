using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAL
{
  public  class DAL_Phong:DAL_KetNoi
    {
      DataTable dt = new DataTable();
        public DataTable GetPhong()
        {
            return Table("SP_Phong_ThongTin", 1);
        }

      public bool CapNhatPhong(DTO_Phong obj)
        {
            int paraNumber = 2;
            string[] paraName = new string[paraNumber];
            object[] values = new object[paraNumber];
            paraName[0] = "MAPHONG";
            paraName[1] = "TINHTRANG";
            values[0] = obj.Maphong;
            values[1] = obj.Tinhtrang;
            return Update("SP_Phong_CapNhatTinhTrang", paraName, values, paraNumber);
        }
      public DataTable getTinhTrang(string maphong)
        {

            int paraNumber = 1;
            string[] paraName = new string[paraNumber];
            object[] values = new object[paraNumber];
            paraName[0] = "MAPHONG";
            values[0] = maphong;
            dt= Table("SP_Phong_TinhTrang", paraName, values, paraNumber);
            return dt;
        }
      public DataTable getTenphong()
        {
            return Table("SP_Phong_ThongTin_MA_TEN", 1);
        }

      public string LayChuoiMPhong()
      {
          return Table("SP_Phong_LayChuoiMaPhong", 1).Rows[0]["MAPHONG"].ToString();
      }

      public string TuTangMPhong()
      {
          string maP = LayChuoiMPhong();
          string maP1 = maP.Substring(0, 2);
          string s = "";
          DataTable dt = Table("SP_Phong_LayChuoiMaPhong", 1);
          if (dt.Rows.Count < 0)
          {
              string t = "PH";
              s = t + "001";
          }
          else
          {
              int k;
              s = maP1;
              int index = dt.Rows.Count - 1;
              k = Int32.Parse(dt.Rows[index][0].ToString().Substring(2, 3));
              k = k + 1;
              if (k < 10)
                  s = s + "00";
              else if (k < 100)
                  s = s + "0";
              s = s + k.ToString();
          }
          return s;
      }

      public bool themPhong(DTO_Phong obj)
      {

          int paraNumber = 4;
          string[] paraName = new string[paraNumber];
          object[] values = new object[paraNumber];
          paraName[0] = "MAPHONG";
          paraName[1] = "MALOAIPHONG";
          paraName[2] = "TINHTRANG";
          paraName[3] = "SDT";
          values[0] = obj.Maphong;
          values[1] = obj.Maloaiphong;
          values[2] = obj.Tinhtrang;
          values[3] = obj.Sodienthoai;
          return Update("SP_Phong_Them", paraName, values, paraNumber);
      }
      public bool xoaPhong(DTO_Phong obj)
      {

          int paraNumber =1;
          string[] paraName = new string[paraNumber];
          object[] values = new object[paraNumber];
          paraName[0] = "MAPHONG";
          values[0] = obj.Maphong;
          return Update("SP_Phong_Xoa", paraName, values, paraNumber);
      }
      public bool suaPhong(DTO_Phong obj)
      {

          int paraNumber = 4;
          string[] paraName = new string[paraNumber];
          object[] values = new object[paraNumber];
          paraName[0] = "MAPHONG";
          paraName[1] = "MALOAIPHONG";
          paraName[2] = "TINHTRANG";
          paraName[3] = "SDT";
          values[0] = obj.Maphong;
          values[1] = obj.Maloaiphong;
          values[2] = obj.Tinhtrang;
          values[3] = obj.Sodienthoai;
          return Update("SP_Phong_Sua", paraName, values, paraNumber);
      }
    }
}
