using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
    internal class Bus : Vehicle
    {
        public Bus( int passengerCount, int year):base(year)
        {
            PassengerCount = passengerCount;

        }
        public int PassengerCount { get; set; }
        public override string ShowInfo()
        {
            return $"Passengercount: {PassengerCount} Year: {Year}";
            
        }
    }
}
