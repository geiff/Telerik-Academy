/*Write a program that reads 5 integer numbers from the console and prints their sum.*/
using System;

namespace Problem07SumOfFiveNumbers
{
    class SumOfFiveNumbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());

            Console.WriteLine(a+b+c+d+f);
        }
    }
}