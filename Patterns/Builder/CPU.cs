using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class CPU : ICPU
    {
        public string Model { get; set; } = "Inter i7 3930k";
        public float Frequency { get; set; } = 3.4f;
    }
}
