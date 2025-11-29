using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class StringOperation
    {
      public static void StrOperation()
        {
            Console.WriteLine("String Operation");

            string str = "Good Morning..!";
            string str2 = "I am Learning Java";

            Console.WriteLine(str.ToLower());

            Console.WriteLine(str2.ToUpper());

            Console.WriteLine(str.Replace("Java", "C#"));

            Console.WriteLine(str2.Length);

            Console.WriteLine(string.Concat(str , str2));

            Console.WriteLine(string.Compare(str, str2));

            Console.WriteLine(str[..^3]);

            Console.WriteLine(str.Equals(str2));
            

        }
    }
}
