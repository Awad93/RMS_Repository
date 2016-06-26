using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WebApplication1.Models
{
    public class rms_BookAuthors 
    {
        #region Fields
        public int BooksAuthors_ID { get; set; }
        public int BookNum { get; set; }
        //public string BookTitle { get; set; }
        public int KFUPMID { get; set; }
        public string Contribution { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<bool> isActive { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}