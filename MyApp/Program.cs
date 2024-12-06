// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

class Program
{
    static void SayHi(string name, int age = 20)
    {
        Console.WriteLine($"Hi! {name} ({age})");
    }

    static string GetHi()
    {
        return "Hi!";
    }

    static string GetHi2() => "Hi!";

    static void Main()
    {
        SayHi("Alice", 30); // Hi! Alice (30)
        SayHi("Bob"); // Hi! Bob (20)
        SayHi(age: 25, name: "Charlie"); // Hi! Charlie (25)

        Console.WriteLine(GetHi());
        Console.WriteLine(GetHi2());
    }
}