﻿using Comp229_Assign03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp229_Assign03
{
    public partial class Courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.GetStudents();
        }

        protected void StudentsPerCourseGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //store which row was clicked
            int selectedRow = e.RowIndex;

            //get the selected EnrollmentID
            int EnrollmentID = Convert.ToInt32(StudentsPerCourseGridView.DataKeys[selectedRow].Values["EnrollmentID"]);

            using (BabyloneContext db = new BabyloneContext())
            {
                var removedStudent = (from studentRec in db.Enrollments
                                      where studentRec.EnrollmentID == EnrollmentID
                                      select studentRec);

                //remove the selected student
                foreach (var item in removedStudent)
                {
                    db.Enrollments.Remove(item);
                }

                db.SaveChanges();

                //refresh the grid
                this.GetStudents();
            }
        }
        /// <summary>
        /// This method gets the student data from the DB
        /// </summary>
        private void GetStudents()
        {
            int CourseID = Convert.ToInt32(Request.QueryString["CourseID"]);
            // connect to EF DB
            using (BabyloneContext db = new BabyloneContext())
            {
                // query the Student Table using EF and LINQ
                var Students = (from allStudents in db.Students
                                join Enrollment in db.Enrollments
                                on allStudents.StudentID equals Enrollment.StudentID
                                where Enrollment.CourseID==CourseID
                                select new { LastName=allStudents.LastName,FirstMidName=allStudents.FirstMidName,EnrollmentID=Enrollment.EnrollmentID });

                // bind the result to the Students GridView
                StudentsPerCourseGridView.DataSource = Students.ToList();
                StudentsPerCourseGridView.DataBind();
            }
        }
    }
}