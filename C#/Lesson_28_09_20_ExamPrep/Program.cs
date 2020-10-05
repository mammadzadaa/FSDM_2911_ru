using Microsoft.VisualBasic.CompilerServices;
using MyLib;
using System;
using System.Collections;
using System.Reflection;

using coll = System.Collections;


namespace Lesson_28_09_20_ExamPrep
{
    static class Extentions
    {
       public static void Print(this string str)
        {
            Console.WriteLine(str);
        }
    }
    enum Colour : ushort
    {
        Red = 0,
        Green,
        Blue
    }
    struct MyStruct
    {
        public int num;
        public int MyProperty { get; set; }

        //public MyStruct(int a)
        //{
        //    MyProperty = a;
        //}

    }
    class BaseAftandil
    {
        public BaseAftandil(int someProp)
        {
            SomeProp = someProp;
        }
        public int SomeProp { get; set; }

    }

    partial class MyClass : BaseAftandil, IEnumerable
    {

        private int myProperty; 
        public int MyProperty { get => myProperty; set => myProperty = value; }

        //public object this[int index]
        //{
        //    get { /* return the specified index here */ }
        //    set { /* set the specified index to value here */ }
        //}
        public int MyProperty1 { get; set; }
        public static int num = 0;

        static MyClass()
        {
            Console.WriteLine("Static Ctr was called");
        }
        public MyClass() : base(0)
        {
            Console.WriteLine("Hi");
        }
        public MyClass(int myProperty, int myProperty1) : this()
        {
            MyProperty = myProperty;
            MyProperty1 = myProperty1;
        }
        public string Foo()
        {
            return "Hello";
        }

        public IEnumerator GetEnumerator()
        {
            yield return 3;
        }
    }
    partial class MyClass
    {
        public static int number;
        public int PartialProp { get; set; }
    }
    class MyGen<T> where T : struct
    {
        public MyGen(T val)
        {

        }
    }

    abstract class MyAbstract
    {
        protected void NonAbstract()
        {

        }

        public abstract void Abstract();
    }

    abstract class DerivedFromAbstract : MyAbstract
    {
        public abstract void DerivedAbstract();
    }

    class Derived : DerivedFromAbstract
    {

        public sealed override void Abstract()
        {
            base.NonAbstract();
            throw new NotImplementedException();
        }

        public override void DerivedAbstract()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void GenFoo<T>(T val) 
        {

        }

        static double Foo(int num = 0)
        {
            return 2.4;
        }
        static int Foo(double d = 0)
        {
            return 5;
        }
        static void Foo(int i, double d)
        {

        }
        static void Foo(double d, int i)
        {

        }

        static void Main(string[] args)
        {
            Foo(1, 1.1);

           // MyAbstract my1 = new MyAbstract();


            GenFoo(12);
            GenFoo("ddss");
            GenFoo(231.43m);
            GenFoo(true);
            GenFoo('a');



            System.Console.WriteLine();
            Console.WriteLine(MyClass.num);

            MyClass my = new MyClass();
            Console.WriteLine(MyClass.number);
      
            
            
            //int h = int.Parse(Console.ReadLine());
            //string str = "He5llo";
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (int.TryParse(str[i].ToString(),out int num))
            //    {
            //        Console.WriteLine(++num);
            //    }
                
            //}

            //string str1 = "1: Abdullayev Mahammad";
            //int number = int.Parse(str1.Split(":")[0]);

            //Console.WriteLine(++number);
           // Console.WriteLine(str);
            //Console.WriteLine(++h);

           // Colour c = Colour.Red;
            //switch (c)
            //{
            //    case Colour.Red:
            //        break;
            //    case Colour.Green:
            //        break;
            //    case Colour.Blue:
            //        break;
            //    default:
            //        break;
            //}

            //FooParams(1, 2, 3, 5, 6, 7,3,4,5,6,7);


            //int i = 100;
            //MyFoo(i);
            //MyFoo(ref i);
            //MyFoo1(in i);
            //MyFoo2(out int num);

            //long u = i;

            //int @in = (int)u;

            //object o = new MyClass();
            

            //MyClass my = o as MyClass;

            //if (o is MyClass my1)
            //{
            //    my1.Foo();
            //}

            ////my1.Foo();
            //Func( num1: 78, num: 12);

            //int? z = 0;
            //Nullable<int> nullableInt  /* = new Nullable<int>()*/;
            //z = null;
            

            //int? numb = 12;

            //int nn = numb ?? 0;
            //int nm = numb != null ? numb.Value : 0;

            //MyClass m = null;

            //if (m != null)
            //{
            //    m.Foo();
            //}

            //var anonim = new { Name = "Adsdad", Surname = "Gdsasad", Age = 123 };

            //anonim = new { Name = "Adad", Surname = "Gdad", Age = 45 };

            //string str = m?.Foo();

            //Console.WriteLine(str.Length);


            //MyStruct mystruct = new MyStruct();
            //mystruct.num = 0;
            //mystruct.MyProperty = 0; // requests new
            //Console.WriteLine(mystruct.num);
            //Console.WriteLine(mystruct.MyProperty);

            //int? number = 12;
            //object o = number;
            //number++;
            //Console.WriteLine(number);
            //Console.WriteLine(o);

            //number = null;

            //Nullable<int> numNullable = new Nullable<int>(13);
            
            //Console.WriteLine();
            //MyClass my = new MyClass();
            //Type t = my.GetType();
            //Type t1 = typeof(MyClass);
            //MethodInfo m = t.GetMethod("Foo");
            //m.Invoke(my,null);
            // Console.WriteLine("Hello World!");
        }


        static void MyFoo(int num)
        {
            num++;
        }
        static void MyFoo(ref int num)
        {
            num++;
        }
        static void MyFoo1(in int num)
        {
            //num++;
        }
        static void MyFoo2(out int num)
        {
            num = 12;
        }
        static void Func(int num, int num1) { }

        static void FooParams(params int[] par)
        {
            foreach (var item in par)
            {
                Console.WriteLine(item);
            }
        }

    }
}
