using System;
using System.Linq;

namespace RomanNumeralConversions.Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 3999");
            var userInput = int.Parse(Console.ReadLine());
            var romanOutput = "";
            var evalInput = userInput.ToString().Count();
            if (evalInput == 1)
            {
            var NumberToRoman = new SingleDigits();
            romanOutput = SingleDigits.ConvertToRoman(userInput);
            }

            Console.WriteLine(romanOutput);

            Console.Read();
        }
    }
}
