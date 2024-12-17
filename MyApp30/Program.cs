// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

// Delegate

delegate void MyDelegate();

class MyApp30
{
    // static void SayHi() {
    //     Console.WriteLine("Hi");
    // }
    static void SayHi() => Console.WriteLine("Hi");
    static void SayHello() => Console.WriteLine("Hello");

    static void Main()
    {
        MyDelegate ShowMessage;

        ShowMessage = SayHi;
        ShowMessage += SayHello; // Multicast Delegate
        // ShowMessage -= SayHello; // Multicast Delegate
        
        ShowMessage();
    }
}