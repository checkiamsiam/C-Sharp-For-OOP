using System;

class Root
{
    static void Main(string[] args)
    {
        // only integer number
        int inum = 4;
        // dosomik soho and last e "f" suffix thakbe
        float fnum = 5.9f;
        // any number
        double dnum = 5.9;
        // any single alphabet 
        char alpha = 'S';
        // anything inside double quote
        string name = "siam sheikh";
        // only two values 
        bool isRight = false;
        // 'const' prefix keyword makes a variable constaint that means it cant be reassign and value cant be change
        const int cantChange = 5;
        // inside the console there is a example of template string in cs
        Console.WriteLine($"data types of cs -- {inum}, {fnum}, {dnum}, {alpha}, {name}, {isRight}, {cantChange}");

    }
}
