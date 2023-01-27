using System;

class Root
{
    class Util
    {
        public int fact()
        {
            Console.WriteLine("Give the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = num; i > 0; i--)
            {
                result = result * i;
            }
            return result;
        }
    }
    static void Main(string[] args)
    {
        Util u = new Util();
        int fact = u.fact();
        Console.WriteLine(fact);
    }

}