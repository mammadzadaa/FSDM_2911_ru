using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class LocalSwordsman : ISwordsman
    {
        public int Health { get; set; } = 35;
        public string Sword { get; set; } = "Local Sword";

        public void Attack()
        {
            Console.WriteLine("Local Swordman atacks with " + Sword + $"\nwith HP {Health}");
        }
    }
}
