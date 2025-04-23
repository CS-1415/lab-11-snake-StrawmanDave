using Lab11;

Board biggest = new Board(54, 215); // biggest grid we want is the height to be 54 and the width to be 215
Snake test = new Snake("me", 3, 2, biggest);
biggest.snakes.Add(test);

Console.WriteLine("I highly recommend making the terminal full screen. Press any button to continue");
Console.ReadKey();

Console.Clear();
AbstractGraphic2D.Display(biggest.Display);
AbstractGraphic2D.Display(test.Body);


do
{
    while(!Console.KeyAvailable)
    {
        test.moveForward();
        Console.Clear();
        AbstractGraphic2D.Display(biggest.Display);
        AbstractGraphic2D.Display(test.Body);
        Thread.Sleep(125);
    }
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
}while(true);