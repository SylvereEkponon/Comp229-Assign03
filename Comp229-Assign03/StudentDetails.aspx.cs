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
    public partial class StudentDetails : System.Web.UI.Page
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
            // use EF to connect to the server
            using (BabyloneContext db = new BabyloneContext())
            {
                //use the student model to create a new student object 
                //save new record
                Student student = new Student();


                //add form data to the new student record
                student.LastName = LastNameTextBox.Text;
                student.FirstMidName = FirstNameTextBox.Text;
                student.EnrollmentDate = Convert.ToDateTime(EnrollmentDateTextBox.Text);

                //use LINQ to ADO.NET to insert new student into the db
                db.Students.Add(student);

                //save and insert
                db.SaveChanges();

                //redirect
                Response.Redirect("~/Default.aspx");

            }
        }
    }
}