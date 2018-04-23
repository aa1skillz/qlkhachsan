using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAL
{
 public   class DAL_TimKiemKhach:DAL_KetNoi
    {
     public DataTable MaKhach()
     {
         return Table("SP_KHACH_TTMAKHACH",1);
     }
        public DataTable TTKtheoMa(String ma)
        {
            int paraNumber = 1;
            string[] paraName = new string[paraNumber];
            object[] values = new object[paraNumber];
            paraName[0] = "MAKHACH";
            values[0] = ma;
            return Table("SP_KHACH_MAKHACH", paraName, values, paraNumber);
        }
      
        public DataTable TTKtheoTen(String ten)
        {
            int paraNumber = 1;
            string[] paraName = new string[paraNumber];
            object[] values = new object[paraNumber];
            paraName[0] = "TENKHACH";
            values[0] = ten;
            return Table("SP_KHACH_TEN", paraName, values, paraNumber);
        }
    }
}
