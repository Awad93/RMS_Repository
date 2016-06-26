using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RSM_Repository.Models
{
    public class rms_Patents_Applied
    {
        public int Patent_Applied_ID { get; set; }
        public int AppliedPatentNumber { get; set; }
        public string ReferenceNumber { get; set; }
        public string FilledBy { get; set; }
        public Nullable<System.DateTime> FillingDate { get; set; }
        public string AttorneyDocketNo { get; set; }
        public string PatentApplicationTitle { get; set; }
        public string ApplicationPatentNo { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
    }
}