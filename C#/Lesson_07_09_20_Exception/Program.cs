using System;
using System.IO;

namespace Lesson_07_09_20_Exception
{

    class Program
    {
        static void Foo()
        {
            int a = 5;
            try
            {
                throw new Exception("Ouuups");
            }
            catch when (a < 0)
            {

            }
            catch (Exception) when (a > 0)
            {
                Console.WriteLine("First cath!");
                throw;
            }
            finally
            {
                Console.WriteLine("will work anyway after all");
            }

        }
        static void Func() => Console.WriteLine("hello!");
        static int Funcr(int x, int y) => x + y;

        //class MyArray
        //{
        //    int[] arr = new int[5] {1,2,3,4,5 };
        //    public int this[int index]
        //    {
        //        get { return arr[index]; }
        //        set { arr[index] = value; }
        //    }
        //}

        //class Dictionary
        //{
        //    public string this[string index]
        //    {
        //        get
        //        {
        //            return index switch
        //            {
        //                "uno" => "One",
        //                "dos" => "Two",
        //                "tres" => "Three",
        //                _ => "Invalid input!",
        //            };
        //        }
        //    }
        //}

        enum Colour : ushort
        {
            Red = 1, Green, Blue
        }

        static void Main(string[] args)
        {

            //Colour colour = Colour.Blue;
            //Console.WriteLine((int)colour);

            //Colour colour1 = (Colour)int.Parse(Console.ReadLine());

            //  Colour colour1 = (Colour)Enum.Parse(typeof(Colour),Console.ReadLine());

           
            if(Enum.TryParse(typeof(Colour), Console.ReadLine(), out object o))
            {
                Console.WriteLine((Colour)o);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }




            //if(colour == Colour.Blue)
            //{
            //}

            //Dictionary dictionary = new Dictionary();

            //string word = Console.ReadLine().ToLower();
            //Console.WriteLine(dictionary[word]);

            //MyArray my = new MyArray();
            //my[3] = 16;
            //Console.WriteLine(my[3]);

            //double a = 10;
            //double b = 0;

            //try
            //{
            //    Console.WriteLine(a / b); // infinity
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //int num = int.MaxValue;

            //int a = 10;
            //int b = 0;

            //try
            //{
            //    Console.WriteLine(a / b);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //unchecked // checked
            //{
            //    try
            //    {
            //        Console.WriteLine(++num);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}



            // 0 111 1111 1111 1111
            // 1 000 0000 0000 0000

            //try
            //{
            //    File.WriteAllText(@"C:\Users\Aqil\Desktop\STTA_2913\test.txt", "");
            //}
            //catch (ArgumentNullException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch(NotSupportedException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch(DirectoryNotFoundException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //int[] arr = new int[5] { 1, 2, 3, 4, 5 };

            //try
            //{
            //    Console.WriteLine(arr[5]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    //throw new Exception("Ouuups");
            //    // posible exception thrwing code
            //    Foo();
            //}
            //catch(FileNotFoundException)
            //{
            //    Console.WriteLine("File not found!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            ////catch (FileNotFoundException) // wont work after general Exception class been caught
            ////{
            ////    Console.WriteLine("File not found!");
            ////}

        }
    }
}
