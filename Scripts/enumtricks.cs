using System;

public enum Volume : byte
{
    Low = 1,
    Medium,
    High
}

class Enumtricks
{
    static void Main(string[] args)
    {
        Enumtricks enumtricks = new Enumtricks();
        enumtricks.GetEnumFromUser();
        enumtricks.ListEnumMembersByName();
        enumtricks.ListEnumMembersByValue();
        Console.ReadLine();
    }

    public void GetEnumFromUser()
    {
        Console.WriteLine("\n----------------");
        Console.WriteLine("Volume Settings:");
        Console.WriteLine("----------------\n");

        Console.Write(
            "1 - Low\n" +
            "2 - Medium\n" +
            "3 - High\n\n" +
            "Please select one (1, 2, or 3): "
        );
        string inputString = Console.ReadLine();
        int inputInt = Int32.Parse(inputString);

        Volume myVolume = (Volume)inputInt;

        Console.WriteLine();

        switch (myVolume)
        {
            case Volume.Low:
                Console.WriteLine("The volume has been turned Down.");
                break;
            case Volume.Medium:
                Console.WriteLine("The volume is in the middle.");
                break;
            case Volume.High:
                Console.WriteLine("The volume has been turned up.");
                break;
        }

        Console.WriteLine();
    }

    public void ListEnumMembersByName()
    {
        Console.WriteLine("\n---------------------------- ");
        Console.WriteLine("Volume Enum Members by Name:");
        Console.WriteLine("----------------------------\n");

        // Enum.GetValues - takes the enum type, returns strings for the enums in an string[]
        string[] enumOptions = Enum.GetNames(typeof(Volume));

        foreach (string enumOption in enumOptions)
        {
            // Enum.Parse - takes enumType and either enumValue or enumString, returns the enum back
            Console.WriteLine(Enum.Parse(typeof(Volume), enumOption)); 
            Console.WriteLine();
        }
    }

    public void ListEnumMembersByValue()
    {
        Console.WriteLine("\n----------------------------- ");
        Console.WriteLine("Volume Enum Members by Value:");
        Console.WriteLine("-----------------------------\n");

        // Enum.GetValues - takes the enum type, returns enums for values in an Array.
        Array enumValues = Enum.GetValues(typeof(Volume));

        foreach (Volume enumValue in enumValues)
        {
            // Enum.GetName - takes enumType and enumValue, returns the enumString
            Console.WriteLine(Enum.GetName(typeof(Volume), enumValue));
            Console.WriteLine();
        }
    }
}