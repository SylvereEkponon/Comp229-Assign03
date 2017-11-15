using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp229_Assign03
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.SetActivePage();
        }

        private void SetActivePage()
        {
            switch (Page.Title)
            {
                case "Updates":
                    update.Attributes.Add("class", "active");
                    break;
                case "Students":
                    student.Attributes.Add("class", "active");
                    break;
                case "Courses":
                    course.Attributes.Add("class", "active");
                    break;
                case "Home":
                    home.Attributes.Add("class", "active");
                    break;
            }
        }
    }
}