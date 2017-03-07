/*Write a program that reads the coordinates of a point x and y and using an expression checks if given point (x, y) 
is inside a circle K({0, 0}, 2) - the center has coordinates (0, 0) and the circle has radius 2. The program should 
then print "yes DISTANCE" if the point is inside the circle or "no DISTANCE" if the point is outside the circle.
In place of DISTANCE print the distance from the beginning of the coordinate system - (0, 0) - to the given point.*/
using System;

namespace Problem07PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());

            if (Math.Pow((0 - x), 2) + Math.Pow((0 - y), 2) <= Math.Pow(2, 2))
            {
                Console.WriteLine("yes {0:f2}", Math.Sqrt(x * x + y * y));
            }
            else 
            {
                Console.WriteLine("no {0:f2}", Math.Sqrt(x * x + y * y));
            }
        }
    }
}