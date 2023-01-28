using System;

class Root
{
    static int findBig(int[] arr)
    {
        int result = 0;
        foreach (int value in arr)
        {
            if (result < value)
            {
                result = value;
            }
        }
        return result;
    }
    static void Main(string[] args)
    {
        int[] arr = { 3, 4, 30, 1, 25, 49, 349, };
        Console.WriteLine(findBig(arr));
    }
}