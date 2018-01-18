using System;
using System.Collections.Generic;

namespace Algebra
{
    partial class Pylonomial
    {
        public static Pylonomial TryFactorization()
        {
            return new Pylonomial();
        }
        public Boolean Factorization()
        {
            if (moList.Count == 3)
            {
                List<SpliedNumber> list1 = Functions.Split((Int64)(Double)moList[0].AbsCoefficient);
                List<SpliedNumber> list2 = Functions.Split((Int64)(Double)moList[2].Coefficient);
                List<Int64> list3=new List<Int64>();
                foreach (var i in list1)
                {
                    foreach(var j in list2)
                    {
                        if ((i.num1 * j.num2 + i.num2 * j.num1) == (Int64)(Double)moList[1].Coefficient)
                        {
                            SpliedNumber ti=i, tj=j;
                            String sign = "";
                            if (ti.num1 < 0 && ti.num2 < 0) 
                            {
                                ti.num1 = -ti.num1;
                                ti.num2 = -ti.num2;
                                tj.num1 = -tj.num1;
                                tj.num2 = -tj.num2;
                            }
                            else if(ti.num1<0 && ti.num2 > 0)
                            {
                                ti.num1 = -ti.num1;
                                tj.num1 = -tj.num1;
                                sign = "-";
                            }
                            else if (ti.num1 > 0 && ti.num2 < 0)
                            {
                                ti.num2 = -ti.num2;
                                tj.num2 = -tj.num2;
                                sign = "-";
                            }
                            Console.WriteLine(sign + "(" + (ti.num1==1?"":ti.num1.ToString()) + "x" + (tj.num1 < 0 ? tj.num1.ToString() : "+" + tj.num1.ToString()) + ")(" + (ti.num2 == 1 ? "" : ti.num2.ToString()) + "x" + (tj.num2 < 0 ? tj.num2.ToString() : "+" + tj.num2.ToString()) + ")");
                            return true;
                        }
                    }
                }
                return false;
            }
            else
            {
                throw new Exception("Use TryFactorization() instead. ");
            }
        }
    }
}
