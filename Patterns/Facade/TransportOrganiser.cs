using System;

namespace Facade
{
    public static class TransportOrganiser
    {
        public static void OrderAirplaneTickets()
        {
            Console.WriteLine("Airplane tickets bought");
        }
        public static void OrderBusTickets()
        {
            Console.WriteLine("Bus tickets bought");
        }
    }
}
