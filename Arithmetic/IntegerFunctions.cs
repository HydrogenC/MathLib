using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic
{
    public class IntegerFunctions
    {
        /// <summary>
        /// Returns the LCM or GCD
        /// </summary>
        /// <param name="a">The numbers</param>
        /// <param name="b">The numbers</param>
        /// <param name="type">If true, it returns GCD, else returns LCM</param>
        /// <returns></returns>
        public static Int64 GetLCMGCD(Int64 a, Int64 b, Boolean type)
        {
            Int64 min = a < b ? a : b;
            Int64 max = a > b ? a : b;
            Int64 LCM;
            for (Int64 i = 1; ; i += 1)
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
