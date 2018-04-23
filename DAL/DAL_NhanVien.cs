using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
   public class DAL_NhanVien :DAL_KetNoi
    {
       DataTable dt = new DataTable();
       public DataTable Display()
       {
           return Table("SP_NhanVien_ThongTin",1);
       }
      
       public string LayChuoiMNV()
       {
           DataTable dt = Table("SP_NhanVien_LayChuoiMNV", 1);
           string dtt;
           if (dt.Rows.Count > 0)
           {
            dtt  = Table("SP_NhanVien_LayChuoiMNV", 1).Rows[0]["MANV"].ToString();
           }
           else
           {
               dtt = "NV";
           }
           return dtt;
       }

       public string TuTangMNV()
       {
           string maNV = LayChuoiMNV();
           string maNV1 = maNV.Substring(0, 2);
           string s = "";
           DataTable dt = Table("SP_NhanVien_LayChuoiMNV", 1);
           if(dt.Rows.Count==0)
           {
               string t = "NV";
               s = t + "001";
           }
           else
           {
                       int k;
                     s = maNV1;
               int index = dt.Rows.Count-1;
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
        public bool ThemNhanVien(DTO_NhanVien obj1,DTO_DangNhap obj2)
        {
                int paraNumber = 9;
                string[] paraName = new string[paraNumber];
                object[] values = new object[paraNumber];
                paraName[0] = "MANV";
                paraName[1] = "TENNV";
                paraName[2]= "NGAYSINH";
                paraName[3]="GIOITINH";
                paraName[4]="DIACHI";
                paraName[5]="SDT";
                paraName[6]="CHUCVU";
                paraName[7]="USER";
                paraName[8]="PASSWORD";
                values[0] = obj1.Manhanvien;
                values[1] = obj1.Tennhanvien;
                values[2] = obj1.Ngaysinh;
                values[3] = obj1.Gioitinh;
                values[4] = obj1.Diachi;
                values[5] = obj1.Sodienthoai;
                values[6] = obj1.Chucvu;
                values[7] = obj2.User;
                values[8] = obj2.Password;
                return Update("SP_NhanVien_Them", paraName, values, paraNumber);
        }

        public bool CapNhatNhanVien(DTO_NhanVien obj)
        {
            int paraNumber = 7;
            string[] paraName = new string[paraNumber];
            object[] values = new object[paraNumber];
            paraName[0] = "MANV";
            paraName[1] = "TENNV";
            paraName[2] = "NGAYSINH";
            paraName[3] = "GIOITINH";
            paraName[4] = "DIACHI";
            paraName[5] = "SDT";
            paraName[6] = "CHUCVU";
            values[0] = obj.Manhanvien;
            values[1] = obj.Tennhanvien;
            values[2] = obj.Ngaysinh;
            values[3] = obj.Gioitinh;
            values[4] = obj.Diachi;
            values[5] = obj.Sodienthoai;
            values[6] = obj.Chucvu;
            return Update("SP_NhanVien_Sua", paraName, values, paraNumber);
        }

        public bool XoaNhanVien(DTO_NhanVien obj)
        {
            int paraNumber = 1;
            string[] paraName = new string[paraNumber];
            object[] values = new object[paraNumber];
            paraName[0] = "MANV";
            values[0] = obj.Manhanvien;
            return Update("SP_NhanVien_Xoa", paraName, values, paraNumber);
        }
       public DataTable getMaNV(string tennhanvien)
        {
            int paraNumber = 1;
            string[] paraName = new string[paraNumber];
            object[] values = new object[paraNumber];
            paraName[0] = "TENNV";
            values[0] =  tennhanvien;
            return Table("SP_NhanVien_TimKiemMaTheoTen", paraName, values, paraNumber);
        }
        public bool iCheckTonTai(DTO_NhanVien obj)
        {
            try
            {
                int paraNumber = 1;
                string[] paraName = new string[paraNumber];
                object[] values = new object[paraNumber];
                paraName[0] = "MANV";
                values[0] = obj.Manhanvien;
                dt = Table("SP_NhanVien_TimKiemMa", paraName, values, paraNumber);
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
