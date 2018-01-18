using System;

namespace Fraction
{
    partial class Fraction
    {
        public static implicit operator Decimal(Fraction a)
        {
            return (Decimal)a.Numerator / (Decimal)a.Denominator;
        }

        public static implicit operator Double(Fraction a)
        {
            return (Double)a.Numerator / (Double)a.Denominator;
        }

        public static explicit operator String(Fraction a)
        {
            return a.ToString();
        }

        public static explicit operator Int64(Fraction a)
        {
            return (Int64)(a.Numerator / a.Denominator);
        }

        public static implicit operator Fraction(Decimal a)
        {
            return new Fraction(a);
        }

        public static implicit operator Fraction(Double a)
        {
            return new Fraction(a);
        }

        public static explicit operator Fraction(String a)
        {
            return new Fraction(a);
        }

        public static explicit operator Fraction(Int64 a)
        {
            return new Fraction(a);
        }

    }
}
