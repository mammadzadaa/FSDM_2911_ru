using System;
using System.Collections.Generic;

namespace Observer
{
    public class Store : IStore
    {
        List<ICustomer> customers = new List<ICustomer>();
        List<StoreItem> storeItems = new List<StoreItem>();
        public void Buy(ICustomer customer,StoreItem item)
        {
            Console.WriteLine($"{customer.Name} bought {item.ItemName} for {item.Price}$");
        }
        public void AddToStore(StoreItem storeItem)
        {
            storeItems.Add(storeItem);
            NotifyCustomers(storeItem);
        }
        public void Subscribe(ICustomer customer)
        {
            customers.Add(customer);
        }
        public void Unsubscribe(ICustomer customer)
        {
            customers.Remove(customer);
        }
        public void NotifyCustomers(StoreItem item)
        {
            foreach (var customer in customers)
            {
                customer.Update(this,new CustomerNotificationArgs(item));
            }
        }
    }
}
