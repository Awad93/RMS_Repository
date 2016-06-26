using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1.Models
{
    public class rms_Departments
    {
        #region rms_Fields
        //public int Department_ID { get; set; }
        //public string DeptCode { get; set; }
        //public string Deptartment { get; set; }
        //public string College { get; set; }
        //public string Colg { get; set; }
        //public Nullable<bool> isDeleted { get; set; }
        //public Nullable<bool> isActive { get; set; }
        //public string CreatedBy { get; set; }
        //public System.DateTime CreatedOn { get; set; }
        #endregion

        #region Fields
            public int DepartmentID { get; set; }
            public string DepartmentName { get; set; }
            public string DepartmentCode { get; set; }
            public string ParentCode { get; set; }
            public Nullable<double> Level { get; set; }
            public string Type { get; set; }
        #endregion
        #region Methods
        public static List<rms_Departments> getAllColleges()
     {
        SqlConnection myConnection = new SqlConnection("server=localhost;" +
            "Trusted_Connection=yes;" +
            "database = RMS;" +
            "connection timeout=30;");

        SqlDataAdapter adapter = new SqlDataAdapter("sp_getAllColleges", myConnection);

        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

        DataTable dt = new DataTable();
        adapter.Fill(dt);
        
        return helper(dt);
    }
        public static List<rms_Departments> getDepartmentsByCollege(string college_code)
        {
            SqlConnection myConnection = new SqlConnection("server=localhost;" +
                "Trusted_Connection=yes;" +
                "database = RMS;" +
                "connection timeout=30;");

            SqlDataAdapter adapter = new SqlDataAdapter("sp_getDepartmentsByCollege", myConnection);
                        
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.Add("@college_code", SqlDbType.Char).Value = college_code;

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return helper(dt);
        }

        //private static List<rms_Departments> helper(DataTable dt)
        //{
        //    var list = dt.AsEnumerable()             
        //        .Select(dr =>
        //        new rms_Departments
        //        {
        //            Department_ID = Convert.ToInt32(dr.Field<int>("Department_ID")),
        //            DeptCode = dr.Field<string>("DeptCode"),
        //            Deptartment = dr.Field<string>("Deptartment"),
        //            College = dr.Field<string>("College"),
        //            Colg = dr.Field<string>("Colg"),
        //            isDeleted = dr.Field<bool>("isDeleted"),
        //            isActive = dr.Field<bool>("isActive"),
        //            CreatedBy = dr.Field<string>("CreatedBy"),
        //            CreatedOn = dr.Field<System.DateTime>("CreatedOn")
        //        }
        //        ).ToList();
        //    return list;
        //}
        private static List<rms_Departments> helper(DataTable dt)
        {
            var list = dt.AsEnumerable()                
                .Select(dr =>
                new rms_Departments
                {
                    DepartmentID = dr.Field<int>("DepartmentID"),
                    DepartmentName = dr.Field<string>("DepartmentName"),
                    DepartmentCode = dr.Field<string>("DepartmentCode"),
                    ParentCode = dr.Field<string>("ParentCode"),
                    Level = dr.Field<Nullable<double>>("Level"),
                    Type = dr.Field<string>("Type")
                    //isDeleted = dr.Field<bool>("isDeleted"),
                    //isActive = dr.Field<bool>("isActive"),
                    //CreatedBy = dr.Field<string>("CreatedBy"),
                    //CreatedOn = dr.Field<System.DateTime>("CreatedOn")
                }
                ).ToList();
            return list;
        }
        #endregion
    }

}