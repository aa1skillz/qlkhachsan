using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using DTO;

namespace DAL
{
   public class DAL_DangNhap : DAL_KetNoi
    {
        DataTable dt = new DataTable();
       public DataTable getCV(DTO_DangNhap obj)
        {

                int paraNumber = 1;
                string[] paraName = new string[paraNumber];
                object[] values = new object[paraNumber];
                paraName[0] = "USER";
                values[0] = obj.User;
                dt = Table("SP_NhanVien_ThongTin_ChucVu ", paraName, values, paraNumber);
                return dt;
        }

       public bool doiMK(string user,string pass)
       {
           int paraNumber = 2;
           string[] paraName = new string[paraNumber];
           object[] values = new object[paraNumber];
           paraName[0] = "USER";
           values[0] = user;
           paraName[1] = "PASSWORD";
           values[1] = pass;
           return Update("SP_TaiKhoan_DoiMK", paraName, values, paraNumber);
       }
       public DataTable getPass(string user)
       {
           int paraNumber = 1;
           string[] paraName = new string[paraNumber];
           object[] values = new object[paraNumber];
           paraName[0] = "USER";
           values[0] = user;
           dt = Table("SP_TaiKhoan_MK", paraName, values, paraNumber);
           return dt;
       }
       public bool checkTK(string tk)
       {
           try
           {
               int paraNumber = 1;
               string[] paraName = new string[paraNumber];
               object[] values = new object[paraNumber];
               paraName[0] = "USER";
               values[0] = tk;
               dt = Table("SP_DangNhap_TaiKhoan", paraName, values, paraNumber);
               if (dt.Rows.Count > 0)
               {
                   return true;
               }
               return false;
           }
           catch (Exception)
           {
               return false;
           }
       }
       public DataTable getName(string user)
       {
           int paraNumber = 1;
           string[] paraName = new string[paraNumber];
           object[] values = new object[paraNumber];
           paraName[0] = "USER";
           values[0] = user;
           dt = Table("SP_TaiKhoan_Ten", paraName, values, paraNumber);
           return dt;
       }
        public bool iCheckTaiKhoan(DTO_DangNhap obj)
        {
            try
            {
                int paraNumber = 2;
                string[] paraName = new string[paraNumber];
                object[] values = new object[paraNumber];
                paraName[0] = "USER";
                paraName[1] = "PASSWORD";
                values[0] = obj.User;
                values[1] = obj.Password;
                dt = Table("SP_DangNhap", paraName, values, paraNumber);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
    }
}
