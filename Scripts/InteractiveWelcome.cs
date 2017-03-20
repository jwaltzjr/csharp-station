using System;

class InteractiveWelcome
{
    public static void Main()
    {
        string name;

        Console.Write("What is your name?: ");
        name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", name);
        Console.WriteLine("Welcome to the C# Tutorial!");
    }
}