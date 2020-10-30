using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class VGA : IVGA
    {
        public int Memory { get; set; } = 4;
        public int Bits { get; set; } = 256;
    }
}
