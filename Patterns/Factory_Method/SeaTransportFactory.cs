using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    class SeaTransportFactory : ITransportFactory
    {
        public ITransport CreateTransport()
        {
            return new SeaTransport();
        }
    }
}
