using System;
using Xunit;
using RomanNumeralConversions;

namespace RomanNumeralConversions.Test
{
    public class ConvertingNumbers
    {
        [Theory]
        //[InlineData(1, "I")]
        [InlineData(5, "V")]
        public void Convert_A_Number_To_A_Roman_Numeral(int number, string romanNumeral)
        {

            var result = NumberToRoman.ConvertToRoman(number);

            Assert.Equal(romanNumeral, result);
        }
    }
}
