using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1.Models
{
    public class rms_Researchers
    {
        #region Fields
        public int Researcher_ID { get; set; }
        public int KFUPMID { get; set; }
        public string Status { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string AcademicRank { get; set; }
        public string AdministrativeRank { get; set; }
        public string ActualJob { get; set; }
        public string Email { get; set; }
        public string UserID { get; set; }
        public string WOSResearcherID { get; set; }
        public Nullable<int> JoiningYear { get; set; }
        public Nullable<System.DateTime> JoiningDate { get; set; }
        public Nullable<int> Phone { get; set; }
        public string Nationality { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        #endregion

        #region Methods
        public static List<rms_Researchers> getFacultyByCollege(string college_code)
        {         
            List<string> parameters = new List<string>();
            List<string> values = new List<string>();
            parameters.Add("@college_code");
            values.Add(college_code);
            return helper(Connection.StoredProcedure("sp_getFacultyByCollege", parameters, values));
        }
        public static List<rms_Researchers> getFacultyByDepartment(string dept_code)
        {
            List<string> parameters = new List<string>();
            List<string> values = new List<string>();
            parameters.Add("@dept_code");
            values.Add(dept_code);
            return helper(Connection.StoredProcedure("sp_getFacultyByDepartment", parameters, values));            
        }
        private static List<rms_Researchers> helper(DataTable dt)
        {
            List<rms_Researchers> list = dt.AsEnumerable()
            .Select(dr =>
            new rms_Researchers
            {
                Researcher_ID = Convert.ToInt32(dr.Field<int>("Researcher_ID")),
                KFUPMID = Convert.ToInt32(dr.Field<int>("KFUPMID")),
                Status = dr.Field<string>("Status"),
                FullName = dr.Field<string>("FullName"),
                FirstName = dr.Field<string>("FirstName"),
                MiddleName = dr.Field<string>("MiddleName"),
                LastName = dr.Field<string>("LastName"),
                DepartmentCode = dr.Field<string>("DepartmentCode"),
                //DepartmentName = getDepartmentName(dr.Field<string>("DepartmentCode")),
                AcademicRank = dr.Field<string>("AcademicRank"),
                AdministrativeRank = dr.Field<string>("AdministrativeRank"),
                ActualJob = dr.Field<string>("ActualJob"),
                Email = dr.Field<string>("Email"),
                UserID = dr.Field<string>("UserID"),
                WOSResearcherID = dr.Field<string>("WOSResearcherID"),
                JoiningYear = dr.Field<Nullable<int>>("JoiningYear"),
                JoiningDate = dr.Field<Nullable<System.DateTime>>("JoiningDate"),
                Phone = dr.Field<Nullable<int>>("Phone"),
                Nationality = dr.Field<string>("Nationality"),
                isDeleted = dr.Field< Nullable<bool>>("isDeleted"),
                isActive = dr.Field<Nullable<bool>>("isActive"),
                CreatedBy = dr.Field<string>("CreatedBy"),
                CreatedOn = dr.Field<System.DateTime>("CreatedOn")
            }
            ).ToList();
        return list;
        }

        private static string getDepartmentName(string dept_code)
        {
            string query = "SELECT DepartmentName FROM Departments WHERE DepartmentCode = \"" + dept_code + "\"";
            DataTable dt = Connection.Query(query);
            return dt.Rows[0][0].ToString();
        }
        #endregion
    }
}