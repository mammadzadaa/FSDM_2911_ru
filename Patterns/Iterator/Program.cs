using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            MyListOfInt list = new MyListOfInt(5);
            list[0] = 1;
            list[1] = 2;
            list[2] = 3;
            list[3] = 4;
            list[4] = 5;

            var enumerator = list.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            enumerator.Reset();

        }
    }

    class MyListOfInt : IEnumerable
    {
        private int[] list;
        public MyListOfInt(int size)
        {
            list = new int[size];
        }
        public int this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }
        public class MyListOFIntEnumerator : IEnumerator
        {
            int index = -1;
            int[] list;
            public MyListOFIntEnumerator(int[] list)
            {
                this.list = list;
            }
            public object Current => list[index];

            public bool MoveNext()
            {
                index++;
                return list.Length > index;
            }

            public void Reset()
            {
                index = -1;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new MyListOFIntEnumerator(list);
        }
    }
}
