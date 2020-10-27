using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Text;

namespace Abstract_Factory
{
    class LocalBarrack : IBarrack
    {
        public IArcher CreateArcher()
        {
            return new LocalArcher();
        }

        public IRider CreateRider()
        {
            return new LocalRider();
        }

        public ISwordsman CreateSwordman()
        {
            return new LocalSwordsman();
        }
    }
}
