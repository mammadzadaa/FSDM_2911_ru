using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    interface IArcher
    {
        public int Health { get; set; }
        public string Bow { get; set; }
        public void Attack();
    }
}
