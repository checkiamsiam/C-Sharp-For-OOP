using System;

class Root
{

    static void Main(string[] args)
    {
        int[] series = { 5, 10, 15 };
        Console.Write("Enter a value of n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int a = series[0];
        int d = series[1] - series[0];
        Console.WriteLine(a);
        Console.WriteLine(d);
        int s = (n / 2) * (2*a + ((n - 1) * d));
        Console.WriteLine($"Addition of the series is: {s}");
    }

}