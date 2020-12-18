using MVVM_Messaging.Model;

namespace MVVM_Messaging.Messages
{
    public class ForecastMessage : IMessage
    {
        public Forecast Forecast { get; set; }
    }
}
