namespace Factory_Method
{
    class RoadTransportFactory : ITransportFactory
    {
        public ITransport CreateTransport()
        {
            return new RoadTransport();
        }
    }
}
