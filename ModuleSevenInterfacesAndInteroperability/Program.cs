using System.Collections;
using static System.Console;

interface IComputer
{
    void buildComputer();
    void nameComputer(String computerName);
    void installComputerOperatingSystem(String computerName, String computerType);
    void installApplications(String computerName, String computerOS, String computerType);

    void assignComputerToUser(String computerName, String computerOS, String installedApplications, String computerType);

    void returnComputerSpecifications(String computerName, String computerOS, String installedApplications, String assignedUser, String computerType);
}

class MainClass
{
    public static void Main()
    {
        iPhoneTest newIphone = new iPhoneTest();
        newIphone.buildComputer();
    }
}

class iPhoneTest : IComputer
{
    public void assignComputerToUser(string computerName, string computerOS, string installedApplications, String computerType)
    {
        String assignedUser = "Josie";
        returnComputerSpecifications(computerName, computerOS, installedApplications, assignedUser, computerType);
    }

    public void buildComputer()
    {
        WriteLine("Building you an iPhone. Please wait...");
        Thread.Sleep(5000);
        WriteLine("Your iPhone has been successfully built!");
        nameComputer("iPhone 14 Pro Max");
    }

    public void installApplications(string computerName, string computerOS, String computerType)
    {
        String installedApplications = "Facebook, Mastodon, Capital One, Best Buy, and Canvas";
        assignComputerToUser(computerName, computerOS, installedApplications, computerType);
    }

    public void installComputerOperatingSystem(string computerName, String computerType)
    {
        String oSVersion = "iOS 16.1.1";
        installApplications(computerName, oSVersion, computerType);

    }

    public void nameComputer(string computerType)
    {
        String computerName = "Josie's iPhone";
        installComputerOperatingSystem(computerName, computerType);
    }

    public void returnComputerSpecifications(string computerName, string computerOS, string installedApplications, string assignedUser, String computerType)
    {
        WriteLine(
            $"Hello {assignedUser}! Your {computerType} has been successfully built! This {computerType} includes {computerOS} with {installedApplications} preinstalled! This {computerType} has also been prenamed {computerName}.");
    }
}