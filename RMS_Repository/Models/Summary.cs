using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1.Models
{
    public class Summary
    {
        #region Fields
        public Nullable<int> Year { get; set; }
        public int Conferences { get; set; }
        public int Books { get; set; }
        public int ISI_Publications { get; set; }
        public int NonISI_Publications { get; set; }
        public int Graduate_Students { get; set; }
        public int Projects { get; set; }
        public decimal Project_Funds { get; set; }
        public int Patents { get; set; }
        #endregion

        #region Methods
        public DataTable SummaryAll(int start_year, int end_year)
        {
            SqlConnection myConnection = new SqlConnection("server=localhost;" +
                "Trusted_Connection=yes;" +
                "database = RMS_DB;" +
                "connection timeout=30;");

            SqlDataAdapter adapter = new SqlDataAdapter("SummaryAll", myConnection);

            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.Add("@start_year", SqlDbType.Int).Value = start_year;
            adapter.SelectCommand.Parameters.Add("@end_year", SqlDbType.Int).Value = end_year;

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            //helper(dt);

            return dt;
        }
        public List<Summary> SummaryByFaculty(int start_year, int end_year, int id)
        {
            SqlConnection myConnection = new SqlConnection("server=localhost;" +
                "Trusted_Connection=yes;" +
                "database = RMS;" +
                "connection timeout=30;");

            SqlDataAdapter adapter = new SqlDataAdapter("sp_SummaryByFaculty", myConnection);

            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.Add("@start_year", SqlDbType.Int).Value = start_year;
            adapter.SelectCommand.Parameters.Add("@end_year", SqlDbType.Int).Value = end_year;
            adapter.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return helper(dt);
    }
        private static List<Summary> helper(DataTable dt)
        {
            List<Summary> list = dt.AsEnumerable()
                .Select(dr =>
                new Summary
                {
                    Year = Convert.ToInt32(dr.Field<int>("Year")),
                    Conferences = Convert.ToInt32(dr.Field<int>("Conferences")),
                    Books = Convert.ToInt32(dr.Field<int>("Books")),
                    ISI_Publications = Convert.ToInt32(dr.Field<int>("ISI_Publications")),
                    NonISI_Publications = Convert.ToInt32(dr.Field<int>("NonISI_Publications")),
                    Graduate_Students = Convert.ToInt32(dr.Field<int>("Graduate_Students")),
                    Projects = Convert.ToInt32(dr.Field<int>("Projects")),
                    Project_Funds = Convert.ToInt32(dr.Field<int>("Project_Funds")),
                    Patents = Convert.ToInt32(dr.Field<int>("Patents")),
                }
                ).ToList();
            return list;
        }
        #endregion
    }
}