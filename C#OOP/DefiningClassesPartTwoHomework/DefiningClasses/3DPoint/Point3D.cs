namespace DefiningClasses
{
/// <summary>
/// structure Point3D to hold a 3D-coordinate
/// </summary>
    public struct Point3D
    {
        private static readonly Point3D START_POINT;
        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;    
        }

        static Point3D()
        {
            START_POINT = new Point3D(0, 0, 0);
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public static Point3D StartPoint { get { return START_POINT; } }

        public override string ToString()
        {
            return $"{this.X}, {this.Y}, {this.Z}";
        }
    }   
}