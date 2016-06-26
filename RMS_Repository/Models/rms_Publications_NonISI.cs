using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1.Models
{
    public class rms_Publications_NonISI
    {
        #region Fields
        public int Publications_NonISI_ID { get; set; }
        public string DOI { get; set; }
        public string Authors { get; set; }
        public string PaperTitle { get; set; }
        public string Source { get; set; }
        public Nullable<int> PublicationYear { get; set; }
        public bool Approved { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        #endregion

        #region Methods
        public static List<rms_Publications_NonISI> getNonISIPublicationsByFaculty(int id)
        {
            SqlConnection myConnection = new SqlConnection("server=localhost;" +
                "Trusted_Connection=yes;" +
                "database = RMS;" +
                "connection timeout=30;");
                       
            SqlDataAdapter adapter = new SqlDataAdapter("getNonISIPublicationsByFaculty", myConnection);

            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;

            DataTable dt = new DataTable();
            adapter.Fill(dt);
                        
            return helper(dt);
        }
        public static List<rms_Publications_NonISI> getNonISIPublicationsByCollege(string college_code)
        {
            SqlConnection myConnection = new SqlConnection("server=localhost;" +
                "Trusted_Connection=yes;" +
                "database = RMS;" +
                "connection timeout=30;");

            SqlDataAdapter adapter = new SqlDataAdapter("sp_getNonISIPublicationsByCollege", myConnection);

            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.Add("@college_code", SqlDbType.Char).Value = college_code;

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return helper(dt);
        }
        private static List<rms_Publications_NonISI> helper(DataTable dt)
        {
            var list = dt.AsEnumerable()
                .Select(dr =>
                new rms_Publications_NonISI
                {
                    Publications_NonISI_ID = Convert.ToInt32(dr.Field<int>("Publications_NonISI_ID")),
                    DOI = dr.Field<string>("DOI"),
                    Authors = dr.Field<string>("Authors"),
                    PaperTitle = dr.Field<string>("PaperTitle"),
                    Source = dr.Field<string>("Source"),        
                    PublicationYear = Convert.ToInt32(dr.Field<int>("PublicationYear")),
                    Approved = dr.Field<bool>("Approved"),
                    isDeleted = dr.Field<bool>("isDeleted"),
                    isActive = dr.Field<bool>("isActive"),
                    CreatedBy = dr.Field<string>("CreatedBy"),
                    CreatedOn = dr.Field<System.DateTime>("CreatedOn")
                }
                ).ToList();
            return list;
        }
        #endregion
    }
}