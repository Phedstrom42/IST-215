using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_LinqLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input array
            string[] array = { "banna", "apple", "peach", "cherry", "strawberry", };
            List<string> fruits = new List<string> { "apple", "passionfruit", "banana", "mango",
                            "grape", "orange", "blueberry", "passionfruit", "strawberry"};

            var result = array.OrderBy(a => new string(a.ToCharArray()));
            Display(result, "A) Sort using OrderedBy extension method, then display");

            IEnumerable<string> arrayReversed = array.Reverse();
            Display(arrayReversed, "B) Reverese Sort the string and then display");

            var asc = from st in array
                      orderby st
                      select st;
            Display(asc, "C) Sort in ascending order using LINQ");

            var desc = from st in array
                       orderby st descending
                       select st;
            Display(desc, "D) Sort in descending order using LINQ");

            string[] reversed2 = ReverseEachString(array);
            Display(reversed2, "E) Reverse each string in the array and display");

            var reversed3 = string.Join(" ", array[0].Split(' ').Select(x => new string(x.Reverse().ToArray())));
            Display(reversed3, "G) Reverse word");

            IEnumerable<string> query = fruits.Where(fruit => fruit.Length < 6);
            Display(query, "H) Use of 'Where' clause to select furits with lenght less than 6.");

            IEnumerable<string> query2 = fruits.Where((num) => num.Contains("e"));
            Display(query2, "I) Use of 'Where' clasue to select fruits that contain 'e'");

            IEnumerable<string> query3 = fruits.Where((num, index) => num.Contains("e") && index < 5);
            Display(query3, "J) Use of 'Where' clause to select fruits that contain 'e' and index < 5.");

            IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x * x);
            Display(squares, "K) Use of 'Enermable.Range and Selecct'");

            var query4 = fruits.Select((fruit, index) => new { index, str = fruit.Substring(0, index) });
            Display(query4, "L) Use 'Select' to project over a sequence of values and use the index of each element.");

            Console.WriteLine("\nSuppose a corporation has many sites, each identified by siteIDs.");
            Console.WriteLine("They have various programs that use sites.");
            Console.WriteLine("M) Expand the following sites:");
            string[] sites = { "1", "2", "4-8", "3-15" };
            string[] expandedSites = ExpandIDs(sites);
            sites.ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine();

            Console.WriteLine("\nExpanded Sites:");
            expandedSites.ToList().ForEach(x => Console.WriteLine(x + " "));

            Console.WriteLine("\n\n\nN) Sites seperated by spaces");
            Console.WriteLine(string.Join(" ", expandedSites));

            Console.WriteLine("\nO) Sites seperated by spaces.");
            Console.WriteLine(string.Join(", ", expandedSites));

            Console.WriteLine("\nP) Sites are joined.");
            Console.WriteLine(string.Join("", expandedSites));

            string str = "1 2334";
            Console.WriteLine($"\nQ) Is this a valid numberic string (can have spaces)? {str}");
            IsNumOnlyOrWhiteSpace(str);

            str = "12334";
            Console.WriteLine($"\nR) Is this a valid numberic string (can have spaces)? {str}");
            IsNumOnlyOrWhiteSpace(str);

            str = "123-34";
            Console.WriteLine($"\nS) Is this a valid numberic string (can have spaces)? {str}");
            IsNumOnlyOrWhiteSpace(str);
        }

        static void Display<T>(IEnumerable<T> str, string msg)
        {
            Console.WriteLine(msg);
            foreach(var item in str)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static string[] ReverseEachString(string[] arr)
        {
            string[] targetArray = new string[arr.Length];

            arr.CopyTo(targetArray, 0);

            for (int i = 0; i < arr.Length; i++)
            {
                targetArray[i] = ReverseString(arr[i]);
            }
            return targetArray;
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        private static string[] ExpandIDs(string[] ids)
        {
            List<string> result = new List<string>();
            foreach (string part in ids)
            {
                int i = part.IndexOf('-');

                if (i == -1)
                {
                    result.Add(part);
                }
                else
                {
                    string min = part.Substring(0, i);
                    string max = part.Substring(i + 1);
                    int iMin = Convert.ToInt32(min);
                    int iMax = Convert.ToInt32(max);
                    for (i = iMin; i <= iMax; i++)
                    {
                        result.Add(i.ToString());
                    }
                }
            }

            var noDupes = result.Distinct().ToList().OrderBy(x => int.Parse(x));
            return noDupes.ToArray<string>();
        }

        public static void IsNumOnlyOrWhiteSpace(string str)
        {
            if(string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Null string.");
                return;
            }

            if(str.ToCharArray().All(c => char.IsNumber(c) || Char.IsWhiteSpace(c)))
            {
                Console.Write("Valid string. Has all numberic or space characters");
            }
            else
            {
                Console.WriteLine("invalid string. Has some non-numberic characters");
            }
            return;
        }
    }
}
