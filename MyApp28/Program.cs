// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

// 列挙型

enum Direction
{
    Stay,
    Right,
    Left
}

class MyApp28
{
    static void Main()
    {
        // Direction dir = Direction.Right;
        Direction dir = Direction.Left;

        switch (dir)
        {
            case Direction.Stay:
                Console.WriteLine("Stay");
                break;
            case Direction.Right:
                Console.WriteLine("Right");
                break;
            case Direction.Left:
                Console.WriteLine("Left");
                break;
            default:
                Console.WriteLine("Unknown");
                break;
        }
    }
}
