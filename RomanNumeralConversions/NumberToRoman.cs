using System;
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
                Console.WriteLine(romanNumeral.ToString());
            }
            else if (number == 5)
            {
                romanNumeral = "V";
            }
            Console.WriteLine(romanNumeral.ToString());

            return romanNumeral;

        }

    }
}
