using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Algebra.Monomial monomial = new Algebra.Monomial("3x^24^y^6^");
            Console.WriteLine(monomial.Coefficient.ToString());
            foreach(var i in monomial.Letters)
            {
                Console.WriteLine(i.Exponent);
                Console.WriteLine(i.GetLetter);
            }
            Console.ReadKey();
        }
    }
}
