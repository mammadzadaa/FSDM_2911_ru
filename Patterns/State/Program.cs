using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    interface IEnemyState
    {
        public Enemy Enemy { get; set; }
        void Action();
    }

    class IdleState : IEnemyState
    {
        public Enemy Enemy { get; set ; }

        public void Action()
        {
            Console.WriteLine("Idle...");
        }
    }

    class PlayerNearbyState : IEnemyState
    {
        public Enemy Enemy { get; set; }
        public void Action()
        {
            if (Enemy.HP > 10)
            {
                Console.WriteLine("Attack enemy!");
            }
            else
            {
                Enemy.CurrentState = new LowHPState() { Enemy = Enemy};
            }
        }
    }

    class LowHPState : IEnemyState
    {
        public Enemy Enemy { get; set; }
        public void Action()
        {
            Console.WriteLine("Run away and hide!");
        }
    }

    class Enemy
    {
        public IEnemyState CurrentState { get; set; }
        public Enemy()
        {
            CurrentState = new IdleState() { Enemy = this };
        }
        public int HP { get; set; }
        public void Action()
        {
            CurrentState.Action();
        }
    }
}
