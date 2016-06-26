using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RSM_Repository.Models
{
    public class rms_Projects_ManPower_Details
    {
        public int Project_ManPower_Detail_ID { get; set; }
        public int KFUPMID { get; set; }
        public int ProjectNo { get; set; }
        //public string ProjectCode { get; set; }
        public Nullable<decimal> ReceivedAmount { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<int> ListItemID { get; set; }
        public string Method { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
    }
}