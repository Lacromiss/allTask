using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp49
{
    internal class Human
    {
        private int _age;
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get => _age;
                set
            {
                if (Age>0)
                {
                    _age = value;
                    return;

                }
                throw new Exceptioon("xetaaaa");
            
            }
        }
    }
}
