using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_DistinctWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence:");
            String usersSentence = Console.ReadLine();

            Console.WriteLine($"\nYou entered:\n{usersSentence}\n");

            String[] splitWords = usersSentence.Split(' ');

            var sortedWords =
                from word in splitWords
                let lowerCaseWord = word.ToLower()
                orderby lowerCaseWord
                select lowerCaseWord;

            Console.Write("\nDistinct words:");

            foreach (var word in sortedWords.Distinct())
                Console.Write($" {word}");

            Console.WriteLine('\n');

        }
    }
}
