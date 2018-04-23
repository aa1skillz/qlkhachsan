using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BUS
{
   public class BUS_DangNhap
    {
        private DAL_DangNhap DangNhap = new DAL_DangNhap();
        public DataTable getCV(DTO_DangNhap obj)
        {
            return DangNhap.getCV(obj);
        }
        public bool iCheckTaiKhoan(DTO_DangNhap obj)
        {
            return DangNhap.iCheckTaiKhoan(obj);
        }
       public bool ichecktk(string tk)
        {
            return DangNhap.checkTK(tk);
        }

       public DataTable getPass(string user)
       {
           return DangNhap.getPass(user);
       }
       public bool doiMK(string user,string pass)
       {
           return DangNhap.doiMK(user, pass);
       }
       public DataTable getName(string user)
       {
           return DangNhap.getName(user);
       }
    }
}
