using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Lesson_23_09_20_LINQ_2
{
    public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public decimal Salary { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"{ID} {FirstName} {LastName} {Gender} {DateOfBirth.ToShortDateString()} {Country} {City}" +
                $" {Salary} {JobTitle} {Department} {CompanyName} {PhoneNumber}";
        }
        public string ToShortString()
        {
            return $"{ID} {FirstName} {LastName} {Gender} {DateOfBirth.ToShortDateString()} {Country}" +
                $" {Salary} ";
        }
    }

    class PersonNameComparer : IEqualityComparer<Person>
    {
        public bool Equals( Person x, Person y)
        {
            return x.FirstName == y.FirstName;
        }

        public int GetHashCode(Person obj)
        {
            return obj.FirstName.GetHashCode();
        }
    }

    class PersonDateOfBirthComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            return x.DateOfBirth == y.DateOfBirth;
        }

        public int GetHashCode(Person obj)
        {
            return obj.DateOfBirth.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            string str = File.ReadAllText("Data.json");

            var people = JsonConvert.DeserializeObject<List<Person>>(str);


            //var newList = from x in people
            //              where x.Country == "Russia"
            //              select x;

                                
                         
            //var newList = people.Where(x => x.Country == "Russia");

            //foreach (var item in newList)
            //{
            //    Console.WriteLine(item);
            //}
           
            
            // Concat, Distinct, Except, Intersec, Union

            //var list1 = new List<int>() { 1, 4, 6, 2, 5, 7, 3, 1, 2, 3 };

            //var list2 = new List<int>() { 1, 0, 17, 2, 5, 0, 2, 14 };

            //var newList =  list1.Concat(list2);
            //var newList = list1.Distinct(); // unique values

            //var newList =  list1.Except(list2);
            // var newList = list1.Union(list2);
            // var newList = list1.Intersect(list2);


            //foreach (var item in newList)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            // GroupBy

            //var groups = people.GroupBy(x => x.Country).OrderBy(x => x.Key);

            //foreach (var group in groups)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine($"\t{item.ToShortString()}");
            //    }
            //}


            // ToDictionary

            //var newList = people.Take(50).ToDictionary(x => x.ID);
            //var newList = people.Take(50).ToDictionary(x => x.City);
            //var newList = people.Take(50).ToDictionary(x => x.PhoneNumber);

            //foreach (var item in newList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(newList["878-493-6473"]);

            //Console.WriteLine(newList[10]);

            // Select

            //var newList = people.Where(x => x.Country == "Germany")
            //                    .Select(x => new { FullName = $"{x.FirstName} {x.LastName}", x.Salary });

            //foreach (var item in newList)
            //{
            //    Console.WriteLine($"{item.FullName} {item.Salary}");
            //}

            // Deferred Execution

            //var querry = people.Where(x => x.Country == "Germany");

            //var querry = people.Where(x => x.Country == "Germany").ToList();

            //foreach (var item in querry)
            //{
            //    Console.WriteLine(item);
            //}

            //people.RemoveAt(360);
            //Console.WriteLine();
            //foreach (var item in querry)
            //{
            //    Console.WriteLine(item);
            //}

            // All, Any, Contains

            //Person person = new Person()
            //{
            //    FirstName = "Barr",
            //    LastName = "Voice",
            //    Gender = "Male",
            //    DateOfBirth = DateTime.Parse("19.7.1991"),
            //    Country = "Bolivia",
            //    City = "Eucaliptus",
            //    Salary = 9791.22m,
            //    JobTitle = "Geological Engineer",
            //    Department = "Services",
            //    CompanyName = "Voonder",
            //    PhoneNumber = "623-432-5180"
            //};

            //people.RemoveAt(10);

            //Console.WriteLine(people.Any(x => x.Country == "Azerbaijan"));
            //Console.WriteLine(people.All(x => x.Country == "Azerbaijan"));
            //Console.WriteLine(people.Contains(person, new PersonDateOfBirthComparer()));

            // Single

            //Console.WriteLine(people.Single(x => x.Country == "Azerbaijan"));
            //Console.WriteLine(people.Single(x => x.Country == "Russia"));
            //Console.WriteLine(people.Single(x => x.Country == "Russia"));
            //Console.WriteLine(people.SingleOrDefault(x => x.Country == "Russia"));
            //Console.WriteLine(people.SingleOrDefault(x => x.Country == "Russiaa")); // not exist, returns default


            // OrderBy , OrderByDescending, ThenBy, ThenByDescending

            //var newList = people.OrderBy(x => x.DateOfBirth);
            //var newList = people.OrderByDescending(x => x.Salary);

            //var newList = people.OrderBy(x => x.Country).OrderByDescending(x => x.Salary);

            // var newList = people.OrderBy(x => x.Country).ThenByDescending(x => x.Salary);
            //var newList = people.OrderBy(x => x.FirstName[0]).ThenByDescending(x => x.LastName[0]);

            //foreach (var item in newList)
            //{
            //    Console.WriteLine(item);
            //}

            // Skip, Take, SkipLast ,TakeLast, TakeWhile, SkipWhile

            // var newList = people.SkipWhile(x => x.Country != "Russia");
            // var newList = people.TakeWhile(x => x.Country != "Russia");


            //foreach (var item in newList)
            //{
            //    Console.WriteLine(item);
            //}

            //var newList = people.SkipLast(5);

            //foreach (var item in newList)
            //{
            //    Console.WriteLine(item);
            //}

            //var newList = people.TakeLast(5);

            //foreach (var item in newList)
            //{
            //    Console.WriteLine(item);
            //}

            //int page = 0;

            //while (true)
            //{
            //    var newList = people.Where(x => x.Country == "China").Skip(5 * page).Take(5);

            //    foreach (var item in newList)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    page++;
            //    Console.ReadKey(true);
            //    Console.Clear();
            //}

            //var newList = people.OrderBy(x => x.FirstName[0]).ThenBy(x => x.LastName[0]).Take(10);

            //foreach (var item in newList)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
