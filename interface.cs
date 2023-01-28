using System;

class Root
{
    interface Human
    {
        int alive { get; set; }
        void run();
    }
    class Women : Human
    {
        public int alive { get; set; } = 1;
        public bool rich = true;
        public void run()
        {
            Console.WriteLine("run");
        }
    }
    static void Main(string[] args)
    {
        Women myLove = new Women();
        Console.WriteLine(myLove.alive);
    }

}