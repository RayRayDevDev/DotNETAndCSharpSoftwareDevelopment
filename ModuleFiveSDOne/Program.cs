using static System.Console;

class Fibonacci
{
    public static void Main(string[] args)
    {
        
        Iterative();
        Recursive();
    }

    private static void Recursive()
    {
        Write("How many results would you like outputted? ");
        int userInput = Convert.ToInt32(ReadLine());
        FibonacciRecursive(0, 1, 1, userInput);
    }

    private static void FibonacciRecursive(int n1, int n2, int n3, int userInput)
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