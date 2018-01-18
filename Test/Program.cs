using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Algebra.Monomial monomial = new Algebra.Monomial("3x^24^y^6^");
            Console.WriteLine(monomial.ToString());
            Console.ReadKey();
        }
    }
}
