using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
   public class DAL_Khach:DAL_KetNoi
    {
       DataTable dt = new DataTable();

       public bool themKhach(DTO_Khach obj)
       {

           int paraNumber = 7;
           string[] paraName = new string[paraNumber];
           object[] values = new object[paraNumber];
           paraName[0] = "MAKHACH";
           paraName[1] = "TENKHACH";
           paraName[2] = "NGAYSINH";
           paraName[3] = "GIOITINH";
           paraName[4] = "DIACHI";
           paraName[5] = "CMND";
           paraName[6] = "QUOCTICH";
           values[0] = obj.Makhach;
           values[1] = obj.Tenkhach;
           values[2] = obj.Ngaysinh;
           values[3] = obj.Gioitinh;
           values[4] = obj.Diachi;
           values[5] = obj.Cmnd;
           values[6] = obj.Diachi;

           return Update("SP_KHACH_Them", paraName, values, paraNumber);
       }
       public bool suaKhach(DTO_Khach obj)
       {

           int paraNumber = 7;
           string[] paraName = new string[paraNumber];
           object[] values = new object[paraNumber];
           paraName[0] = "MAKHACH";
           paraName[1] = "TENKHACH";
           paraName[2] = "NGAYSINH";
           paraName[3] = "GIOITINH";
           paraName[4] = "DIACHI";
           paraName[5] = "CMND";
           paraName[6] = "QUOCTICH";
           values[0] = obj.Makhach;
           values[1] = obj.Tenkhach;
           values[2] = obj.Ngaysinh;
           values[3] = obj.Gioitinh;
           values[4] = obj.Diachi;
           values[5] = obj.Cmnd;
           values[6] = obj.Diachi;

           return Update("SP_KHACH_Sua", paraName, values, paraNumber);
       }

       public bool xoaKhach(DTO_Khach obj)
       {
           int paraNumber = 1;
           string[] paraName = new string[paraNumber];
           object[] values = new object[paraNumber];
           paraName[0] = "MAKHACH";
           values[0] = obj.Makhach;
           

           return Update("SP_KHACH_Xoa", paraName, values, paraNumber);
       }
       public DataTable getKhach()
       {
           dt = Table("SP_KHACH_Xem",1);
           return dt;
       }
       public string LayChuoiMKHACH()
       {
           DataTable dt = Table("SP_Khach_LayMaKhach", 1);
           string dtt;
           if (dt.Rows.Count >0)
           {
               dtt = Table("SP_Khach_LayMaKhach", 1).Rows[0]["MAKHACH"].ToString();
           }
           else
           {
               dtt = "KH";
           }
           return dtt;
       }

       public string TuTangMKhach()
       {
           string maKhach = LayChuoiMKHACH();
           string maKhach1 = maKhach.Substring(0, 2);
           string s = "";
           DataTable dt = Table("SP_Khach_LayMaKhach", 1);
           if (dt.Rows.Count == 0)
           {
               string t = "KH";
               s = t + "001";
           }
           else
           {
               int k;
               s = maKhach1;
               int index = dt.Rows.Count - 1;
               k = Int32.Parse(maKhach.Substring(2, 3));
               k = k + 1;
               if (k < 10)
                   s = s + "00";
               else if (k < 100)
                   s = s + "0";
               s = s + k.ToString();
           }
           return s;
       }
    }
}
