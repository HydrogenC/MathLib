using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    partial class Fraction
    {
        public override String ToString()
        {
            return numerator + "/" + denominator;
        }

        public override bool Equals(object obj)
        {
            if (this == (Fraction)obj)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override Int32 GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
