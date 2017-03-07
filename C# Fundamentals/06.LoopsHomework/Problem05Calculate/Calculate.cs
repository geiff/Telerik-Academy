/*Write a program that, for a given two numbers N and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + N!/xN.
Use only one loop. Print the result with 5 digits after the decimal point.*/
using System;

namespace Problem05Calculate
{
    class Calculate
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            decimal sum = 1;

            for (int i = 1; i <= n; i++)
            {
                decimal factorial = 1;
                for (int j = 1; j <= i; j++)
                {
                    factorial *= j;
                }
             sum += factorial/ (decimal)Math.Pow(x, i);
            }

            Console.WriteLine("{0:f5}", sum);
        }
    }
}