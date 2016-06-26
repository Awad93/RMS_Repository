using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1.Models
{
    public class rms_Publications_ISI
    {
        #region Fields
        public int Publication_ISI_ID { get; set; }
        public string ISICategory { get; set; }
        public string WOSNum { get; set; }
        public string Authors { get; set; }
        public string PaperTitle { get; set; }
        public string Source { get; set; }
        public string Language { get; set; }
        public string Abstract { get; set; }
        public string DocumentType { get; set; }
        public string ConferenceTitle { get; set; }
        public string ConferenceDates { get; set; }
        public string ConferenceLocation { get; set; }
        public string Keywords { get; set; }
        public string AuthorAddress { get; set; }
        public string ReprintAddress { get; set; }
        public string FundingAgnecy { get; set; }
        public string FundingText { get; set; }
        public Nullable<int> TimeCited { get; set; }
        public string Publisher { get; set; }
        public string ISSN { get; set; }
        public Nullable<System.DateTime> PublicationDate { get; set; }
        public string PublicationMonth { get; set; }
        public Nullable<double> PublicationYear { get; set; }
        public Nullable<double> Volume { get; set; }
        public Nullable<double> Issue { get; set; }
        public string WideCategory { get; set; }
        public string SubjectCategory { get; set; }
        public Nullable<int> ImpactFactorLastYear { get; set; }
        public Nullable<int> ImpactFactorPublicationYear { get; set; }
        public string QClass { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        #endregion

        #region Methods
        public static List<rms_Publications_ISI> getISIPublicationsByFaculty(int id)
        {
            SqlConnection myConnection = new SqlConnection("server=localhost;" +
                "Trusted_Connection=yes;" +
                "database = RMS;" +
                "connection timeout=30;");                  

            SqlDataAdapter adapter = new SqlDataAdapter("getISIPublicationsByFaculty",myConnection);
           
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;

            DataTable dt = new DataTable();
            adapter.Fill(dt);
          
            return helper(dt);
        }
        public static List<rms_Publications_ISI> getISIPublicationsByCollege(string college_code)
        {
            SqlConnection myConnection = new SqlConnection("server=localhost;" +
                "Trusted_Connection=yes;" +
                "database = RMS;" +
                "connection timeout=30;");          

            SqlDataAdapter adapter = new SqlDataAdapter("sp_getISIPublicationsByCollege", myConnection);

            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.Add("@college_code", SqlDbType.Char).Value = college_code;

            DataTable dt = new DataTable();
            adapter.Fill(dt);
           
            return helper(dt);
        }
        private static List<rms_Publications_ISI> helper(DataTable dt)
        {
            var list = dt.AsEnumerable()
                .Select(dr =>
                new rms_Publications_ISI
                {
                    Publication_ISI_ID = Convert.ToInt32(dr.Field<int>("Publication_ISI_ID")),
                    ISICategory = dr.Field<string>("ISICategory"),
                    WOSNum = dr.Field<string>("WOSNum"),
                    Authors = dr.Field<string>("Authors"),
                    PaperTitle = dr.Field<string>("PaperTitle"),
                    Source = dr.Field<string>("Source"),
                    Language = dr.Field<string>("Language"),
                    Abstract = dr.Field<string>("Abstract"),
                    DocumentType = dr.Field<string>("DocumentType"),
                    ConferenceTitle = dr.Field<string>("ConferenceTitle"),
                    ConferenceDates = dr.Field<string>("ConferenceDates"),
                    ConferenceLocation = dr.Field<string>("ConferenceLocation"),
                    Keywords = dr.Field<string>("Keywords"),
                    AuthorAddress = dr.Field<string>("AuthorAddress"),
                    ReprintAddress = dr.Field<string>("ReprintAddress"),
                    FundingAgnecy = dr.Field<string>("FundingAgency"),
                    FundingText = dr.Field<string>("FundingText"),
                    TimeCited = Convert.ToInt32(dr.Field<int>("TimeCited")),
                    Publisher = dr.Field<string>("Publisher"),
                    ISSN = dr.Field<string>("ISSN"),
                    PublicationDate = dr.Field<System.DateTime>("PublicationDate"),
                    PublicationMonth = dr.Field<string>("PublicationMonth"),
                    PublicationYear = Convert.ToInt32(dr.Field<int>("PublicationYear")),
                    Volume = dr.Field<double>("Volume"),
                    Issue = dr.Field<double>("Issue"),
                    WideCategory = dr.Field<string>("WideCategory"),
                    SubjectCategory = dr.Field<string>("SubjectCategory"),
                    ImpactFactorLastYear = Convert.ToInt32(dr.Field<int>("ImpactFactorLastYear")),
                    ImpactFactorPublicationYear = Convert.ToInt32(dr.Field<int>("ImpactFactorPublicationYear")),
                    QClass = dr.Field<string>("QClass"),
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
