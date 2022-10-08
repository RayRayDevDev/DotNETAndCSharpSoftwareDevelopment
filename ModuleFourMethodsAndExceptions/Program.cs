using static System.Console;

//Created by Cole Stanley (RäDev) for CEN 4370C on 10/07/2022.

class AreaCalculator
{
    public static void Main(string[] args)
    {
        UserSelectionScreen();
    }

    private static void UserSelectionScreen()
    {
        int userSelection = 0;
        WriteLine("Welcome to the area calculator!\nPlease type the number corresponding to the action you'd like to perform:");
        WriteLine("1. Calculate the area of a circle.\n2. Calculate the area of a square.\n3. Calculate the area of a rectangle.");
        Write("Please type your selection: ");
        try
        {
            userSelection = Convert.ToInt32(ReadLine());
        }
        catch (FormatException)
        {
            Clear();
            WriteLine("Yikes! You should've entered a number! Please relaunch the program and try again!");
            WaitForKey();
            Environment.Exit(1);
        }
        
        WriteLine(Calculations(userSelection));

    }
    private static string Calculations(int userSelection) 
    {
        string value = null;
        double r = 0;
        double l = 0;
        double w = 0;
        try
        {
            
            switch (userSelection)
            {
                case 1:
                    Write("Please enter the circle's radius: ");
                    try
                    {
                        r = Convert.ToDouble(ReadLine());
                    }
                    catch (FormatException)
                    {
                        Clear();
                        WriteLine("Yikes! You should've entered a number! Please try again!");
                        WaitForKey();
                        Clear();
                        UserSelectionScreen();
                    }
                    value = Convert.ToString($"The area of the circle is: {Math.PI * (r * r)}");
                     break;
                case 2:
                    Write("Please enter the length of the square's side: ");
                    try
                    {
                        l = Convert.ToDouble(ReadLine());
                    }
                    catch (FormatException)
                    {
                        Clear();
                        WriteLine("Yikes! You should've entered a number! Please try again!");
                        WaitForKey();
                        Clear();
                        UserSelectionScreen();
                    }
                    value = Convert.ToString($"The area of the square is: {l * l}");
                     break;
                case 3:
                    try
                    {
                        Write("Please enter the rectangle's length: ");
                        l = Convert.ToDouble(ReadLine());
                        Write("Now, please enter the rectangle's width: ");
                        w = Convert.ToDouble(ReadLine());
                    }
                    catch (Exception)
                    {
                        Clear();
                        WriteLine("Yikes! You should've entered a number! Please try again!");
                        WaitForKey();
                        Clear();
                        UserSelectionScreen();
                    }
                    value = Convert.ToString($"The area of the rectangle is: {l * w}");
                     break;
                default:
                    WriteLine("That is not a valid selection. Please make a valid selection and try again.");
                     break;
            }
        }
        catch (FormatException)
        {
            
        }

        return value;
    }

    private static void WaitForKey()
    {
        WriteLine("\nPress any key to continue...");
        ReadKey();
    }
}