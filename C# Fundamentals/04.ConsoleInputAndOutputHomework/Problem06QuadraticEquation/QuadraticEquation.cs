/*Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).*/
using System;

namespace Problem06QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double d = Math.Pow(b, 2) - 4*a*c;

            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d))/(2*a);
                double x2 = (-b - Math.Sqrt(d)) /(2*a);

                Console.WriteLine("{0:f2}\n{1:f2}", Math.Min(x1, x2), Math.Max(x1, x2));
            }

            if (d == 0)
            {
                double x = -b/(2*a);

                Console.WriteLine("{0:f2}", x);
            }

            if (d < 0)
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}