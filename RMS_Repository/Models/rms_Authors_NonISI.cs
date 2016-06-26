using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class rms_Authors_NonISI
    {
        public int Authors_NonISI_ID { get; set; }
        public int KFUPMID { get; set; }
        public string DOI { get; set; }
        //public string PublicationTitle { get; set; }
        public Nullable<bool> CorrespondingAuthor { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
    }
}