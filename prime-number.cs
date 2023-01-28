using System;

class Root
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i < 3)
            {
                Console.WriteLine($"{i} is a prime number");
            }
            else
            {
                double bhag = i / 6;
                double minAbs = Math.Floor(bhag);
                double maxAbs = Math.Ceiling(bhag);
                if (((6 * minAbs) + 1) == i)
                {
                    Console.WriteLine($"{i} is a prime number");
                }
                if (((6 * maxAbs) - 1) == i)
                {
                    Console.WriteLine($"{i} is a prime number");
                }
            }

        }
    }
}