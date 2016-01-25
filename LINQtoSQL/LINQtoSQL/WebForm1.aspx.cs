using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQtoSQL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void GetData()
        {
            ContactsDataContext dbContext = new ContactsDataContext();
            //linq getting from store procedure
            GridView1.DataSource = dbContext.GetEmployee();
            GridView1.DataBind();
        }

        protected void btnGetData_Click(object sender, EventArgs e)
        {
            GetData();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            using (ContactsDataContext dbContext = new ContactsDataContext())
            {
                Employee newEmployee = new Employee
                {
                    FirstName = "Time",
                    LastName = "T",
                    Gender = "Male",
                    Salary = 5000,
                    DepartmentId = 1
                };

                dbContext.Employees.InsertOnSubmit(newEmployee);
                dbContext.SubmitChanges();
            }

            GetData();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            using (ContactsDataContext dbContext = new ContactsDataContext())
            {
                Employee employee = dbContext.Employees.SingleOrDefault
                                    (x => x.ID == 8);
                employee.Salary = 6500;
                dbContext.SubmitChanges();
            }

            GetData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            using (ContactsDataContext dbContext = new ContactsDataContext())
            {
                Employee employee = dbContext.Employees.SingleOrDefault
                                    (x => x.ID == 8);
                dbContext.Employees.DeleteOnSubmit(employee);
                dbContext.SubmitChanges();
            }

            GetData();
        }

        protected void btnGetEmployeeByDepartment_Click(object sender, EventArgs e)
        {
            using (ContactsDataContext dbContext = new ContactsDataContext())
            {
                string deptName = string.Empty;
                GridView1.DataSource = dbContext.GetEmployeesByDepartment(1, ref deptName);
                GridView1.DataBind();

                lblDept.Text = "Department Name = " + deptName;
            }
        }
    }
}