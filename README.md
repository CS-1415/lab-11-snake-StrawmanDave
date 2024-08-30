# Lab-11-Snake-

Lab 11 - Design Patterns Drawing App
General Learning Objectives

Use a modern operating system and utilities.

Use an integrated development environment to develop a program.

Solve problems and develop programs using the control structures of sequence, selection, and repetition, following a disciplined approach.

Objectives
Consider some design challenges and the idea of "design patterns" to help solve them.
Practice polymorphism.
Step 1: Setup Basic Environment and Copy Code From Previous Drawing Lab
Accept the GitHub Classroom Assignment.
Clone the associated repo.
Copy and add your working code from the Polymorphic Drawing lab into your new repo folder.
Step 2: Read and Understand This Overview

In this lab, you will begin to develop a multi-player snake game (if you've never played snake, look here: JavaScript Snake (patorjk.com) (Links to an external site.)).

Rules of the game:

The game has a board with a width, height, and a character that will be used to represent the apple. There are two snakes: one controlled by arrow keys and the other controlled by ASWD. Each time your snake eats an apple, the apple is moved to a random location and your tail grows by one. If your head runs into a wall or your opponent's tail, then your opponent wins. Both snakes advance whenever any key is pressed. Use Teams to ask clarifying questions about the game rules. Checkpoint requirements:

A UML diagram (25 points), test-cases (25 points), and implementation (50 points; see rubric) for the following datatypes: A Cell "struct" (or class if you prefer) holding a location on the board (e.g. Row and Column). A Board class that knows its length and width and the current position of the apple (as a Cell), and a list of Snake objects and that has a way to add a snake to the board and a way to move the apple. A Snake class that has the player's name, the List of Cells occupied by the head and tail, a current direction (represented however you want but that indicates one of up, down, left, right), and a reference to a Board. The Snake class needs to have methods that: turn left, right, up, or down move forward by one (appends the next cell in the current direction to the end of the occupied cell list and removes the first cell in the list [which is the end of the tail]; if the apple was eaten, then the end of the tail isn't removed; if the head runs into the wall or another player, then return false, otherwise return true) [the apple and collisions are optional this week] a test method (this will be useful to have as a member method so that you can inspect the elements of the list of occupied cells) Next week you will finish the game by creating the main method.

Make sure you have test cases that exercise all functionality and that your code meets the rubric guidelines, then submit and pass-off before the respective deadlines.

(update: multi-player is now for extra credit 5 points for last week and 5 points for this week's lab; If you choose not to do multi-player, then make sure that you output the player's snake length.)

Implement the main driver so that your Snake game is playable. Make sure that your print out a greeting with instructions and that the winner of the game is reported at the end. (You score will come from the 25-point rubric below multiplied by 4.)

You will just write the output to the console (with Console.SetCursorPosition, you can move the cursor to a specific position and then use Console.Write to print a character at that position). I used the following to allow me to check keyboard input and to update characters at arbitrary positions on the screen:

System.Console.ReadKey System.ConsoleKey.UpArrow System.ConsoleKey.D System.Console.SetCursorPosition System.Console.Write The following might help if you choose to have the snakes advance at time intervals rather than only when a button is pressed:

Sytem.Console.KeyAvailable System.Threading.Thread.Sleep Make sure you have test cases that exercise all functionality and that your code meets the rubric guidelines, then submit and pass-off before the respective deadlines.

Step 3: Create the Factory Interface
Create a new interface called IGraphic2DFactory with the following members:
A readonly, string-valued property Name which should be a string describing what type of graphic will be built (e.g. "Circle"). This will be displayed to the user in a menu so that they can select the type of shape they want to build.
A method Create() that requires no parameters and returns an object of type IGraphic2D. For example, for the CircleFactory this method would ask the user for the x-value of the center, the y-value of the center, and the radius of the circle. (Optionally, you could ask for the foreground and background colors).
Step 4: Implement Main
The main driver should start with a greeting to the user describing that the drawing program will iteratively allow the user to either draw or modify and existing drawing.
There should be the following local variables:
List<IGraphic2DFactory> availableShapeTypes which should be initialized with a list of instances of the available factories. (For now, that list should be empty since we haven't made any concrete factory types yet!)
List<IGraphic2D> builtShapes which should be initialized to an empty list representing a blank drawing.
The main menu should display the following options with associated numbers and allow the user to select by entering the corresponding number:
Display drawing should clear the screen, use AbstractGraphic2D.Display(List<IGraphic2D>) to render the current drawing, and then wait for the user to press enter (Console.ReadLine() is fine).
Add graphic should loop over the factories in availableShapeTypes and display the index and the Name, allow the user to enter an index, call the Create() method on the selected factory, and then add the resulting graphic to the builtShapes list.
Remove graphic should display the number of graphic objects in the current drawing, allow the user specify an index to remove, and then remove that graphic object from the builtShapes list.
Exit exit the program.
Step 5: Implement the concrete factories
Create classes RectangleFactory and CircleFactory that each implement the IGraphic2DFactory interface as described above.
Make sure that your main driver works properly.
Step 6: Optional enhancements to functionality and design

Consider how you would implement the following:

Extend your drawing app to support 10 additional shape types. How many files would you have change?
Allow the user to specify foreground and background colors for AbstractGraphic2D shapes without duplicating that code for each concrete subclass.
Enforce that there can only be one instance of each of the Factory classes. Anyone thinking the Singleton pattern here? ;-)
Add the option to edit an object's properties (again, not requiring the main-driver to know details about individual shape types).
Add the option to reorder the graphic components of the current drawing.
Add the option to display the list of available shape types in a variety of orders. For example, sort by name; sort by category; sort by complexity; sort by frequency of use, etc.
Create a Blazor-based version of the project.
Grading

Make sure the final version of your code is all added, committed, and pushed to github.

You may work in groups of two or three to complete this project, however, each individual will need to submit a repository.  Each individual should include comments in their code indicating which portions of the code they contributed to the final project. 

Grading must be done in person or via Teams with a TA or instructor.

Getting a TA or instructor to sign-off on your lab before you leave is the easiest and best way to get the best grade possible.
