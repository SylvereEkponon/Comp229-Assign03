using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Comp229_Assign03.Models;
using System.Web.ModelBinding;

namespace Comp229_Assign03
{
    public partial class Updates : System.Web.UI.Page
    {
        int StudentID;
        protected void Page_Load(object sender, EventArgs e)
        {
            // populate the form with existing data from db
             StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);

            if (!IsPostBack)
            {
                this.BindTextBoxValues();
            }

        }

        private void BindTextBoxValues()
        {
            using (BabyloneContext db = new BabyloneContext())
            {
                // populate a student object instance with the StudentID from 
                // the URL parameter
                var Students = (from student in db.Students
                                where student.StudentID == StudentID
                                select student);

                //bind the result to the textbox
                foreach (var aStudent in Students.ToList())
                {
                    LastNameTextBox.Text = aStudent.LastName;
                    FirstNameTextBox.Text = aStudent.FirstMidName;
                    EnrollmentDateTextBox.Text = Convert.ToString(aStudent.EnrollmentDate);
                }
            }
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            //Redirect to the Home page
            Response.Redirect("~/Default.aspx");
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            // use EF to connect to the server
            using (BabyloneContext db = new BabyloneContext())
            {
                //Query the database for the row to be updated
                var query = (from student in db.Students
                                where student.StudentID == StudentID
                                select student);


                //add form data to the new student record
                foreach (var student in query)
                {
                    student.LastName = LastNameTextBox.Text;
                    student.FirstMidName = FirstNameTextBox.Text;
                    student.EnrollmentDate = Convert.ToDateTime(EnrollmentDateTextBox.Text);

                }

                //Submit the changes to the database
                db.SaveChanges();

                //redirect
                Response.Redirect("~/Default.aspx");

            }
        }
    }
}