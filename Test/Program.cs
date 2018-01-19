using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Algebra.Pylonomial pylonomial = new Algebra.Pylonomial("-x^2^+8x+16-12");
            Algebra.Product product = new Algebra.Product();
            Algebra.Pylonomial p = new Algebra.Pylonomial();
            Boolean m = Algebra.Pylonomial.TryFactorization(pylonomial, out product, out p);
            Console.WriteLine(product.ToString()+m);
            Console.ReadKey();
        }
    }
}
