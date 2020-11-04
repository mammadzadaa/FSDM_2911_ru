using System;

namespace Decorator
{
    public class Ak47 : IWeapon
    {
        public int Capacity { get; } = 30;
        public int Sight { get; } = 3;
        public int Damage { get; } = 20;

        public void ShowInfo()
        {
            Console.WriteLine($"Capacity: {Capacity}\nSight: {Sight}\nDamage: {Damage}\n\n");
        }
    }
}
