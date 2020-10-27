using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    interface ISwordsman
    {
        public int Health { get; set; }
        public string Sword { get; set; }
        public void Attack();

    }
}
