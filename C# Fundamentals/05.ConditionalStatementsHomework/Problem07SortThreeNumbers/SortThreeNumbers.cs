/*Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.
Don’t use arrays and the built-in sorting functionality.*/

using System;

namespace Problem07SortThreeNumbers
{
    class SortThreeNumbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a >= b && a >= c)
            {
                Console.Write(a + " ");

                if (b > c)
                {
                    Console.WriteLine("{0} {1}", b, c);
                }
                else
                {
                    Console.WriteLine("{0} {1}", c, b);
                }
            }

            if (b > a && b >= c)
            {
                Console.Write(b + " ");

                if (a > c)
                {
                    Console.WriteLine("{0} {1}", a, c);
                }
                else
                {
                    Console.WriteLine("{0} {1}", c, a);
                }
            }

            if (c > a && c > b)
            {
                Console.Write(c + " ");

                if (a > b)
                {
                    Console.WriteLine("{0} {1}", a, b);
                }
                else
                {
                    Console.WriteLine("{0} {1}", b, a);
                }
            }
        }
    }
}