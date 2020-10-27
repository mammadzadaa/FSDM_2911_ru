using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class MerceryArcher : IArcher
    {
        public int Health { get; set; } = 20;
        public string Bow { get; set; } = "Mercery Bow";

        public void Attack()
        {
            Console.WriteLine("Mercery Archer atacks with " + Bow + $"\nwith HP {Health}");
        }
    }
}
