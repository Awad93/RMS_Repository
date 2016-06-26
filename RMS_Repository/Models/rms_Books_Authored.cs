using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1.Models
{
    public class rms_Books_Authored
    {
        #region Fields
        public int Book_Authored_ID { get; set; }
        public string BookTitle { get; set; }
        public string Authors { get; set; }
        public Nullable<int> PublicationYear { get; set; }
        public string Publisher { get; set; }
        public string Country { get; set; }
        public string ProjectNo { get; set; }
        //public string ProjectCode { get; set}
        public Nullable<int> FundingYear { get; set; }
        public string Language { get; set; }
        public bool Completed { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        #endregion

        #region Methods
        public static List<rms_Books_Authored> getAllBooks()
        {
            SqlConnection myConnection = new SqlConnection("server=DELLDSR;" +
                "Trusted_Connection=yes;" +
                "database = RMS;" +
                "connection timeout=30;");

            SqlDataAdapter adapter = new SqlDataAdapter("sp_getAllBooks", myConnection);

            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return helper(dt);
        }
        public static List<rms_Books_Authored> getBooksByFaculty(int id)
        {
            SqlConnection myConnection = new SqlConnection("server=localhost;" +
                "Trusted_Connection=yes;" +
                "database = RMS;" +
                "connection timeout=30;");

            SqlDataAdapter adapter = new SqlDataAdapter("getBooksByFaculty", myConnection);

            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return helper(dt);
        }
        public static List<rms_Books_Authored> getBooksByCollege(string college_code)
        {
            List<string> parameters = new List<string>();
            List<string> values = new List<string>();
            parameters.Add("@college_code");
            values.Add(college_code);
            return helper(Connection.StoredProcedure("sp_getBooksByCollege", parameters, values));
        }
        private static List<rms_Books_Authored> helper(DataTable dt)
        {
            List<rms_Books_Authored> list = dt.AsEnumerable()

                .Select(dr =>
                new rms_Books_Authored
                {
                    Book_Authored_ID = dr.Field<int>("Book_Authored_ID"),             
                    BookTitle = dr.Field<string>("BookTitle"),
                    Authors = dr.Field<string>("Authors"),
                    PublicationYear = dr.Field<Nullable<int>>("PublicationYear"),
                    Publisher = dr.Field<string>("Publisher"),
                    Country = dr.Field<string>("Country"),
                    ProjectNo = dr.Field<string>("ProjectNo"),
                    FundingYear = dr.Field<Nullable<int>>("FundingYear"),
                    Language = dr.Field<string>("Language"),
                    Completed = dr.Field<bool>("Completed"),
                    isDeleted = dr.Field<Nullable<bool>>("isDeleted"),
                    isActive = dr.Field<Nullable<bool>>("isActive"),
                    CreatedBy = dr.Field<string>("CreatedBy"),
                    CreatedOn = dr.Field<System.DateTime>("CreatedOn")
                }
                ).ToList();
            return list;
        }
        #endregion
    }
}