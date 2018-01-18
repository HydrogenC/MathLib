using System;
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
            Int64 lcm = GetLCMGCD(a.Denominator, b.Denominator, LCM);
            return new Fraction(a.Numerator * (lcm / a.Denominator) + b.Numerator * (lcm / b.Denominator), lcm);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            Int64 lcm = GetLCMGCD(a.Denominator, b.Denominator, LCM);
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

        public static Boolean operator <(Fraction a, Fraction b)
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

        public static Fraction operator +(Int64 a, Fraction b)
        {
            return (Fraction)a + b;
        }

        public static Fraction operator +(Fraction a, Int64 b)
        {
            return a + (Fraction)b;
        }

        public static Fraction operator +(Fraction a, Decimal b)
        {
            return a + (Fraction)b;
        }

        public static Fraction operator +(Decimal a, Fraction b)
        {
            return (Fraction)a + b;
        }

        public static Fraction operator -(Int64 a, Fraction b)
        {
            return (Fraction)a - b;
        }

        public static Fraction operator -(Fraction a, Int64 b)
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

        public static Fraction operator *(Int64 a, Fraction b)
        {
            return (Fraction)a * b;
        }

        public static Fraction operator *(Fraction a, Int64 b)
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

        public static Fraction operator /(Int64 a, Fraction b)
        {
            return (Fraction)a / b;
        }

        public static Fraction operator /(Fraction a, Int64 b)
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
            return new Fraction(-a.Numerator, a.Denominator);
        }

        public static Fraction operator +(Fraction a)
        {
            return a;
        }

        public static Int64 operator %(Fraction a, Fraction b)
        {
            return (Int64)((Decimal)a % (Decimal)b);
        }

        public static Int64 operator %(Decimal a, Fraction b)
        {
            return (Int64)(a % (Decimal)b);
        }

        public static Int64 operator %(Fraction a, Decimal b)
        {
            return (Int64)((Decimal)a % b);
        }

        public static Int64 operator %(Int64 a, Fraction b)
        {
            return (Int64)(a % (Decimal)b);
        }

        public static Int64 operator %(Fraction a, Int64 b)
        {
            return (Int64)((Decimal)a % b);
        }

        public static Boolean operator >(Int64 a, Fraction b)
        {
            return a > (Decimal)b;
        }

        public static Boolean operator <(Int64 a, Fraction b)
        {
            return a < (Decimal)b;
        }

        public static Boolean operator >=(Int64 a, Fraction b)
        {
            return a >= (Decimal)b;
        }

        public static Boolean operator <=(Int64 a, Fraction b)
        {
            return a <= (Decimal)b;
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


        public static Boolean operator >(Fraction a, Int64 b)
        {
            return (Decimal)a > b;
        }

        public static Boolean operator <(Fraction a, Int64 b)
        {
            return (Decimal)a < b;
        }

        public static Boolean operator >=(Fraction a, Int64 b)
        {
            return (Decimal)a >= b;
        }

        public static Boolean operator <=(Fraction a, Int64 b)
        {
            return (Decimal)a <= b;
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

        public static Boolean operator ==(Fraction a, Int64 b)
        {
            return (Decimal)a == (Decimal)b;
        }

        public static Boolean operator !=(Fraction a, Int64 b)
        {
            return (Decimal)a != (Decimal)b;
        }

        public static Boolean operator ==(Int64 a, Fraction b)
        {
            return (Decimal)a == (Decimal)b;
        }

        public static Boolean operator !=(Int64 a, Fraction b)
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
