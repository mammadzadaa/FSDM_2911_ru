using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    interface IBarrack
    {
        IRider CreateRider();
        ISwordsman CreateSwordman();
        IArcher CreateArcher();
    }
}
