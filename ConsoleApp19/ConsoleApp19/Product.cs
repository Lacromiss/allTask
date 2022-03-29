using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp19
{
    internal  abstract class Product
    {
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
            Id = _id;

        }
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public int TotalInCome{ get;  protected set; }
        public abstract string ShowInfo();
        public abstract void Sell();

    }
}
