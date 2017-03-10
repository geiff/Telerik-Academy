using System;
using System.Collections.Generic;
using System.IO;

namespace DefiningClasses
{
    public static class PathStorage
    {
        /// <summary>
        /// Save paths in a text file.
        /// </summary>
        /// <param name="path"></param>
        public static void SavePath(Path path)
        {
            using (StreamWriter file = new StreamWriter(@"../../../WritePath.txt"))
            {
                foreach (var point in path.Points)
                {
                    file.WriteLine(point.ToString());
                }
            }
        }

        /// <summary>
        /// Load paths from a text file.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static Path LoadPath(string file)
        {
            Path path = new Path(new List<Point3D>());
            List<string> lines = new List<string>();

            using (StreamReader fileLoad = new StreamReader(file))
            {
                while (!fileLoad.EndOfStream)
                {
                    lines.Add(fileLoad.ReadLine());
                }
            }

            foreach (var line in lines)
            {
                string[] coordinates = line.Split(new [] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries);
                Point3D point = new Point3D(double.Parse(coordinates[0]), double.Parse(coordinates[1]), double.Parse(coordinates[2]));
                path.Points.Add(point);
            }

            return path;
        }
    }
}