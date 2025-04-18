using System.Diagnostics;

namespace Lab11;

public class Snake
{
    public string? Name{get; set;} //player's name
    public List<IGraphic2D> Body {get; set;} //list of cells ocupied by the head and tail
    // current direction not sure how to make a property for that yet.
    public Board Board {get; set;} // refrence to a board
    public Cell Head{get; set;}
    public Cell Tail{get; set;}
    Dircetions Current{get; set;}
    public decimal MoveX{get; set;}
    public decimal MoveY{get; set;}

    public Snake(string? name)
    {
        Name = name;

        Head = new Cell(MoveX, MoveY){BackgroundColor = ConsoleColor.Green, DisplayChar = '>'};
        Tail = new Cell(MoveX, MoveY - 1) {BackgroundColor = ConsoleColor.Green, DisplayChar = '<'};

        Body = new List<IGraphic2D>
        {
            Head,Tail
        };
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
            MoveY = MoveY - 1;
            break;
            case Dircetions.South:
            MoveY = MoveY + 1;
            break;
            case Dircetions.West:
            MoveX = MoveX - 1;
            break;
            case Dircetions.East:
            MoveX = MoveX + 1;
            break;
        }
        list = new List<IGraphic2D>
        {
            Head,Tail
        };

    Console.Clear();
    AbstractGraphic2D.Display(list);
    }

    enum Dircetions{North,South, East, West};
}