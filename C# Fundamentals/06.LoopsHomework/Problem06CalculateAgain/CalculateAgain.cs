/*Write a program that calculates N! / K! for given N and K.*/
using System;
using System.Numerics;

namespace Problem06CalculateAgain
{
    class CalculateAgain
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger k = BigInteger.Parse(Console.ReadLine());
            
            BigInteger factorialN = 1;
            for (BigInteger i = 1; i <= n; i++)
            {
                factorialN *= i;
            }

            BigInteger factorialK = 1;
            for (BigInteger i = 1; i <= k; i++)
            {
                factorialK *= i;
            }

           Console.WriteLine("{0}", factorialN / factorialK);
        }
    }
}