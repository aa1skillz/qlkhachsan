using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
   public class DAL_DichVu:DAL_KetNoi
    {
       public DataTable  getThongTinDV()
       {
           return Table("SP_DichVu_ThongTin", 1);
       }

       public DataTable getMDV(string TDV)
       {
           int paraNumber = 1;
           string[] paraName = new string[paraNumber];
           object[] values = new object[paraNumber];
           paraName[0] = "TENDV";
           values[0] = TDV;
           return Table("SP_DichVu_MaDV_TheoTDV", paraName, values, paraNumber);
       }

       public bool  themDV(DTO_DichVu obj)
       {
           int paraNumber = 3;
           string[] paraName = new string[paraNumber];
           object[] values = new object[paraNumber];
           paraName[1] = "TENDV";
           values[1] = obj.Tendichvu;
           paraName[0] = "MADV";
           values[0] = obj.Madichvu;
           paraName[2] = "DONGIA";
           values[2] = obj.Dongia;
           return Update("SP_DICHVU_Them", paraName, values, paraNumber);
       }

       public bool capnhatDV(DTO_DichVu obj)
       {
           int paraNumber = 3;
           string[] paraName = new string[paraNumber];
           object[] values = new object[paraNumber];
           paraName[1] = "TENDV";
           values[1] = obj.Tendichvu;
           paraName[0] = "MADV";
           values[0] = obj.Madichvu;
           paraName[2] = "DONGIA";
           values[2] = obj.Dongia;
           return Update("SP_DICHVU_SUA", paraName, values, paraNumber);
       }

       public bool xoaDV(DTO_DichVu obj)
       {
           int paraNumber = 1;
           string[] paraName = new string[paraNumber];
           object[] values = new object[paraNumber];
           paraName[0] = "MADV";
           values[0] = obj.Madichvu;
           return Update("SP_DICHVU_XOA", paraName, values, paraNumber);
       }

       public bool ktTM(string ma)
       {
           int paraNumber = 1;
           string[] paraName = new string[paraNumber];
           object[] values = new object[paraNumber];
           paraName[0] = "MADV";
           values[0] = ma;
           DataTable dt= Table("SP_DICHVU_KTTM", paraName, values, paraNumber);
           if(dt.Rows.Count>0)
           {
               return true;
           }
           return false;
       }
    }
}
