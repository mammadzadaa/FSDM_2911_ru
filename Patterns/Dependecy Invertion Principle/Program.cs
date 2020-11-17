using System;

namespace Dependecy_Invertion_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    interface IPrint
    {
        void Print(string text);
    }

    class Book
    {
        public IPrint Printer { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }

        public void Print()
        {
            Printer.Print(Text);
        }
    }
}
