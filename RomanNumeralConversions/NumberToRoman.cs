using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralConversions
{
    public class NumberToRoman
    {
        public void ConvertToRoman(int number)
        {
            
                var romanNumeral = "";
                if (number < 4)
                {
                    for (var i = 0; i < number; i++)
                    {
                        romanNumeral += "I";
                    }
                }
            
        }

    }
}
