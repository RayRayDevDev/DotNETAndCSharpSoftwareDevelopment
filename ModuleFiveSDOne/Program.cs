using static System.Console;

class Fibonacci
{
    private static int userSelection;

    public static void Main(string[] args)
    {
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
        }
    }

    private static void Recursive()
    {
        Write("How many results would you like outputted? ");
        int userInput = Convert.ToInt32(ReadLine());
        FibonacciRecursive(0, 1, 1, userInput);
    }

    private static void FibonacciRecursive(Int64 n1, Int64 n2, Int64 n3, int userInput)
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
        Int64 n1 = 0, n2 = 1;
        WriteLine($"{n1}");
        WriteLine($"{n2}");
        for (int i = 2; i < userInput; i++)
        {
            Int64 n3 = n1 += n2;
            WriteLine($"{n3}");
            n1 = n2;
            n2 = n3;
        }
    }

}