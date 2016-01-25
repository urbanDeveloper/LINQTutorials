using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace LINQ
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["SampleConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
                SqlCommand cmd = new SqlCommand("select ID, Name, Gender from tblStudents where Gender = 'Male'", con);
                List<Student>listStudent = new List<Student>();
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Student student = new Student();
                student.ID = Convert.ToInt32(rdr["ID"]);
                student.Name = rdr["Name"].ToString();
                student.Gender= rdr["Gender"].ToString();

                listStudent.Add(student);

            }
            con.Close();

            GridView1.DataSource = listStudent;
            GridView1.DataBind();
        }
    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}