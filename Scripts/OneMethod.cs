using System;

class OneMethod
{
    public static void Main()
    {
        string myChoice;

        OneMethod om = new OneMethod();

        do
        {
            myChoice = om.getChoice();

            switch(myChoice)
            {
                case "A":
                case "a":
                    Console.WriteLine("You wish to add an address.");
                    break;
                case "D":
                case "d":
                    Console.WriteLine("You wish to delete an address.");
                    break;
                case "M":
                case "m":
                    Console.WriteLine("You wish to modify an address.");
                    break;
                case "V":
                case "v":
                    Console.WriteLine("You wish to view the address list.");
                    break;
                case "Q":
                case "q":
                    Console.WriteLine("Bye.");
                    break;
                default:
                    Console.WriteLine("{0} is not a valid choice", myChoice);
                    break;
            }

            Console.WriteLine();
            Console.Write("press Enter to continue...");
            Console.ReadLine();
            Console.WriteLine();
            
        } while (myChoice != "Q" && myChoice != "q");
    }

    string getChoice()
    {
        string myChoice;

        Console.WriteLine("My Address Book\n");

        Console.WriteLine("A - Add New Address");
        Console.WriteLine("D - Delete Address");
        Console.WriteLine("M - Modify Address");
        Console.WriteLine("V - View Addresses");
        Console.WriteLine("Q - Quit\n");

        Console.Write("Choice (A,D,M,V,or Q): ");

        myChoice = Console.ReadLine();
        Console.WriteLine();

        return myChoice;
    }
}