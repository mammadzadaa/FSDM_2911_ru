using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Lesson_14_09_20_Generics
{
    abstract class Flower
    {

        internal abstract void Func();
       internal void Foo()
        {
            Console.WriteLine("Flower");
        }

        internal virtual void VirtualFoo()
        {
            Console.WriteLine("Virtual Flower");
        }
    }

    class SunFlower : Flower
    {
        internal override void Func()
        {

        }
        internal new void Foo()
        {
            Console.WriteLine("SunFlower");
        }

        internal override void VirtualFoo()
        {
            Console.WriteLine("Virtual Sunflowers");
        }
    }

    class Account<T>
    {
        public Account(T iD, string login, string password)
        {
            ID = iD;
            Login = login;
            Password = password;
        }
        
        public T ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"{Login} {Password} \n{ID} \n";
        }

    }

    class MyList<T> : IEnumerable
    {
        private T[] array;
        public int Length { get; }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public MyList(params T[] param)
        {
            array = param;
            Length = param.Length;

            //Length = param.Length;
            //array = new T[Length];
            //for (int i = 0; i < Length; i++)
            //{
            //    array[i] = param[i];
            //}
        }

        class MyEnumerator : IEnumerator
        {
            private int i = -1;
            private T[] array;
            public object Current => array[i];

            public bool MoveNext()
            {
                i++;
                if (i >= array.Length)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public void Reset()
            {
                i = -1;
            }
            public MyEnumerator(T[] array)
            {
                this.array = array;
            }
        }
        //public IEnumerator GetEnumerator()
        //{
        //    return new MyEnumerator(array);
        //}

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                //if (i > 3)
                //{
                //    yield break;
                //}
                yield return array[i];
            }
            
        }
    }

    class Program
    {
        static IEnumerable foo()
        {
            yield return 12;
            yield return 14;
            yield return 16;
        }
        static void Print<T>(T val) where T: class,IEnumerable
        {
            Console.WriteLine(val);
        }
        static void Main(string[] args)
        {

            //foreach (var item in foo())
            //{
            //    Console.WriteLine(item);
            //}

            MyList<int> list = new MyList<int>(21, 32, 54, 1, 5, 76, 23);

            list[1] = 3;
            list[4] = 80;

            //var iterator = list.GetEnumerator();

            //while (iterator.MoveNext())
            //{
            //    Console.WriteLine((int)iterator.Current);
            //}
            //iterator.Reset();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            //for (int i = 0; i < list.Length; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}


            //Print(13);
            //Print("string");
            //Print(43.23m);

            //Account<int> account = new Account<int>(1,"root","qwerty");
            //Console.WriteLine(account);

            //Account<Guid> account1 = new Account<Guid>(Guid.NewGuid(), "user", "user");
            //Console.WriteLine(account1);


            //Flower flower = new SunFlower();
            //flower.Foo();
            //SunFlower sunFlower = new SunFlower();
            //sunFlower.Foo();

            //Console.WriteLine();

            //flower.VirtualFoo();
            //sunFlower.VirtualFoo();
        }
    }
}
