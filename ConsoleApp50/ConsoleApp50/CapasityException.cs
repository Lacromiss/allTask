using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    internal class CapacityException : Exception
    {
        public CapacityException(string message) : base(message)
        {
        }
    }
}