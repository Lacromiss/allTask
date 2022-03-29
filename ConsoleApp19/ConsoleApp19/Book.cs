using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp19
{
    internal class Book : Product
    {
        public Book( string authorName, int pageCount,string name, int price):base(name,price)
        {
            AuthorName = authorName;
            PageCount = pageCount;

        }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public override void Sell()
        {
            Count--;
            TotalInCome += Price;
        }

        public override string ShowInfo()
        {
            return $"Authorname:{AuthorName} PageCount{PageCount},Name{Name} Price:{Price}";
        }
    }
}
