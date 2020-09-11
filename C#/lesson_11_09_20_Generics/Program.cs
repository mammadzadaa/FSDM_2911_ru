using System;
using System.Collections.Generic;

namespace lesson_11_09_20_Generics
{
    abstract class DB
    {
        public string Name { get; set; }
        public abstract void Create();
        public abstract void Update();
        public abstract void Insert();
        public abstract void Select();
    }

    interface IDBwritable
    {
        void WriteToDB();
    }
    class Person : IDBwritable, ICloneable, IComparable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public void WriteToDB()
        {
            Console.WriteLine($"Write to db {Name} {Surname}");
        }

        public override string ToString()
        {
            return $"{Name} {Surname} {Age}";
        }

        public object Clone()
        {
            return new Person() { Name = this.Name, Surname = this.Surname };
        }

        public int CompareTo(object obj)
        {
            return Name.CompareTo((obj as Person).Name);
        }

        //public int CompareTo(object obj)
        //{
        //    return Age - (obj as Person).Age;
        //}
    }

    class MyGeneric<T>
    {
        public T MyProperty { get; set; }
        public void Foo()
        {
            Console.WriteLine(MyProperty);
        }
    }

    class Fraction : IDBwritable
    {
        public int Enum { get; set; }
        public int Denom { get; set; }

        public void WriteToDB()
        {
            Console.WriteLine($"Write to db {Enum} / {Denom}");
        }
    }
    class Program
    {
        public static void WorkWithDB(DB database)
        { // Actual work with DB
            database.Create();
            database.Insert();
            database.Update();
            database.Select();
        }
        public static void WriteDB(IDBwritable DBwritable)
        {
            DBwritable.WriteToDB();
        }
        public static void FooObj(object obj)
        {
            int number = (int)obj;
        }
        public static void FooInt(int num)
        {
            int number = num;
        }

        static void Main(string[] args)
        {
            var begin = DateTime.Now;
            for (int i = 0; i < 100000; i++)
            {
                FooObj(15);
            }
            Console.WriteLine(DateTime.Now - begin);
            begin = DateTime.Now;
            for (int i = 0; i < 100000; i++)
            {
                FooInt(15);
            }
            Console.WriteLine(DateTime.Now - begin);


            //var people = new List<Person>();

            //people.Add(new Person() { Name = "Aftandil", Surname = "Mammadov", Age = 45 });
            //people.Add(new Person() { Name = "Israfil", Surname = "Hikmetov", Age = 35 });
            //people.Add(new Person() { Name = "Huseyn", Surname = "Abbasov", Age = 47 });
            //people.Add(new Person() { Name = "Anastasiya", Surname = "Muratova", Age = 17 });
            //people.Add(new Person() { Name = "Lida", Surname = "Pavlovna", Age = 19 });

            //if (people[0] is IComparable)
            //{
            //    people.Sort();
            //}

            //foreach (var item in people)
            //{
            //    Console.WriteLine(item);
            //}

            //    var numbers = new List<int>();

            //    numbers.Add(3);
            //    numbers.Add(7);
            //    numbers.Add(1);
            //    numbers.Add(2);
            //    numbers.Add(9);

            //    numbers.Sort();

            //    foreach (var item in numbers)
            //    {
            //        Console.WriteLine(item);
            //    }



            //Person person = new Person() { Name = "Gulya", Surname = "Mahmudova" };
            ////Person person1 = person;
            //Person person1 = person.Clone() as Person;

            //person1.Name = "Elvira";
            //Console.WriteLine(person);


            //Person person = new Person() { Name = "Gulya", Surname = "Mahmudova" };
            //WriteDB(person);

            //Fraction fraction = new Fraction() { Enum = 10, Denom = 6 };
            //WriteDB(fraction);


            //WorkWithDB(new MySQL("TeachersDB"));
        }
    }

    internal class MySQL : DB
    {
         public MySQL(string name)
        {
            Name = name;
        }

        public override void Create()
        {
            Console.WriteLine($"{Name} created My SQL DB");
        }

        public override void Insert()
        {
            Console.WriteLine($"{Name} insert My SQL DB");
        }

        public override void Select()
        {
            Console.WriteLine($"{Name} select My SQL DB");
        }

        public override void Update()
        {
            Console.WriteLine($"{Name} update My SQL DB");
        }
    }

    internal class MSSQLDB : DB
    {
        public MSSQLDB(string name)
        {
            Name = name;
        }

        public override void Create()
        {
            Console.WriteLine($"{Name} created MS SQL DB");
        }

        public override void Insert()
        {
            Console.WriteLine($"{Name} inserted MS SQL DB");
        }

        public override void Select()
        {
            Console.WriteLine($"{Name} selected MS SQL DB");
        }

        public override void Update()
        {
            Console.WriteLine($"{Name} updated MS SQL DB");
        }
    }
}
