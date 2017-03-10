using System;

namespace DefiningClasses
{
    /// <summary>
    /// Calculate the distance between two points in the 3D space.
    /// </summary>
    public static class Distance
    {
       public static double Calculate(Point3D first, Point3D second)
        {
           return Math.Sqrt(Math.Pow((second.X - first.X), 2) + Math.Pow((second.Y - first.Y), 2) + Math.Pow((second.Z - first.Z), 2));
        }
    }
}