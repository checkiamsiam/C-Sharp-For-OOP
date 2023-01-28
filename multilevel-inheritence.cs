using System;

class Root
{
    class Vehicle
    {
        public string brand = "Ford";
        public void honk()
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
    class Car : Vehicle
    {
        public string type = "4 seat";
    }

    class BMW : Car
    {
        public string model = "bmw";
    }

    static void Main(string[] args)
    {
        BMW myCar = new BMW();
        myCar.honk();
        Console.WriteLine(myCar.brand + " " + myCar.model);
    }

}