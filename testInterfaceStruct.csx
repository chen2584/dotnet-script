interface IPosition
{
    double Longtitude { get; set; }
    double Lagitude { get; set; }

    double GetPosition();
}

public struct Position : IPosition
{
    public double Longtitude { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double Lagitude { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public double GetPosition()
    {
        return 5555.555f;
    }
}

var position = new Position();
Console.WriteLine(position.GetPosition());
