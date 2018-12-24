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
            if (numToCheck.Count == 2)
            {
                return Tens[numArray[0]] + Ones[numArray[1]];
            }
            if (numToCheck.Count == 3)
            {
                return Hundreds[numArray[0]] + Tens[numArray[1]] + Ones[numArray[2]];
            }
            if (numToCheck.Count == 4)
            {
                return Thousands[numArray[0]] + Hundreds[numArray[1]] + Tens[numArray[2]] + Ones[numArray[3]];
            }

            return "Invalid input";
        }


    }
}
