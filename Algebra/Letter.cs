using System;

namespace Algebra
{
    public class Letter
    {
        private Int64 exponent = 1;
        private Char letter;
        public Letter(Char lLetter)
        {
            letter = lLetter;
        }
        public Letter(Char lLetter, Int64 exp)
        {
            letter = lLetter;
            exponent = exp;
        }

        public char GetLetter
        {
            get => letter;
            set => letter = value;
        }
        public Int64 Exponent
        {
            get => exponent;
            set => exponent = value;
        }
    }
}
