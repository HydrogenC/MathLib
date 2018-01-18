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
        public Boolean Factorization(out Product product)
        {
            if (moList.Count == 3 && (moList[0].Letters[0].Exponent==2))
            {
                Boolean sig = true;
                if (moList[0].Coefficient < 0)
                {
                    ChangeSign();
                    sig = false;
                }
                Char letter = moList[0].Letters[0].GetLetter;
                List<SpliedNumber> list1 = Functions.Split((Int64)moList[0].Coefficient);
                List<SpliedNumber> list2 = Functions.Split((Int64)moList[2].Coefficient);
                List<Int64> list3 = new List<Int64>();
                foreach (var i in list1)
                {
                    foreach (var j in list2)
                    {
                        if ((i.num1 * j.num2 + i.num2 * j.num1) == (Int64)moList[1].Coefficient)
                        {
                            SpliedNumber ti = i, tj = j;
                            Boolean sign = true;
                            if (ti.num1 < 0 && ti.num2 < 0)
                            {
                                ti.num1 = -ti.num1;
                                ti.num2 = -ti.num2;
                                tj.num1 = -tj.num1;
                                tj.num2 = -tj.num2;
                            }
                            else if (ti.num1 < 0 && ti.num2 > 0)
                            {
                                ti.num1 = -ti.num1;
                                tj.num1 = -tj.num1;
                                sign = false;
                            }
                            else if (ti.num1 > 0 && ti.num2 < 0)
                            {
                                ti.num2 = -ti.num2;
                                tj.num2 = -tj.num2;
                                sign = false;
                            }
                            product = new Product();
                            if (sig == sign)
                            {
                                product.IsPositive = true;
                            }
                            else
                            {
                                product.IsPositive = false;
                            }
                            product.Add(new Pylonomial((ti.num1 == 1 ? "" : ti.num1.ToString()) + letter + (tj.num1 < 0 ? tj.num1.ToString() : "+" + tj.num1.ToString())));
                            product.Add(new Pylonomial((ti.num2 == 1 ? "" : ti.num2.ToString()) + letter + (tj.num2 < 0 ? tj.num2.ToString() : "+" + tj.num2.ToString())));
                            return true;
                        }
                    }
                }
                product = new Product();
                return false;
            }
            else
            {
                throw new Exception("Use TryFactorization() instead. ");
            }
        }
        public Int64 Round()
        {
            for (Int64 i = 1; ; i += 1)
            {
                Boolean isInteger = true;
                foreach (var j in Monomials)
                {
                    if (((Decimal)i * (Decimal)j.Coefficient) % 1 != 0)
                    {
                        isInteger = false;
                    }
                }

                if (isInteger)
                {
                    foreach (var j in Monomials)
                    {
                        j.Coefficient *= i;
                    }
                    return i;
                }
            }
        }
    }
}
