namespace Decorator
{
    public class SilencerUpgrade : WeaponDecorator
    {
        public SilencerUpgrade(IWeapon weapon) : base(weapon)
        {
            additionalCapacity = 0;
            additionalDamage = -5;
            additionalSight = 0;
        }
    }
}
