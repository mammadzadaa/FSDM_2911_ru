using System;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            War(new MerceryBarrack());
        }
        public static void War(IBarrack barrack)
        {
            IArcher[] archers = new IArcher[2];
            ISwordsman[] swordsmen = new ISwordsman[3];
            IRider[] riders = new IRider[2];

            for (int i = 0; i < 2; i++)
            {
                archers[i] = barrack.CreateArcher();
                archers[i].Attack();
            }
            for (int i = 0; i < 3; i++)
            {
                swordsmen[i] = barrack.CreateSwordman();
                swordsmen[i].Attack();
            }
            for (int i = 0; i < 2; i++)
            {
                riders[i] = barrack.CreateRider();
                riders[i].Attack();
            }


        }
    }
}
