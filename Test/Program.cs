using System;
using static Fraction.Fraction;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction.Fraction fraction = new Fraction.Fraction("4/6");
            Console.Write((Decimal)fraction);
            Console.ReadKey();
        }
    }
}
