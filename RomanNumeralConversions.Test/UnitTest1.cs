using System;
using Xunit;
using RomanNumeralConversions;

namespace RomanNumeralConversions.Test
{
    public class ConvertingNumbers
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(11, "XI")]
        [InlineData(12, "XII")]
        [InlineData(13, "XIII")]
        [InlineData(14, "XIV")]
        [InlineData(15, "XV")]
        [InlineData(20, "XX")]
        [InlineData(30, "XXX")]
        [InlineData(33, "XXXIII")]
        [InlineData(42, "XLII")]
        [InlineData(45, "XLV")]
        [InlineData(68, "LXVIII")]
        [InlineData(83, "LXXXIII")]
        [InlineData(97, "XCVII")]
        [InlineData(99, "XCIX")]
        [InlineData(500, "D")]
        [InlineData(501, "DI")]
        [InlineData(649, "DCXLIX")]
        [InlineData(798, "DCCXCVIII")]
        [InlineData(891, "DCCCXCI")]
        //        //[InlineData(1000, "M")]
        //        //[InlineData(1004, "MIV")]
        //        //[InlineData(1006, "MVI")]
        //        //[InlineData(1023, "MXXIII")]
        //        //[InlineData(2014, "MMXIV")]
        //        //[InlineData(3999, "MMMCMXCIX")]

        public void Convert_A_Number_To_A_Roman_Numeral(int number, string expResult)
        {

            var RomanNumeralConverter = new RomanNumeralConverter();
            string result = RomanNumeralConverter.ConvertNumToRoman(number);

            Assert.Equal(expResult, result);
        }
    }
}
