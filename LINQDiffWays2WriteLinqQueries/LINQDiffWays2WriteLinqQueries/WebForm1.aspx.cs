using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQDiffWays2WriteLinqQueries
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //using LAMBDA EXPRESSION
            //IEnumerable<Student> qureyResult = Student.GetAllStudents().Where(student => student.Gender == "Male");
            //GridView1.DataSource = qureyResult;
            //GridView1.DataBind();

            //LINQ qurey using SQL like qurey expressions
            IEnumerable<Student> qureyResult = from student in Student.GetAllStudents()
                                               where student.Gender == "Male"
                                               select student;
            GridView1.DataSource = qureyResult;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}