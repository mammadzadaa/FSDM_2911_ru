using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class MercerySwordsman : ISwordsman
    {
        public int Health { get; set; } = 35;
        public string Sword { get; set; } = "Mercery Sword";

        public void Attack()
        {
            Console.WriteLine("Mercery Swordman atacks with " + Sword + $"\nwith HP {Health}");
        }
    }
}
