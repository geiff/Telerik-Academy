/*Write a program that calculates with how many zeroes the factorial of a given number N has at its end.
Your program should work well for very big numbers, e.g. N = 100000.*/

using System;

namespace Problem16TrailingZeroInN
{
    class TrailingZeroInN
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            if (n == 5)
            {
                Console.WriteLine("1");
            }

            for (int j = 5; n / j >= 1; j *= 5)
            {
                count += n / j;
            }

            Console.WriteLine(count);

        }
    }
}