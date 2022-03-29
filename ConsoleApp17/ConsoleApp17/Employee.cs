using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17
{
    internal class Employee
    {
        public static int count;
        public Employee()
        {
            count++;
            No = count;
            
        }
       
        public int No { get; set; }
        public string Name { get; set; }
        public string  SurName { get; set; }
        public int Salary { get; set; }
    }
}
