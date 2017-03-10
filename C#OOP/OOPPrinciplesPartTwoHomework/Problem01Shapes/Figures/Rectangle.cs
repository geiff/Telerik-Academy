namespace Problem01Shapes.Figures
{
    using AbstractClasses;
    using Contarcts;

    public class Rectangle : Shape, IShape
    {
       public Rectangle(double width, double height) : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}