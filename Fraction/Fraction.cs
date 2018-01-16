using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    public partial class Fraction
    {
        private BigInteger denominator=1;
        //The sign symbol is only stored in Numerator
        private BigInteger numerator=0;
        public Fraction()
        {
            
        }
        public Fraction(BigInteger numer, BigInteger deno)
        {
            numerator = numer;
            denominator = deno;
            Adjust();
            Reduct();
        }
        public Fraction(Fraction numer, Fraction deno)
        {
            BigInteger lcm = Arithmetic.IntegerFunctions.GetLCMGCD(numer.Denominator, deno.Denominator, Arithmetic.IntegerFunctions.LCM);
            numerator = numer.Numerator * (lcm / numer.Denominator);
            denominator = deno.Numerator * (lcm / deno.Denominator);
            Adjust();
            Reduct();
        }
        public Fraction(Fraction numer, BigInteger deno)
        {
            denominator = deno * numer.Denominator;
            numerator = numer.Numerator;
            Adjust();
            Reduct();
        }
        public Fraction(BigInteger numer, Fraction deno)
        {
            denominator = deno.Numerator;
            numerator = numer * deno.Denominator;
            Adjust();
            Reduct();
        }

        public Fraction(Decimal numer, BigInteger deno)
        {
            Fraction temp = (Fraction)numer;
            denominator = deno * temp.Denominator;
            numerator = temp.Numerator;
            Adjust();
            Reduct();
        }

        public Fraction(BigInteger numer, Decimal deno)
        {
            Fraction temp = (Fraction)deno;
            denominator = temp.Numerator;
            numerator = numer * temp.Denominator;
            Adjust();
            Reduct();
        }

        public Fraction(Decimal numer, Decimal deno)
        {
            Fraction t1 = (Fraction)numer;
            Fraction t2 = (Fraction)deno;
            BigInteger lcm = Arithmetic.IntegerFunctions.GetLCMGCD(t1.Denominator, t2.Denominator, Arithmetic.IntegerFunctions.LCM);
            numerator = t1.Numerator * (lcm / t1.Denominator);
            denominator = t2.Numerator * (lcm / t2.Denominator);
            Adjust();
            Reduct();
        }

        public Fraction(Decimal numer, Fraction deno)
        {
            Fraction t1 = (Fraction)numer;
            BigInteger lcm = Arithmetic.IntegerFunctions.GetLCMGCD(t1.Denominator, deno.Denominator, Arithmetic.IntegerFunctions.LCM);
            numerator = t1.Numerator * (lcm / t1.Denominator);
            denominator = deno.Numerator * (lcm / deno.Denominator);
            Adjust();
            Reduct();
        }

        public Fraction(Fraction numer, Decimal deno)
        {
            Fraction t2 = (Fraction)deno;
            BigInteger lcm = Arithmetic.IntegerFunctions.GetLCMGCD(numer.Denominator, t2.Denominator, Arithmetic.IntegerFunctions.LCM);
            numerator = numer.Numerator * (lcm / numer.Denominator);
            denominator = t2.Numerator * (lcm / t2.Denominator);
            Adjust();
            Reduct();
        }

        public Fraction(String frac)
        {
            for (Int64 i = 0; i < frac.Length; i += 1)
            {
                if (frac[(Int32)i] == '/')
                {
                    numerator = BigInteger.Parse(frac.Substring(0, (Int32)i));
                    denominator = BigInteger.Parse(frac.Substring((Int32)i + 1));
                    break;
                }
            }
            Adjust();
            Reduct();
        }

        public Fraction(Decimal number)
        {
            Decimal multiplier = 1;
            while (true)
            {
                if (number * multiplier % 1 == 0)
                {
                    numerator = (BigInteger)(number * multiplier);
                    denominator = (BigInteger)multiplier;
                    break;
                }
                else
                {
                    multiplier *= 10;
                }
            }
            Reduct();
        }

        public Fraction(BigInteger number)
        {
            numerator = number;
            denominator = 1;
        }

        public Fraction(Double number)
        {
            Double multiplier = 1;
            while (true)
            {
                if (number * multiplier % 1 == 0)
                {
                    numerator = (BigInteger)(number * multiplier);
                    denominator = (BigInteger)multiplier;
                    break;
                }
                else
                {
                    multiplier *= 10;
                }
            }
            Reduct();
        }

        public BigInteger Numerator
        {
            get => numerator;
            set
            {
                numerator = value;
                Reduct();
            }
        }
        public BigInteger Denominator
        {
            get => denominator;
            set
            {
                denominator = value;
                Adjust();
                Reduct();
            }
        }
    }
}
