using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestrictionOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDBContext context = new EmployeeDBContext();

            IEnumerable<Department> departments = context.Departments.Where(x => x.Name == "IT" || x.Name == "HR");

            foreach (Department dept in departments)
            {
                Console.WriteLine("Department - {0}", dept.Name);
                IEnumerable<Employee> employees = dept.Employees.Where(x => x.Gender == "Male");
                foreach (Employee emp in employees)
                {
                    Console.WriteLine("\tEmployee Name = {0} {1}", emp.FirstName,emp.LastName);
                }
            }

            Console.ReadLine();
        }
    }
}
