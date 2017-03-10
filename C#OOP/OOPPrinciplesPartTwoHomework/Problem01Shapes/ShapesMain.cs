namespace Problem01Shapes
{
    using System;
    using AbstractClasses;
    using Figures;

    class ShapesMain
    {
        static void Main()
        {
            Shape[] shape = new Shape[]
            {
                new Rectangle(3.21, 5.4),
                new Triangle(8.12, 3.1),
                new Square(5.00)
            };

            foreach (var sh in shape)
            {
                Console.WriteLine("{0} surface is {1:f2}.", sh.GetType().Name, sh.CalculateSurface());
            }
        }
    }
}