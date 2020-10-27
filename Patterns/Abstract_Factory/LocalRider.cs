using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class LocalRider : IRider
    {
        public int Health { get; set; } = 40;
        public string Horse { get; set; } = "Local Horse";

        public void Attack()
        {
            Console.WriteLine("Local Rider atacks on " + Horse + $"\nwith HP {Health}");
        }
    }
}

