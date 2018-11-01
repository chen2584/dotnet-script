public readonly struct Point
{
    // public double X { get; set; } can't compile
    public double X { get; }
    public double Y { get; }

    public Point(double x, double y) => (X, Y) = (x, y);

    public override string ToString() => $"({X}, {Y})";
}

var point = new Point(1234d, 2345d);
Console.WriteLine(point.ToString());
