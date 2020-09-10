using System;

namespace Zoo
{

    public interface ICanFly
    {
        void Fly();
    }
    public class Bird : Animal,ICanFly
    {
        public void Fly()
        {
            Console.WriteLine("Fliyes like a bird!");
        }

        public override void Sound()
        {
           
            Console.WriteLine("Chik Chirik");

          //  base.Public // OK
          // base.Private // Inaccessable
          // base.Protected // OK
          // base.Internal // OK
          //base.InternalProtecdet //OK
          //base.PrivateProtected //Ok
        }
    }

}
