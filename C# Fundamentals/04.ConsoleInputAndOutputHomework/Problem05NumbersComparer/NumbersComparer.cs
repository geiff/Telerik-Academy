/*Write a program that gets two numbers from the console and prints the greater of them.*/

using System;

namespace Problem05NumbersComparer
{
    class NumbersComparer
    {
        static void Main()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(a, b));            
        }
    }
}