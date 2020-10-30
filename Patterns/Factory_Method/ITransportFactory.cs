using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    interface ITransportFactory
    {
        public ITransport CreateTransport();
    }
}
