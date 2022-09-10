using static System.Console; //Because typing "Console" every time isn't particularly fun.

//Created by Cole Stanley (RäDev) for CEN 4370C on 09/09/2022.
//This program takes in five inputs from the user in the form of an int or double, and then allows them to select whether they want to add, average, do both adding and averaging, or exit the program and do nothing.
//Created with .NET (C#) 6.0
class SumAvg
{
    private static int userChoice; //Field for user menu selection int.
    private static bool willContinue = true; //Field for do...while loop condition. Once the value is changed to "false" by the user, it will exit the loop.

    static void Main(string[] args)
    {
        Title = "Sum and Average Calculator";
        WriteLine(Title);

        do //Loop so one doesn't have to keep relaunching the program.
        {
            string[] numbers = new string[5]; //Array to hold the user's numbers.
            for (int i = 0; i < numbers.Length; i++) //Loop to collect user's entries.
            {
                Write("Please enter a number: ");
                string prompt = ReadLine().Trim(); //Reading user's entries.
                numbers[i] = prompt; //Storing user's entries in the array.
            }

            WriteLine(
                "\nPlease select the corresponding number for the operation you wish to perform:\n1. Sum the inputted numbers\n2.Average the inputted numbers\n3. Both Sum and Average the inputted numbers.\n4. Exit.");
            userChoice = Convert.ToInt32(Console.ReadLine()); //Converting string representation of the number entered into an int representation.

            switch (userChoice) //Switch statement to determine if wants to sum, average, sum AND average, or exit the loop.
            {
                case 1 when userChoice == 1:
                    double sum = Sum(numbers);
                    WriteLine($"The sum of the inputted numbers is: {sum}");
                    break;
                case 2 when userChoice == 2:
                    double avg = Avg(numbers);
                    WriteLine($"The average of the inputted numbers is: {avg}");
                    break;
                case 3 when userChoice == 3:
                    sum = Sum(numbers);
                    avg = Avg(numbers);
                    WriteLine($"The sum of the inputted numbers is: {sum}.\nThe average of the inputted numbers is: {avg}.");
                    break;
                case 4 when userChoice == 4:
                    willContinue = false;
                    break;
                default:
                    WriteLine("Oops! Looks like you didn't make a valid choice! Please try again!");
                    break;
            }

        } while (willContinue);


    }

    private static double Sum(string[] numbers) //Pass in the array of user inputted numbers.
    {
        int i = 0;
        double sum = 0;
        foreach (var j in numbers) //Foreach loop to recursively add each number to itself.
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
            throw new DivideByZeroException("Something went wrong. Try again!"); //Throws an exception if i == 0 for some reason as my compiler stated at least one path could lead to this outcome.
        }
        return Math.Round(avg, 2); //Round the final number to two decimal points and return it to the calling function.
    }
}