using System;
using System.Numerics;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Algebra.Pylonomial pylonomial = new Algebra.Pylonomial("x+2w-3");
            pylonomial.Factorization();
            Console.ReadKey();
        }
    }
}
