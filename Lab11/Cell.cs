namespace Lab11;

public class Cell : AbstractGraphic2D
{
    public decimal X{get;}
    public decimal Y{get;}

    public override decimal LowerBoundX { get; protected set;}
    public override decimal UpperBoundX { get; protected set;}
    public override decimal LowerBoundY { get; protected set;}
    public override decimal UpperBoundY { get; protected set;}

    public Cell(decimal x, decimal y)
    {
        X = x;
        Y = y;
        
        LowerBoundX = UpperBoundX = X;
        LowerBoundY = UpperBoundY = Y;
    }

    public override bool ContainsPoint(decimal x, decimal y)
    {
        return X == x && Y == y;
    }
}