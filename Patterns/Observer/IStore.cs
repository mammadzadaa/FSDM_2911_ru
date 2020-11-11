namespace Observer
{
    public interface IStore
    {
        void Buy(ICustomer customer, StoreItem item);
        void Subscribe(ICustomer customer);
        void Unsubscribe(ICustomer customer);
        void NotifyCustomers(StoreItem item);
    }
}
