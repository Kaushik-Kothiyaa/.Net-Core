using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TypeCastingExmple
    {
        public static void TypeCasting()
        {

            // Implicit Conversion(Automatic Conversion)
            // When the compiler automatically converts one data type to another without data loss.

            Console.WriteLine("Implicit Conversion(Automatic Conversion)");
            int a = 10;
            float b = a;  

            Console.WriteLine(b);


            // Explicit Conversion (Manual Conversion)
            // When you manually tell the compiler to convert one type to another using a cast operator
            // Because it can cause data loss or exceptions if not used carefully.

            Console.WriteLine("Explicit Conversion (Manual Conversion)");

            int g = 15;
            byte i = (byte)g;
            Console.WriteLine(i);

            // Using Convert Method

            string c = "50";
            string d = "60";

            int e = Convert.ToInt32(c) + Convert.ToInt32(d); 

            Console.WriteLine(e);

            // Using Try Parse Method

            Console.Write("Enter a 1st Float Number : ");
            float K = float.Parse(Console.ReadLine());

            Console.Write("Enter a 2nd Float Number : ");
            float J = float.Parse(Console.ReadLine());

            float H = K + J;

            Console.WriteLine(H);




        }

    }
}
