/*Write a program that reads a pair of coordinates x and y and uses an expression to 
 checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).*/
using System;

namespace Problem10PointCircleRectangle
{
    class PointCircleRectangle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if (Math.Pow((1 - x), 2) + Math.Pow((1 - y), 2) <= Math.Pow(1.5, 2))
            {
                Console.Write("inside circle ");
            }
            else
            {
                Console.Write("outside circle ");
            }

            if (-1 <= x && x <= 5 && -1 <= y && y <= 1)
            {
                Console.WriteLine("inside rectangle");
            }
            else
            {
                Console.WriteLine("outside rectangle");
            }
        }
    }
}