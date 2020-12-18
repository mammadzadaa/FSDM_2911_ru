using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_Messaging.Messages
{
    class LocationMessage : IMessage
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
