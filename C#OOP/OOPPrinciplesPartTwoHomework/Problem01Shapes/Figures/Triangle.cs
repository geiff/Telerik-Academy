namespace Problem01Shapes.Figures
{
    using AbstractClasses;
    using Contarcts;

    public class Triangle : Shape, IShape
    {
        public Triangle(double width, double height) : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            return this.Height*this.Width/2;
        }
    }
}