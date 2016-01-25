using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAggregateFunctions
{
    class Program
    {
        //Program without using LINQ
        static void Main(string[] args)
        {
            //int[] Numbers = {1,2,3,4,5,6,7,8,9,10 };

            //double? sum = 0;
            //int total = 0;
            //double? result = null;

            //foreach (int i in Numbers)
            //{
            //    sum = sum + i;
            //    total = total + 1;

            //}
            //result = sum / total;
            //Console.WriteLine(result);

            string[] countries = { "India", "USA", "UK", "Canada","Australia" };

            string result = string.Empty;

            foreach (string str in countries)
            {
                result = result + str + ",";
            }

            int lastIndex = result.LastIndexOf(" , ");
            result = result.Remove(lastIndex);

            Console.WriteLine(result);

            //int? result = null;

            //foreach(string str in countries)
            //{
            //    if(!result.HasValue || str.Length < result)
            //    {
            //        result = str.Length;
            //    }
            //}

            //Console.WriteLine("The shortest country name has {0} characters in its name", result); 
        }
    }
}
