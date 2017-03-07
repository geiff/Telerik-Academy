/*Write a program that reads from the console a sequence of N integer numbers and returns the minimal, the maximal number, 
 the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number N (alone in a line) followed by N lines, each holding an integer number.
The output is like in the examples below.*/

using System;
using System.Linq;

namespace Problem03MMSAOfNNumbers
{
    class MMSAOfNNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double[] numbers = new double[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }


            Console.WriteLine("min={0:f2}", numbers.Min());
            Console.WriteLine("max={0:f2}", numbers.Max());
            Console.WriteLine("sum={0:f2}", numbers.Sum());
            Console.WriteLine("avg={0:f2}", numbers.Average());
        }
    }
}