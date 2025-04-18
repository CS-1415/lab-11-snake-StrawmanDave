namespace Lab11;

public class Circle : AbstractGraphic2D
{
    public decimal CenterX;
    public decimal CenterY;
    public decimal Radius;
    
    public override decimal LowerBoundX { get; protected set;}
    public override decimal UpperBoundX { get; protected set;}
    public override decimal LowerBoundY { get; protected set;}
    public override decimal UpperBoundY { get; protected set;}

    public Circle(decimal x, decimal y, decimal radius)
    {
        CenterX = x;
        CenterY = y;
        Radius = radius;

        if(CenterX - radius < 0)
        {
            LowerBoundX = 0;
        }else
        {
            LowerBoundX = CenterX - Radius;
        }

        UpperBoundX = CenterX + Radius;

        if(CenterY - Radius < 0)
        {
            LowerBoundY = 0;
        }else
        {
            LowerBoundY = CenterY - Radius;
        }

        UpperBoundY = CenterY + Radius;
    }

    public override bool ContainsPoint(decimal x, decimal y)
    {
        return (Math.Sqrt((double)((x-CenterX) * (x-CenterX) + (y-CenterY) * (y-CenterY))) <= (double)Radius);
    }
}