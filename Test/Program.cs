using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Algebra.Pylonomial pylonomial = new Algebra.Pylonomial("23(-x^2^+8x+16-12)");
            Console.WriteLine(pylonomial.ToString());
            Console.ReadKey();
        }
    }
}
