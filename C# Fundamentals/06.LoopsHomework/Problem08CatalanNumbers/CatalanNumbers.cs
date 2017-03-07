/*In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
Write a program to calculate the Nth Catalan number by given N*/

using System;
using System.Numerics;

namespace Problem08CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            BigInteger factorialTwoN = 1;
            for (BigInteger i = 1; i <= 2 * n; i++)
            {
                factorialTwoN *= i;
            }

            BigInteger factorialN = 1;
            for (BigInteger i = 1; i <= n; i++)
            {
                factorialN *= i;
            }

            BigInteger factorialNPlusOne = 1;
            for (BigInteger i = 1; i <= (n + 1); i++)
            {
                factorialNPlusOne *= i;
            }

            Console.WriteLine("{0}", factorialTwoN / (factorialNPlusOne * factorialN));
        }
    }
}