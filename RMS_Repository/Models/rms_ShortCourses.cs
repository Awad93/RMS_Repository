using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RSM_Repository.Models
{
    public class rms_ShortCourses
    {
        public int ShortCourse_ID { get; set; }
        public int KFUPMID { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> Coordination { get; set; }
        public Nullable<int> SectionPresidency { get; set; }
        public Nullable<int> CompensationTime { get; set; }
        public Nullable<int> AverageCompensationTime { get; set; }
        public Nullable<int> TeachingHours { get; set; }
        public Nullable<int> Incentives { get; set; }
        public Nullable<int> Due { get; set; }
        public Nullable<int> Total { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
    }
}