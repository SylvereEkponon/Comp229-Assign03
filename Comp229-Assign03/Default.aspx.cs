using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//using statement that are required to connect to EF DB
using Comp229_Assign03.Models;
using System.Web.ModelBinding;

namespace Comp229_Assign03
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //If loading the page for the fisrt time
            //populate the student grid

            if (!IsPostBack)
            {
                //Get the student data
                this.GetStudents();
            }
        }

        /// <summary>
        /// This method gets the student data from the DB
        /// </summary>
        private void GetStudents()
        {
            //connect to EF
            using(BabyloneContext db = new BabyloneContext())
            {
                //query the student table using EF and LINQ
                var Students = (from allStudents in db.Students
                                select allStudents);

                //bind the result to the students gridview
                StudentsGridView.DataSource = Students.ToList();
                StudentsGridView.DataBind();

            }
        }

        protected void StudentsGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //set the new page number
            StudentsGridView.PageIndex = e.NewPageIndex;

            //refresh the grid
            this.GetStudents();
        }
    }
}