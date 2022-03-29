using System;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Employee employee = new Employee();
            employee.Name = "Mustafa";
            Employee employee2 = new Employee();
            employee2.Name = "Eli";
            Employee employee3 = new Employee();
            employee3.Name = "Pireli";
            Console.WriteLine(Employee.count);
            Console.WriteLine(employee2.No);



        }
    }
}
