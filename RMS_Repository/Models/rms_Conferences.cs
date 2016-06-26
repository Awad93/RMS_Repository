using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RSM_Repository.Models
{
    public class rms_Conferences
    {
        public int Conference_ID { get; set; }
        public int KFUPMID { get; set; }
        public int Year { get; set; }
        public string ConfName { get; set; }
        public string ConfLocation { get; set; }
        public Nullable<System.DateTime> StDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> PaperPresentation { get; set; }
        public string PaperTitle { get; set; }
        public string Authors { get; set; }
        public string Affiliation { get; set; }
        public string ProjectNo { get; set; }
        //public string ProjectCode { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
    }
}