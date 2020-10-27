using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class MerceryRider : IRider
    {
        public int Health { get; set; } = 40;
        public string Horse { get; set; } = "Mercery Horse";

        public void Attack()
        {
            Console.WriteLine("Mercery Rider atacks on " + Horse + $"\nwith HP {Health}");
        }
    }
}
