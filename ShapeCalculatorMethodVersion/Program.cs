using static System.Console;
using static System.Math;

class MainClass
{
    private static readonly String userMenu = $"Welcome! Please use your number pad to make a selection:\n1. Compute the area of a Rectangle\n2. Compute the area of a Square\n3. Compute the area of a Circle\n4. Exit ";
    public static void Main()
    {
        Write(userMenu);
        var userChoice = Convert.ToInt32(Console.ReadLine());
        switch (userChoice)
        {
            case 1:
                var userInputLength = Convert.ToDouble(ReadLine());
                var userInputWidth = Convert.ToDouble(ReadLine());
                Rectangle newRectangle = new Rectangle(userInputLength, userInputWidth);
                WriteLine(newRectangle.area());
                break;
            case 2:
                var userInputSideOfSquare = Convert.ToDouble(ReadLine());
                Square newSquare = new Square(userInputSideOfSquare);
                WriteLine(newSquare.area());
                break;
            case 3:
                var userInputRadius = Convert.ToDouble(ReadLine());
                Circle newCircle = new Circle(userInputRadius);
                WriteLine(newCircle.area());
                break;
        }
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

    public Rectangle(double sideLen, double sideWit) : base(sideLength: sideLen, sideWidth: sideWit) { }
    public double area() { return sideLength * sideWidth; }
}

sealed class Square : Shape
{
    public Square(double sideLen) : base(sideLength: sideLen) { }
    public double area() { return Pow(sideLength, 2); }
}

sealed class Circle : Shape
{
    public Circle (double radius) : base(radius: radius) {}
    public double area() { return PI * Pow(radius, 2); }
}

