using System;
using System.Collections.Generic;

namespace Algebra
{
    public struct SpliedNumber
    {
        public Int64 num1;
        public Int64 num2;
    }
    partial class Pylonomial
    {
        public static List<SpliedNumber> Split(Int64 integer)
        {
            Int64 abs = integer < 0 ? -integer : integer;
            List<SpliedNumber> temp = new List<SpliedNumber>();
            for (Int64 i = -abs; i <= abs; i += 1)
            {
                SpliedNumber spliedNumber = new SpliedNumber();
                if (i == 0)
                {
                    continue;
                }
                if (integer % i == 0)
                {
                    spliedNumber.num1 = i;
                    spliedNumber.num2 = integer / i;
                    temp.Add(spliedNumber);
                }
            }
            return temp;
        }

        public static Boolean TryFactorization(Pylonomial pylonomial, out Product product, out Pylonomial others)
        {
            product = new Product();
            others = new Pylonomial();
            Boolean succeed = false;
            for (Int64 i = 0; i < pylonomial.moList.Count - 2; i += 1)
            {
                for (Int64 j = i + 1; j < pylonomial.moList.Count - 1; j += 1)
                {
                    for (Int64 n = j + 1; n < pylonomial.moList.Count; n += 1)
                    {
                        Pylonomial temp = new Pylonomial(pylonomial.moList[(Int32)i].ToString(true, true) + pylonomial.moList[(Int32)j].ToString(true, true) + pylonomial.moList[(Int32)n].ToString(true, true));
                        succeed = Factorization(temp, out product);
                        if (succeed)
                        {
                            for (Int64 m=0;m< pylonomial.moList.Count; m += 1)
                            {
                                if (m == i || m == j || m == n)
                                {
                                    continue;
                                }
                                else
                                {
                                    others.Add(pylonomial.moList[(Int32)m]);
                                }
                            }
                            {

                            }
                            break;
                        }
                        else
                        {
                            product = new Product();
                        }
                    }
                    if (succeed)
                    {
                        break;
                    }
                }
                if (succeed)
                {
                    break;
                }
            }
            return succeed;
        }

        public static Boolean Factorization(Pylonomial list, out Product product)
        {
            if (list.moList.Count == 3 && (list.moList[0].Letters[0].Exponent == 2))
            {
                Boolean sig = true;
                if (list.moList[0].Coefficient < 0)
                {
                    list.ChangeSign();
                    sig = false;
                }
                Char letter = list.moList[0].Letters[0].GetLetter;
                List<SpliedNumber> list1 = Split((Int64)list.moList[0].Coefficient);
                List<SpliedNumber> list2 = Split((Int64)list.moList[2].Coefficient);
                List<Int64> list3 = new List<Int64>();
                foreach (var i in list1)
                {
                    foreach (var j in list2)
                    {
                        if ((i.num1 * j.num2 + i.num2 * j.num1) == (Int64)list.moList[1].Coefficient)
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
            product = new Product();
            return false;
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
