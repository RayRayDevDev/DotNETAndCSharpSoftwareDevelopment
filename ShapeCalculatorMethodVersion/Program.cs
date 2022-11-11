using static System.Console;
using static System.Math;

//This program was created by Cole Stanley (RäDev) on 10/10/2022 and 10/11/2022.
//This program presents the user with a console-based menu.
//Users type in the number which corresponds to the calculation they want to perform.
//Next, the users type in the appropriate measurements and, afterwards, the answer is printed to the console.
//The user can keep making calculations until they press the number 4, which terminates the program.
//This program makes use of inheritance.
class MainClass
{
    private static readonly String userMenu = $"Welcome! Please use your number pad to make a selection:\n1. Compute the area of a Rectangle\n2. Compute the area of a Square\n3. Compute the area of a Circle\n4. Exit ";
    public static void Main()
    {
        var userChoice = 0;

        while (userChoice != 4)
        {
            Write(userMenu);
            userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    Clear();
                    Write("Please enter the rectangle's length: ");
                    var userInputLength = Convert.ToDouble(ReadLine());
                    Write("Please enter the rectangle's width: ");
                    var userInputWidth = Convert.ToDouble(ReadLine());
                    Rectangle newRectangle = new Rectangle(userInputLength, userInputWidth);
                    WriteLine($"\nThe area of a rectangle with a length of {userInputLength} and a width of {userInputWidth} is {newRectangle.area()}.");
                    WaitForKey();
                    break;
                case 2:
                    Clear();
                    Write("Please enter the length of one of the square's sides: ");
                    var userInputSideOfSquare = Convert.ToDouble(ReadLine());
                    Square newSquare = new Square(userInputSideOfSquare);
                    WriteLine($"\nThe area of a square with a side of length {userInputSideOfSquare} is {newSquare.area()}.");
                    WaitForKey();
                    break;
                case 3:
                    Clear();
                    Write("Please enter the circle's radius: ");
                    var userInputRadius = Convert.ToDouble(ReadLine());
                    Circle newCircle = new Circle(userInputRadius);
                    WriteLine($"\nThe area of a circle with a radius of {userInputRadius} is {newCircle.area()}.");
                    WaitForKey();
                    break;
            }
        }
        
    }

    protected static void WaitForKey()
    {
        WriteLine("\n\nPress any key to continue...");
        ReadKey();
        Clear();
    }
}
class Shape
{
    protected double sideLength { get; set; } = 0;
    protected double sideWidth { get; set; } = 0;
    protected double radius { get; set; } = 0;
    public Shape(double sideLength = 0, double sideWidth = 0, double radius = 0) //Optional parameters as not all are used.
    {
        this.sideLength = sideLength;
        this.sideWidth = sideWidth;
        this.radius = radius;
    }
}

sealed class Rectangle : Shape
{

    public Rectangle(double sideLen, double sideWit) : base(sideLength: sideLen, sideWidth: sideWit) {}
    public double area() { return sideLength * sideWidth; }
}

sealed class Square : Shape
{
    public Square(double sideLen) : base(sideLength: sideLen) {}
    public double area() { return Pow(sideLength, 2); }
}

sealed class Circle : Shape
{
    public Circle (double radius) : base(radius: radius) {}
    public double area() { return PI * Pow(radius, 2); }
}

