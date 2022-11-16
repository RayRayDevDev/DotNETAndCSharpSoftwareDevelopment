using System.Collections;
using static System.Console;

//This program was created by Cole Stanley (RäDev) on 10/15/2022 and 10/16/2022.
//This program makes use of an interface to illustrate how different types of computers may be built from the same core.

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
        gamingComputer newGamingComputer = new gamingComputer();
        newGamingComputer.buildComputer();
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
        WriteLine("\nYour iPhone has been successfully built!");
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
            $"\nHello {assignedUser}! Your {computerType} has been successfully built! This {computerType} includes {computerOS} with {installedApplications} preinstalled! This {computerType} has also been prenamed \"{computerName}\".");
    }
}

class gamingComputer : IComputer
{
    public void assignComputerToUser(string computerName, string computerOS, string installedApplications, string computerType)
    {
        String assignedUser = "Darren";
        returnComputerSpecifications(computerName, computerOS, installedApplications, assignedUser, computerType);
    }

    public void buildComputer()
    {
        WriteLine("\nBuilding you a Gaming Computer. Please wait...");
        Thread.Sleep(5000);
        WriteLine("\nYour Gaming Computer has been successfully built!");
        nameComputer("HP OMEN");
    }

    public void installApplications(string computerName, string computerOS, string computerType)
    {
        String installedApplications = "Brave, Visual Studio 2022, Steam, Microsoft Word, and Android Studio";
        assignComputerToUser(computerName, computerOS, installedApplications, computerType);
    }

    public void installComputerOperatingSystem(string computerName, string computerType)
    {
        String oSVersion = "Windows 11, Version 22H2";
        installApplications(computerName, oSVersion, computerType);
    }

    public void nameComputer(string computerType)
    {
        String computerName = "Darren's HP OMEN";
        installComputerOperatingSystem(computerName, computerType);
    }

    public void returnComputerSpecifications(string computerName, string computerOS, string installedApplications, string assignedUser, string computerType)
    {
        WriteLine(
            $"\nHello {assignedUser}! Your {computerType} has been successfully built! This {computerType} includes {computerOS} with {installedApplications} preinstalled! This {computerType} has also been prenamed \"{computerName}\".");
    }
}