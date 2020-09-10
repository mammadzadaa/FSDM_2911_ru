using System;

namespace Zoo
{

    class Test
    {
        static void Foo()
        {
            Animal a = new Bird();
            //a.Public // OK
            //a.Private // Inaccessable
            //a.Protected // Inaccessable
            //a.Internal // OK
            //a.InternalProtected // OK
            //a.PrivateProtected // Inaccessable
        }
    }

   public abstract class Animal
    {
        public int Public { get; set; }
        private  int Private { get; set; }

        protected int Protected { get; set; }

        internal int Internal { get; set; }

        internal protected int InternalProtecdet { get; set; }

        private protected int PrivateProtected { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }

        abstract public void Sound();
        public void Foo()
        {
            Console.WriteLine("I am an Animal");
        }
    }

}
