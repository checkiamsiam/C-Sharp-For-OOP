using System;

class Root
{
    public delegate void PrintByDelegate(string txt);
    static void Print(string txt)
    {
        Console.WriteLine(txt);
    }
    static void Main(string[] args)
    {
        PrintByDelegate print = new PrintByDelegate(Print);
        print("this is from delegate");
    }
}