using System;

class DrawingObject
{
    public virtual void Draw()
    {
        Console.WriteLine("This is a DrawingObject.");
    }
}

class Line : DrawingObject
{
    public override void Draw()
    {
        Console.WriteLine("This is a line.");
    }
}

class Circle : DrawingObject
{
    public override void Draw()
    {
        Console.WriteLine("This is a circle.");
    }
}

class Square : DrawingObject
{
    public override void Draw()
    {
        Console.WriteLine("This is a square.");
    }
}

class DrawDemo
{
    public static void Main()
    {
        DrawingObject[] dObj = new DrawingObject[4];

        dObj[0] = new Line();
        dObj[1] = new Circle();
        dObj[2] = new Square();
        dObj[3] = new DrawingObject();

        foreach(DrawingObject obj in dObj)
        {
            obj.Draw();
        }
    }
}