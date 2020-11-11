using System;

namespace Strategy
{
    class CarRouteBuilder : IRouteBuilder
    {
        public void BuildRoute(Location begin, Location end)
        {
            Console.WriteLine($"Distance between {begin} and {end}\nCould be reach in 15 min");
        }
    }
}
