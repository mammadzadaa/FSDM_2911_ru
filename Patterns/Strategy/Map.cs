namespace Strategy
{
    class Map
    {
        public IRouteBuilder routeBuilder { get; set; }
        public Map(IRouteBuilder routeBuilder)
        {
            this.routeBuilder = routeBuilder;
        }
        public void RouteBuilder(Location begin, Location end)
        {
            routeBuilder.BuildRoute(begin, end);
        }
    }
}
