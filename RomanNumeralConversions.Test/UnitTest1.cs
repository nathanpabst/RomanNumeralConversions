using System;
using Xunit;
using RomanNumeralConversions;

namespace RomanNumeralConversions.Test
{
    public class ConvertingNumbers
    {
        [Theory]
        [InlineData(1, "I")]
        public void Convert_A_Number_To_A_Roman_Numeral(int number, string expectedResult)
        {
            string result = NumbersToRoman.Conversions(number);

            Assert.Equal(expectedResult, result);
        }
    }
}
