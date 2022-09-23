using static System.Console; //Because typing "Console" every time isn't particularly fun.
using static System.Net.Mime.MediaTypeNames;

//Created by Cole Stanley (RäDev) for CEN 4370C on 09/09/2022. UPDATED on 09/11/2022 due to incorrect implementation of the Sum() function such that the returned results were not accurate. Additionally, the incorrect implementation of the switch function caused the user to be unable to exit the program when entering the correct number. Both of these issues have been fixed alongside code numerous other improvements.
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
        while (willContinue) //Loop so the user doesn't have to keep relaunching the program after one series of inputs/one selection.
        {
            WriteLine("\nYou may exit the program anytime during this process by typing the letter 'e'.");
            string[] numbers = new string[5]; //Array to hold the user's entries.
            for (int i = 0; i < numbers.Length; i++) //Loop to collect user's entries.
            {
                Write("\nPlease enter a number: ");
                string prompt = ReadLine().Trim(); //Reading the user's entries.

                    if (prompt.ToLower() == "e") //UPDATED: entering 'e' or 'E' in any input field exits the program in this portion of the program.
                    {
                        System.Environment.Exit(0);
                    }
                    else if (string.IsNullOrEmpty(prompt)) //UPDATED: Preventing a Format Exception if the user just presses ENTER without supplying an integer.
                    {
                        WriteLine("Oops! Looks like you didn't enter anything. Please try again!");
                        if (i == 0) //UPDATED: Prevents any exception if the user tries to press ENTER while still in the first index of the array.
                        {
                            continue;
                        }
                        else 
                        {
                            i--; //UPDATED: Subtracts i in the for loop so the user can only ever enter five numbers, preventing an IndexOutofRange Exception.
                            continue;
                        }
                    }
                    numbers[i] = prompt; //Storing user's entries in the array.
            }

            bool continueWithCurrentArray = true;
            while (continueWithCurrentArray) //UPDATED: Loop to allow multiple selections with the same array of numbers.
            {
                Clear();
                WriteLine("\nPlease utilize the corresponding number for the operation you wish to perform:\n1. Sum the entered numbers\n2. Average the entered numbers\n3. Both Sum and Average the entered numbers.\n4. Restart and use different numbers.\n5. Exit the program.");
                Write("Please make your selection: "); //UPDATED: Cleaner selection prompting. 
                try
                {
                    userChoice = Convert.ToInt32(Console.ReadLine()); //Converting string representation of the number entered into its int representation. 

                }
                catch (FormatException e)
                {
                    Clear();
                    WriteLine("\nUh oh! You did not enter a valid input. Please only use the numbers '1-5' and try again.");
                    WaitForKey();
                    continue;
                }

                switch
                    (userChoice) //Switch statement to determine if wants to sum, average, sum AND average, restart the entire process, or exit the loop.
                                //UPDATED: Calling Clear() keeps the focus on the results. Calling ReadKey() allows the user to see the program's output clearly.
                               //UPDATED: Pressing any key will clear the screen and bring up the menu again, from which the user may select a different number, or exit the program altogether. 
                {
                    case 1 when userChoice == 1:
                        double sum = Sum(numbers);
                        Clear();
                        if (sum == 0) //UPDATED: Since the sum will always equal "0" when a Format Exception occurs and is unlikely to be the answer a user will receive when using the program as intended, it is used to break out of the loop and restart the program as a result.
                        {
                           continueWithCurrentArray = false;
                           break;
                        }
                        WriteLine($"\nThe sum of the entered numbers is: {sum}");
                        WaitForKey(); //Wait for the user to press any key to continue. 
                        Clear();
                        break;
                    case 2 when userChoice == 2:
                        double avg = Avg(numbers);
                        Clear();
                        if (avg == 0) //UPDATED: Since the avg will always equal "0" when a Format Exception occurs and is unlikely to be the answer a user will receive when using the program as intended, it is used to break out of the loop and restart the program as a result.
                        {
                            continueWithCurrentArray = false;
                            break;
                        }
                        WriteLine($"\nThe average of the entered numbers is: {avg}");
                        WaitForKey();
                        Clear();
                        break;
                    case 3 when userChoice == 3:
                        sum = Sum(numbers);
                        avg = Avg(numbers);
                        Clear();
                        WriteLine($"\nThe sum of the entered numbers is: {sum}.\nThe average of the entered numbers is: {avg}.");
                        WaitForKey();
                        Clear();
                        break;
                    case 4 when userChoice == 4: //UPDATED: Exit the current loop and restart the array insertion process.
                        continueWithCurrentArray = false;
                        Clear(); //UPDATED: Clear the console since we're done with the old array and it just clutters up the console.
                        break;
                    case 5 when userChoice == 5: //UPDATED: Set both the inner and outer bools to false, thereby exiting the Main method and exiting the program as a result.
                        continueWithCurrentArray = false;
                        willContinue = false;
                        Clear();
                        Write("Press any key to exit...");
                        ReadKey();
                        break;
                    default:
                        Clear();
                        WriteLine("\nUh oh! You did not enter a valid input. Please only use the numbers '1-5' and try again.");
                        WaitForKey();
                        Clear();
                        continue;
                }
            }
        }
    }

    private static double Sum(string[] numbers) //Pass in the array of user inputted numbers.
    {
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++) //UPDATED: The previous version of the program did not update i, causing the program to not properly add the indices of the array together.
        {
            try //UPDATED: Try...catch block for any Format Exceptions.
            {
                sum += Convert.ToDouble(numbers[i]);

            }
            catch (FormatException e) //When a Format Exception occurs, clear the console, Write the message to the screen, clear the array completely since it cannot be used with incorrectly formatted data, and wait for the user to press any key. 
            {
                Clear();
                WriteLine($"\nUh oh! Looks like you entered an invalid character! Please try again.\n");
                Array.Clear(numbers, i, numbers.Length);
                WaitForKey();
            }
        }
        return sum;

    }

    private static double Avg(string[] numbers)
    { 
        int i = 0;
        double sum = 0;
        double avg = 0;

        try
        {
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
        }
        catch (FormatException e) //When a Format Exception occurs, clear the console, Write the message to the screen, clear the array completely since it cannot be used with incorrectly formatted data, and wait for the user to press any key.
        {
            Clear();
            WriteLine($"\nUh oh! Looks like you entered an invalid character! Please try again.\n");
            Array.Clear(numbers, i, numbers.Length);
            WaitForKey();
        }
        return Math.Round(avg, 2); //Round the final number to two decimal points and return it to the calling function.
    }

    private static void WaitForKey() //Easier implementation than doing it manually. 
    {
        Write("\nPress any key to continue...");
        ReadKey();
        Clear();
    }
}