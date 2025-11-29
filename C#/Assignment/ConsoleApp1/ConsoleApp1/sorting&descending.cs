using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class sorting_descending
    {
        public static void sorting()
        {

            Console.WriteLine("Enter a String : ");
            string? str = Console.ReadLine();

            char[] chars = str.ToCharArray();  // Using Array.Sort() and Array.Reverse()
            Array.Sort(chars);
                Array.Reverse(chars);
            Console.WriteLine(chars.Length);
            Console.WriteLine(chars);

            string result = new string (str.OrderByDescending(x => x).ToArray()); // Using LINQ 
            Console.WriteLine(result);



        }
    }
}
