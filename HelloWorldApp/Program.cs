// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

class MyApp
{
    static void Main()
    {
        // This is a single-line comment

        /*
        This is a multi-line comment
        */

        // Declare a variable
        // string msg = "Hello, World!";

        // Declare a constant
        // const string msg = "Hello, World!";

        // Display the message onto the console
        // Console.WriteLine(msg);



        // ========================
        // Data types
        // ========================

        // string, char
        // string s = "hello"; // double quotes for string
        // char c = 'a'; // single quotes for char

        // byte, short, int, long
        // int i = 100; // 32-bit signed integer. Use this most of the time

        // float, double
        // double d = 52342.34; // 64-bit double-precision floating point number. Use this most of the time
        // float f = 23.3f; // 32-bit single-precision floating point number. Need to add 'f' at the end

        // bool
        // bool flag = true; // true or false

        // Type Inference (型推論)
        // var x = 5; // int
        // var y = "world"; // string



        // ========================
        // Operators
        // ========================

        // var x = 10;
        // Console.WriteLine(x / 3); // 3
        // Console.WriteLine(x % 3); // 1
        // Console.WriteLine(x / 3.0); // 3.33333333333333
        // Console.WriteLine(x / (double)3); // 3.33333333333333

        // var y = 5;
        // y++;
        // Console.WriteLine(y); // 6
        // y--;
        // Console.WriteLine(y); // 5

        // var z = 6;
        // z += 10;
        // Console.WriteLine(z); // 16



        // ========================
        // Comparison Operators
        // ========================

        // AND OR NOT
        // && || !
        // var flag = true;
        // Console.WriteLine(!flag); // False



        // ========================
        // 文字列の扱い
        // ========================

        // Concatenation
        // Console.WriteLine("hello " + "world");

        // \n, \t
        // Console.WriteLine("hell\no wo\trld");


        // var name = "Hiro";
        // var score = 52.3;
        // Console.WriteLine(string.Format("{0} [{1}]", name, score)); // Hiro [52.3]

        // $-string (ver. 6.0 or later)
        // Console.WriteLine($"{name} [{score}]"); // Hiro [52.3]
        // Console.WriteLine($"{name, 10} [{score, 10}]"); //       Hiro [      52.3]
        // Console.WriteLine($"{name, -10} [{score, 10}]"); // Hiro       [      52.3]
        // Console.WriteLine($"{name, -10} [{score, 10:0.00}]"); // Hiro       [     52.30]
        // Console.WriteLine($"{name, -10} [{score + 25, 10:0.00}]"); // Hiro       [     77.30]



        // ========================
        // Conditional Branch
        // ========================

        // var score = int.Parse(Console.ReadLine());

        // if (score > 80)
        // {
        //     Console.WriteLine("Great!");
        // }
        // else if (score > 60)
        // {
        //     Console.WriteLine("Good!");
        // }
        // else
        // {
        //     Console.WriteLine("so so ...!");
        // }



        // ========================
        // 三項演算子
        // ========================

        // var score = int.Parse(Console.ReadLine());

        // Console.WriteLine(score > 80 ? "Great!" : "so so ...!");


        // ========================
        // Switch
        // ========================

        // var signal = Console.ReadLine();

        // switch (signal)
        // {
        //     case "red":
        //         Console.WriteLine("Stop!");
        //         break;
        //     case "blue":
        //     case "green":
        //         Console.WriteLine("Go!");
        //         break;
        //     case "yellow":
        //         Console.WriteLine("Caution!");
        //         break;
        //     default:
        //         Console.WriteLine("Wrong signal!");
        //         break;
        // }



        // ========================
        // while
        // ========================

        // var i = 0;

        // while (i < 10)
        // {
        //     Console.WriteLine(i);
        //     i++;
        // }



        // ========================
        // do-while
        // ========================

        var i = 0;

        do
        {
            Console.WriteLine(i);
            i++;
        } while (i < 10);



    }
}
