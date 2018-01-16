using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    partial class Fraction
    {
        public static explicit operator Decimal(Fraction a)
        {
            return (Decimal)a.Numerator / (Decimal)a.Denominator;
        }
        public static explicit operator Double(Fraction a)
        {
            return (Double)(Decimal)a;
        }
        public static explicit operator BigInteger(Fraction a)
        {
            return (BigInteger)Math.Floor((Decimal)a);
        }
        public static explicit operator String(Fraction a)
        {
            return a.ToString();
        }
        public static explicit operator Fraction(Decimal a)
        {
            return new Fraction(a);
        }
        public static explicit operator Fraction(String a)
        {
            return new Fraction(a);
        }
        public static explicit operator Fraction(BigInteger a)
        {
            return new Fraction(a);
        }
        public static explicit operator Fraction(Double a)
        {
            return new Fraction((Decimal)a);
        }
    }
}
