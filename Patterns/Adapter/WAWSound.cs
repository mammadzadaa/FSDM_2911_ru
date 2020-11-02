using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class WAWSound
    {
        public WAWSound(double frequency, double length, int quality, double size, string content)
        {
            Frequency = frequency;
            Length = length;
            Quality = quality;
            Size = size;
            Content = content;
        }

        public double Frequency { get; set; }
        public double Length { get; set; }
        public int Quality { get; set; }
        public double Size { get; set; }
        public string Content { get; set; }
    }
}
