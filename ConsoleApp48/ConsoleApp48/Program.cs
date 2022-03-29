using System;

namespace ConsoleApp48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Exchange(Currency.Usd, 4));
        }

        static double Exchange(Enum enums, double rupi)
        {
            if (enums is Currency)
            {
                switch (enums)
                {
                    case Currency.Usd:
                        return rupi * 0.59;
                    case Currency.Eur:
                        return rupi * 0.53;
                    case Currency.Try:
                        return rupi * 8.71;
                    default:
                        return -1;
                }


            }
            return -1;






        }
    }
}
