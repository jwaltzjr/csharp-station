using System;

class Unary
{
    public static void Main()
    {
        int unary = 0;
        int preIncrement;
        int preDecrement;
        int postIncrement;
        int postDecrement;
        int positive;
        int negative;
        sbyte bitNot;
        bool logNot;

        preIncrement = ++unary;
        Console.WriteLine("Pre-Increment: {0}, Unary = {1}", preIncrement, unary);
        
        preDecrement = --unary;
        Console.WriteLine("Pre-Decrement: {0}, Unary = {1}", preDecrement, unary);

        postDecrement = unary--;
        Console.WriteLine("Post-Decrement: {0}, Unary = {1}", postDecrement, unary);

        postIncrement = unary++;
        Console.WriteLine("Post-Increment: {0}, Unary = {1}", postIncrement, unary);

        positive = -postIncrement;
        Console.WriteLine("Positive: {0}", positive);

        negative = +postIncrement;
        Console.WriteLine("Negative: {0}", negative);

        bitNot = 0;
        bitNot = (sbyte)(~bitNot);
        Console.WriteLine("Bitwise Not: {0}", bitNot);

        logNot = false;
        logNot = !logNot;
        Console.WriteLine("Logical Not: {0}", logNot);

        Console.ReadLine();

    }
}