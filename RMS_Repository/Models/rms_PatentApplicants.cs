using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RSM_Repository.Models
{
    public class rms_PatentApplicants
    {
        public int PatentApplicant_ID { get; set; }
        public int AppliedPatentNumber { get; set; }
        //public string PatentApplicationTitle { get; set; }
        public int KFUPMID { get; set; }
        public string Role { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
    }
}