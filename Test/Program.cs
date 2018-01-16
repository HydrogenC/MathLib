using System;
using System.Numerics;
using static Fraction.Fraction;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction.Fraction fraction = new Fraction.Fraction((Decimal)1.5, (Decimal)0.5);
            Console.Write((Decimal)fraction);
            Console.ReadKey();
        }
    }
}
