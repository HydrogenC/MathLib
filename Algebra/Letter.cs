using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algebra
{
    public class Letter
    {
        private BigInteger exponent = 1;
        private Char letter;
        public Letter(Char lLetter)
        {
            letter = lLetter;
        }
        public Letter(Char lLetter,BigInteger exp)
        {
            letter = lLetter;
            exponent = exp;
        }

        public char GetLetter {
            get => letter;
            set => letter = value;
        }
        public BigInteger Exponent {
            get => exponent;
            set => exponent = value;
        }
    }
}
