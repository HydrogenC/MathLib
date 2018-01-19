using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Algebra
{
    partial class Monomial
    {
        public Monomial Abs() => new Monomial(AbsCoefficient, Letters);

        public static Fraction.Fraction OutputNumbers(String input, ref List<Letter> output)
        {
            const String letterWithExp = @"[A-Za-z]\^(\d+)\^";
            const String patternLetter = @"[A-Za-z]";
            const String patternExp = @"\d+";
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

        public static List<Letter> OutputNumbers(String input)
        {
            List<Letter> list = new List<Letter>();
            const String letterWithExp = @"[A-Za-z]\^(\d+)\^";
            const String patternLetter = @"[A-Za-z]";
            const String patternExp = @"\d+";
            MatchCollection match = Regex.Matches(input, letterWithExp);
            for (Int64 i = 0; i < match.Count; i += 1)
            {
                Int64 exp = Int64.Parse(Regex.Match(match[(Int32)i].Value, patternExp).Value);
                input = input.Replace(match[(Int32)i].Value, "");
                list.Add(new Letter(Regex.Match(match[(Int32)i].Value, patternLetter).Value[0], exp));
            }
            MatchCollection matchCollection = Regex.Matches(input, patternLetter);
            for (Int64 i = 0; i < matchCollection.Count; i += 1)
            {
                list.Add(new Letter(matchCollection[(Int32)i].Value[0]));
                input = input.Replace(matchCollection[(Int32)i].Value, "");
            }
            return list;
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

        public void Add(Letter letter)
        {
            moLetters.Add(letter);
        }

        public void Add(String monomial)
        {
            Monomial temp = new Monomial(monomial);
            foreach(var i in temp.Letters)
            {
                moLetters.Add(i);
            }
        }

        public void Add(Monomial monomial)
        {
            foreach (var i in monomial.Letters)
            {
                moLetters.Add(i);
            }
        }
    }
}