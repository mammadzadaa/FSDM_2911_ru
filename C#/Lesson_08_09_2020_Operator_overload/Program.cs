using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Threading;

namespace Lesson_08_09_2020_Operator_overload
{
    class Program
    {
        struct MyStruct 
        {
            public int X { get; set; }
            public int Y { get; set; }
            public MyStruct(int x, int y)
            {
                X = 1;
                Y = 2;
            }
        }

        class Person
        {
            public string Name { get; set; }
            public string Surname { get; set; }

            public override bool Equals(object obj)
            {
                if (obj is Person)
                {
                    Person person = obj as Person;
                    return Name == person.Name && Surname == person.Surname;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return Name.GetHashCode() + Surname.GetHashCode();
            }

            //public static bool operator true (Person person)
            //{
            //    return !(string.IsNullOrEmpty(person.Name)) && !(string.IsNullOrEmpty(person.Surname));
            //}
            //public static bool operator false(Person person)
            //{
            //    return string.IsNullOrEmpty(person.Name) || string.IsNullOrEmpty(person.Surname);
            //}

            //public static bool operator ==(Person left, Person right)
            //{
            //    return left.Name == right.Name && left.Surname == right.Surname;
            //}
            //public static bool operator !=(Person left, Person right)
            //{
            //    return !(left == right);
            //}
        }
        
        class Money
        {
            public int USD { get; set; }
            private int cent;

            public Money()
            {
                USD = 0;
                Cent = 0;
            }
            public Money(int uSD, int cent)
            {
                USD = uSD;
                Cent = cent;
            }

            public int Cent
            {
                get { return cent; }
                set {
                    if (value >= 100)
                        {
                            USD += value / 100;
                            cent = value % 100;
                        }
                    else
                        cent = value;
                    }
            }


            public static Money operator+(Money left, Money right)
            {
                Money temp = new Money();
                temp.USD = left.USD + right.USD;
                temp.Cent = left.Cent + right.Cent;
                return temp;
            }

            public override string ToString()
            {
                return $"{USD},{Cent} $";
            }

            public static Money operator++(Money money)
            {
                return new Money { USD = money.USD, Cent = money.Cent + 1 };
            }


            //public static Money operator -(Money left)
            //{
            //    return new Money();
            //}

        }

        static void Main(string[] args)
        {
            Dictionary<Person, string> dictionary = new Dictionary<Person, string>();

            dictionary.Add(new Person() { Name = "A",Surname = "B" },"student");

            Console.WriteLine(dictionary[new Person() { Name = "A", Surname = "B" }]);

            //string s = "";
            //string ss = "Aftandil";
            //string s1 = "Aftandil";

            //int num = 0;
            //int num1 = 145;
            //int num3 = 145;

            //Person person = new Person() { Name = "Aftandil", Surname = "Mammadov" };
            //Person person1 = new Person() { Name = "Israfil", Surname = "Mammadov" };
           

            //Console.WriteLine(s.GetHashCode());
            //Console.WriteLine(ss.GetHashCode());
            //Console.WriteLine(s1.GetHashCode());

            //Console.WriteLine(num.GetHashCode());
            //Console.WriteLine(num1.GetHashCode());
            //Console.WriteLine(num3.GetHashCode());

            //Console.WriteLine(person.GetHashCode());
            //Console.WriteLine(person1.GetHashCode());

            //Money money = new Money();
            //Money money1 = new Money(5, 84);
            //Money money2 = new Money(20, 134);

            //Console.WriteLine(money);
            //Console.WriteLine(money1);
            //Console.WriteLine(money2);

            //Money money3 = money1 + money2;
            //Console.WriteLine(money3);

            //Console.WriteLine(++money3);
            //Console.WriteLine(money3++);
            //Console.WriteLine(money3);


            //Person person = new Person() { Name = "Aftandil", Surname = "Mammadov" };
            //Person person1 = new Person() { Name = "", Surname = "" };

            ////if (person1)
            ////{
            ////    Console.WriteLine("hmmmmm");
            ////}

            //if(person.Equals(person1))
            //{
            //    Console.WriteLine("Are they Same? 0_o ");
            //}
            //else
            //{
            //    Console.WriteLine("Or NOT the Same? 0_o ");

            //}


            //if (person == person1)
            //{
            //    Console.WriteLine("Are they Same? 0_o ");
            //}
            //else
            //{
            //    Console.WriteLine("Or NOT the Same? 0_o ");

            //}

            //// Thread.Sleep(1000);
            //DateTime begin = DateTime.Now;
            //File.WriteAllText("time.txt",DateTime.Now.ToString());
            //int num = 1;
            //for (int i = 0; i < 100000; i++)
            //{
            //    num++;
            //}

            //DateTime end = DateTime.Now;

            //TimeSpan dif =  end.Subtract(begin);
            //Console.WriteLine(dif);



            //DateTime dateTime = DateTime.Now;
            //Console.WriteLine(dateTime);
            //Console.WriteLine(dateTime.Ticks);


            //DateTime dateTime1 = DateTime.UtcNow;
            //Console.WriteLine(dateTime1);

            //MyStruct s = new MyStruct() { X = 2, Y = 4 };
            //MyStruct s1 = new MyStruct(10,14);
        }
    }
}
