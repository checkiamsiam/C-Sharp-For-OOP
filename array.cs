using System;

class Root
{
    static void Main(string[] args)
    {
        // array define
        int[] arr = { 1, 2, 3 };
        string[] arrS = { "siam", "sheikh", "shaharioar" };
        // loop a array
        foreach (string name in arrS)
        {
            Console.WriteLine(name);
        }
        // sort an harray have many methods
        Array.Sort(arr);
        // two dimentional array
        int[,] twoD = { { 1, 2, 3 }, { 3, 4, 7 } };


    }

}