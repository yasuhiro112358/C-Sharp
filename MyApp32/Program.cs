// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

// Event

delegate void MyEventHandler();

class MyButton
{
    public event MyEventHandler MyEvent;
    public void OnClicked()
    {
        if (MyEvent != null)
        {
            MyEvent();
        }
    }
}

class MyApp32
{
    static void Main()
    {
        MyButton btn = new MyButton();

        btn.MyEvent += () => Console.WriteLine("Button Clicked!");

        btn.OnClicked();
    }
}