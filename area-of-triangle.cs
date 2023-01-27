using System;

class Root
{
    static void Main(string[] args)
    {
        Console.WriteLine("Give the 3 lengths Value");
        Console.Write("a =  ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b =  ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("c =  ");
        double c = Convert.ToDouble(Console.ReadLine());
        if (((a + b) > c) && ((b + c) > a) && ((c + a) > b))
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine(Math.Round(area));
        }
        else
        {
            Console.WriteLine("invalid values");
        }
    }

}