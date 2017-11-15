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
    public partial class EnrollStudent : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            //Redirect to the students page
            Response.Redirect("~/Default.aspx");
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            
            using (BabyloneContext db = new BabyloneContext())
            {
                //use the enrollment model to create a new enrollment object 
                //save new record
                Enrollment enrol = new Enrollment();


                //add form data to the new enrollment record
                enrol.CourseID = Convert.ToInt32(CourseIDTextBox.Text);
                enrol.StudentID = Convert.ToInt32(StudentIDTextBox.Text);
                enrol.Grade = Convert.ToInt32(GradeTextBox.Text);

                //use LINQ to ADO.NET to insert new enrollment into the db
                db.Enrollments.Add(enrol);

                //save and insert
                db.SaveChanges();

                //redirect
                Response.Redirect("~/Default.aspx");
            }
        }
    }
}