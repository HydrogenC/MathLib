using System;
using System.Numerics;
using static Fraction.Fraction;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction.Fraction fraction = new Fraction.Fraction((Decimal)2,new Fraction.Fraction("2/3"));
            Console.Write((Decimal)fraction);
            Console.ReadKey();
        }
    }
}
