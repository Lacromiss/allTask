using System;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car cars = new Car("qalik", "asasas", 2022);
            Bus buss = new Bus(20,2021);

            Vehicle[] vehicles = { cars, buss };

            foreach (var vehicle in vehicles)
            {
                vehicle.ShowInfo();
            }


        }
    }
}
