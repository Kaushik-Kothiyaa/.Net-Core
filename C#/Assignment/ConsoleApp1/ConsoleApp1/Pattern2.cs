using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pattern2
    {
        public static void StarPattern()
        {
            /* 
                *
                # #
                * * *
                # # # #
                * * * * * */

            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("# ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }

        public static void StarPattern2()

        { /*
           *
           * #
           * # *
           * # * #
           * # * # *
           
            */
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("# ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void SquarePattern()
        { /*    12345
                12345
                12345
                12345   
                12345 */

            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }

        public static void SquarePattern2()
        {
            /*    11111
                  22222
                  33333
                  44444   
                  55555 */
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(i);
                }

                Console.WriteLine();
            }
            Console.WriteLine();

        }

        public static void SquarePattern3()
        {

            /*
                1
                2 2
                3 3 3
                4 4 4 4
                5 5 5 5 5
              */
            int n = 5;

            for (int i = 1;i <= n; i++)
            {
                for(int j = 1;  j <= i ; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void SquarePattern4()
        { /*
            1
            1 2
            1 2 3       
            1 2 3 4
            1 2 3 4 5
                    */
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();

            }
            Console.WriteLine();
        }
        
        public static void StarPattern3()
        {
            /*
                     * 
                   * * 
                 * * * 
               * * * * 
             * * * * * 
              */

            int n = 5;

            for (int i = 1; i <= n ; i++)
            {

                for (int k = 1; k <= (n - i); k++)
                {
                    Console.Write("  ");
                }

                for (int j =1; j <= i; j++)

                {
                    Console.Write("* ");

                }

                Console.WriteLine();
            }

        }



    }


}
