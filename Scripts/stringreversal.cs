using System;

class StringReversal
{
    static void Main()
    {
        string s = "helloworld";
        string sReversed = string.Empty;

        Console.WriteLine(s);

        for (int i=s.Length-1; i >= 0; i--)
        {
            sReversed += s[i];
        }

        Console.WriteLine(sReversed);
    }
}