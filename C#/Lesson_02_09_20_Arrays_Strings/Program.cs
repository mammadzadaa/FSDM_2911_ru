using System;
using System.Collections.Specialized;
using System.Xml;

namespace Lesson_02_09_20_Arrays_Strings
{
    struct Point
    {
        public int x;
    }
    class Person
    {
        public int age;
        public string name;
    }
    class Program
    {
        static void Foo(ref Point p)
        {
            p.x = 0;
        }
        static void Foo(Point p)
        {
            p.x = 0;
        }
        static void Foo(Person p)
        {
            p.age = 0;
 
        }

        static void Foo(out int num)
        {
            num = int.Parse(Console.ReadLine()); // need initialisation
        }
        static void Foo(int num)
        {
            Console.WriteLine(num);
        }
        static void Foo1(in int num)
        {
            Console.WriteLine(num);
            // num = 0; can't do it            
        }

        public enum MyEnum
        {
            Eng, Az, Ru
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 4, 1, 6, 0, 8, 2, 9 };
            Array.Sort(arr);
            

            foreach (var item in arr)
            {
                Console.Write($"{item}, ");
            }
            
            //int[][] arr;

            //int[][] arr1 = new int[][]{ new int[] {1,2,3},
            //                            new int[] {4,5},
            //                            new int[] {6,7,8,9} };

            //foreach (var item in arr1)
            //{
            //    foreach (var i in item)
            //    {
            //        Console.Write($"{i}, ");
            //    }
            //    Console.WriteLine();
            //}

            //int[] arr_1 = { 1, 2, 3 }; // Length = 3
            //int[] arr_2 = new int[arr_1.Length + 1]; // for = arr1;  + new element;
            //arr_2[arr_1.Length] = 12; 
            //arr_1 = arr_2;

            //int[,] arr_mul = { {1,2,3 },{4,5,6} };
            //int[,,] arr_m = new int[2, 3, 4];

            // int[,] arr = new int[3, 4] { {1,2,3,4 },
            //                              {5,6,7,8},
            //                              {9,10,11,12 } };

            //Console.WriteLine(arr.Length);
            //Console.WriteLine(arr.Rank);
            //Console.WriteLine(arr.GetUpperBound(0));
            //Console.WriteLine(arr.GetUpperBound(1));

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j <= arr.GetUpperBound(1); j++)
            //    {
            //        Console.Write($" {arr[i, j]}, ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j <= arr.GetUpperBound(i); j++)
            //    {
            //        Console.WriteLine(arr.GetUpperBound(i));
            //        Console.Write($" {arr[i, j]}, ");
            //    }
            //    Console.WriteLine();
            //}




            //int[] arr = {1,2,3,4,5};

            //int[] arr1 = new int[] { };
            //int[] arr3 = new int[10];
            //int[] arr2 = new int[10] {1,2,3,4,5,6,7,8,9,0 };

            //arr2[0] = 12;


            //int size = 3;
            //int[] arr = new int[size];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //foreach (var item in arr)
            //{
            //    Console.Write($" {item} ,");
            //}
            //Console.WriteLine();



            //MyEnum myEnum = MyEnum.Az;

            //double num = 2.1;
            //string s = "Aftandil";
            //char c = 'A';

            //switch (c)
            //{
            //    case 'A':
            //        Console.WriteLine("A");
            //        //goto case 'B';

            //    case 'B':
            //    case 'C':
            //        Console.WriteLine("B or C");
            //        break;
            //    default:
            //        break;
            //}

            //int number; // const int* const num;
            //Foo(out number);
            //Foo(number);
            //Foo1(in number);

            //Foo(out int x);
            //Console.WriteLine(x);

            //Point point;
            //point.x = 5;
            //Person person = new Person() { age = 20, name = "Aftandil"};

            //Foo(ref point); // ref out in
            ////Foo(point);
            //Console.WriteLine($"Pint X is {point.x}");
            //Foo(person);
            ////Person person1 = person;
            ////person1.age = 50;
            //Console.WriteLine($"Person's age is {person.age}");
            ////Console.WriteLine("{0}    {1}",person.age, person.name);

            //int num = 5;
            //Console.WriteLine($"Hello World!{num}"); // интерполяция
        }
    }
}
