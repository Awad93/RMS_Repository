using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class results_page : System.Web.UI.Page
    {
        #region Fields
        int numOfBooks;
        int numOfISIPublications;
        int numOfNonISIPublications;
        int year;
        #endregion
        protected void repeaterISIPublications_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Header)
            {
                ((Label)e.Item.FindControl("lblTotalPublications")).Text = numOfISIPublications + "";
            }
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                if ((DataBinder.Eval(e.Item.DataItem, "PaperTitle") != null))
                    ((Literal)e.Item.FindControl("ltrlPaperTitle")).Text = (DataBinder.Eval(e.Item.DataItem, "BookTitle")).ToString(); ;
                if ((DataBinder.Eval(e.Item.DataItem, "Authors") != null))
                    ((Literal)e.Item.FindControl("ltrlAuthors")).Text = (DataBinder.Eval(e.Item.DataItem, "Authors")).ToString();
                if ((DataBinder.Eval(e.Item.DataItem, "PublicationYear") != null))
                    ((Literal)e.Item.FindControl("ltrlPublicationYear")).Text = (DataBinder.Eval(e.Item.DataItem, "PublicationYear")).ToString();
            }
        }
        protected void repeaterNonISIPublications_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Header)
            {
                ((Label)e.Item.FindControl("lblTotalPublications")).Text = numOfNonISIPublications + "";
            }
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                if ((DataBinder.Eval(e.Item.DataItem, "PaperTitle") != null))
                    ((Literal)e.Item.FindControl("ltrlPaperTitle")).Text = (DataBinder.Eval(e.Item.DataItem, "BookTitle")).ToString(); ;
                if ((DataBinder.Eval(e.Item.DataItem, "Authors") != null))
                    ((Literal)e.Item.FindControl("ltrlAuthors")).Text = (DataBinder.Eval(e.Item.DataItem, "Authors")).ToString();
                if ((DataBinder.Eval(e.Item.DataItem, "PublicationYear") != null))
                    ((Literal)e.Item.FindControl("ltrlPublicationYear")).Text = (DataBinder.Eval(e.Item.DataItem, "PublicationYear")).ToString();
            }
        }
        protected void repeaterBooks_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Header)
            {
                ((Label)e.Item.FindControl("lblTotalBooks")).Text = numOfBooks + "";
            }
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                if ((DataBinder.Eval(e.Item.DataItem, "BookTitle") != null))
                    ((Literal)e.Item.FindControl("ltrlBookTitle")).Text = (DataBinder.Eval(e.Item.DataItem, "BookTitle")).ToString(); ;
                if ((DataBinder.Eval(e.Item.DataItem, "Authors") != null))
                    ((Literal)e.Item.FindControl("ltrlAuthors")).Text = (DataBinder.Eval(e.Item.DataItem, "Authors")).ToString();
                if ((DataBinder.Eval(e.Item.DataItem, "PublicationYear") != null))
                    ((Literal)e.Item.FindControl("ltrlPublicationYear")).Text = (DataBinder.Eval(e.Item.DataItem, "PublicationYear")).ToString();
            }
        }

        protected void repeaterColleges_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                if ((DataBinder.Eval(e.Item.DataItem, "DepartmentName") != null))
                    ((Literal)e.Item.FindControl("ltrlCollege")).Text = (DataBinder.Eval(e.Item.DataItem, "DepartmentName")).ToString();
                if ((DataBinder.Eval(e.Item.DataItem, "DepartmentCode") != null))
                {
                    //((HiddenField)e.Item.FindControl("hfvCollege")).Value = (DataBinder.Eval(e.Item.DataItem, "DepartmentCode")).ToString();
                    string DepartmentCode = (DataBinder.Eval(e.Item.DataItem, "DepartmentCode")).ToString();
                    List<Models.rms_Departments> Departments = Models.rms_Departments.getDepartmentsByCollege(DepartmentCode);
                    Repeater repeaterDepartments = (Repeater)e.Item.FindControl("repeaterDepartments");
                    repeaterDepartments.DataSource = Departments;
                    repeaterDepartments.DataBind();
                }
            }
        }
        protected void repeaterDepartments_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                if ((DataBinder.Eval(e.Item.DataItem, "DepartmentName") != null))
                    ((Literal)e.Item.FindControl("ltrlDepartment")).Text = (DataBinder.Eval(e.Item.DataItem, "DepartmentName")).ToString();
            }
        }
        protected void repeaterFaculty_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                if ((DataBinder.Eval(e.Item.DataItem, "FullName") != null))
                    ((Literal)e.Item.FindControl("ltrlFaculty")).Text = (DataBinder.Eval(e.Item.DataItem, "FullName")).ToString();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            #region Load Sidebar
            //string html_code = "";
            //List<Models.rms_Departments> collegeList = Models.rms_Departments.getAllColleges();
            //for (int i = 0; i < collegeList.Count; i++)
            //{
            //    List<Models.rms_Departments> departmentList = Models.rms_Departments.getDepartmentsByCollege(collegeList[i].DepartmentCode);
            //    string dept_html_code = "<ul id=\"deptlist" + i + "\" class=\"collapse list-unstyled\">";
            //    for (int j = 0; j < departmentList.Count; j++)
            //    {
            //        dept_html_code += "<li><a>" + departmentList[j].DepartmentName + "</a></li>";
            //    }
            //    dept_html_code += "</ul>";
            //    html_code += "<span class=\"panel\"><li data-toggle=\"collapse\"" +
            //        "href=\"#deptlist" + i + "\"" +
            //        "data-parent=\"#listCollege\">" +
            //        "<a>" + collegeList[i].DepartmentName + "</a>" +
            //        "</li>" + dept_html_code + "</span>";
            //}
            //listCollege.InnerHtml = html_code;
            #endregion

            #region Get Colleges
            List<Models.rms_Departments> Colleges = Models.rms_Departments.getAllColleges();
            repeaterColleges.DataSource = Colleges;
            repeaterColleges.DataBind();
            #endregion

            #region Get Books            
            List<Models.rms_Books_Authored> Books = Models.rms_Books_Authored.getAllBooks();
            // Get the total number of books
            numOfBooks = Books.Count;
            year = (int)Books[0].PublicationYear;

            repeaterBooks.DataSource = Books;
            repeaterBooks.DataBind();
            #endregion

            #region Get ISI Publications
            List<Models.rms_Publications_ISI> ISIPublications = Models.rms_Publications_ISI.getISIPublicationsByCollege("CCSE");
            numOfISIPublications = ISIPublications.Count;

            repeaterISIPublications.DataSource = ISIPublications;
            repeaterISIPublications.DataBind();
            #endregion

            #region Get NonISI Publications
            List<Models.rms_Publications_NonISI> NonISIPublications = Models.rms_Publications_NonISI.getNonISIPublicationsByCollege("CCSE");
            numOfNonISIPublications = NonISIPublications.Count;
            repeaterNonISIPublications.DataSource = NonISIPublications;
            repeaterNonISIPublications.DataBind();
            #endregion

            #region Get Faculty
            List<Models.rms_Researchers> Researchers = Models.rms_Researchers.getFacultyByCollege("CCSE");
            repeaterFaculty.DataSource = Researchers;
            repeaterFaculty.DataBind();
            #endregion
        }
        protected void collegeEvent_click(object sender, EventArgs e)
        {

        }
    }
}