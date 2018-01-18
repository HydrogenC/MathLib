using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Algebra.Pylonomial pylonomial = new Algebra.Pylonomial("x^2^+x-2");
            Algebra.Product product = new Algebra.Product();
            pylonomial.Factorization(out product);
            Console.WriteLine(product.Value);
            Console.ReadKey();
        }
    }
}
