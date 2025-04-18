namespace Lab11;

public class RectangleFactory : IGraphic2DFactory
{
    public string Name { get => "Rectangle"; set => value = "Rectangle"; }

    public IGraphic2D Create()
    {
        Console.WriteLine("Where would you like the Top of the Rectangle to be?");
        string? TopString = Console.ReadLine();
        while (CanBeDecimal(TopString) == false)
        {
            TopString = Console.ReadLine();
        }
        decimal TopDecimal = Convert.ToDecimal(TopString);
        Console.WriteLine("Where would you like Left of the Rectangle to be?");
        string? LeftString = Console.ReadLine();
        while(CanBeDecimal(LeftString) == false)
        {
            LeftString = Console.ReadLine();
        }
        decimal LeftDecimal = Convert.ToDecimal(LeftString);
        Console.WriteLine("What would you like the height of the rectangle to be?");
        string? HeightString = Console.ReadLine();
        while(CanBeDecimal(HeightString) == false)
        {
            HeightString = Console.ReadLine();
        }
        decimal HeightDecimal = Convert.ToDecimal(HeightString);
        Console.WriteLine("What would you like the width of the rectangle to be?");
        string? WidthString = Console.ReadLine();
        while (CanBeDecimal(WidthString) == false)
        {
            WidthString = Console.ReadLine();
        }
        decimal WidthDecimal = Convert.ToDecimal(WidthString);
        return new Rectangle(LeftDecimal, TopDecimal, WidthDecimal, HeightDecimal){BackgroundColor = ConsoleColor.Red, ForegroundColor = ConsoleColor.Green, DisplayChar = ' '};
    }

    public static bool CanBeDecimal(string? Input)
    {
        try
        {
            if (Input == null)
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