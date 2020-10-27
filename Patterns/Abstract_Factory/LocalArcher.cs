using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    class LocalArcher : IArcher
    {
        public int Health { get; set; } = 20;
        public string Bow { get; set; } = "Local Bow";

        public void Attack()
        {
            Console.WriteLine("Local Archer atacks with " + Bow + $"\nwith HP {Health}");
        }
    }
}
