using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
    internal  abstract class Vehicle
    {
        public Vehicle(int year)
        {
            Year = year;

        }
        public int Year { get; set; }
        public string Color { get; set; }
        public abstract string ShowInfo();

    }
}
