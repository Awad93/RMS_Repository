﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class rms_Authors_ISI
    {
        //------------------------------------------------------------------------------
        // <auto-generated>
        //     This code was generated from a template.
        //
        //     Manual changes to this file may cause unexpected behavior in your application.
        //     Manual changes to this file will be overwritten if the code is regenerated.
        // </auto-generated>
        //------------------------------------------------------------------------------
            public int Authors_ISI_ID { get; set; }
            public int KFUPMID { get; set; }
            public string WOS { get; set; }
            //public string PublicationTitle { get; set; }
            public Nullable<int> NumberOfAuthors { get; set; }
            public Nullable<int> AuthorshipOrder { get; set; }
            public Nullable<int> PublicationPoints { get; set; }
            public string ProjectNo { get; set; }
            public bool CorrespondingAuthor { get; set; }
            public string Remarks { get; set; }
            public Nullable<bool> isDeleted { get; set; }
            public Nullable<bool> isActive { get; set; }
            public string CreatedBy { get; set; }
            public System.DateTime CreatedOn { get; set; }
    }
}

