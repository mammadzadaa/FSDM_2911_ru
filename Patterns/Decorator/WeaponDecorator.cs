using System;

namespace Decorator
{
    public abstract class WeaponDecorator : IWeapon
    {
        private IWeapon weapon;
        protected int additionalCapacity;
        protected int additionalSight;
        protected int additionalDamage;
        public WeaponDecorator(IWeapon weapon)
        {
            this.weapon = weapon;
        }
        public int Capacity
        {
            get => weapon.Capacity + additionalCapacity;
        }
        public int Sight
        {
            get => weapon.Sight + additionalSight;
        }
        public int Damage
        {
            get => weapon.Damage + additionalDamage; 
        }

        public IWeapon UnWrapp()
        {
            return weapon;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Capacity: {Capacity}\nSight: {Sight}\nDamage: {Damage}\n\n");
        }
    }
}
