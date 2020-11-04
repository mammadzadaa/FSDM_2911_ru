namespace Decorator
{
    public interface IWeapon
    {
        public int Capacity { get; }
        public int Sight { get; }
        public int Damage { get; }
        public void ShowInfo();
    }
}
