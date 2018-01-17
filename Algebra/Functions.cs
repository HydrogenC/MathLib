using System;
using System.Numerics;
using System.Collections.Generic;

namespace Algebra
{
    public struct SpliedNumber
    {
        public BigInteger num1;
        public BigInteger num2;
    }
    public class Functions
    {
        public static Fraction.Fraction OutputNumbers(String input, ref List<Char> output)
        {
            const String list = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            String temp = input;
            foreach (Char i in list)
            {
                if (temp.Contains(i.ToString()))
                {
                    output.Add(i);
                    temp=temp.Replace(i.ToString(), "");
                }
            }
            return Fraction.Fraction.Parse(temp);
        }

        public static Boolean ContainsLetters(String input)
        {
            const String list = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (Char i in list)
            {
                if (input.Contains(i.ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        public static List<SpliedNumber> Split(BigInteger integer)
        {
            BigInteger abs = integer < 0 ? -integer : integer;
            List<SpliedNumber> temp = new List<SpliedNumber>();
            for (BigInteger i = -abs; i <= abs; i += 1)
            {
                SpliedNumber spliedNumber=new SpliedNumber();
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
    }
}
