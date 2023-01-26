using System;

class Root
{
    // void method without perameter
    static void Method()
    {
        Console.WriteLine("this is from method");
    }
    // return something and perametar and arg use and default arg set.
    static double Plus(int one = 1, int two = 2)
    {
        return one / two;
    }
    // named arg
    static void Main(string[] args)
    {
        Method();
        Console.WriteLine(Plus(5, 10));
        Console.WriteLine(Plus());
        // named args
        Console.WriteLine(Plus(two: 1, one: 7));

    }

}

// note return type and arg type should be same