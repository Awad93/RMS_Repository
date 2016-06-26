using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RSM_Repository.Models
{
    public class rms_ScientificTrips
    {
        public int ScientificTrip_ID { get; set; }
        public int TripNumber { get; set; }
        public string ProjectCode { get; set; }
        public int KFUPMID { get; set; }
        public string PersonUndetookTrip { get; set; }
        public string Location { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public Nullable<int> NumberOfDays { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
    }
}