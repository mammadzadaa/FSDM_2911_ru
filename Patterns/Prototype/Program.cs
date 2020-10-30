using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var robot = new Robot("Chappie","T800","Skynet","Silver",  345990.3 ,324.5,new Soft("12.4.5v"));
            var anotherRobot = robot.Clone() as Robot;
            anotherRobot.Name = "Sarah";
            anotherRobot.Color = "Black";
            anotherRobot.Soft.Version = "1.1.1v";
            Console.WriteLine(robot);
            Console.WriteLine(anotherRobot);

        }
    }
}
