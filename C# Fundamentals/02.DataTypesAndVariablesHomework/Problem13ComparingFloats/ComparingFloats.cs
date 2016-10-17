/*Write a program that safely compares two floating-point numbers (double) with precision eps = 0.000001.*/

using System;

namespace Problem13ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;

            if (Math.Abs(a - b) <= eps)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}