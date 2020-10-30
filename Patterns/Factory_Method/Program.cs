using System;
using System.Collections.Generic;

namespace Factory_Method
{
    enum TransportType
    {
        Air, Road, Sea
    }
    class Program
    {
        static void Main(string[] args)
        {
            var listOfTransport = new List<ITransport>();
            //for (int i = 0; i < 10; i++)
            //{
            //    listOfTransport.Add(RandomTransport());
            //}
            listOfTransport.Add(GetTransportByType(TransportType.Sea));
            listOfTransport.Add(GetTransportByType(TransportType.Air));
            listOfTransport.Add(GetTransportByType(TransportType.Road));
            listOfTransport.Add(GetTransportByType(TransportType.Air));

            foreach (var item in listOfTransport)
            {
                item.Deliver();
            }
        }

        public static ITransport GetTransportByType(TransportType type)
        {
            return type switch
            {
                TransportType.Air => new AirTransport(),
                TransportType.Road => new RoadTransport(),
                TransportType.Sea => new SeaTransport(),
                _ => null
            };
        }

        public static ITransport RandomTransport()
        {
            Random random = new Random();
            var listOfTransportFactory = new List<ITransportFactory>();
            listOfTransportFactory.Add(new AirTransportFactory());
            listOfTransportFactory.Add(new RoadTransportFactory());
            listOfTransportFactory.Add(new SeaTransportFactory());

            var randomTransportFactoryIndex = random.Next(0, listOfTransportFactory.Count);
            return listOfTransportFactory[randomTransportFactoryIndex].CreateTransport();

        }
    }
}
