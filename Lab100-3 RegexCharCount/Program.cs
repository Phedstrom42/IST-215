using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab100_3_RegexCharCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int digits, words, nonwords, whitespace;

            Console.Write("Please enter a sentence: ");
            string sentence = Console.ReadLine();

            digits = Regex.Matches(sentence, @"\d").Count;

            words = Regex.Matches(sentence, @"\w").Count;

            nonwords = Regex.Matches(sentence, @"\W").Count;

            whitespace = Regex.Matches(sentence, @"\s").Count;

            Console.WriteLine($"\nDigits: {digits}, word chars: {words}, non-words chars: {nonwords}, whitespace chars: {whitespace}.");


        }
    }
}
