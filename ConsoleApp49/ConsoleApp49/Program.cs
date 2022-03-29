using System;

namespace ConsoleApp49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();

            try
            {
                human.Age = 0;
                

            }
            catch ( Exceptioon ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
