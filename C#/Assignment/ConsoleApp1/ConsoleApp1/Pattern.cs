using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{

   /* Write a program to perform below series and patterns
    o 1+4+9+16+25+…..
    o 1+1+2+3+5+8+….. 1
    o 1+5+14+30+55+…..*/

    internal class Pattern
    {
        public static void Pattern1()
        {

            Console.WriteLine("Enter a Number : ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            var series = "" ;


            for (int i = 1; i <= n; i++)
            {
                sum += i * i;
                series += ( i * i) + "+";
            }      
            
            Console.WriteLine($"{series}…..{sum}");
         
        }

     
        public static void Pattern2()
        {
            Console.WriteLine("Enter a Number : ");
            int n = int.Parse(Console.ReadLine());

            int a = 0 ;
            int b = 1 ;
            int c ;

            Console.Write($"{a} {b} ");

            for (int i = 2 ;i <= n;i++)
            {

                c = a + b ;
                Console.Write($"{c} " );

                a  = b;
                b  =  c;
            }
            Console.ReadLine( );
        }

        public static void Pattern3()
        {
            Console.Write("Enter a Number : ");
            int n = int.Parse(Console.ReadLine());

            // 1 , 1 + 4 , 1 + 4 + 9 , ....
                    
            
            int sum = 0 ;

            for (int i = 1 ; i <= n; i++)
            {
                sum = sum + i * i ;
                

                Console.Write($"{sum} ");
            }
            Console.ReadLine( );    
        }

       
    }
}
