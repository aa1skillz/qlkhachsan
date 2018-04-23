using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
   public class DAL_KetNoi
    {
        protected SqlConnection Connect()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["QLKhachSanConnectString"].ConnectionString.ToString());
        }

        protected bool Update(string StoreName, string[] paraName, object[] value, int paraNumber)
        {
            SqlConnection connect = Connect();
            try
            {

                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                SqlCommand command = new SqlCommand(StoreName, connect);
                command.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < paraNumber; i++)
                {
                    command.Parameters.AddWithValue(paraName[i], value[i]);
                }
                command.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                connect.Close();
            }
        }
        public DataTable Table(string storeProc, int types)
        {
            SqlConnection connect = Connect();
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
            }
            SqlCommand command = new SqlCommand(storeProc, connect);
            if (types == 1)
            {
                command.CommandType = CommandType.StoredProcedure;
            }
            SqlDataReader dr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
        public DataTable Table(string storeProc, string[] paraName, object[] valueName, int paraNumber)
        {
            SqlConnection connect = Connect();
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
            }
            SqlCommand command = new SqlCommand(storeProc, connect);
            command.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < paraNumber; i++)
            {
                command.Parameters.AddWithValue(paraName[i], valueName[i]);
            }
            SqlDataReader dr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        }

    }
}
