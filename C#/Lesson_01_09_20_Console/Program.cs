using System;

namespace Lesson_01_09_20_Console
{
    struct Point
    {
       public int x;
       public int y;

    }

    class Person
    {
       public string name;
       public int age;
    }

    class Program
    {

        static void Foo(Point point)
        {
            point.x = 0;
            point.y = 0;
        }

        static void Foo(Person person)
        {
            person.age = 30;
            person.name = "Aftandil";
        }

        static void Main(string[] args)
        {

              String s = "Aftandil";
           // String s = new String("Aftandil");

            Point p; // struct
                     //Point p = new Point();

            p.x = 13;
            p.y = 25;

            Foo(p);

            Console.WriteLine($"X is {p.x}\nY is {p.y}");

            Person chalovek = new Person(); // = null; // class
            chalovek.name = "Agil";
            chalovek.age = 25;

            Foo(chalovek);
            Console.WriteLine($"Name is : {chalovek.name} \nAge is : {chalovek.age}");

            // VALUE TYPE and REFERENCE TYPE

            // Stucts - Value types
            // Class - Reference types


            //byte - Byte
            // short - Int16
            // int - Int32
            // long - Int64
            // float - Float
            // double -Double
            // decimal - Decimal

            // string - String // Reference type

           // string name;
           // int age;
           // Console.Write("Enter your name: ");
           // name = Console.ReadLine();
           // Console.Write("Enter your age: ");
           //// age = Convert.ToInt32(Console.ReadLine());
           // age = int.Parse(Console.ReadLine());

           // Console.WriteLine($"Your name is {name}!");
           // Console.WriteLine($"Your age is {age}!");


            // byte - 1
            // short - 2
            // int - 4
            // long - 8

            // float - 4
            // double - 8
            // decimal - 16

            // bool - 1
            // char - 2
            // string 

            // sbyte - 1 (signed)
            // ushort - 2 (unsigned)

            // var num = 13;

            //string name = "Aftandil";
            //int age = 25;

            //var filename = "Prog.cs";
            //Console.WriteLine(@"C:\Windows\User\Download");

            //Console.WriteLine(@$"C:\Windows\User\Download\{filename}");

            //Console.WriteLine($"My name is: {name} \nMy age is: {age}");

            //Console.WriteLine("My name is : {0} \n My age is: {1} \n",name,age);

            //Console.Write("My name is: " + name + "\n");
            //Console.WriteLine("My age is: " + age);

            //Console.Write("My Name is: ");
            //Console.WriteLine(name);
            //Console.Write("My Age: ");
            //Console.WriteLine(age);


        }
    }
}


// .NET
// Lang: C#, VB.NET, F#

// Windows: WinForms, WPF, UWP
// Mobile: Xamarin
// WEB Back-end: ASP.NET
// WEB Front-end: Blazor
// Game: Unity

// CLR - Common Language Runtime 
    //  JIT - just-in-time (compiler)
    //  GC - Garbage Collector

//BCL - Base Class Library

//CTS - Common Type System  
//CLS - Common Language Specification

// .NET Framework
// .NET Core
// .NET 5

// Reflector
// Dotfuscator

