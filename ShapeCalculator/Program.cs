// Include namespace system
using System;
using System.IO;

// Importing for userInput.
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
            double finalArea;
            Rectangle zeroArgRect = new Rectangle();
            // Call first 0 arg constructor for class Rectangle and initialize all values to "0." 
            Circle zeroArgCircle = new Circle();
            // Call first 0 arg constructor for class Circle and initialize all values to "0."
            Console.WriteLine($"The current length of a Rectangle stored in memory is: {zeroArgRect.getLength()}.");
            // Show all values are, indeed, initialized to 0 per the first constructor. 
            Console.WriteLine($"The current width of a Rectangle stored in memory is: {zeroArgRect.getWidth()}.");
            Console.WriteLine($"The current radius of a Circle stored in memory is: {zeroArgCircle.getRadius()}.");
            var userInput = "Inputs";
            Console.WriteLine("Please type a number to select an option:\n1. Compute the area of a Rectangle\n2. Compute the area of a Circle");
            // Menu for the user's menu choice.
            var userChoice = Convert.ToInt64(Console.ReadLine());
            if (userChoice == 1)
            {
                Console.Write("Please enter the length of the rectangle: ");
                userLength = Convert.ToDouble(Console.ReadLine());
                Rectangle.setLength(userLength);
                Console.Write("Please enter the width of the rectangle: ");
                userWidth = Convert.ToDouble(Console.ReadLine());
                Rectangle.setWidth(userWidth);
                var twoArgRect = new Rectangle(userLength, userWidth);
                // Pass the two variables storing the user's input into the overloaded constructor.
                finalArea = twoArgRect.computeArea();
                // Compute the area using the stored variables from the new constructor which took in the previous two arguments and store it in a variable.
                Console.WriteLine($"The area of a Rectangle with length {twoArgRect.getLength()} and width {twoArgRect.getWidth()} is: {finalArea}.");
            }
            else if (userChoice == 2)
            {
                Console.Write("Please enter the radius of the Circle: ");
                userRadius = Convert.ToDouble(Console.ReadLine());
                Circle.setRadius(userRadius);
                var oneArgCircle = new Circle(userRadius);
                // Pass the variable into the overloaded constructor.
                finalArea = oneArgCircle.computeArea();
                // Compute the area using the stored variables from the new constructor which took in the previous argument and store it in a variable.
                Console.WriteLine($"The area of a Circle with radius {oneArgCircle.getRadius()} is: {finalArea}.");
            }
            else
            {
                Console.WriteLine("You did not make a valid selection. Please try again.");
            }
        }
        catch (Exception e)
        {
            // Catch the aforementioned exceptions.
            Console.WriteLine("You did not enter a valid input. Please try again.");
        }
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
    public static void setLength(double userLength)
    {
        Rectangle.length = userLength;
    }
    public double getLength()
    {
        return Rectangle.length;
    }
    public static void setWidth(double userWidth)
    {
        Rectangle.width = userWidth;
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
    public static void setRadius(double userRadius)
    {
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