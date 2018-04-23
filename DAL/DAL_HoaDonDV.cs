using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
   public class DAL_HoaDonDV:DAL_KetNoi
    {
       DataTable dt = new DataTable();
       public DataTable getDVSD(string maphong)
       {
           int paraNumber = 1;
           string[] paraName = new string[paraNumber];
           object[] values = new object[paraNumber];
           paraName[0] = "MAPHONG";
           values[0] =maphong;
           dt =  Table("SP_PHIEUDV_TheoPL", paraName, values, paraNumber);
           return dt;
       }
       public DataTable XEM(string maphong)
       {
           int paraNumber = 1;
           string[] paraName = new string[paraNumber];
           object[] values = new object[paraNumber];
           paraName[0] = "MAPHONG";
           values[0] = maphong;
           dt = Table("SP_HOADONDV_XEM_CHUATT", paraName, values, paraNumber);
           return dt;
       }
       public string makhachtheomaphong(string maphong)
       {
           int paraNumber = 1;
           string[] paraName = new string[paraNumber];
           object[] values = new object[paraNumber];
           paraName[0] = "MAPHONG";
           values[0] = maphong;
           return Table("SP_KHACH_MA_PHONG_1", paraName, values, paraNumber ).Rows[0]["MAKHACH"].ToString();
       }

       public string maphieuthuetheomakhach(string makhach)
       {
           int paraNumber = 1;
           string[] paraName = new string[paraNumber];
           object[] values = new object[paraNumber];
           paraName[0] = "MAKHACH";
           values[0] = makhach;
           return Table("SP_KHACH_MA_TT", paraName, values, paraNumber).Rows[0]["MAPHIEUTHUE"].ToString();
       }
       public bool them(DTO_HoaDonDV obj)
       {
           int paraNumber = 5;
           string[] paraName = new string[paraNumber];
           object[] values = new object[paraNumber];
           paraName[0] = "MADV";
           paraName[1] = "MAPHIEUTHUE";
           paraName[2] = "SLDV";
           paraName[3] = "NGAYTHUE";
           paraName[4] = "TRANGTHAI";
           values[0] = obj.Madichvu;
           values[1] = obj.Maphieuthue;
           values[2] = obj.Soluongdv;
           values[3] = obj.Ngaysudung;
           values[4] = obj.Tinhtrang;
           return Update("SP_HOADONDV_Them", paraName, values, paraNumber);
       }
       public bool capnhat(string maphong,string trangthai)
       {
           int paraNumber = 2;
           string[] paraName = new string[paraNumber];
           object[] values = new object[paraNumber];
           paraName[0] = "MAPHONG";
           paraName[1] = "TRANGTHAI";
         
           values[0] = maphong;
           values[1] = trangthai;

           return Update("SP_HOADONDV_CNTT", paraName, values, paraNumber);
       }
            
       public DataTable xemHoaDonTheoMaPT(string mahd)
       {
           int paraNumber = 1;
           string[] paraName = new string[paraNumber];
           object[] values = new object[paraNumber];
           paraName[0] = "MAPHIEUTHUE";
           values[0] = mahd;
           return Table("HOADON_XEM_THEOMA", paraName, values, paraNumber);
           
       }
          public DataTable getTenDV()
       {
           return Table("SP_PHIEUDV_LOAIDV", 1);
       }
       
    }
}
