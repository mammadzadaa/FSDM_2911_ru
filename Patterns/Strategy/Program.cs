using System.Data.Common;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map(new WalkingRouteBuilder());
            map.RouteBuilder(new Location(40.123m, 41.543m), new Location(43.123m, 45.543m));
            map.routeBuilder = new PublicTransportRouteBuilder();
            map.RouteBuilder(new Location(40.123m, 41.543m), new Location(43.123m, 45.543m));

        }
    }
}
