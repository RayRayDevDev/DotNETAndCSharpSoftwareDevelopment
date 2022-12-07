using System.Collections;
[Serializable]
public class SaveStoryToFile
{
    public void saveStoryToFile(ArrayList usersStory)
    {
        TextWriter writer = File.CreateText("CompletedStory.txt");
        foreach (String story in usersStory)
        {
            writer.WriteLine(story);
        }
        writer.Close();
    }
}
