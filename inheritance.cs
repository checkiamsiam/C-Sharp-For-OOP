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
        public string modelName = "Mustang";  
}

    static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.honk();
        Console.WriteLine(myCar.brand + " " + myCar.modelName);
    }

}
