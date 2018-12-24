using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RomanNumeralConversions
{
    public class RomanNumeralConverter
    {
        private readonly string[] Ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        private readonly string[] Tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        private readonly string[] Hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        private readonly string[] Thousands = { "", "M", "MM", "MMM" };

        private readonly Dictionary<char, int> RomanCharactersDict = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

        public string ConvertNumToRoman(int number)
        {
            var numToCheck = new Stack<int>();
            while (number != 0)
            {
                numToCheck.Push(number % 10);
                number /= 10;
            }

            var numArray = numToCheck.ToArray();
            if (numToCheck.Count == 1)
            {
                return Ones[numArray[0]];
            }

            return "Invalid input";
        }


    }
}
