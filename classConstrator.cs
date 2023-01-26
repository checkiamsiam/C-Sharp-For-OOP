using System;

class Root
{
    class Data
    {
        public string name;
        public int roll;
        public Data(string n, int r)
        {
            name = n;
            roll = r;
        }
    }
    static void Main(string[] arg)
    {
      Data myData = new Data(n: "Siam" , r: 559718);
      Console.WriteLine(myData.name);
    }
}
