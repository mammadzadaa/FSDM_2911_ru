using System;
using System.Data.Common;
using Zoo;

namespace Lesson_10_09_20_Interface
{
    class Test : Animal
    {
        public override void Sound()
        {
            //base.Private // Inaccessable
            //base.Protected // OK
            //base.Public //OK
            //base.Internal // Inaccessable
            //base.InternalProtecdet // OK
            //base.PrivateProtected // Inaccessable
        }
    }
    class Program
    {
        public static void FlyingSchool(ICanFly classThatCanFly)
        {
            classThatCanFly.Fly();   
        }
        static void Main(string[] args)
        {
            
            Bird bird = new Bird();
            Dog dog = new Dog();

            FlyingSchool(bird);
            // FlyingSchool(dog);


            //object obj = new Dog();
            //object o = new String("");


            //int number = 31;

            //object @object = number;
            //int internalNumber = (int)@object;

            //int num = 31;
            //num.Equals(12);



            //Animal dog = new Dog();
            //Animal cat = new Cat();
            //Animal bird = new Bird();

            //dog.Sound();
            //cat.Sound();
            //bird.Sound();

            //Console.WriteLine();

            //Animal animal = new Dog();
            //Dog dog1 = new Dog();

            //animal.Foo();
            //dog1.Foo();

            // bird.Public // OK
            //bird.Private // Inaccessable
            //bird.Protected // Inaccessable
            //bird.Internal // Inaccessable
            //bird.InternalProtecdet // Inaccessable
            //bird.PrivateProtected // Inaccessable
        }
    }

} 
