using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    class AirTransport : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Delivering by Air");
        }
    }
}
