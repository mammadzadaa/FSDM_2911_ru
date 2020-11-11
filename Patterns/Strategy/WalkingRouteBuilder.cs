using System;

namespace Strategy
{
    class WalkingRouteBuilder : IRouteBuilder
    {
        public void BuildRoute(Location begin, Location end)
        {
            Console.WriteLine($"Distance between {begin} and {end}\nCould be reach in 1 hr 10 min");
        }
    }
}
