using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RSM_Repository.Models
{
    public class rms_Misc_Countries
    {
        public int Country_ID { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
    }
}