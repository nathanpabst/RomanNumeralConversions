using System;
using RomanNumeralConversions;

namespace RomanNumeralConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            var getNumeral = new NumberToRoman();
            getNumeral.ConvertToRoman(1);
            Console.WriteLine(getNumeral);

            Console.Read();
        }
    }
}
