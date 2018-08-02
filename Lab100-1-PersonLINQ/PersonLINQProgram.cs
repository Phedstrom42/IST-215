﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab100_PersonLINQ
{
    class PersonLINQProgram
    {
        static void Main(string[] args)
        {
            DataList arr;
            string dataFile = @"..\..\Person2000Address.csv";

            arr = new DataList(dataFile);
            arr.LoadData();

            Console.WriteLine("\n1. Display All people");
            arr.DisplayPeople();

            String searchKey = "Davis";
            Console.WriteLine($"Find person by last name, name = '{searchKey}'");

            Person personFound = arr.FindPerson(searchKey);

            string msg = personFound != null ? $"      Found {personFound}\n" : $"NOT found {searchKey}\n";
            Console.WriteLine(msg);

            Console.WriteLine("\n3.1. Find a person by Person object");
            Person temp = new Person("Michael", "Williams", "69 Andrews Dr", "Aberdeen", "SD", 06031);

            personFound = arr.FindPerson(temp);
            msg = personFound != null ? $"      Found {personFound}\n" : $"NOT found {temp}\n";
            Console.WriteLine(msg);

            Console.WriteLine("\n3.2. Find a person by Person object (person is not in the list)");
            temp = new Person("Monica", "Williams", "69 Andrews Dr", "Aberdeen", "SD", 06031);
            personFound = arr.FindPerson(temp);
            msg = personFound != null ? $"      Found {personFound}\n" : $"NOT found {temp}\n";

            Console.WriteLine("\n4.1 Display people from Albany");
            arr.DisplayPeopleByCity("Albany");

            Console.WriteLine("\n4.2 Display people from Albany, NY");
            arr.DisplayPeopleByCityAndState("Albany", "NY");

            string findLastName = "Levy";
            Console.WriteLine($"\n5. Display people with lastName '{findLastName}'");
            arr.FindPeopleWithSameLastName(findLastName).ForEach(n => Console.WriteLine(n));

            Console.WriteLine("\n6. Compare a few people by last name");
            Console.WriteLine("\t" + arr.CompareTwoPersons(arr.GetPersonAt(3), arr.GetPersonAt(33)));
            Console.WriteLine("\t" + arr.CompareTwoPersons(arr.GetPersonAt(1000), arr.GetPersonAt(100)));
            Console.WriteLine("\t" + arr.CompareTwoPersons(arr.GetPersonAt(1500), arr.GetPersonAt(150)));

            Console.WriteLine($"\n7. Find a person's address.");
            Console.WriteLine($"\t{arr.GetPersonAt(4).FirstName} {arr.GetPersonAt(4).LastName}");
            Console.WriteLine($"\t" + arr.FindPersonAddress(arr.GetPersonAt(4)));

        }
    }
}
