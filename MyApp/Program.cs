// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;


class User
{
    // private string name;
    protected string name;

    // プロパティ
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    // コンストラクタ
    public User(string name)
    {
        this.name = name;
    }

    // コンストラクタのオーバーロード
    public User()
    {
        this.name = "Nobody";
    }

    public virtual void SayHi()
    {
        Console.WriteLine($"Hi! {this.name}");
    }
}

class AdminUser : User
{
    public AdminUser(string name) : base(name)
    {

    }

    public void SayHello()
    {
        Console.WriteLine($"Hello! {this.name}");
    }

    public override void SayHi()
    {
        Console.WriteLine($"[Admin] Hi! {this.name}");
    }
}


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

        // ==================

        User tom = new User("Tom");
        tom.SayHi();
        Console.WriteLine(tom.Name);
        tom.Name = "Tommy";
        Console.WriteLine(tom.Name);


        User user = new User();
        user.SayHi();

        AdminUser bob = new AdminUser("Bob");
        bob.SayHi();
        bob.SayHello();
    }
}