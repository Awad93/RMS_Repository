using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RSM_Repository.Models
{
    public class rms_Variations_Names
    {
        public int Variation_Name_ID { get; set; }
        public int KFUPMID { get; set; }
        public string Name { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
    }
}