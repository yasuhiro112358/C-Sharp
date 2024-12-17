// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

class MyException : Exception {
    public MyException(string msg) : base(msg) {
        
    }
}


class MyApp29
{
    static void Div(int a, int b)
    {
        try
        {
            if (b < 0)
            {
                throw new MyException("b must be greater than 0");
            }

            Console.WriteLine(a / b);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        } catch (MyException e) {
            Console.WriteLine(e.Message);
        } finally {
            Console.WriteLine("== End ==");
        }
    }

    static void Main()
    {
        Div(10, 2);
        Div(10, 0);
        Div(10, -3);
    }
}