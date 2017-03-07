/*Write a program that calculates the greatest common divisor (GCD) of given two integers A and B.
Use the Euclidean algorithm (find it in Internet).*/

using System;

namespace Problem15GCD
{
    class GCD
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            Console.WriteLine(Gcd(a, b));

            //while (a != 0 && b != 0)
            //{
            //    if (a > b)
            //        a %= b;
            //    else
            //        b %= a;
            //}

            //if (a == 0)
            //    Console.WriteLine(b);
            //else
            //    Console.WriteLine(a);
        }

        public static int Gcd(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return Gcd(b, a % b);
            }
        }
    }
}