using System.Reflection.PortableExecutable;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Store Apple = new Store();
            Store Walmart = new Store();
            Customer customer1 = new Customer("Alex",345,ItemType.Electronics);
            Customer customer2 = new Customer("Rick", 45, ItemType.Food);
            Customer customer3 = new Customer("Martin", 123, ItemType.Food);
            Customer customer4 = new Customer("Dr Dree", 872, ItemType.HouseKeeping);

            Apple.Subscribe(customer1);
            Apple.Subscribe(customer2);
            Apple.Subscribe(customer3);
            Apple.Subscribe(customer4);

            Walmart.Subscribe(customer1);
            Walmart.Subscribe(customer2);
            Walmart.Subscribe(customer3);
            Walmart.Subscribe(customer4);

            Apple.AddToStore(new StoreItem() { ItemName = "Iphone 12", Price = 800, Type = ItemType.Electronics });
            Apple.AddToStore(new StoreItem() { ItemName = "Airpods Pro", Price = 250, Type = ItemType.Electronics });

            Walmart.AddToStore(new StoreItem() { ItemName = "Coockie", Price = 5,Type = ItemType.Food });
            Walmart.AddToStore(new StoreItem() { ItemName = "Vanish", Price = 20, Type = ItemType.HouseKeeping });
            Walmart.AddToStore(new StoreItem() { ItemName = "Pan", Price = 100, Type = ItemType.HouseKeeping });
            Walmart.AddToStore(new StoreItem() { ItemName = "Doritos", Price = 3, Type = ItemType.Food });
        }
    }
}
