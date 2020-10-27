using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Factory
{
    interface IRider
    {
        public int Health { get; set; }
        public string Horse { get; set; }
        public void Attack();

    }
}
