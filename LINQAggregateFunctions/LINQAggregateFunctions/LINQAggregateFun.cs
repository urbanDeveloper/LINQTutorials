using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAggregateFunctions
{
    class LINQAggregateFun
    {
        public static void Main()
        {
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //int smallestNumber = Numbers.Min();
            //int smallestEvenNumber = Numbers.Where(x => x % 2 == 0).Min();

            //int largestNumber = Numbers.Max();
            //int largestEvenNumber = Numbers.Where(x => x % 2 == 0).Max();

            //int sumOfAllNumbers = Numbers.Sum();
            //int sumOfAllEvenNumbers = Numbers.Where(x => x % 2 == 0).Sum();

            //int countOfAllNumbers = Numbers.Count();
            //int countOfAllEvenNumbers = Numbers.Where(x => x % 2 == 0).Count();

            //double averageOffAllNumbers = Numbers.Average();
            //double averageOfAllEvenNumbers = Numbers.Where(n => n % 2 == 0).Average();

            //string[] countries = { "India", "USA", "UK" };

            //Console.WriteLine("The shortest country{0}",countries.Min(country => country.Length));
            //Console.WriteLine("The longest country{0}", countries.Max(country => country.Length));
            //Console.ReadLine();

            // Aggregate Function
            string[] countries = { "India", "USA", "UK", "Canada", "Australia" };
            string result = countries.Aggregate((a,b) => a + ", " + b);


            int[] Numbers = { 2, 3, 4, 5 };
            int result1 = Numbers.Aggregate((a,b) => a * b);
            
            // Overloaded function has Seed parameter: pass 10 as a seed parameter
            int result2 = Numbers.Aggregate(10,(a, b) => a * b);

            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.ReadLine();
        }


    }
}
