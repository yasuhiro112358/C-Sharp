// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

abstract class User
{
    public abstract void SayHi();
}

class Japanese : User
{
    public override void SayHi()
    {
        Console.WriteLine("こんにちは！");
    }
}

class American : User
{
    public override void SayHi()
    {
        Console.WriteLine("Hi！");
    }
}

class MyApp23
{
    static void Main()
    {
        Japanese aki = new Japanese();
        aki.SayHi();
        
        American tom = new American();
        tom.SayHi();
    }
}