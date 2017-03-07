/*In combinatorics, the number of ways to choose N different members out of a group of N different elements 
(also known as the number of combinations) is calculated by the following formula: formula For example, 
there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. Your task is to write a 
program that calculates N! / (K! * (N - K)!) for given N and K.
Try to use only two loops.*/

using System;
using System.Numerics;

namespace Problem07CalculateThree
{
    class CalculateThree
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger k = BigInteger.Parse(Console.ReadLine());

            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            for (BigInteger i = 1; i <= n; i++)
            {
                factorialN *= i;
                if (i <= k)
                {
                    factorialK *= i;
                }
            }

            BigInteger factorialNK = 1;
            for (BigInteger i = 1; i <= (n - k); i++)
            {
                factorialNK *= i;
            }
            Console.WriteLine("{0}", factorialN / (factorialK * factorialNK));
        }
    }
}