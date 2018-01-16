using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctions
{
    public class IntegerFunctions
    {
        /// <summary>
        /// Returns the LCM or GCD
        /// </summary>
        /// <param name="a">The numbers</param>
        /// <param name="b">The numbers</param>
        /// <param name="gcd">If true, it returns GCD, else returns LCM</param>
        /// <returns></returns>
        public static BigInteger GetLCMGCD(BigInteger a, BigInteger b, Boolean type)
        {
            BigInteger min = a < b ? a : b;
            BigInteger max = a > b ? a : b;
            BigInteger LCM;
            for (BigInteger i = 1; ; i += 1)
            {
                if ((max * i) % min == 0)
                {
                    LCM = max * i;
                    break;
                }
            }

            if (type==GCD)
            {
                return a / (LCM / b);
            }
            else
            {
                return LCM;
            }
        }

        public static Boolean GCD
        {
            get => true;
        }

        public static Boolean LCM
        {
            get => false;
        }
    }
}
