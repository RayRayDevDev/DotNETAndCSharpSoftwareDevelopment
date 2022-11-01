using System;
using static System.Console;

// Created by Cole Stanley (R?Dev)

public class WorkingMain
{
    public static void Main(String[] args)
    {
        try
        {
            double userLength;
            // Fields for User inputted length, width, radius, and the final area depending on the control statement executed.
            double userWidth;
            double userRadius;
            double userSideLength;
            double finalArea;
            Rectangle zeroArgRect = new Rectangle();
            // Call first 0 arg constructor for class Rectangle and initialize all values to "0." 
            Circle zeroArgCircle = new Circle();
            // Call first 0 arg constructor for class Circle and initialize all values to "0."
            Square zeroArgSquare = new Square();
            // Show all values are, indeed, initialized to 0 per the first constructor. 
            Console.WriteLine($"The current length of a Rectangle stored in memory is: {zeroArgRect.getLength()}.\n");
            Console.WriteLine($"The current width of a Rectangle stored in memory is: {zeroArgRect.getWidth()}.\n");
            Console.WriteLine($"The current radius of a Circle stored in memory is: {zeroArgCircle.getRadius()}.\n");
            Console.WriteLine($"The current length of a Square's side stored in memory is: {zeroArgSquare.getUserSideLength()}.\n\n");
            waitForKey();

            var userInput = "Inputs";
            Console.Write("Please type a number to select an option:\n1. Compute the area of a Rectangle\n2. Compute the area of a Circle\n3. Compute the area of a Square\n\nPlease type your selection: ");
            // Menu for the user's menu choice.
            var userChoice = Convert.ToInt32(Console.ReadLine());
            if (userChoice == 1)
            {
                Clear();
                Console.Write("Please enter the length of the rectangle: ");
                userLength = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please enter the width of the rectangle: ");
                userWidth = Convert.ToDouble(Console.ReadLine());
                var twoArgRect = new Rectangle(userLength, userWidth);
                // Pass the two variables storing the user's input into the overloaded constructor.
                finalArea = twoArgRect.computeArea();
                // Compute the area using the stored variables from the new constructor which took in the previous two arguments and store it in a variable.
                Clear();
                Console.WriteLine($"The area of a Rectangle with length {twoArgRect.getLength()} and width {twoArgRect.getWidth()} is: {finalArea}.");
                waitForKey();
            }
            else if (userChoice == 2)
            {
                Clear();
                Console.Write("Please enter the radius of the Circle: ");
                userRadius = Convert.ToDouble(Console.ReadLine());
                var oneArgCircle = new Circle(userRadius);
                // Pass the variable into the overloaded constructor.
                finalArea = oneArgCircle.computeArea();
                // Compute the area using the stored variables from the new constructor which took in the previous argument and store it in a variable.
                Clear();
                Console.WriteLine($"The area of a Circle with radius {oneArgCircle.getRadius()} is: {finalArea}.");
                waitForKey();
            }
            else if (userChoice == 3)
            {
                Clear();
                Console.Write("Please enter the length of one of the square's sides: ");
                userSideLength = Convert.ToDouble(Console.ReadLine());
                var oneArgSquare = new Square(userSideLength);
                finalArea = oneArgSquare.computeArea();
                Clear();
                WriteLine($"The area of a Square with side length {oneArgSquare.getUserSideLength()} is: {finalArea}");
                waitForKey();

            }
            else
            {
                Console.WriteLine("You did not make a valid selection. Please try again.");
                waitForKey();
            }
        }
        catch (Exception e)
        {
            // Catch the aforementioned exceptions.
            Console.WriteLine("You did not enter a valid input. Please try again.");
            waitForKey();
        }
    }

    private static void waitForKey()
    {
        Console.WriteLine("\n\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }
}
public class Rectangle
{
    private static double length;
    private static double width;
    public Rectangle()
    {
        // Initial constructor setting values to "0".
        Rectangle.length = 0;
        Rectangle.width = 0;
    }
    public Rectangle(double userLength, double userWidth)
    {
        // Overloaded constructor per requirements.
        Rectangle.length = userLength;
        Rectangle.width = userWidth;
    }
    public double getLength()
    {
        return Rectangle.length;
    }
    public double getWidth()
    {
        return Rectangle.width;
    }
    public double computeArea()
    {
        // Compute the area of the rectangle and return the result to the calling function.
        return Rectangle.length * Rectangle.width;
    }
}
public class Circle
{
    private static double radius;
    public Circle()
    {
        // Initial constructor setting the value to "0".
        Circle.radius = 0;
    }
    public Circle(double userRadius)
    {
        // Overloaded constructor per requirements. 
        Circle.radius = userRadius;
    }
    public double getRadius()
    {
        return Circle.radius;
    }
    public double computeArea()
    {
        // Compute the area of the circle and return the result to the calling function.
        return Math.PI * Math.Pow(Circle.radius, 2);
    }
}

public class Square
{
    private static double sideLength;
    public Square()
    {
        Square.sideLength = 0;
    }
    public Square(double userSideLength)
    {
        Square.sideLength = userSideLength;
    }
    public void setUserSideLength(double userSideLength)
    {
        Square.sideLength = userSideLength;
    }
    public double getUserSideLength()
    {
        return Square.sideLength;
    }
    public double computeArea()
    {
        return Math.Pow(getUserSideLength(), 2);
    }
}