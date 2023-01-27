using System;

class Root
{
    static void Main(string[] args)
    {
        double a, b, c, x1, x2, niscayok;
        Console.WriteLine("ax^2 + bx + c");
        Console.Write("a = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b = ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("c = ");
        c = Convert.ToDouble(Console.ReadLine());
        niscayok = (b * b) - (4 * a * c);
        if (niscayok > 0)
        {
            x1 = (-b + Math.Sqrt(niscayok)) / (2 * a);
            x2 = (-b - Math.Sqrt(niscayok)) / (2 * a);
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
        }
        else
        {
            Console.WriteLine("invalid");
        }
    }

}