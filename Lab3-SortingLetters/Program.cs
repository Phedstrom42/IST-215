using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_SortingLetters
{
    class Program
    {
        static void Main(string[] args)
        {
     

//////////////////////////// LIST ///////////////////////////////////////////////////////////////////////////

            List<char> charList = new List<char> {  'f', 'j', 'm', 'c', 'w', 'i', 'd', 'p', 'p', 'z',
                                                    't', 'd', 'w', 'u', 'n', 'r', 'a', 'l', 'p', 's',
                                                    't', 'n', 'y', 't', 'm', 'l', 't', 'i', 'r', 'h'  };

            Console.WriteLine("Generated List:");

            foreach (var c in charList)
            {
                Console.Write($" {c}");
            }

////////////////////////// ASCENDING //////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\nAscending order:");

            var ascendingList =
                from a in charList
                orderby a ascending
                select a;

            foreach (var c in ascendingList)
            {
                Console.Write($" {c}");
            }

////////////////////////  DESCENDING /////////////////////////////////////////////////////////////////////////


            Console.WriteLine("\n\nDescending order:");

            var descendingList =
                from d in charList
                orderby d descending
                select d;

            foreach (var c in descendingList)
            {
                Console.Write($" {c}");
            }

//////////////////// DUPLICATES REMOVED ////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\nAscending order, no duplicates:");

            foreach (var c in ascendingList.Distinct())
            {
                Console.Write($" {c}");
            }


            Console.WriteLine();
        }
    }
}
