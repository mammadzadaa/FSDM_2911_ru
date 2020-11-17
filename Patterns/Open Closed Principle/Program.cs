using System;

namespace Open_Closed_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    interface IMeal
    {
        public void Make();
    }

    class PotatoMeal : IMeal
    {
        public void Make()
        {
            Console.WriteLine("Clean potatoes");
            Console.WriteLine("Put potatos on stove");
            Console.WriteLine("Smash the potaoes");
            Console.WriteLine("Add some spicies");
            Console.WriteLine("Smashed potato is ready");
        }
    }
    class Cook
    {
        public string Name { get; set; }

        public Cook(string name)
        {
            Name = name;
        }

        public void MakeDinner(IMeal meal)
        {
            meal.Make();
        }
    }

    //class Cook
    //{
    //    public string Name { get; set; }

    //    public Cook(string name)
    //    {
    //        Name = name;
    //    }

    //    public void MakeDinner()
    //    {
    //        Console.WriteLine("Clean potatoes");
    //        Console.WriteLine("Put potatos on stove");
    //        Console.WriteLine("Smash the potaoes");
    //        Console.WriteLine("Add some spicies");
    //        Console.WriteLine("Smashed potato is ready");
    //    }
    //}
}
