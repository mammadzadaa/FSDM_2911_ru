using System;

namespace Liskov_Substitution_Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Square();
            TestRectangleArea(rectangle);
        }

        public static void TestRectangleArea(Rectangle rectangle)
        {
            rectangle.Height = 5;
            rectangle.Width = 10;
            if (rectangle.GetArea() == 50)
            {
                Console.WriteLine("Test Passed!");
            }
            else
            {
                Console.WriteLine("Test failed!");
            }
        }
    }

    class Rectangle
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }

        public int GetArea()
        {
            return Height * Width;
        }
    }

    class Square : Rectangle
    {
        public override int Height 
        {
            get => base.Height;
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
        public override int Width 
        { 
            get => base.Width;
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

    }
}
