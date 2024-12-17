// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using YasuhiroNamespace;

namespace YasuhiroNamespace
{
    class User
    {
        public void SayHi()
        {
            Console.WriteLine("Hi!");
        }
    }
}

class Myapp26
{
    static void Main()
    {
        // YasuhiroNamespace.User user = new YasuhiroNamespace.User();
        User user = new User();
        user.SayHi();
    }
}

