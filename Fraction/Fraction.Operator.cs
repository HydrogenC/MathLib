using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static Arithmetic.IntegerFunctions;

namespace Fraction
{
    partial class Fraction
    {
        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            BigInteger lcm = GetLCMGCD(a.Denominator, b.Denominator,LCM);
            return new Fraction(a.Numerator * (lcm / a.Denominator) + b.Numerator * (lcm / b.Denominator), lcm);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            BigInteger lcm = GetLCMGCD(a.Denominator, b.Denominator,LCM);
            return new Fraction(a.Numerator * (lcm / a.Denominator) - b.Numerator * (lcm / b.Denominator), lcm);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            return a * b.Reciprocal();
        }

        public static Boolean operator ==(Fraction a, Fraction b)
        {
            return a.ToString() == b.ToString();
        }

        public static Boolean operator !=(Fraction a, Fraction b)
        {
            return a.ToString() != b.ToString();
        }

        public static Boolean operator <(Fraction a,Fraction b)
        {
            return (Decimal)a < (Decimal)b;
        }

        public static Boolean operator >(Fraction a, Fraction b)
        {
            return (Decimal)a > (Decimal)b;
        }

        public static Boolean operator <=(Fraction a, Fraction b)
        {
            return (Decimal)a <= (Decimal)b;
        }

        public static Boolean operator >=(Fraction a, Fraction b)
        {
            return (Decimal)a >= (Decimal)b;
        }

        public static Fraction operator +(BigInteger a,Fraction b)
        {
            return (Fraction)a + b;
        }

        public static Fraction operator +(Fraction a, BigInteger b)
        {
            return a + (Fraction)b;
        }

        public static Fraction operator +(Fraction a,Decimal b)
        {
            return a + (Fraction)b;
        }

        public static Fraction operator +(Decimal a, Fraction b)
        {
            return (Fraction)a + b;
        }

        public static Fraction operator -(BigInteger a, Fraction b)
        {
            return (Fraction)a - b;
        }

        public static Fraction operator -(Fraction a, BigInteger b)
        {
            return a - (Fraction)b;
        }

        public static Fraction operator -(Fraction a, Decimal b)
        {
            return a - (Fraction)b;
        }

        public static Fraction operator -(Decimal a, Fraction b)
        {
            return (Fraction)a - b;
        }

        public static Fraction operator *(BigInteger a, Fraction b)
        {
            return (Fraction)a * b;
        }

        public static Fraction operator *(Fraction a, BigInteger b)
        {
            return a * (Fraction)b;
        }

        public static Fraction operator *(Fraction a, Decimal b)
        {
            return a * (Fraction)b;
        }

        public static Fraction operator *(Decimal a, Fraction b)
        {
            return (Fraction)a * b;
        }

        public static Fraction operator /(BigInteger a, Fraction b)
        {
            return (Fraction)a / b;
        }

        public static Fraction operator /(Fraction a, BigInteger b)
        {
            return a / (Fraction)b;
        }

        public static Fraction operator /(Fraction a, Decimal b)
        {
            return a / (Fraction)b;
        }

        public static Fraction operator /(Decimal a, Fraction b)
        {
            return (Fraction)a / b;
        }

        public static Fraction operator -(Fraction a)
        {
            return (BigInteger)0 - a;
        }

        public static Fraction operator +(Fraction a)
        {
            return a;
        }

        public static BigInteger operator %(Fraction a,Fraction b)
        {
            return (BigInteger)((Decimal)a % (Decimal)b);
        }

        public static BigInteger operator %(Decimal a, Fraction b)
        {
            return (BigInteger)(a % (Decimal)b);
        }

        public static BigInteger operator %(Fraction a, Decimal b)
        {
            return (BigInteger)((Decimal)a % b);
        }

        public static BigInteger operator %(BigInteger a, Fraction b)
        {
            return (BigInteger)((Decimal)a % (Decimal)b);
        }

        public static BigInteger operator %(Fraction a, BigInteger b)
        {
            return (BigInteger)((Decimal)a % (Decimal)b);
        }

        public static Boolean operator >(BigInteger a,Fraction b)
        {
            return (Decimal)a > (Decimal)b;
        }

        public static Boolean operator <(BigInteger a, Fraction b)
        {
            return (Decimal)a < (Decimal)b;
        }

        public static Boolean operator >=(BigInteger a, Fraction b)
        {
            return (Decimal)a >= (Decimal)b;
        }

        public static Boolean operator <=(BigInteger a, Fraction b)
        {
            return (Decimal)a <= (Decimal)b;
        }

        public static Boolean operator >(Decimal a, Fraction b)
        {
            return a > (Decimal)b;
        }

        public static Boolean operator <(Decimal a, Fraction b)
        {
            return a < (Decimal)b;
        }

        public static Boolean operator >=(Decimal a, Fraction b)
        {
            return a >= (Decimal)b;
        }

        public static Boolean operator <=(Decimal a, Fraction b)
        {
            return a <= (Decimal)b;
        }


        public static Boolean operator >(Fraction a, BigInteger b)
        {
            return (Decimal)a > (Decimal)b;
        }

        public static Boolean operator <(Fraction a, BigInteger b)
        {
            return (Decimal)a < (Decimal)b;
        }

        public static Boolean operator >=(Fraction a, BigInteger b)
        {
            return (Decimal)a >= (Decimal)b;
        }

        public static Boolean operator <=(Fraction a, BigInteger b)
        {
            return (Decimal)a <= (Decimal)b;
        }

        public static Boolean operator >(Fraction a, Decimal b)
        {
            return (Decimal)a > b;
        }

        public static Boolean operator <(Fraction a, Decimal b)
        {
            return (Decimal)a < b;
        }

        public static Boolean operator >=(Fraction a, Decimal b)
        {
            return (Decimal)a >= b;
        }

        public static Boolean operator <=(Fraction a, Decimal b)
        {
            return (Decimal)a <= b;
        }

        public static Boolean operator ==(Fraction a,BigInteger b)
        {
            return (Decimal)a == (Decimal)b;
        }

        public static Boolean operator !=(Fraction a, BigInteger b)
        {
            return (Decimal)a != (Decimal)b;
        }

        public static Boolean operator ==(BigInteger a, Fraction b)
        {
            return (Decimal)a == (Decimal)b;
        }

        public static Boolean operator !=(BigInteger a, Fraction b)
        {
            return (Decimal)a != (Decimal)b;
        }

        public static Boolean operator ==(Fraction a, Decimal b)
        {
            return (Decimal)a == b;
        }

        public static Boolean operator !=(Fraction a, Decimal b)
        {
            return (Decimal)a != b;
        }

        public static Boolean operator ==(Decimal a, Fraction b)
        {
            return a == (Decimal)b;
        }

        public static Boolean operator !=(Decimal a, Fraction b)
        {
            return a != (Decimal)b;
        }
    }
}
