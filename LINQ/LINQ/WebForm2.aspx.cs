using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1. create a new item called linq to sql
            //2. Connect to your SQL database and drag and drop table
            //3 MUST reference the sampledatacontext - this can be found in sample.designer.cs

            SampleDataContext dataContext = new SampleDataContext();
            //in memeory objects
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //GridView1.DataSource = from number in numbers
            //                       where (number % 2) == 0
            //                       select number;

            GridView1.DataSource = from student in dataContext.tblStudents
                                   where student.Gender == "Male"
                                   select student;

            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}