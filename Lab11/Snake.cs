namespace Lab11;

public class Snake
{
    public string? Name{get; set;} //player's name
    public List<IGraphic2D> Body {get; set;} //list of cells ocupied by the head and tail
    public Board Board {get; set;} // refrence to a board
    public Dircetions Current{get; set;}
    public int MoveX{get; set;}
    public int MoveY{get; set;}
    public int snakeScore{get; set;}

    public event Action? KeyPressed;

    public Snake(string? name , int movex, int movey, Board board)
    {
        Name = name;
        MoveX = movex;
        MoveY = movey;
        Current = Dircetions.East;

        Body = new List<IGraphic2D>
        {
            new Cell(MoveX - 1, MoveY) {BackgroundColor = ConsoleColor.Green, DisplayChar = '>'},
            new Cell(MoveX, MoveY){BackgroundColor = ConsoleColor.Green, DisplayChar = '>'}
        };
        Board = board;
        Board.snakes.Add(this);
        snakeScore = 2;
    }

    public void turnWest()
    {
        Current = Dircetions.West;
    }

    public void turnEast()
    {
        Current = Dircetions.East;
    }

    public void turnNorth()
    {
        Current = Dircetions.North;
    }

    public void turnSouth()
    {
        Current = Dircetions.South;
    }

    public void moveForward()
    {
        Cell newCell = new Cell(0,0);
        switch(Current)
        {
            case Dircetions.North:
            if(canMove(MoveX, MoveY - 1) == true)
            {
                MoveY = MoveY - 1;
                
                newCell = new Cell(MoveX,MoveY){BackgroundColor = ConsoleColor.Green, DisplayChar = '^'};
            }
            break;
            case Dircetions.South:
            if(canMove(MoveX,MoveY + 1) == true)
            {
                MoveY = MoveY + 1;
                
                newCell = new Cell(MoveX, MoveY){BackgroundColor = ConsoleColor.Green, DisplayChar = 'v'};
            }
            break;
            case Dircetions.West:
            if(canMove(MoveX -1, MoveY) == true)
            {
                MoveX = MoveX - 1;
                
                newCell = new Cell(MoveX,MoveY){BackgroundColor = ConsoleColor.Green, DisplayChar = '<'};
            }
            break;
            case Dircetions.East:
            if(canMove(MoveX + 1,MoveY) == true)
            {
                MoveX = MoveX + 1;
                
                newCell = new Cell(MoveX, MoveY){BackgroundColor = ConsoleColor.Green, DisplayChar = '>'};
            }
            break;
        }

        if(canMove(MoveX,MoveY) != false)
        {
            if(MoveX == Board.Apple.X && MoveY == Board.Apple.Y)
            {
                snakeScore ++;
                Body.Add(newCell);
                while(isSnake(Board.Apple.X, Board.Apple.Y) == true)
                {
                    Board.NextApple();
                }
            }else
            {
                Body.Remove(Body[0]);
                Body.Add(newCell);
            }
        }else
        {
            Body = new List<IGraphic2D>(); // empty list the snake died and it is no more.
        }
    }

    public bool canMove(int movex, int movey)
    {
        return movex > 0 && movex < Board.Width && movey > 0 && movey < Board.Height && !isSnake(movex,movey);
    }

    public bool isSnake(decimal x, decimal y)
    {
        foreach (Cell cell in Body)
        {
            if (cell.X == x && cell.Y == y)
            {
                return true;
            }
        }
        return false;
    }

    public enum Dircetions{North,South, East, West};
}