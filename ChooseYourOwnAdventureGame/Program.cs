using static System.Console;

//Created by Cole Stanley (RäDev) for CEN 4370C on 12/05/2022, 12/06/2022, and 12/07/2022.
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