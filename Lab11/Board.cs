namespace Lab11;

public class Board
{
    public Cell[,]Grid{get; set;} // biggest grid we want is the height to be 54 and the width to be 215
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
        Grid = new Cell[Height,Width];
        
        Apple = RandomApple();
        snakes = new List<Snake>();

        Display = new List<IGraphic2D>
        {
            // new Rectangle(0,0,Width,Height){BackgroundColor = ConsoleColor.White, DisplayChar = ' '},
            Apple
        };
    }

    public Cell RandomApple()
    {
        int NextX = rand.Next(0,Width);
        int NextY = rand.Next(0,Height);

        while(!canBePlaced(NextX, NextY))
        {
            NextX = rand.Next(0,Width);
            NextY = rand.Next(0,Height);
        }

        return new Cell(NextX,NextY){ BackgroundColor = ConsoleColor.Red, DisplayChar = 'A'};
    }
    public void NextApple()
    {
        int NextX = rand.Next(0,Width);
        int NextY = rand.Next(0,Height);

        while(!canBePlaced(NextX, NextY) && !IsAtSnake())
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
        return x > 1 && x < Width && y > 1 && y < Height;
    }

    public bool IsAtSnake()
    {
        for (int i = 0; i < snakes.Count(); i++)
        {
            for(int j = 0; j < snakes[i].Body.Count; j++)
            {
                if(snakes[i].Body[j].Display() == Apple.Display())
                {
                    return false;
                }
            }
        }
        return true;
    }
}