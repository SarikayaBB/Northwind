using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public static class db
    {
        public  static  SqlConnection Conn()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);
            return conn;

            /*  
            return conn new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString); */ // bu da olabilirdi
        }
    }
}
