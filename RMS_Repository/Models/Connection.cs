using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1.Models
{
    public class Connection
    {
        public static DataTable StoredProcedure(string sp_name, List<string> parameters, List<string> values)
        {
            SqlConnection connection = Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(sp_name, connection);

            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            for(int i = 0; i < parameters.Count; i++)
            {
                adapter.SelectCommand.Parameters.Add(parameters[i], SqlDbType.Char).Value = values[i];
            }

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static DataTable Query(string query)
        {            
            using(SqlConnection connection = Connect())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
           

        }
        public static SqlConnection Connect()
        {
            return Connect("localhost", "RMS");
        }
        public static SqlConnection Connect(string server_name, string db_name)
        {
            SqlConnection connection = new SqlConnection("server = " + server_name + ";" +
                "Trusted_Connection=yes;" +
                "database = " + db_name + ";" +
                "connection timeout=30;");
            return connection;
        }
    }
}