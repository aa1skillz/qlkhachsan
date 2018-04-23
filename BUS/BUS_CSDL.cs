using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_CSDL
    {
        private DAL_CSDL csdl = new DAL_CSDL();
        public bool KiemTraChuoiKetNoi(string connectString)
        {
            return csdl.KiemTraChuoiKetNoi(connectString);
        }
        public DataTable LayCSDL()
        {
            return csdl.LayCSDL();
        }
    }
}
