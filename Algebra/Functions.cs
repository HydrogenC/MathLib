using System;
using System.Collections.Generic;

namespace Algebra
{
    public class Functions
    {
        public static Fraction.Fraction OutputNumbers(String input, List<Char> output)
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
    }
}
