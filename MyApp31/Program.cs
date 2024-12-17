// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

delegate void MyDelegate();

class MyApp31
{
    static void Main()
    {
        MyDelegate ShowMessage;

        // 匿名メソッド
        ShowMessage = delegate
        {
            Console.WriteLine("Hi!");
        };

        // ラムダ式: 引数 => 処理
        // ShowMessage += () =>
        // {
        //     Console.WriteLine("Hello!");
        // };
        ShowMessage += () => Console.WriteLine("Hello!");

        ShowMessage();
    }
}
