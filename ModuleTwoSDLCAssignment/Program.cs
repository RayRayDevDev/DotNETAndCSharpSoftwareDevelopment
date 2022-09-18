using SolrNet.Utils;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static System.Console;

class Parser
{
    public static void Main(string[] args)
    {
        Title = "Occurrence Counter";
        checkIfFileExists();
        readFile();

    }

    private static void countOccurences(List<String> regexList)
    {
        Dictionary<String, int> countOccurences = new Dictionary<String, int>();
        for (int i = 0; i < regexList.Count; i++)
        {
            if (countOccurences.ContainsKey(regexList[i]))
            {
                int occurenceCount = countOccurences[regexList[i]];
                countOccurences[regexList[i]] = occurenceCount += 1;
            }
            else
            {
                countOccurences.Add(regexList[i], 1);
            }

        }

        foreach (KeyValuePair<string, int> counts in countOccurences)
        {
            WriteLine($"The word: \"{counts.Key}\" was used {counts.Value} time(s) in the document!");
        }
    }
    private static void readFile()
    {
        var inputMixedCaseFile = new string(@"Text_File\The_Raven--EAP.txt");
        string outputToLowercase = @"Text_File\The_Raven--EAP_Output.txt";
        string toLowercase =  File.ReadAllText(inputMixedCaseFile);
        toLowercase = toLowercase.ToLower();
        File.WriteAllText(outputToLowercase, toLowercase);
        var pattern = @"\w+";
        var regex = new Regex(pattern);
        var matches = regex.Matches(File.ReadAllText(outputToLowercase)).OfType<Match>().Select(m => m.Value);
        matches = new List<string>(matches);
        foreach (var match in matches)
        {
            WriteLine(match);
        }
        countOccurences((List<string>)matches);
    }

    private static void checkIfFileExists()
    {
        string relativePath = Path.Combine(Directory.GetCurrentDirectory(), @"Text_File\The_Raven--EAP.txt");
        if (File.Exists(relativePath)) WriteLine("File Exists");
        else
        {
            WriteLine("File Does not Exist. Aborting.");
            System.Environment.Exit(1);
        }
    }
    private static void WaitForKey() 
    {
        Write("\nPress any key to continue...");
        ReadKey();
        Clear();
    }
}
