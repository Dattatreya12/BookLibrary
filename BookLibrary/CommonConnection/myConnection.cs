using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.CommonConnection
{
    public static class myConnection
    {
        // private IConfiguration _configuration;
        public static SqlConnection GetConnection()
        {
            //string connectionString = _configuration["ConnectionStrings:Default"];
            string connectionString = "Server=DATTA;Database=BookApp;Trusted_Connection=True;MultipleActiveResultSets=true";
            SqlConnection con = new SqlConnection(connectionString);
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
