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
                var userInputLength = Convert.ToInt32(Console.ReadLine());
                var userInputWidth = Convert.ToInt32(Console.ReadLine());
                Rectangle newRectangle = new Rectangle();
                newRectangle.area(userInputLength, userInputWidth);
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

internal class Rectangle : Shape //Sealed to prevent inheritance from the subclasses.
{
    public double area() { return sideLength * sideWidth; }
}

sealed class Square : Shape
{
    public double area() { return Pow(sideLength, 2); }
}

sealed class Circle : Shape
{
    public double area() { return PI * Pow(radius, 2); }
}

