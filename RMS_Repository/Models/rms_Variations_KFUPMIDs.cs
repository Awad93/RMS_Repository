using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RSM_Repository.Models
{
    public class rms_Variations_KFUPMIDs
    {
        public int Variation_KFUPMID_ID { get; set; }
        public int CurrentKFUPMID { get; set; }
        public int OtherKFUPMID { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
    }
}