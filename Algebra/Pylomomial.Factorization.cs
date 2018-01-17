using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algebra
{
    partial class Pylonomial
    {
        public static Pylonomial TryFactorization()
        {
            return new Pylonomial();
        }
        public void Factorization()
        {
            if (moList.Count == 3)
            {
                List<SpliedNumber> list1 = Functions.Split((BigInteger)moList[0].AbsCoefficient);
                List<SpliedNumber> list2 = Functions.Split((BigInteger)moList[2].Coefficient);
                List<BigInteger> list3=new List<BigInteger>();
                foreach (var i in list1)
                {
                    foreach(var j in list2)
                    {
                        if ((i.num1 * j.num2 + i.num2 * j.num1) == (BigInteger)moList[1].Coefficient)
                        {
                            Console.WriteLine("("+i.num1+"x+"+j.num1+")("+i.num2+"x+"+j.num2+")");
                            return;
                        }
                    }
                }
            }
            else
            {
                throw new Exception("Use TryFactorization() instead. ");
            }
        }
    }
}
