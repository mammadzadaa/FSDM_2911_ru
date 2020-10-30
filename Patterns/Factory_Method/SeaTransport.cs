using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    class SeaTransport : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivering by Sea");
        }
    }
}
