namespace Factory_Method
{
    class AirTransportFactory : ITransportFactory
    {
        public ITransport CreateTransport()
        {
            return new AirTransport();
        }
    }
}
