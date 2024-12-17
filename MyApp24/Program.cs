// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

interface ISharable
{
    void Share();
    // 自動的にpublicになる
}

class User : ISharable
{
    public void Share()
    // overrideを付けなくてもよい
    {
        Console.WriteLine("Now sharing...");
    }
}

class MyApp24
{
    static void Main()
    {
        User user = new User();
        user.Share();
    }
}