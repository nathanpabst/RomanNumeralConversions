using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralConversions
{
    class RomanNumeralConverter
    {
        private readonly string[] Ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        private readonly string[] Tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        private readonly string[] Hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        private readonly string[] Thousands = { "", "M", "MM", "MMM" };

        private readonly Dictionary<char, int> RomanCharacters = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };


    }
}
