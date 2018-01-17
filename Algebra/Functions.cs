using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Algebra
{
    public struct SpliedNumber
    {
        public BigInteger num1;
        public BigInteger num2;
    }
    public class Functions
    {
        public static Fraction.Fraction OutputNumbers(String input, ref List<Letter> output)
        {
            const String list = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Regex m = new Regex(@"^[A-Za-z]\^(\d+)\^$");
            String parttern = @"\d+";
            for (BigInteger i=0;i<list.Length;i+=1)
            {
                if (input.Contains(list[(Int32)i].ToString()))
                {
                    Int64 t = input.IndexOf(list[(Int32)i]);
                    if (input[(Int32)t + 1].ToString() == @"^")
                    {
                        for(Int64 j = 4; j < list.Length-i; j += 1)
                        {
                            String temp = input.Substring((Int32)t, (Int32)j);
                            if (m.IsMatch(temp))
                            {
                                Match f = Regex.Match(temp, parttern);
                                BigInteger bigInteger = BigInteger.Parse(f.Groups[0].Value);
                                output.Add(new Letter(list[(Int32)i], bigInteger));
                                input = input.Replace(temp, "");
                                break;
                            }
                        }
                    }
                    else
                    {
                        output.Add(new Letter(list[(Int32)i]));
                        input = input.Replace(i.ToString(), "");
                    }
                }
            }
            return Fraction.Fraction.Parse(input);
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
