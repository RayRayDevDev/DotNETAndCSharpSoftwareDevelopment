using System.Collections;
using static System.Console;

public class Story
{
    public void MainStory(string? userName = null)
    {
        ArrayList completeStory = new ArrayList();
        Clear();
        WriteLine("You're the prince of a country in crisis, Rableonia.\n" +
                  "You're awakened by one of your advisers suddenly.\n" +
                  "He seems concerned, but you're tired.\n\n" +
                  "What will you do?\n");
        Write("1. Tell him to go away ");
        int userSelection = Convert.ToInt32(ReadLine());

        if (userSelection == 1)
        {
            Clear();
            var initialPrompt = $"You tell him to go away.\n\n" +
                                "He looks very confused by your outburst, but nevertheless persists:\n\n" +
                                $"\'But {userName}, they're trying to storm the castle!\' he protests.\n\n";
            WriteLine(initialPrompt);
            WriteLine("What will you do?\n");
            completeStory.Add(initialPrompt);
            Write("1. \'Leave me alone to die then!\'\n" +
                  "2. \'Wait...WHAT?!\' ");
            userSelection = Convert.ToInt32(ReadLine());

            if (userSelection == 1)
            {
                Clear();
                var choiceOneOne =
                    "Your adviser, now concerned primarily for his own safety and, seeing that you're not," +
                    " simply responds with: \'Ok\'\n";
                var choiceOneTwo =
                    "He runs out, being immediately met with a crowd of soldiers approaching your bedchamber.\n\n\n\n" +
                    "He is killed due to your selfishness.\n\n\n\n" +
                    "Not to worry, though, you're next.\n\n" +
                    "The soldiers find you in your bed and kill you as well.\n\n\n\n" +
                    "Maybe you should've listened to your adviser.";
                WriteLine(choiceOneOne + choiceOneTwo);
                completeStory.Add(choiceOneOne + choiceOneTwo);
                SaveStoryToFile save = new SaveStoryToFile();
                save.saveStoryToFile(completeStory);
                MainClass.WaitForKey();
            }
            else if (userSelection == 2)
            {
                Clear();
                var choiceTwo = "You are all of a sudden awake and alert--How did this happen?\n\n" +
                                "\'What?! Why?\' you ask\n\n" +
                                "Your adviser looks at you sullenly:\n\n" +
                                "\'It's Iolo...he's trying to become king...at any cost...\n\n" +
                                "You immediately get out of bed and begin heading towards the door.\n\n" +
                                "Your adviser stops you suddenly.\n\n" +
                                "What will you do?\n\n\n\n";
                completeStory.Add(choiceTwo);
                WriteLine(choiceTwo);
                Write("1. 'Stand Aside!'\n" +
                      "2. 'What's wrong?' ");
                userSelection = Convert.ToInt32(ReadLine());

                if (userSelection == 1)
                {
                    Clear();
                    var choiceOne = "You push past your Adviser and open the door.\n\n" +
                                    "You're quickly confronted by the invading army just outisde your door.\n\n\n\n" +
                                    "'Well, that was easy' the soldier leading the pack stated, while taking out his sword.\n\n\n\n" +
                                    "You're killed on the spot.\n\n" +
                                    "By now, your adviser has escaped using a secret door in the corner of your room and successfully escapes!\n\n\n\n" +
                                    "Maybe you should've listened to your adviser.";
                    completeStory.Add(choiceOne);
                    WriteLine(choiceOne);
                    SaveStoryToFile save = new SaveStoryToFile();
                    save.saveStoryToFile(completeStory);
                    MainClass.WaitForKey();
                }
                else if (userSelection == 2)
                {
                    Clear();
                    var choiceOne = "You are taken aback. Your adviser has never gotten in your way before.\n\n" +
                                    "'Don't go that way!' he tells you. 'The army is outside and will kill you on sight!\n\n" +
                                    "He sounds frightened, so you listen to him.\n\n\n\n" +
                                    "'This way!' he motions to you, revealing a secret door in the corner.\n\n" +
                                    "Flabbergasted, you run into the corner and through the door, which you soon realize leads into an underground bunker.\n\n\n\n" +
                                    "You're saved.\n\n\n\n" +
                                    "Aren't you glad you listened to your adviser?";
                    completeStory.Add(choiceOne);
                    WriteLine(choiceOne);
                    SaveStoryToFile save = new SaveStoryToFile();
                    save.saveStoryToFile(completeStory);
                    MainClass.WaitForKey();

                }
                else
                {
                    Clear();
                    WriteLine("Uh oh! You didn't make a valid selection! Please try again!");
                    MainClass.WaitForKey();
                }


            }
            else
            {
                Clear();
                WriteLine("Uh oh! You didn't make a valid selection! Please try again!");
                MainClass.WaitForKey();

            }
        }
        else
        {
            Clear();
            WriteLine("Uh oh! You didn't make a valid selection! Please try again!");
            MainClass.WaitForKey();
        }
    }

    public void Initialization()
    {
        Write("Please enter your name: ");
        var userName = ReadLine().Trim();
        Clear();
        int userChoice = 0;
        while (userChoice != 2)
        {
            try
            {
                WriteLine($"Welcome, {userName}!\nPlease enter the number that corresponds to your desired selection:\n" +
                      "1. New Game\n" +
                      "2. Exit\n");
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
                    Clear();
                    WriteLine("Thanks for playing!\n\nGoodbye!");
                    MainClass.WaitForKey();
                    break;
                default:
                    Clear();
                    Console.WriteLine("Uh oh! That's not a valid selection! Please try again!");
                    MainClass.WaitForKey();
                    continue;
            }
        }
    }
}
