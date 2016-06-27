using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;

namespace RMS_Repository
{
    public partial class admin_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void show_chart_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void getData()
        {
            DataTable summary = (new Summary).SummaryAll(DateTime.Now.Year-8, DateTime.Now.Year);
            DataTable publicationTable = publicationData(summary)

        }

        public DataTable publicationData(DataTable table)
        {
            DataView view = new DataView(table);
            return view.ToTable();
        }
    }