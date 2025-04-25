using Lab11;

Console.WriteLine("I highly recommend making the terminal full screen.");
Console.WriteLine("Welcome to the snake game eat apples to grow do not go off the screen and run into yourself.");
Console.WriteLine("Use the W, A, S, and D keys to change directions.");
Board biggest = new Board(54, 215); // biggest grid we want is the height to be 54 and the width to be 215
Console.WriteLine("What would you like your name to be?");
Snake player1 = new Snake(Console.ReadLine(), 3, 2, biggest);
biggest.snakes.Add(player1 );


Console.Clear();
AbstractGraphic2D.Display(biggest.Display);
AbstractGraphic2D.Display(player1 .Body);

bool lose = false;
do
{
    while(!Console.KeyAvailable)
    {
        try
        {
            player1.moveForward();
            Console.Clear();
            AbstractGraphic2D.Display(biggest.Display);
            AbstractGraphic2D.Display(player1.Body);
            Thread.Sleep(125);
        }catch(ArgumentOutOfRangeException)
        {
            //really interesting way to have the game end if you can't move then the snakes body will have nothing in it and then it will try to remove something.
            loseMenu();
            lose = true;
            break;
        }
    }
    if(lose == true)
    {
        continue;
    }
    switch (Console.ReadKey(true).Key)
    {
        case ConsoleKey.D:
        if(player1 .Current != Snake.Dircetions.West)
        {
            player1 .turnEast();
        }
        break;
        case ConsoleKey.W:
        if(player1 .Current != Snake.Dircetions.South)
        {
            player1 .turnNorth();
        }
        break;
        case ConsoleKey.A:
        if(player1 .Current != Snake.Dircetions.East)
        {
            player1 .turnWest();
        }
        break;
        case ConsoleKey.S:
        if(player1.Current != Snake.Dircetions.North)
        {
            player1.turnSouth();
        }
        break;
    }
}while(lose != true);


void loseMenu()
{
    Console.Clear();
    Console.WriteLine("You died");
    Console.WriteLine($" You {player1.Name} had a score of {player1.snakeScore}");
}