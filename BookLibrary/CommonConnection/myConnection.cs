using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.CommonConnection
{
    public static class myConnection
    {
        public static SqlConnection GetConnection()
        {
            string str = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection con = new SqlConnection(str);
            con.Open();
            return con;
        }

        //-- code to make sure to close connection and dispose the object
        public static void Dispose(SqlConnection con)
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
            con.Dispose();
        }
    }
}
