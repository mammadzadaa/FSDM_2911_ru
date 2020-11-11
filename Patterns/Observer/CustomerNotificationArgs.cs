using System;

namespace Observer
{
    public class CustomerNotificationArgs : EventArgs
    {
        public StoreItem Item { get; private set; }
        
        public CustomerNotificationArgs(StoreItem item)
        {
            Item = item;
        }
    }
}
