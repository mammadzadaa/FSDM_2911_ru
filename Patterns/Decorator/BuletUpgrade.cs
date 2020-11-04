namespace Decorator
{
    public class BuletUpgrade : WeaponDecorator
    {
        public BuletUpgrade(IWeapon weapon) : base(weapon)
        {
            additionalCapacity = -5;
            additionalDamage = 10;
            additionalSight = -5;
        }
    }
}
