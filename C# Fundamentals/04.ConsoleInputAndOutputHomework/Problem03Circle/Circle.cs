/*Write a program that reads from the console the radius r of a circle and prints its perimeter and area, rounded and formatted with 2 digits after the decimal point.*/
using System;

namespace Problem03Circle
{
    class Circle
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());

            double perimeter = 2*Math.PI*r;
            double area = Math.PI*Math.Pow(r, 2);

            Console.WriteLine("{0:f2} {1:f2}", perimeter, area);
        }
    }
}