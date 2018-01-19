using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Algebra.Pylonomial pylonomial = new Algebra.Pylonomial("23(-x^2^+8x+16-12)");
            Algebra.Product product = new Algebra.Product();
            Algebra.Pylonomial others = new Algebra.Pylonomial();
            Algebra.Pylonomial.TryFactorization(pylonomial, out product, out others);
            Console.WriteLine(product.ToString());
            Console.WriteLine(others.ToString());
            Console.ReadKey();
        }
    }
}
