/*Write a program that reads 3 real numbers from the console and prints their sum.*/
using System;

namespace Problem01SumofThreeNumbers
{
    class SumofThreeNumbers
    {
        static void Main()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            Console.WriteLine(a + b + c);
        }
    }
}