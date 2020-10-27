using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class MerceryBarrack : IBarrack
    {
        public IArcher CreateArcher()
        {
            return new MerceryArcher();
        }

        public IRider CreateRider()
        {
            return new MerceryRider();
        }

        public ISwordsman CreateSwordman()
        {
            return new MercerySwordsman();
        }
    }
}
