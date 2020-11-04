namespace Decorator
{
    public class SightUpgrade : WeaponDecorator
    {
        public SightUpgrade(IWeapon weapon) : base(weapon)
        {
            additionalCapacity = 0;
            additionalDamage = 0;
            additionalSight = 10;
        }
    }
}
