using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecttionOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // using anonymous types in LINQ
            //example give 10% bonus to all employees whose annual salary is greater than 50000 and project all 
            //anonymous type such employee's FirstName,AnnualSalary and Bonus into
            
            var result = Employee.GetAllEmployees().Where(x => x.AnnualSalary > 50000)
                                                    .Select(emp => new { Name = emp.FirstName, AnnualSalary = emp.AnnualSalary, Bonus = emp.AnnualSalary * .1});

            foreach (var v in result)
            {
                Console.WriteLine(v.Name + " : " + v.AnnualSalary + " - " + v.Bonus);
                
            }

            ReadLine();
        }
        private static void ReadLine()
        {
            Console.ReadLine();
        }
    }
}
