using System;

class SwitchPractice
{
    static void Main(string[] args)
    {
        switch (args[0])
        {
            case "hello":
                Console.WriteLine("Hello!");
                Console.ReadLine();
                break;
            case "goodbye":
                Console.WriteLine("See you later!");
                Console.ReadLine();
                break;
            default:
                Console.WriteLine("Sorry - I didn't understand that.");
                Console.ReadLine();
                break;
        }
    }
}