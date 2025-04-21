using Lab11;

Board biggest = new Board(54, 215); // biggest grid we want is the height to be 54 and the width to be 215
Snake test = new Snake("me", 2, 2, biggest);
biggest.snakes.Add(test);

Console.WriteLine("I highly recommend making the terminal full screen. Press any button to continue");
Console.ReadKey();

Console.Clear();
AbstractGraphic2D.Display(biggest.Display);
AbstractGraphic2D.Display(test.Body);
while(true)
{
    switch (Console.ReadKey(true).Key)
    {
        case ConsoleKey.D:
        test.turnEast();
        break;
        case ConsoleKey.W:
        test.turnNorth();
        break;
        case ConsoleKey.A:
        test.turnWest();
        break;
        case ConsoleKey.S:
        test.turnSouth();
        break;
    }
    test.moveForward(test.Body);

    if(test.Head.X == biggest.Apple.X && test.Head.Y == biggest.Apple.Y)
    {
        biggest.NextApple();
    }

    Console.Clear();
    AbstractGraphic2D.Display(biggest.Display);
    AbstractGraphic2D.Display(test.Body);
}