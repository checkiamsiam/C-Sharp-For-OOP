using System;

class Root
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        if (name == "siam")
        {
            Console.WriteLine("that is insite if");
        }
        else if (name.Length < 4)
        {
            Console.WriteLine("that is insite else if");
        }
        else
        {
            Console.WriteLine("that is insite else");
        }
        // ternary
        string t = "siam" == name ? "if true" : "if false";

        // switch
        switch (name)
        {
            case "siam":
                Console.WriteLine("its me");
                break;
            case "sheikh":
                Console.WriteLine("its also me");
                break;
            default:
                Console.WriteLine("its not me");
                break;
        }

    }
}
