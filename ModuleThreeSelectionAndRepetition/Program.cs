using static System.Console;

//Created by Cole Stanley (RäDev) for CEN 4370C on 09/22/2022. 
//This program takes in ten inputs from the user, in the form of a double (and, implicitly, an int) each prompt. The program then stores each input into an array that gets sorted in ascending order after all inputs are stored, outputting the smallest and largest value, respectively, to the console. The program then exits with status code 0. 
//Created with .NET (C#) 6.0

class MainProgram
{
    public static void Main(string[] args)
    {
        double[] numbers = new double[10];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i == 0)
            {
                Write("Howdy! I eat numbers. Gimme one: ");
            }
            else if (i >= 1 && i <= 3)
            {

                Write("More, MORE!: ");
            }
            else if (i >= 3 && i <= 7)
            {
                Write("HUNGRY! MOAR NUMBERS! ");
            }
            else if (i >= 7 && i <= 8)
            {
                Write("Ok, just ONE more, I promise: ");
            }
            else if (i == 9)
            {
                Write("Haha! I lied! Gimme moar: ");
            }
            string userInput = ReadLine();
            try
            {
                numbers[i] = Convert.ToDouble(userInput);

            }
            catch (FormatException e)
            {
                WriteLine("Uh oh! You didn't type a number. Please try again!");
                if (i >= 0) //Prevent subtracting i into negative territory. 
                {
                    i--;
                    continue;
                }
            }
        }
        Array.Sort(numbers);
        Clear();
        WriteLine($"The lowest value in this set is: {numbers[0]}");
        WriteLine($"The highest value in this set is: {numbers[9]}");
        Write("\n\nPress any key to exit..."); 
        ReadKey(); 
    }
}
