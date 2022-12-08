using static System.Console;

//Created by Cole Stanley (RäDev) for CEN 4370C on 12/05/2022, 12/06/2022, and 12/07/2022.
//This program takes in a String representing the user's name and then displays a simple menu.
//This simple menu allows the user to either play the game, or exit the program altogether.
//When the user plays the game, they are taken through a very basic "choose your own adventure" style story.
//At the conclusion of whatever branch the user chooses, a TextWriter object is created and saves the entire story to a text file.
//This file is currently saved to /bin of the project directory.
//Upon opening the file, the user is presented with the entire story they had just created, which will refresh on every playthrough automatically unless they save the file separately.
//The user is finally presented with the menu indefinitely until they press the number '2'.
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