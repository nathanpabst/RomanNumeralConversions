﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralConversions
{
    public class NumberToRoman
    {
        public static string ConvertToRoman(int number)
        {
            var romanNumeral = "";
            if (number < 4)
            {
                for (var i = 0; i < number; i++)
                {
                    romanNumeral += "I";
                }
            }
            else if (number == 5)
            {
                romanNumeral = "V";
            }
            else if (number > 5 && number < 9)
            {
                romanNumeral = "V";
                number -= 5;
                for (var i = 0; i < number; i++)
                {
                    romanNumeral += "I";
                }
                Console.WriteLine(romanNumeral.ToString());
            }

            return romanNumeral;
        }
    }

}

