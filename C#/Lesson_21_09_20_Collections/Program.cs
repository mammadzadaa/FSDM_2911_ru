using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

namespace Lesson_21_09_20_Collections
{
    //class Base
    //{

    //}
    //class Derived : Base
    //{

    //}

    //class AnotherDerived : Base
    //{

    //}
   
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^[3,4,5][0-9]{3}\s?\d{4}\s?\d{4}\s?\d{4}$");

            Console.Write("Enter your card number: ");
            string cardNumber = Console.ReadLine();
            Match match = regex.Match(cardNumber);
            

            if (match.Success)
            {
                Console.WriteLine("Well Done");
            }
            else
            {
                Console.WriteLine("OOOps");
            }


            // Generic

            //Dictionary<int, string> someDictionary = new Dictionary<int, string>();

            //ObservableCollection<int> observableCollection = new ObservableCollection<int>();

            //LinkedList<int> linkedList = new LinkedList<int>();

            //var iter = linkedList.First;


            //Stack<int> stack = new Stack<int>();
            //Queue<int> queue = new Queue<int>();

            //HashSet<int> hset = new HashSet<int>();

            //SortedList<int,string> slist;

            //SortedSet<int> sset;

            //SortedDictionary<int, string> sdictionary;
            

            //List<int> list = new List<int>();

            //List<Base> someList = new List<Base>();

            //someList.Add(new Base());
            //someList.Add(new Derived());
            //someList.Add(new AnotherDerived());



            // Non Generic

            //ArrayList arrayList = new ArrayList();

            //arrayList.Add(12);
            //arrayList.Add(12.6);
            //arrayList.Add(12.98m);
            //arrayList.Add("Salam");

            //foreach (var item in arrayList)
            //{ 
            //    if (item is Int32 num)
            //    {
            //        Console.WriteLine(num + 1);
            //    }
            //}

        }
    }
}
