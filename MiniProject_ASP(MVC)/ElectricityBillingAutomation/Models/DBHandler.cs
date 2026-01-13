using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ElectricityBillingAutomation.Models
{
    public class DBHandler
    {
        public SqlConnection GetConnection()

        {
            string connStr = ConfigurationManager.ConnectionStrings["EBConnection"].ConnectionString; 
            SqlConnection con = new SqlConnection(connStr); 
            con.Open(); // ✅ This is what ensures the connection is open
            return con;
        } 
    }
}