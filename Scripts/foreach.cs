using System;

class ForEachLoop
{
    public static void Main()
    {
        string[] names = {"Cheryl", "Joe", "Matt", "Robert"};

        foreach (string name in names)
        {
            Console.WriteLine("{0} ", name);
        }
    }
}