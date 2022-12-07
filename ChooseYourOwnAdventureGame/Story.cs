using static System.Console;

public class Story
{
    public void MainStory(string userName)
    {
        Clear();
        WriteLine("You're the prince of a country in crisis, Rableonia.\n" +
                  "You're awakened by one of your advisers suddenly.\n" +
                  "He seems concerned, but you're tired.\n\n" +
                  "What will you do?");
        Write("1. Tell him to go away\n" +
              "2. Ask him what's wrong ");
        int userSelection = Convert.ToInt32(ReadLine());

        if (userSelection == 1) //Angry and annoyed timeline.
        {
            Clear();
            WriteLine($"You tell him to go away.\n\n" +
                      "He looks very confused by your outburst, but nevertheless persists:\n\n" +
                      $"\'But {userName}, they're trying to storm the castle!\' he protests.\n\n" +
                      "What will you do?\n");
            Write("1. \'Leave me alone to die then!\'\n\n" +
                  "2. \'Wait...WHAT?!\' ");
             userSelection = Convert.ToInt32(ReadLine());

            if (userSelection == 1)
            {
                Clear();
                WriteLine("Your adviser, now concerned primarily for his own safety and, seeing that you're not," +
                          " simply responds with: \'Ok\'\n");
                WriteLine("He runs out, being immediately met with a crowd of soldiers approaching your bedchamber.\n\n\n\n" +
                          "He is killed due to your selfishness.\n\n\n\n" +
                          "Not to worry, though, you're next.\n\n" +
                          "The soldiers find you in your bed and kill you as well.\n\n\n\n" +
                          "Maybe you should've listened to your adviser.");
                MainClass.WaitForKey();
            }
            else if (userSelection == 2)
            {
                

            }
            else
            {
                
            }
            {
                
            }
        }
        else if (userSelection == 2)
        {
            
        }
        else
        {
            
        }
    }

    public void Initialization()
    {
        Write("Please enter your name: ");
        var userName = ReadLine().Trim();
        Clear();
        int userChoice = 0;
        while (userChoice != 3)
        {
            try
            {
                WriteLine($"Welcome, {userName}!\nPlease enter the number that corresponds to your desired selection:\n" +
                      "1. New Game\n" +
                      "2. Load Game\n" +
                      "3. Exit");
                Write("Please make your selection: ");
                userChoice = Convert.ToInt32(ReadLine());

            }
            catch (FormatException)
            {
                Clear();
                WriteLine("Uh oh! That wasn't a valid selection! Please try again!");
                MainClass.WaitForKey();
                continue;
            }
            switch (userChoice)
            {
                case 1:
                    MainStory(userName);
                    break;
                case 2:
                    SaveAndLoadGame save = new SaveAndLoadGame();
                    save.loadGame();
                    break;
                case 3:
                    Clear();
                    WriteLine("Thanks for loading the game!\n\nGoodbye!");
                    MainClass.WaitForKey();
                    break;
                default:
                    Console.WriteLine("Uh oh! That's not a valid selection! Please try again!");
                    continue;
            }
        }
    }
}
