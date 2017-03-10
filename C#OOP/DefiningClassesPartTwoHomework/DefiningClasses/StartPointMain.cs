using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartPointMain
    {
        static void Main()
        {
            //Test Problems from 1 to 3.
            Console.WriteLine("Enter two point in 3D space!");
            Console.Write("Enter coordinate for first point separate by space:");
            string[] oneStrInputPoint = Console.ReadLine().Split(' ');
            Console.Write("Enter coordinate for second point separate by space:");
            string[] twoStrInputPoint = Console.ReadLine().Split(' ');

            Point3D first = new Point3D(double.Parse(oneStrInputPoint[0]), double.Parse(oneStrInputPoint[1]), double.Parse(oneStrInputPoint[2]));
            Point3D second = new Point3D(double.Parse(twoStrInputPoint[0]), double.Parse(twoStrInputPoint[1]), double.Parse(twoStrInputPoint[2]));

            Console.WriteLine("Distance between points {{{0}}} and {{{1}}} is: {2:F2}", first, second, Distance.Calculate(first, second));

            //Test Problems from 4.
            Path path = new Path(new List<Point3D>() { first, second });
            PathStorage.SavePath(path);

            Path readPoints = PathStorage.LoadPath(@"../../../WritePath.txt");
            readPoints.Points.ForEach(x => Console.WriteLine(x));
        }
    }
}