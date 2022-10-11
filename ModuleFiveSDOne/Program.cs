using System.Diagnostics;
using static System.Console;

//Created by Cole Stanley (RäDev) for CEN 4370C on 10/07/2022 and 10/10/2022.

class Fibonacci
{
    private static int userSelection;

    public static void Main(string[] args)
    {
        Write($"Please select \"1\" to view the iterative example of the Fibonacci sequence. Press \"2\" to view the recursive example of the Fibonacci sequence. ");
        userSelection = Convert.ToInt32(ReadLine());
        if (userSelection == 1)
        {
            Iterative();
        }
        else if (userSelection == 2)
        {
            Recursive();
        }
        else
        {
            WriteLine("You did not make a valid selection. Please relaunch the program and try again.");
            WaitForKey();
        }
    }

    private static void Recursive()
    {
        Write("How many results would you like outputted? ");
        int userInput = Convert.ToInt32(ReadLine());
        long startTid = Stopwatch.GetTimestamp();
        FibonacciRecursive(0, 1, 1, userInput);
        long pausTid = Stopwatch.GetTimestamp();
        WriteLine($"It took {pausTid - startTid} milliseconds to calculate {userInput} results! ");
        WaitForKey();
    }

    private static void FibonacciRecursive(long n1, long n2, long n3, int userInput)
    {
        WriteLine($"{n1}");
        if (n3 < userInput)
        {
            FibonacciRecursive(n2, n1 += n2, n3 += 1, userInput);
        }
    }

    private static void Iterative()
    {
        Write("How many results would you like outputted? ");
        int userInput = Convert.ToInt32(ReadLine());
        long n1 = 0, n2 = 1;
        long startTid = Stopwatch.GetTimestamp();
        WriteLine($"{n1}");
        WriteLine($"{n2}");
        for (int i = 2; i < userInput; i++)
        {
            long n3 = n1 += n2;
            WriteLine($"{n3}");
            n1 = n2;
            n2 = n3;
        }

        long pausTid = Stopwatch.GetTimestamp();
        WriteLine($"It took {pausTid - startTid} milliseconds to calculate {userInput} results! ");
    }

    private static void WaitForKey()
    {
        WriteLine("Press any key to continue...");
        ReadKey();
    }
}