using System;

namespace RomanNumeralConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 3999");
            var userInput = int.Parse(Console.ReadLine());
            var NumberToRoman = new NumberToRoman();
            var romanOutput = NumberToRoman.ConvertToRoman(userInput);

            Console.WriteLine(romanOutput);

            Console.Read();
        }
    }
}
