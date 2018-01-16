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
        private BigInteger denominator;
        //The sign symbol is only stored in Numerator
        private BigInteger numerator;
        public Fraction()
        {
            denominator = 1;
            numerator = 0;
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
            Adjust();
            Reduct();
        }
        public Fraction(Fraction numer, BigInteger deno)
        {
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

        }

        public Fraction(BigInteger numer,Decimal deno)
        {

        }

        public Fraction(Decimal numer,Decimal deno)
        {

        }

        public Fraction(Decimal numer, Fraction deno)
        {

        }

        public Fraction(Fraction deno,Decimal numer)
        {

        }

        public Fraction(String frac)
        {
            for(Int64 i = 0; i < frac.Length;i+=1)
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

        }

        public Fraction(BigInteger number)
        {
            numerator = number;
            denominator = 1;
        }

        public BigInteger Numerator {
            get => numerator;
            set {
                numerator = value;
                Reduct();
            }
        }
        public BigInteger Denominator {
            get => denominator;
            set {
                denominator = value;
                Adjust();
                Reduct();
            }
        }
    }
}
