using System.Drawing;

namespace Builder
{
    public class PSU
    {
        public PSU(int amountOfWatts)
        {
            Power = amountOfWatts;
        }
        public int Power { get; set; }
    }
}