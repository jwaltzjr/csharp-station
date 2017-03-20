using System;

public class Parent
{
    string parentString;

    public Parent()
    {
        Console.WriteLine("Parent Constructor.");
    }

    public Parent(string myString)
    {
        parentString = myString;
        Console.WriteLine(parentString);
    }

    public void print()
    {
        Console.WriteLine("I'm a parent class.");
    }
}

public class Child : Parent
{
    public Child() : base("From Derived")
    {
        Console.WriteLine("Child Constructor.");
    }

    public new void print()
    {
        base.print();
        Console.WriteLine("I'm a child class.");
    }

    public static void Main()
    {
        Child child = new Child();
        child.print();
        ((Parent)child).print();
    }
}