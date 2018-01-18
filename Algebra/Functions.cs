using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Algebra
{
    public struct SpliedNumber
    {
        public Int64 num1;
        public Int64 num2;
    }
    public class Functions
    {
        public static Fraction.Fraction OutputNumbers(String input, ref List<Letter> output)
        {
            const String list = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const String letterWithExp = @"[A-Za-z]\^(\d+)\^";
            String patternLetter = @"[A-Za-z]{1}";
            String patternExp = @"\d+";
            Match match = Regex.Match(input, letterWithExp);
            for(Int64 i = 0; i < match.Groups.Count; i += 1)
            {
                Match m = Regex.Match(match.Groups[(Int32)i].Value, patternExp);
                Int64 exp = Int64.Parse(m.Groups[0].Value);
                input = input.Replace(match.Groups[(Int32)i].Value, "");
                Match ma = Regex.Match(match.Groups[(Int32)i].Value, patternLetter);
                output.Add(new Letter(ma.Groups[0].Value[0],exp));
            }
            Match mat = Regex.Match(input, patternLetter);
            for(Int64 i = 0; i < mat.Groups.Count; i += 1)
            {
                output.Add(new Letter(mat.Groups[(Int32)i].Value[0]));
                input = input.Replace(mat.Groups[(Int32)i].Value, "");
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

        public static List<SpliedNumber> Split(Int64 integer)
        {
            Int64 abs = integer < 0 ? -integer : integer;
            List<SpliedNumber> temp = new List<SpliedNumber>();
            for (Int64 i = -abs; i <= abs; i += 1)
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