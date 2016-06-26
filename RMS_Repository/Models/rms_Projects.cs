using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RSM_Repository.Models
{
    public class rms_Projects
    {
        public int ProjectID { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectType { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> Duration { get; set; }
        public Nullable<System.DateTime> ExtendedDate { get; set; }
        public Nullable<int> Year { get; set; }
        public string AcademicYear { get; set; }
        public Nullable<decimal> ApprovedBudget { get; set; }
        public string ProjectStatus { get; set; }
        public int Proposal_ID { get; set; }
        //public string ProposalCode { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
    }
}