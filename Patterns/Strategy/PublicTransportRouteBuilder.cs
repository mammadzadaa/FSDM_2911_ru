using System;

namespace Strategy
{
    class PublicTransportRouteBuilder : IRouteBuilder
    {
        public void BuildRoute(Location begin, Location end)
        {
            Console.WriteLine($"Distance between {begin} and {end}\nCould be reach in 40 min");
        }
    }
}
