/*Write a program that finds all prime numbers in the range [1 ... N]. Use the Sieve of Eratosthenes algorithm. 
 The program should print the biggest prime number which is <= N.*/
using System;

namespace Problem15PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] numbers = new bool[n + 1];

            for (int i = 0; i <= n; i++)
            {
                numbers[i] = true;
            }

            for (int i = 2; (i * i) <= n; i++)
            {
                if (numbers[i])
                {
                    for (int j = i * i; j <= n; j = j + i)
                    { 
                        numbers[j] = false;
                    }
                }
            }

            for (int i = n; i >= 2; i--)
            {
                if (numbers[i])
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}