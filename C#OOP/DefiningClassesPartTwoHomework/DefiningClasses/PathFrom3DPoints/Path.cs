using System.Collections.Generic;

namespace DefiningClasses
{
    /// <summary>
    /// Class Path to hold a List of points in the 3D space.
    /// </summary>
    public class Path
    {
        public Path(List<Point3D> points)
        {
            this.Points = points;
        }
        public List<Point3D> Points { get; set; }
    }
}