namespace Observer
{
    public class Customer : ICustomer
    {
        public Customer(string name, decimal budget, ItemType interest)
        {
            Name = name;
            Budget = budget;
            Interest = interest;
        }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public ItemType Interest { get; set; }
        public void Update(IStore sender, CustomerNotificationArgs args)
        {
            if (args.Item.Type == Interest)
            {
                if (args.Item.Price <= Budget)
                {
                    Budget -= args.Item.Price;
                    sender.Buy(this,args.Item);
                }
            }
        }

    }
}
