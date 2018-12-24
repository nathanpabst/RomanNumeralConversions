using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

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
                var singleDigits = new SingleDigits();
                romanOutput = SingleDigits.ConvertToRoman(userInput);
            }
            else if (evalInput == 2)
            {
                var dosDigits = new DosDigits();
                romanOutput = DosDigits.ConvertToRoman(userInput);
            }

            Console.WriteLine(romanOutput);
            
            Console.Read();
        }
    }
}
