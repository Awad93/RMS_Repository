using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class rms_Books_Translated
    {
        public int Book_Translated_ID { get; set; }
        public string BookTitle { get; set; }
        public Nullable<int> PublicationYear { get; set; }
        public string Publisher { get; set; }
        public string Country { get; set; }
        public string OriginalTitle { get; set; }
        public string OriginalAuthors { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
    }
}