using System;

class Root
{
    class Details
    {
        public string title;
        // output type perameter
        public void setName(out string name)
        {
            Console.WriteLine("Enter Your Name : ");
            name = Console.ReadLine();
        }
        public Details(string t)
        {
            title = t;
        }
    }
    static void Main(string[] args)
    {
        string myName;
        Details siam = new Details("web Developer");
        siam.setName(out myName);
        Console.WriteLine(siam.title);
        Console.WriteLine(myName);
    }

}