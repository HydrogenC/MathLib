using System;
using System.Text.RegularExpressions;
using System.Numerics;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Algebra.Monomial monomial = new Algebra.Monomial("3x^24^");
            Console.WriteLine(monomial.Coefficient.ToString()+" "+monomial.Letters[0].Exponent);
            Console.ReadKey();
        }
    }
}
