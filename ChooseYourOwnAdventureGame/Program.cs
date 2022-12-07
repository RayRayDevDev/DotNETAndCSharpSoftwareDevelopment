using static System.Console;

class MainClass
{
    public static void Main()
    {
        Story newStory = new Story();
        newStory.Initialization();
    }

    public static void WaitForKey()
    {
        WriteLine("\n\nPress any key to continue...");
        ReadKey();
        Clear();
    }
}