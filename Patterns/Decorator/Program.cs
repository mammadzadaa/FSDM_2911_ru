namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeapon weapon = new Ak47();
            weapon.ShowInfo();
            IWeapon update = new SightUpgrade(weapon);
            update.ShowInfo();
            IWeapon update2 = new SilencerUpgrade(update);
            update2.ShowInfo();
            
            IWeapon update3 = new BuletUpgrade(update2);
            update3.ShowInfo();

            IWeapon unwrapped = (update3 as WeaponDecorator).UnWrapp();
            unwrapped.ShowInfo();

        }
    }
}
