namespace Lab11;

public class Snake
{
    public string? Name{get; set;} //player's name
    public List<IGraphic2D> Body {get; set;} //list of cells ocupied by the head and tail
    public Board Board {get; set;} // refrence to a board
    public Cell Head{get; set;}
    public Cell Tail{get; set;}
    Dircetions Current{get; set;}
    public decimal MoveX{get; set;}
    public decimal MoveY{get; set;}

    public Snake(string? name , decimal movex, decimal movey, Board board)
    {
        Name = name;
        MoveX = movex;
        MoveY = movey;

        Head = new Cell(MoveX, MoveY){BackgroundColor = ConsoleColor.Green, DisplayChar = '>'};
        Tail = new Cell(Head.X - 1, Head.Y) {BackgroundColor = ConsoleColor.Green, DisplayChar = '>'};

        Body = new List<IGraphic2D>
        {
            Tail,Head
        };
        Board = board;
        Board.snakes.Add(this);
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
        switch (Current)
        {
            case Dircetions.North:
            if(canMove(MoveX, MoveY - 1, Board) == true)
            {
                MoveY = MoveY - 1;
                
                newCell = new Cell(MoveX,MoveY){BackgroundColor = ConsoleColor.Green, DisplayChar = '^'};
            }
            break;
            case Dircetions.South:
            if(canMove(MoveX,MoveY + 1, Board) == true)
            {
                MoveY = MoveY + 1;
                
                newCell = new Cell(MoveX, MoveY){BackgroundColor = ConsoleColor.Green, DisplayChar = 'v'};
            }
            break;
            case Dircetions.West:
            if(canMove(MoveX -1,MoveY,Board) == true)
            {
                MoveX = MoveX - 1;
                
                newCell = new Cell(MoveX,MoveY){BackgroundColor = ConsoleColor.Green, DisplayChar = '<'};
            }
            break;
            case Dircetions.East:
            if(canMove(MoveX + 1,MoveY, Board) == true)
            {
                MoveX = MoveX + 1;
                
                newCell = new Cell(MoveX, MoveY){BackgroundColor = ConsoleColor.Green, DisplayChar = '>'};
            }
            break;
        }
        if(canMove(MoveX,MoveY, Board) != false)
        {
            if(MoveX == Board.Apple.X && MoveY == Board.Apple.Y)
            {
                Body.Add(newCell);
                Board.NextApple();
            }else
            {
                Body.Remove(Body[0]);
                Body.Add(newCell);
            }
        }
        
    }

    public bool canMove(decimal movex, decimal movey, Board on)
    {
        return (movex > 0 && movex < Board.Width && movey > 0 && movey < Board.Height);
    }

    enum Dircetions{North,South, East, West};
}