using System.Diagnostics;

namespace Lab11;

public class Snake
{
    public string? Name{get; set;} //player's name
    public List<Cell> Body {get; set;} //list of cells ocupied by the head and tail
    // current direction not sure how to make a property for that yet.
    public Board Board {get; set;} // refrence to a board
    public Cell Head{get; set;}
    public Cell Tail{get; set;}
    Dircetions Current{get; set;}

    public Snake(string? name)
    {
        Name = name;
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
        switch (Current)
        {
            case Dircetions.North:
            // Head = Board CellY + 1;
            // if(Head = Board.Apple) skip
            // Tail = Body list next cell;
            break;
            case Dircetions.South:
            // Head = Board CellY -1;
            // if(Head = Board.Apple) skip
            // Tail = Body list next cell;
            break;
            case Dircetions.West:
            // Head = Board CellX -1;
            // if(Head = Board.Apple) skip
            // Tail = Body list next cell;
            break;
            case Dircetions.East:
            // Head = Board CellX +1;
            // if(Head = Board.Apple) skip
            // Tail = Body list next cell;
            break;
        }
    }

    enum Dircetions{North,South, East, West};
}