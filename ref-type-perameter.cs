using System;

class Root
{
    class Details
    {
        // referance type perameter
        public void setName(ref string name)
        {
            name = "siam" + " " + "sheikh";
        }
    }
    static void Main(string[] args)
    {
        string myName = "siam";
        Details siam = new Details();
        siam.setName(ref myName);
        Console.WriteLine(myName);
    }

}