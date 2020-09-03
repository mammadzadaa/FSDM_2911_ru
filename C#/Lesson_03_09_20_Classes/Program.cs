using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Lesson_03_09_20_Classes
{
        //enum MyEnum
        //{
        //    Black, Yellow, White
        //}
    class Account
    {
        public string name;
        public string surname;
    }
    
    class Person
    {
        private string surname;

        private int age;

        public int Age
        {
            get { return age; }
            set 
            {
                if (value >= 0 && value <= 100)
                    age = value;
                else
                    age = 0;
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int id;

        public int ID
        {
            get { return id; }
        }

        public int Height { get; set; }




        public void SetSurname(string surname) { this.surname = surname; }
        public string GetSurname() { return surname; }
       

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.SetSurname("Mammadov");
            person.Name =  "Arif";
            person.Age = 20;
            person.Height = 170;

            Console.WriteLine($"Name {person.Name} \nSurname {person.GetSurname()} \nAge {person.Age}");
            Console.WriteLine(person.Height);
            

            //string s = Console.ReadLine();

            //switch (s)
            //{
            //    case "Aftandil":
            //        Console.WriteLine("Hey Man!");
            //        break;
            //    case "Gulnise":
            //        Console.WriteLine("Hey Girl!");
            //        break;
            //    default:
            //        break;
            //}

            //StringBuilder pass = new StringBuilder();
            //while (true)
            //{
            //    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            //    if (keyInfo.Key == ConsoleKey.Enter)
            //    {
            //        break;
            //    }
            
            //    if (keyInfo.Key == ConsoleKey.Backspace) // keyInfo.KeyChar == 13
            //    {
            //        pass.Remove((pass.Length - 1),1);
            //        Console.Write("\b \b"); 
            //    }
            //    else
            //    {
            //        pass.Append(keyInfo.KeyChar);
            //        Console.Write('*');
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine(pass);

            //string str = "1234567890qwertyuiopasdfghjklzxcvbnm";

            //Random random = new Random();
            ////Console.WriteLine(random.Next(0,str.Length));
            //StringBuilder strb = new StringBuilder(10);
            //for (int i = 0; i < 10; i++)
            //{
            //    strb.Append(str[random.Next(0,str.Length)]);
            //}
            //Console.WriteLine(strb.ToString());



            //Account[] accounts = new Account[10];

            //accounts[0] = new Account();
            //accounts[0].name = "Aftandil";
            //accounts[0].surname = "Mammadov";

            //Console.WriteLine($"Name: {accounts[0].name} \nSurname: {accounts[0].surname}");

            //string str = "   Aftandil ai";
            //// String s = new String("Aftandil");
            //Console.WriteLine(str);
            //Console.WriteLine(str.Length);
            //str = str.Trim();
            //Console.WriteLine(str.Contains('D'));
            //Console.WriteLine(str.Contains("ft"));
            //Console.WriteLine(str.IndexOf('i'));
            //Console.WriteLine(str.LastIndexOf("a"));
            //Console.WriteLine(str.Insert(str.IndexOf('n'),"aaaaaaaaaaaaa"));
            //Console.WriteLine(str.EndsWith("ai"));
            //Console.WriteLine(str.Remove(str.IndexOf(' '),2));
            //Console.WriteLine(str.Replace("ft","FT"));
            //str = str.ToUpper();

            //Console.WriteLine(str.Substring(str.IndexOf(' ') + 1));
            //Console.WriteLine(str);
            //Console.WriteLine("\n\\\\\\\\\\\\\\\\\n");
            //string s = "My name is Aftandil";

            //string[] s_arr = s.Split(' ');

            //foreach (var item in s_arr)
            //{
            //    Console.WriteLine(item);
            //}

            //string st = "";

            //for (int i = 0; i < 10; i++)
            //{
            //    st += i;
            //    Console.WriteLine(st);
            //}

            //StringBuilder strb = new StringBuilder();

            //Console.WriteLine(strb.Capacity);
            //Console.WriteLine(strb.Length);

            //strb.Append("My name is Aftandil. I am from Azerbaijan!");
            //strb.Append(" My name is Israfil.");

            //Console.WriteLine(strb.Capacity);
            //Console.WriteLine(strb.Length);
            //Console.WriteLine(strb);

            //strb.Insert(strb.ToString().IndexOf('.') + 1, " Added Sentence. ");

            //string str = strb.ToString();
            //Console.WriteLine(str);

            //int a = 10;
            //int b = 9;
            //if(b < a++ || ++b < a--)
            //{
            //    Console.WriteLine($"a is {a} and b is {b} "); //
            //}
        }
    }
}
