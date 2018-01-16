using System;
using System.Numerics;
using static Fraction.Fraction;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction.Fraction fraction = (Fraction.Fraction)"5/1";
            Console.Write((Decimal)fraction);
            Console.ReadKey();
        }
    }
}
