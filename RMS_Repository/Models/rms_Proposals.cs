using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RSM_Repository.Models
{
    public class rms_Proposals
    {
        public int Proposal_ID { get; set; }
        public string ProposalCode { get; set; }
        public Nullable<int> PrincipalInvestigator { get; set; }
        public string ProposalTitle { get; set; }
        public string ProjectType { get; set; }
        public string Semester { get; set; }
        public string Keywords { get; set; }
        public string StDate { get; set; }
        public string EndDate { get; set; }
        public Nullable<int> RequestedBudget { get; set; }
        public string ChairmanApproval { get; set; }
        public string ChairmanComments { get; set; }
        public bool IsEvaluationCompleted { get; set; }
        public string Status { get; set; }
        public Nullable<int> Project_ID { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
    }
}