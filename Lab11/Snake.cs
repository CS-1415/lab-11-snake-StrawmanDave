using System.Security.Cryptography.X509Certificates;

namespace Lab11;

public class Snake
{
    public string? Name{get; set;} //player's name
    public List<IGraphic2D> Body {get; set;} //list of cells ocupied by the head and tail
    public List<IGraphic2D> Guts {get; set;}
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

        Head = new Cell(MoveX, MoveY){BackgroundColor = ConsoleColor.Green, DisplayChar = '.'};
        Tail = new Cell(MoveX -1, MoveY) {BackgroundColor = ConsoleColor.Green, DisplayChar = '<'};

        Body = new List<IGraphic2D>
        {
            Tail,Head,
        };
        Guts = new List<IGraphic2D>();
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

    public void moveForward(List<IGraphic2D> list)
    {
        switch (Current)
        {
            case Dircetions.North:
            if(canMove(MoveX, MoveY - 1, Board) == true)
            {
                MoveY = MoveY - 1;
                list.Clear();
                Tail = new Cell(Head.X, Head.Y){BackgroundColor = ConsoleColor.Green, DisplayChar = '.'};
                Head = new Cell(MoveX,MoveY){BackgroundColor = ConsoleColor.Green, DisplayChar = '>'};
                list = new List<IGraphic2D>
                {
                    Tail,Head,
                };
                Body = list;
            }
            break;
            case Dircetions.South:
            if(canMove(MoveX,MoveY + 1, Board) == true)
            {
                MoveY = MoveY + 1;
                list.Clear();
                Tail = new Cell(Head.X, Head.Y){BackgroundColor = ConsoleColor.Green, DisplayChar = '.'};
                Head = new Cell(MoveX,MoveY){BackgroundColor = ConsoleColor.Green, DisplayChar = '>'};
                list = new List<IGraphic2D>
                {
                    Tail,Head,
                };
                Body = list;
            }
            break;
            case Dircetions.West:
            if(canMove(MoveX -1,MoveY,Board) == true)
            {
                MoveX = MoveX - 1;
                list.Clear();
                Tail = new Cell(Head.X, Head.Y){BackgroundColor = ConsoleColor.Green, DisplayChar = '.'};
                Head = new Cell(MoveX,MoveY){BackgroundColor = ConsoleColor.Green, DisplayChar = '>'};
                list = new List<IGraphic2D>
                {
                    Tail,Head,
                };
                Body = list;
            }
            break;
            case Dircetions.East:
            if(canMove(MoveX + 1,MoveY, Board) == true)
            {
                MoveX = MoveX + 1;
                list.Clear();
                Tail = new Cell(Head.X, Head.Y){BackgroundColor = ConsoleColor.Green, DisplayChar = '.'};
                Head = new Cell(MoveX,MoveY){BackgroundColor = ConsoleColor.Green, DisplayChar = '>'};
                list = new List<IGraphic2D>
                {
                    Tail,Head,
                };
                Body = list;
            }
            break;
        }
    }

    public bool canMove(decimal movex, decimal movey, Board on)
    {
        return (movex > 0 && movex < Board.Width && movey > 0 && movey < Board.Height);
    }

    public bool EatenApple()
    {
        return Board.Apple.X == Head.X && Board.Apple.Y == Head.Y;
    }

    enum Dircetions{North,South, East, West};
}