using System;

class Root
{
    static void Main(string[] args)
    {
        int[] rolls = { 3, 6, 2, 9, 12, 1 };
        // accending order
        Array.Sort(rolls);
        // decending the order
        Array.Reverse(rolls);
        foreach (int roll in rolls)
        {
            Console.WriteLine(roll);
        }
    }

}