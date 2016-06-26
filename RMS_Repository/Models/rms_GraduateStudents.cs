using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RSM_Repository.Models
{
    public class rms_GraduateStudents
    {
        public int GraduateStudentID { get; set; }
        public int StudentID { get; set; }
        public Nullable<int> AdvisorID { get; set; }
        public string StudentName { get; set; }
        public string StudentDept { get; set; }
        public string Nationality { get; set; }
        public string Degree { get; set; }
        public string Major { get; set; }
        public string Level { get; set; }
        public string Classification { get; set; }
        public string Full_Part_Type { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public Nullable<int> Year { get; set; }
        public string ThesisTitle { get; set; }
        public string ThesisStatus { get; set; }
        public Nullable<int> LevelGPA { get; set; }
        public Nullable<int> NumberOfActiveTerms { get; set; }
        public Nullable<int> GraduationTerm { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
    }
}