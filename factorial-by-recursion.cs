using System;

class Root
{
    static void Main(string[] args)
    {
        static int fact(int num)
        {
            if (num > 0)
            {
                return num * fact(num - 1);
            }
            return 1;

        }
        Console.WriteLine("Give the number");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(fact(num));
    }

}