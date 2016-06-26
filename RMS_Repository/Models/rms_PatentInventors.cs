using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RSM_Repository.Models
{
    public class rms_PatentInventors
    {
        public int PatentInventor_ID { get; set; }
        public string PatentNumber { get; set; }
        //public string PatentTitle { get; set; }
        public int KFUPMID { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
    }
}