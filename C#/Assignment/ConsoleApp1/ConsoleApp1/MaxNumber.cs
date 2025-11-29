using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MaxNumber
    {
        public static void MaximumNumber()
        {
            Console.WriteLine("Enter a First Number : ");
            string? str = Console.ReadLine();


            Console.WriteLine("Enter a Second Number : ");
            string? str2 = Console.ReadLine();

            int.TryParse(str, out int value);
            int.TryParse(str2, out int value2);

            if (value2 > value)
            {
                Console.WriteLine($"Maximum number is {str2}");
            }

            else if ( value2 == value){
                Console.WriteLine("Both Number are Equal");
            }
            else
            {
                Console.WriteLine($"Maximum Number is {str}");


            }

        }
    }
}
