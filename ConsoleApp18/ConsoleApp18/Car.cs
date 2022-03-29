using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
    internal class Car : Vehicle
    {
        public Car(string brand,string model,int year):base(year)
        {
            Brand = brand;
            Model = model;
            

        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int MaxSpeed { get; set; }
        public override string ShowInfo()
        {
            throw new NotImplementedException();
        }

    }
}
