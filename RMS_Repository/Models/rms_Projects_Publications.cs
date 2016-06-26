using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RSM_Repository.Models
{
    public class rms_Projects_Publications
    {
        public int Project_Publication_ID { get; set; }
        public string WOS { get; set; }
        //public string PublicationTitle { get; set; }
        public string ProjectNo { get; set; }
        //public string ProjectCode { get; set; }
        public string FundType { get; set; }
        public string ProjectType { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
    }
}