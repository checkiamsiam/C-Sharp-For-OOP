using System;

// main
class Root
{
    static void Main(string[] args)
    {
        int temp;

        for (int n = 1; n <= 100; n++)
        {
            temp = 0;

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    temp++;
                    break;
                }
            }

            if (temp == 0 && n != 1) Console.WriteLine(n);
        }
    }
}

// complex
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