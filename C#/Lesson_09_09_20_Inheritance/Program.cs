using System;
using System.Collections.Generic;

namespace Lesson_09_09_20_Inheritance
{
    class Person
    {
        public Person()
        {
            Name = "N/A";
            Surname = "N/A";
        }
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; set; }
        public string Surname { get; set; }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Surname.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj is Person person)
            {
                return Name == person.Name && Surname == person.Surname;
            }
            return false;
        }

        //public static explicit operator int(Person person)
        //{
        //    return 10;
        //}

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }


    abstract class Animal
    {
        public Animal()
        {

        }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        abstract public void Move();

        public virtual void Say() 
        {
            Console.WriteLine("Unknown sound");
        }

        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }


    sealed class Cat : Animal
    {
        public Cat() : base("N/A",0)
        {

        }
        public int Lives { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} {Lives}";
        }

        //public new void Move()
        //{
        //    Console.WriteLine("Move like Cat");
        //}

        public override void Say()
        {
            Console.WriteLine("Myau");
        }

        public override void Move()
        {
            Console.WriteLine("Move like Cat");
        }
    }

    //class SuperCat : Cat
    //{

    //}

    //class Dog : Animal
    //{
        
    //}
    
    class Program
    {
       
        static void Main(string[] args)
        {

            Animal animal = new Animal();
            Animal cat = new Cat();

            animal.Move();
            animal.Say();
            Console.WriteLine();
            cat.Move();
            cat.Say();
            Console.WriteLine();
            (cat as Cat).Move();

            //Animal a = new Animal();

            //Console.WriteLine(a.ToString());
            //Cat c = new Cat();
            //Console.WriteLine(c.ToString());

            //Console.WriteLine();

            //a.Move();
            //c.Move();

            //object animal = new Animal();
            //object cat = new Cat();

            //Console.WriteLine(animal.ToString());
            //Console.WriteLine(cat.ToString());
            

            

           


            //Dictionary<int, Dictionary<string, string>> diction = new Dictionary<int, Dictionary<string, string>>();

            //diction[1] = new Dictionary<string, string>();
            //diction[1]["Key"] = "Value";
            

           // Key : Value

           
           // int? num = 15;

           // Nullable<int> numer;

           //if(num.HasValue)
           // {
           //     Console.WriteLine(num.Value);
           // }


            //Person person = null; //new Person("Anna", "Semenovich");

           // Person person1 = person ?? new Person();

            // Console.WriteLine(person?.ToString());

            


            //Person person = new Person("Anna", "Semenovich");
            //Console.WriteLine((int)person);

            //(int, string) val = (5,"Some text");
            //var val1 = (num:5, text:"Some text");

            //Tuple<int, string> val2 = new Tuple<int, string>(5, "Some text");
            //val.Item1 = 34;
            //val2.Item1 = 32;
            //val1.num = 6;

            //var anonim = new { Name = "Aftandil", Age = 25 };




            //Dictionary<Person, string> diction = new Dictionary<Person, string>();


            //diction[new Person("Anna", "Semenovich")] = "Actrice";
            //Person person = new Person("Anna", "Semenovich");
            //Person person1 = new Person("Semenovich", "Anna");

            //Console.WriteLine(person.GetHashCode());
            //Console.WriteLine(person1.GetHashCode());

            //if(diction.TryGetValue(new Person("Semenovich", "Anna"),out string str))
            //{
            //    Console.WriteLine(str);
            //}
            //else
            //{
            //    Console.WriteLine("No such a key");
            //}

            ////diction.Add(new Person("Tom", "Hanks"), "aaaaa");

            //if (diction.TryAdd(new Person("Tom", "Hanks"),"Actor"))
            //{
            //    Console.WriteLine("Success");
            //}
            //else
            //{
            //    Console.WriteLine("The same key already exist!");
            //}


            //if (diction.TryAdd(new Person("Hanks", "Tom"), "aaaaa"))
            //{
            //    Console.WriteLine("Success");
            //}
            //else
            //{
            //    Console.WriteLine("The same key already exist!");
            //}

            //Console.WriteLine(diction[new Person("Tom", "Hanks")]);

        }
    }
}
