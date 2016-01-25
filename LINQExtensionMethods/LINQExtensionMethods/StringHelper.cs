using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExtensionMethods
{
    /*Implementing Extention Methods in LINQ 
    1) insert static keyword to the class
    2) in your method you put in this.keyword in your first parameter
    */
   public static class StringHelper
    {
        public static string ChangeFirstLetterCase(this string inputString)
        {
            if(inputString.Length > 0)
            {
                char[] charArray = inputString.ToCharArray();
                charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
                return new string(charArray);
            }
            return inputString;
        }
    }
}
