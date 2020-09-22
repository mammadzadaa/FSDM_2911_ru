using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace Lesson_22_09_20_LINQ
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
    }

    class MyClass
    {
        private int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
    }

    static class ExtendsMyClass
    {
        public static void Print(this MyClass myClass)
        {
            // some code
        }
    }

    static class ExtendString
    {
        public static void PrintString<T>(this string str, T num)
        {
            Console.WriteLine(str);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            string str = File.ReadAllText("Data.json");

            var people = JsonConvert.DeserializeObject<List<Person>>(str);

            // Where, First, Last

            Console.WriteLine(people.First(x => x.Gender == "Female"));
            Console.WriteLine(people.Last(x => x.Gender == "Female"));

            Console.WriteLine(people.LastOrDefault(x => x.Salary > 10000));
            Console.WriteLine(people.FirstOrDefault(x => x.Salary > 10000));



            // Enumerable.Where(people, x => x.Gender == "Male");

            //IEnumerable<Person> list = people.Where(x => x.Gender == "Male")
            //                                 .Where(x => x.Salary > 8000);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            // Sum, Min, Max, Avarage, Count

            //Console.WriteLine(people.Count());
            //Console.WriteLine(people.Count(x => x.Country == "China"));
            //Console.WriteLine(people.Count(x => x.Salary > 5000));
            //Console.WriteLine(people.Count(x => (DateTime.Now - x.DateOfBirth).TotalDays / 365 > 40));

            //Console.WriteLine(people.Average(x => x.Salary));
            //Console.WriteLine(people.Sum(x => x.Salary));

            //Console.WriteLine(people.Min(x => (DateTime.Now - x.DateOfBirth).TotalDays / 365));
            //Console.WriteLine(people.Max(x => x.Salary));






            //Console.WriteLine(people.Length);


            //foreach (var item in people)
            //{
            //    Console.WriteLine(item);
            //}

            //MyClass my = new MyClass();

            //string str = "Aftandil";

            //Console.WriteLine(str);

            //ExtendString.PrintString(str, 12);

            //str.PrintString("dsad");

        }
    }
}
