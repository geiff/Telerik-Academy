namespace Problem01Shapes.AbstractClasses
{
    using Contarcts;

    public abstract class Shape : IShape
    {
        private double width;
        private double height;

        protected Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }

        public abstract double CalculateSurface();
    }
}