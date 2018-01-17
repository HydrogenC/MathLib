using System;
using System.Numerics;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction.Fraction fraction = (Fraction.Fraction)"1/3";
            Decimal m = 1/3;
            Console.Write(fraction==m);
            Console.ReadKey();
        }
    }
}
