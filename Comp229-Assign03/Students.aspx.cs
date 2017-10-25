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
    public partial class Students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // populate the form with existing data from db
            int StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);

            using (BabyloneContext db = new BabyloneContext())
            {
                // populate a student object instance with the StudentID from 
                // the URL parameter
                var Students = (from student in db.Students
                                          where student.StudentID == StudentID
                                          select student);
                //bind the result to the students gridview
                StudentGridView.DataSource = Students.ToList();
                StudentGridView.DataBind();



                var courseTitleAndGrade = (from course in db.Courses
                                           join enrol in db.Enrollments
                                           on course.CourseID equals enrol.CourseID
                                           where enrol.StudentID == StudentID
                                           select new { CourseID=course.CourseID,Title = course.Title, Grade=enrol.Grade });

                CourseTitleAndGradeGridView.DataSource = courseTitleAndGrade.ToList();
                CourseTitleAndGradeGridView.DataBind();

            }
        }
    }
}