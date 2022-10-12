using System.Text.RegularExpressions;
using static System.Console;
//Created by Cole Stanley (RäDev) for CEN 4370C on 09/18/2022.
//Program takes a text file, converts it into lowercase, parses each word into a list, and loops through the list, counting each unique occurrence of a particular word. The program then publishes the list to the Console. 

internal class Parser
{
    public static void Main(string[] args) //Cleaner Main method.
    {
        Title = "Occurrence Counter";
        checkIfFileExists();
        readAndParseFile();
    }

    private static void countOccurences(List<string> regexList) //Pass the List generated in the readAndParseFile into this method.
    {
        var countOccurrences = new SortedDictionary<string, int>(); //SortedDictionary due to Alphabetical sorting when values are the same.
        for (var i = 0; i < regexList.Count; i++)
            if (countOccurrences.ContainsKey(regexList[i])) //Check and see if the word is already in the dictionary. If so, add 1 to the occurrenceCount.
            {
                var occurrenceCount = countOccurrences[regexList[i]];
                countOccurrences[regexList[i]] = occurrenceCount += 1;
            }
            else //If the word is NOT already in the dictionary, add it to the dictionary and initialize its value to 1.
            {
                countOccurrences.Add(regexList[i], 1);
            }

        foreach (var counts in countOccurrences.OrderByDescending(key => key.Value)) //Initialize a foreach loop that sorts the number of occurrences of any given word in descending order and prints the newly sorted dictionary to the console. 
            WriteLine($"The word \"{counts.Key}\" was used {counts.Value} time(s) in the document!");
        WaitForKey();
    }

    private static void readAndParseFile()
    {
        var inputMixedCaseFile = new string(@"Text_File\The_Raven--EAP.txt");
        var outputToLowercase = new string(@"Text_File\The_Raven--EAP_Output.txt");
        var toLowercase = File.ReadAllText(inputMixedCaseFile); //I couldn't figure out how to stop the regex from seeing the same words as different ones depending on the case, causing an inaccurate count as a result. This was the less-than-perfect solution. 
        toLowercase = toLowercase.ToLower();
        File.WriteAllText(outputToLowercase, toLowercase);
        var pattern = @"\w+"; //Regex to disregard whitespace and only look at word characters.
        var regex = new Regex(pattern);
        var matches = regex.Matches(File.ReadAllText(outputToLowercase)).OfType<Match>().Select(m => m.Value); //Probably redundant, but output the text after reading it to lowercase, just as a safety valve. Select each value output by the Regex expression and output them to a new form.
        matches = new List<string>(matches); //Create a new list and fill the new list from the IEnumerable<string> "matches." 
        countOccurences((List<string>)matches); //Pass the new list "matches" (with a cast since the compiler was yelling at me) into the function which counts each occurrence of a given word. 
    }

    private static void checkIfFileExists() //Check if the input text file exists and, if not, display a message and exit the program. If the file does exist, print a message and wait for the user to press any key to continue. 
    {
        var relativePath = Path.Combine(Directory.GetCurrentDirectory(), @"Text_File\The_Raven--EAP.txt");
        if (File.Exists(relativePath))
        {
            WriteLine("File Exists");
            WaitForKey();
        }
        else
        {
            WriteLine("File Does not Exist. Aborting.");
            WaitForKey();
            Environment.Exit(1);
        }
    }

    private static void WaitForKey() //Easier method than calling "ReadKey()" and writing more lines of code as a result. 
    {
        Write("\nPress any key to continue...");
        ReadKey();
        Clear();
    }
}