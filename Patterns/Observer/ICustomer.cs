namespace Observer
{
    public interface ICustomer
    {
        public string Name { get; set; }
        public void Update(IStore sender, CustomerNotificationArgs args);
    }
}
