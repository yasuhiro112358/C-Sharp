// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

class Program
{
    static void SayHi()
    {
        Console.WriteLine("Hi!");
    }

    static string GetHi()
    {
        return "Hi!";
    }

    static string GetHi2() => "Hi!";

    static void Main()
    {
        SayHi();
        Console.WriteLine(GetHi());
        Console.WriteLine(GetHi2());
    }
}