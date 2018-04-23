using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
 public   class DAL_TimKiemPhong:DAL_KetNoi
    {
        public DataTable getMaPhong()
        {
            return Table("SP_PHONG_MAPHONG", 1);
        }

        public DataTable getLoaiPhong()
        {
            return Table("SP_PHONG_LOAIPHONG", 1);
        }

        public DataTable TTPtheoMa(String ma)
        {
            int paraNumber = 1;
            string[] paraName = new string[paraNumber];
            object[] values = new object[paraNumber];
            paraName[0] = "MAPHONG";
            values[0] = ma;
            return Table("SP_PHONG_MAPHONG_TTMA", paraName, values, paraNumber);
        }

        public DataTable TTPtheoLoai(String ten)
        {
            int paraNumber = 1;
            string[] paraName = new string[paraNumber];
            object[] values = new object[paraNumber];
            paraName[0] = "LOAIPHONG";
            values[0] = ten;
            return Table("SP_PHONG_MAPHONG_TTLOAI", paraName, values, paraNumber);
        }
    }
}
