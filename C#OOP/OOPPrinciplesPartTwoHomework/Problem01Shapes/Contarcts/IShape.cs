namespace Problem01Shapes.Contarcts
{
    interface IShape
    {
        double Width { get; set; }
        double Height { get; set; }

        double CalculateSurface();
    }
}