using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab100_2_RegExPhoneValidation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a phone number in format (XXX) XXX-XXXX: ");
            string input = Console.ReadLine();
            Console.WriteLine($"Input string: {input}");

            Match result = Regex.Match(input, @"^\(+(\d{3})\)?[\s\-]+(\d{3})\-+(\d{4})$");

            GroupCollection gc = null;

            if (!result.Success)
            {
                Console.WriteLine("Invaild input");
                return;
            }
            else
            {
                Console.WriteLine($"\nSingle Match: {result.Value}\n");

                gc = result.Groups;
                Console.WriteLine($"Count for the match: {gc.Count}, Original number: {result.Groups[0]}");

                string str = string.Format($"{result.Groups[1]}.{result.Groups[2]}.{result.Groups[3]}");
                Console.WriteLine(str);
            }
        
        }
    }
}
