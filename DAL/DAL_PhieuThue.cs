using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
   public class DAL_PhieuThue:DAL_KetNoi
    {
        DataTable dt = new DataTable();

        public string LayChuoiPT()
        {
            DataTable dt = Table("SP_PHIEUTHUETRA_LayMa", 1);
            string dtt;
            if (dt.Rows.Count > 0)
            {
                dtt = Table("SP_PHIEUTHUETRA_LayMa", 1).Rows[0]["MAPHIEUTHUE"].ToString();
            }
            else
            {
                dtt = "PT";
            }
            return dtt;
        }
        public string TuTangMPT()
        {
            string maPT = LayChuoiPT();
            string maPT1 = maPT.Substring(0, 2);
            string s = "";
            DataTable dt = Table("SP_PHIEUTHUETRA_LayMa", 1);
            if (dt.Rows.Count == 0)
            {
                string t = "PT";
                s = t + "001";
            }
            else
            {
                int k;
                s = maPT1;
                int index = dt.Rows.Count - 1;
                string t = maPT.Substring(2, 3);
                //k = Int32.Parse(dt.Rows[index][0].ToString().Substring(2, 3));
                k = Int32.Parse(t);
                k += 1;
                if (k < 10)
                    s = s + "00";
                else if (k < 100)
                    s = s + "0";
                s = s + k.ToString();
            }
            return s;
        }
        public bool themPhieuThue(DTO_PhieuThue obj)
        {
            int paraNumber = 8;
            string[] paraName = new string[paraNumber];
            object[] values = new object[paraNumber];
            paraName[0] = "MAPHIEUTHUE";
            paraName[1] = "MAPHONG";
            paraName[2] = "MAKHACH";
            paraName[3] = "NGAYTHUE";
            paraName[4] = "NGAYTRA";
            paraName[5] = "SLNGUOI";
            paraName[6] = "NGAYLAP";
            paraName[7] = "MANV";
            values[0] = obj.Maphieuthue;
            values[1] = obj.Maphong;
            values[2] = obj.Makhach;
            values[3] = obj.Ngaythue;
            values[4] = obj.Ngaytra;
            values[5] = obj.Soluongnguoi;
            values[6] = obj.Ngaylap;
            values[7] = obj.Manhanvien;

            return Update("SP_PHIEUTHUETRA_THEM", paraName, values, paraNumber);
        }
    }
}
