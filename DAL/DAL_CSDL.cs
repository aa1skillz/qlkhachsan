using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DAL
{
   public class DAL_CSDL:DAL_KetNoi
    {
        DataTable dt = new DataTable();
        public DataTable GetServerName()
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;//lay thong tin ten may 
            dt = instance.GetDataSources();
            return dt;
        }
        public bool KiemTraChuoiKetNoi(string connectString)
        {

            SqlConnection con = new SqlConnection(connectString);
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
        public DataTable LayCSDL()
        {
            SqlConnection con = Connect();
            SqlCommand cmd = new SqlCommand("SP_DATABASES", con);
            SqlDataReader reader;
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                reader = cmd.ExecuteReader();
                dt.Load(reader);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                con.Close();
                con.Dispose();
                cmd.Dispose();
            }
        }
    }
}
