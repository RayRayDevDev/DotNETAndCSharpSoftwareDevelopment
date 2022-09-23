using static System.Console;

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
                if (i <= 0)
                {
                    i--;
                    continue;
                }
            }
        }
        Array.Sort(numbers);
        WriteLine(numbers[0]);
        WriteLine(numbers[9]);
    }
}
