namespace Lab11;

public class Board
{
    // public Cell[,]Grid{get; set;} // biggest grid we want is the height to be 54 and the width to be 215
    public List<IGraphic2D> Display{get; set;}
    public int Height{get;set;}
    public int Width{get;set;}
    public Cell Apple{get;set;}
    public List<Snake> snakes{get; set;}
    Random rand = new Random();

    public Board(int height, int width)
    {
        Height = height;
        Width = width;
        // Grid = new Cell[Height,Width];
        
        Apple = new Cell(5,5) { BackgroundColor = ConsoleColor.Red, DisplayChar = 'A'};
        snakes = new List<Snake>();

        Display = new List<IGraphic2D>
        {
            // new Rectangle(0,0,Width,Height){BackgroundColor = ConsoleColor.White, DisplayChar = ' '},
            Apple
        };
    }

    public void NextApple()
    {
        int NextX = rand.Next(0,Width);
        int NextY = rand.Next(0,Height);

        while(!canBePlaced(NextX, NextY))
        {
            NextX = rand.Next(0,Width);
            NextY = rand.Next(0,Height);
        }
        
        Apple = new Cell(NextY, NextY){BackgroundColor = ConsoleColor.Red, DisplayChar = 'A'};
        Display.Clear();
        Display = new List<IGraphic2D>
        {
            Apple
        };
    }

    public bool canBePlaced(int x, int y)
    {
        return x > 1 && y > 1 && x < Width && y < Height;
    }
}