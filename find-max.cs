using System;

class Root
{
    static void Main(string[] args)
    {
        int[] arr = { 45, 75, 21, 165, 85, 95, 19 };
        int n = arr[0];
        foreach (int i in arr)
        {
            n = Math.Max(n, i); ;
        }

        Console.WriteLine(n);
    }

}