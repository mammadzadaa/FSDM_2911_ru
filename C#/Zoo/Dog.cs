using System;

namespace Zoo
{
   public sealed class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Gaw Gaw");
        }

        public new void Foo()
        {
            Console.WriteLine("I am a Dog");
        }
    }
}

