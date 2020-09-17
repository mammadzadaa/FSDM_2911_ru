using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;

namespace Lesson_16_09_20_Delegates
{
    class Program
    {
        delegate void MyDelegate();
        delegate void MyDelegate1(int num1, int num2);

        static void Print()
        {
            Console.WriteLine("Hello");
        }

        static void PrintSomeText()
        {
            Console.WriteLine("Some Text");
        }

        delegate bool FiltrElement<T>(T num);

        static bool ZeroCheck(int num) => true;

        static bool PositiveCheck(int num) => num > 0;

        static bool EvenCheck(int num) => num % 2 == 0;

        static void FiltrArray(int[] arr, FiltrElement<int> filtrElement)
        {
            foreach (var item in arr)
            {
                if (filtrElement(item))
                {
                    Console.WriteLine(item);
                }
            }            
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 6, 8, -3, 9, -12, -5, 19, 32, -34, -22 };

            var listNew = list.ConvertAll<int>(x => x * 2);

            listNew.ForEach(x => Console.WriteLine(x));

            if (list.TrueForAll(x => x > -100))
            {
                Console.WriteLine("True for all elements");
            }
            else
            {
                Console.WriteLine("Not true for all elements");
            }
            Console.WriteLine();

            list.Sort((x, y) => (x - y)*-1);

            list.ForEach(x => Console.WriteLine(x));

            Console.WriteLine();
            if (list.Exists(x => x < 50))
            {
                Console.WriteLine("Yes, exist");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.WriteLine();

            Console.WriteLine(list.Find(x => x < 10));
            Console.WriteLine(list.FindLast(x => x < 10));

            Console.WriteLine();
            var findedList = list.FindAll(x => x > 0);
            findedList.ForEach(x => Console.WriteLine(x));


            //list.ForEach(x => x += 10);

            //list.ForEach(x => Console.WriteLine(x));


            //Action action = () => Console.WriteLine("Action");
            //Action<int> action1 = (x) => Console.WriteLine(x);

            //Predicate<string> predicate = x => x == "";

            //Func<int> func = () => 10;
            //Func<string, int> func1 = x => int.Parse(x);
            //Func<int, double, int, string> func2 = (x, y, z) => "str";


            //int[] arr = new int[] { 1, 6, 8, -3, 9, -12, -5, 19, 32, -34, -22 };

            //FiltrArray(arr, EvenCheck);


            //Console.WriteLine();

            //FiltrElement<int> filtr = x => x < -5;

            //FiltrElement<int> filtr1 = x =>
            //{
            //    return x < -5;
            //};

            //MyDelegate1 my = (x, y) => Console.WriteLine("Hi");
            //my(12, 32);

            //FiltrArray(arr, x => x < -1);

            // FiltrArray(arr, delegate (int num) { return num > 10; });


            //Console.WriteLine();

            ////FiltrElement filtr = delegate (int num) { return num > 10; };

            ////FiltrArray(arr, filtr);

            //FiltrArray(arr, delegate (int num) { return num > 10; });





            //MyDelegate myDelegate = new MyDelegate(Print);

            //myDelegate += PrintSomeText;
            //myDelegate -= Print;

            //myDelegate = null;

            //myDelegate?.Invoke();

            //myDelegate();



            //TranslateRequest translate = new TranslateRequest() { source = "en", target = "ru", format = "text" };

            //Console.Write("Enter your text: ");
            //translate.q = Console.ReadLine();

            //WebClient web = new WebClient();
            //string url = "https://translation.googleapis.com/language/translate/v2?key=AIzaSyCqwaXLLd9JraElDHNGKFIN2zfbSAgAHms";

            //string answer = web.UploadString(url, JsonSerializer.Serialize(translate));
            ////Console.WriteLine(answer);

            //var response = JsonSerializer.Deserialize<TranslateResponse>(answer);
            //Console.Write("\nYour Translation: ");
            //Console.WriteLine(response.data.translations[0].translatedText);

        }

    }
}
