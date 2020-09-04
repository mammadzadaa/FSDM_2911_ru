using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lesson_04_09_20_List
{
    struct Point
    {
        public Point(int a, int b)
        {
            A = a;
            B = b;
        }
        public void Method() { }
        public int A { get; set; }
        public int B { get; set; }
    }
    class Person
    {
        public override string ToString()
        {
            return $"{Name} {Surname} {Age}";
        }
        public Person()
        {
            ID = Counter++;
        }

        public Person(string name, string surname, int age) : this()
        {           
            Name = name;
            Surname = surname;
            Age = age;
        }

        static public int Counter { get; private set; } = 0;
        public int ID { get; }
        public string Name { get; set; }
        public string Surname { get; set; } = "N/A";

        private int age;

        public int Age
        {
            get => age;
            set => age = value >= 0 && value <= 100 ? value : 0;
        }
        //public static int count;
        //public static void F() { }
        //public const int num = 3;
        //public readonly int number;
        //public int ReadOnlyNum { get; }

        //static Person()
        //{
        //    Console.WriteLine("Hey, I am static ctor of Person");
        //}
        //public Person() : this("No name", "No Surname")
        //{
        //    number = 3;
        //    ReadOnlyNum = 4;
        //}
        //public Person(string name, string surname)
        //{
        //    Name = name;
        //    Surname = surname;
        //}

    }

    class Program
    {
        static void Foo(string a , string b = @"N\A", int num = 0)
        {

        }
        static void Main(string[] args)
        {
            var list = new List<Person>(); // Vector from c++ 
            // LinkedList // list form c++

            Console.WriteLine(list.Capacity);
            Console.WriteLine(list.Count);
            list.Add(new Person("Aftandil", "Mammadov", 30));
            list.Add(new Person("Ibrahim", "Huseynov", 20));
            list.Add(new Person("Murad", "Huseynov", 25));        
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            list.Reverse();

            //string str = "Hello World!";
            //File.WriteAllText("test.txt",str);

            //string s = File.ReadAllText("test.txt");
            // Console.WriteLine(s);

            // Person p = new Person("Aftandil", "Mammadov", 30);

            // File.WriteAllText("person.txt",p.ToString());

            //string s = File.ReadAllText("person.txt");

            //string[] str = s.Split(' ');
            //Person person = new Person() { Name = str[0], Surname = str[1], Age = int.Parse(str[2]) };

            //Console.WriteLine(person);

            //Console.WriteLine(person.Age);


            //StringBuilder stringBuilder = new StringBuilder();
            //foreach (var item in list)
            //{
            //    stringBuilder.Append(item.ToString() + "\n");
            //}
            //File.WriteAllText("people.txt", stringBuilder.ToString());

            var people = new List<Person>();
            string[] str_arr =  File.ReadAllLines("people.txt");
            foreach (var item in str_arr)
            {
                string[] str = item.Split(' ');
                people.Add(new Person() { Name = str[0], Surname = str[1], Age = int.Parse(str[2]) });
            }

            
            foreach (var item in people)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Age);
            }


            //Person[] people = new Person[3];

            //people[0] = new Person("Aftandil","Mammadov",30);
            //Console.WriteLine(people[0].ID);

            //people[1] = new Person("Ibrahim","Huseynov",20);
            //Console.WriteLine(people[1].ID);

            //people[2] = new Person("Murad","Huseynov",25);
            //Console.WriteLine(people[2].ID);

            //Console.WriteLine(people);
            //foreach (var item in people)
            //{
            //    Console.WriteLine(item.ToString());
            // }



            //var num = Math.PI;
            //int n = Person.num;
            //Person person = new Person {Name = "Asif", Surname = "Aliyev"};
            //Person person1 = new Person(surname: "Mammadov", name: "Arif");
            //Foo(num: 12, a: "sdasda", b: "dsada");
            //Foo(num: 12, a: "sdasda");

            //Console.WriteLine(person.number);
        }
    }
}
