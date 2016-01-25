using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExtensionMethods
{
    /*
    Extension Methods - enables you to "add" methods to existing types without 
    creating a new derived type, recompiling or otherwise modifying the original type.
        Extension methods are a special kind of static method but they are called as instance methods on the extend type
    */
    class Program
    {
        static void Main(string[] args)
        {
            string strName = "sunny";

            string result = strName.ChangeFirstLetterCase();
            //string result = StringHelper.ChangeFirstLetterCase(strName);

            Console.WriteLine(result);
            Console.ReadLine();

            //LINQ extension Method
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> EvenNumbers = Enumerable.Where(Numbers, n => n % 2 == 0);

            foreach(int evenNumber in EvenNumbers)
            {
                Console.WriteLine(evenNumber);
                Console.ReadLine();
            }
        }
    }
}
