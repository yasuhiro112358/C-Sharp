// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

// 構造体

struct Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void GetInfo()
    {
        Console.WriteLine($"({this.X}, {this.Y})");
    }
}

class Myapp27
{
    static void Main()
    {
        Point p1 = new Point(5, 3);
        Point p2 = new Point(12, 4);
        p1.GetInfo();
        p2.GetInfo();
    }
}
