using static System.Console; //Because typing "Console" every time isn't particularly fun.

//Created by Cole Stanley (RäDev) for CEN 4370C on 09/09/2022.
//This program takes in five inputs from the user in the form of an int or double, and then allows them to select whether they want to add, average, do both adding and averaging, or exit the program and do nothing.
//Created with .NET (C#) 6.0
class SumAvg
{
    private static int userChoice; //Field for user menu selection int.
    private static bool willContinue = true; //Field for while loop condition. Once the value is changed to "false" by the user, it will exit the loop.

    static void Main(string[] args)
    {
        Title = "Sum and Average Calculator";
        WriteLine(Title);
        while (willContinue) //Loop so one doesn't have to keep relaunching the program.
        {
            WriteLine("\nYou may exit the program at anytime by typing the letter 'e'.");
            string[] numbers = new string[5]; //Array to hold the user's numbers.
            for (int i = 0; i < numbers.Length; i++) //Loop to collect user's entries.
            {
                Write("\nPlease enter a number: ");
                string prompt = ReadLine().Trim(); //Reading user's entries.
                if (prompt.ToLower() == "e")
                {
                    System.Environment.Exit(0);
                }
                numbers[i] = prompt; //Storing user's entries in the array.
            }

            bool continueWithCurrentArray = true;
            while (continueWithCurrentArray) //UPDATED: Loop to allow multiple selections with the same array of numbers.
            {
                WriteLine("\nPlease utilize the corresponding number for the operation you wish to perform:\n1. Sum the entered numbers\n2. Average the entered numbers\n3. Both Sum and Average the entered numbers.\n4. Enter different numbers.\n5. Exit the program.");
                Write("Please make your selection: ");
                userChoice = Convert.ToInt32(Console.ReadLine()); //Converting string representation of the number entered into its int representation.

                switch
                    (userChoice) //Switch statement to determine if wants to sum, average, sum AND average, or exit the loop.
                {
                    case 1 when userChoice == 1:
                        double sum = Sum(numbers);
                        WriteLine($"\nThe sum of the entered numbers is: {sum}");
                        break;
                    case 2 when userChoice == 2:
                        double avg = Avg(numbers);
                        WriteLine($"\nThe average of the entered numbers is: {avg}");
                        break;
                    case 3 when userChoice == 3:
                        sum = Sum(numbers);
                        avg = Avg(numbers);
                        WriteLine(
                            $"\nThe sum of the entered numbers is: {sum}.\nThe average of the entered numbers is: {avg}.");
                        break;
                    case 4 when userChoice == 4: //UPDATED: Exit the current loop and restart the array insertion process.
                        continueWithCurrentArray = false;
                        Clear(); //UPDATED: Clear the console since we're done with the old array and it just clutters up the console.
                        break;
                    case 5 when userChoice == 5: //UPDATED: Exit the loop containing 
                        continueWithCurrentArray = false;
                        willContinue = false;
                        break;
                    default:
                        WriteLine("\nOops! Looks like you didn't make a valid choice! Please try again!");
                        continue;
                }
            }
        }
    }

    private static double Sum(string[] numbers) //Pass in the array of user inputted numbers.
    {
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += Convert.ToDouble(numbers[i]);

        }
        return sum;

    }

    private static double Avg(string[] numbers)
    {
        int i = 0;
        double sum = 0;
        double avg = 0;

        foreach (var j in numbers)
        {
            sum += Convert.ToDouble(numbers[i]);
            i++; //Increase i by the number of entries in the array. While not necessary for this particular assignment given the fixed index, I still wanted it to be implemented such that a variable amount of numbers may eventually be used instead.
        }

        if (i != 0) //prevent divide by zero exceptions.
        {
            avg = sum / i;
        }

        else
        {
            throw new DivideByZeroException("\nYikes! Something went wrong. Try again!"); //Throws an exception if i == 0 for some reason as my compiler stated at least one path could lead to this outcome.
        }
        return Math.Round(avg, 2); //Round the final number to two decimal points and return it to the calling function.
    }
}