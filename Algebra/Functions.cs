using System;
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
            const String letterWithExp = @"[A-Za-z]\^(\d+)\^";
            String patternLetter = @"[A-Za-z]";
            String patternExp = @"\d+";
            MatchCollection match = Regex.Matches(input, letterWithExp);
            for (Int64 i = 0; i < match.Count; i += 1)
            {
                Int64 exp = Int64.Parse(Regex.Match(match[(Int32)i].Value, patternExp).Value);
                input = input.Replace(match[(Int32)i].Value, "");
                output.Add(new Letter(Regex.Match(match[(Int32)i].Value, patternLetter).Value[0], exp));
            }
            MatchCollection matchCollection = Regex.Matches(input, patternLetter);
            for (Int64 i = 0; i < matchCollection.Count; i += 1)
            {
                output.Add(new Letter(matchCollection[(Int32)i].Value[0]));
                input = input.Replace(matchCollection[(Int32)i].Value, "");
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
    }
}