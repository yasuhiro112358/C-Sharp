// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

// Generic class
// 型の汎用化

// class MyInteger
// {
//     public void GetThree(int x)
//     {
//         Console.WriteLine(x);
//         Console.WriteLine(x);
//         Console.WriteLine(x);
//     }
// }

class MyData<T>
{
    public void GetThree(T x)
    {
        Console.WriteLine(x);
        Console.WriteLine(x);
        Console.WriteLine(x);
    }
}

class MyApp25
{
    static void Main()
    {
        // MyInteger mi = new MyInteger();
        // mi.GetThree(55);

        MyData<string> s = new MyData<string>();
        s.GetThree("Hello");
        MyData<double> d = new MyData<double>();
        d.GetThree(3.14);
    }
}