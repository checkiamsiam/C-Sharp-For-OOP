using System;

class Root
{
    static void ShowName()
    {
        Console.WriteLine("name showed");
    }
    static void ShowName(string name)
    {
        Console.WriteLine($"{name}");
    }
    static void ShowName(int name)
    {
        Console.WriteLine($"{name}");
    }
    static void Main(string[] args)
    {
        ShowName();
        ShowName("siam");
        ShowName(5);
    }

}