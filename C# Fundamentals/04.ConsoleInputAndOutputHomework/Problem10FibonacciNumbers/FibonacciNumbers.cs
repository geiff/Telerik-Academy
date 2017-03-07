/*Write a program that reads a number N and prints on the console the first N members
  of the Fibonacci sequence (at a single line, separated by comma and space - ", ") : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….*/

using System;
using System.Collections.Generic;

namespace Problem10FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<long> result = new List<long>();

            if (n == 1)
            {
                result.Add(0);
            }

            if (n == 2)
            {
                result.Add(0);
                result.Add(1);
            }

            if (n > 2)
            {
                result.Add(0);
                result.Add(1);
                for (int i = 2; i < n; i++)
                {
                    result.Add(result[i-1] + result[i - 2]);
                }
            }
           
            Console.WriteLine(string.Join(", ", result));
        }
    }
}