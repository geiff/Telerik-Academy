namespace Problem01Shapes.Figures
{
    using AbstractClasses;
    using Contarcts;

    class Square : Shape, IShape
    {
        public Square(double width) : base (width, width)
        {
        }

        public override double CalculateSurface()
        {
            return this.Width*this.Width;
        }
    }
}