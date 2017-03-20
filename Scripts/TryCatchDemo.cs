using System;
using System.IO;

class tryCatchDemo
{
    static void Main(string[] args)
    {
        try
        {
            File.OpenRead("NonExistentFile");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}