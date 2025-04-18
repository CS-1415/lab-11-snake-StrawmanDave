using Lab11;
int moveX = 1;

List<IGraphic2D> shapes = new List<IGraphic2D> {
    new Circle(moveX, 1, 0.5m) { BackgroundColor = ConsoleColor.DarkYellow, DisplayChar = ' ' }, // yellow head
};

Console.Clear();
AbstractGraphic2D.Display(shapes);

// moveForward();
Console.Clear();
AbstractGraphic2D.Display(shapes);

Console.ReadKey();
moveForward(shapes);

while (true)
{
    switch (Console.ReadKey().Key)
    {
        case ConsoleKey.D:
        moveForward(shapes);
        break;
    }
}

void moveForward(List<IGraphic2D> list)
{
    moveX = moveX + 2;
    list = new List<IGraphic2D>
    {
        new Circle(moveX, 1, 0.5m){ BackgroundColor = ConsoleColor.DarkYellow, DisplayChar = ' '},
    };

    Console.Clear();
    AbstractGraphic2D.Display(list);
}