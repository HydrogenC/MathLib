using System;

namespace Fraction
{
    partial class Fraction
    {
        public Fraction Reciprocal() => new Fraction(denominator, numerator);

        public Fraction Sqrt() => new Fraction((Int64)Math.Sqrt(denominator), (Int64)Math.Sqrt(denominator));

        public Fraction HDSqrt() => new Fraction(Math.Sqrt(denominator), Math.Sqrt(denominator));

        public Fraction Pow(Double times) => new Fraction((Int64)Math.Pow(numerator, times), (Int64)Math.Pow(denominator, times));

        public Fraction HDPow(Double times) => new Fraction(Math.Pow(numerator, times), Math.Pow(denominator, times));

        private void Reduct()
        {
            if (numerator != 0)
            {
                Int64 gcd = Arithmetic.IntegerFunctions.GetLCMGCD(numerator, denominator, Arithmetic.IntegerFunctions.GCD);
                numerator = numerator / gcd;
                denominator = denominator / gcd;
            }
        }

        public void Adjust()
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException();
            }
            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }
        }

        public Fraction Abs() => new Fraction(Math.Abs(numerator), denominator);

        public static Fraction Parse(String fraction) => new Fraction(fraction);
    }
}
