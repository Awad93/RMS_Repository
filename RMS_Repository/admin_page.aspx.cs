using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;
using System.Web.Script.Serialization;

namespace RMS_Repository
{
    public partial class admin_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            DataTable summary = (new Summary()).SummaryAll(DateTime.Now.Year - 8, DateTime.Now.Year);

            DataTable publicationTable = publicationData(summary);
            publTable.DataSource = publicationTable;
            publTable.DataBind();

            DataTable conferenceTable = conferenceData(summary);
            conf_patent.DataSource = conferenceTable;
            conf_patent.DataBind();

            DataTable projectTable = projectData(summary);
            project.DataSource = projectTable;
            project.DataBind();

            DataTable courseTable = courseData(summary);
            courses_graduate.DataSource = courseTable;
            courses_graduate.DataBind();

            publPoints(summary);

        }

        public DataTable publicationData(DataTable table)
        {
            DataView view = new DataView(table);
            return view.ToTable("Publication", false, "Year", "ISI_Publications", "NonISI_Publications", "Publication_Points", "Books");
        }

        public DataTable conferenceData(DataTable table)
        {
            DataView view = new DataView(table);
            return view.ToTable("Conference", false, "Year", "Conferences", "Patents");
        }

        public DataTable projectData(DataTable table)
        {
            DataView view = new DataView(table);
            return view.ToTable("Project", false, "Year", "Projects", "Project_Funds");
        }

        public DataTable courseData(DataTable table)
        {
            DataView view = new DataView(table);
            return view.ToTable("Graduate", false, "Year", "Graduate_Students");
        }

        protected void publTable_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                //if ((DataBinder.Eval(e.Item.DataItem, "FullName") != null))
                ((Literal)e.Item.FindControl("year")).Text = (DataBinder.Eval(e.Item.DataItem, "Year")).ToString();
                ((Literal)e.Item.FindControl("isi")).Text = (DataBinder.Eval(e.Item.DataItem, "ISI_Publications")).ToString();
                ((Literal)e.Item.FindControl("nonisi")).Text = (DataBinder.Eval(e.Item.DataItem, "NonISI_Publications")).ToString();
                ((Literal)e.Item.FindControl("points")).Text = (DataBinder.Eval(e.Item.DataItem, "Publication_Points")).ToString();
                ((Literal)e.Item.FindControl("books")).Text = (DataBinder.Eval(e.Item.DataItem, "Books")).ToString();


            }
        }

        protected void conf_patent_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                //if ((DataBinder.Eval(e.Item.DataItem, "FullName") != null))
                ((Literal)e.Item.FindControl("conf_year")).Text = (DataBinder.Eval(e.Item.DataItem, "Year")).ToString();
                ((Literal)e.Item.FindControl("conference")).Text = (DataBinder.Eval(e.Item.DataItem, "Conferences")).ToString();
                ((Literal)e.Item.FindControl("patent")).Text = (DataBinder.Eval(e.Item.DataItem, "Patents")).ToString();


            }
        }

        protected void project_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                //if ((DataBinder.Eval(e.Item.DataItem, "FullName") != null))
                ((Literal)e.Item.FindControl("proj_year")).Text = (DataBinder.Eval(e.Item.DataItem, "Year")).ToString();
                ((Literal)e.Item.FindControl("projects")).Text = (DataBinder.Eval(e.Item.DataItem, "Projects")).ToString();
                ((Literal)e.Item.FindControl("fund")).Text = (DataBinder.Eval(e.Item.DataItem, "Project_Funds")).ToString();


            }
        }

        protected void courses_graduate_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                //if ((DataBinder.Eval(e.Item.DataItem, "FullName") != null))
                ((Literal)e.Item.FindControl("course_year")).Text = (DataBinder.Eval(e.Item.DataItem, "Year")).ToString();
                //((Literal)e.Item.FindControl("projects")).Text = (DataBinder.Eval(e.Item.DataItem, "Projects")).ToString();
                ((Literal)e.Item.FindControl("graduate")).Text = (DataBinder.Eval(e.Item.DataItem, "Graduate_Students")).ToString();


            }
        }

        public void publPoints(DataTable table)
        {
            double[][] publpoints = new double[table.Rows.Count][];
            int i = 0;
            foreach(DataRow row in table.Rows)
            {
                publpoints[i] = new double[2]{ (double)row["Year"],  (double)row["Publication_Points"]};
                //publpoints[i][1] = (double)row["Publication_Points"];
                i++;
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var json = serializer.Serialize(publpoints);

            points.Value = json;
            i = 0;
        }
    }
}