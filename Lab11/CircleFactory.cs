namespace Lab11;

public class CirlceFactory : IGrahic2DFactory
{
    public string Name { get => "Circle"; set => value = "Circle";}
    public IGraphic2D Create()
    {
        Console.WriteLine("What X value would you like for the center?");
        string? XString = Console.ReadLine() ;
        while (CanBeDecimal(XString) == false)
        {
            XString = Console.ReadLine();
        }
        decimal XDecimal = Convert.ToDecimal(XString);
        Console.WriteLine("What Y value would you like for the center?");
        string? YString = Console.ReadLine();
        while (CanBeDecimal(YString) == false)
        {
            YString = Console.ReadLine();
        }
        decimal YDecimal = Convert.ToDecimal(YString);
        Console.WriteLine("What Radius would you like for the circle?");
        string? RadiusString = Console.ReadLine();
        while(CanBeDecimal(RadiusString) == false)
        {
            RadiusString = Console.ReadLine();
        }
        decimal RadiusDecimal = Convert.ToDecimal(RadiusString);
        return new Circle(XDecimal, YDecimal, RadiusDecimal){ BackgroundColor = ConsoleColor.Green, ForegroundColor = ConsoleColor.Red, DisplayChar = ' '};
    }
    public static bool CanBeDecimal(string? Input)
    {
        try
        {
            if(Input == null)
            {
                return false;
            }else
            {
                Convert.ToDecimal(Input);
                return true;
            }
        }catch(FormatException e)
        {
            Console.WriteLine(e.Message);
            return false;
        }
    }
}