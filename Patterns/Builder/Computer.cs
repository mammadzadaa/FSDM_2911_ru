using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Computer
    {
        public Computer()
        {

        }
        public Computer(ICPU cPU, IVGA vGA = null, IMotherboard motherboard = null, RAM rAM = null, PSU pSU = null)
        {
            CPU = cPU;
            VGA = vGA;
            Motherboard = motherboard;
            RAM = rAM;
            PSU = pSU;
        }
        public void Info()
        {
            Console.WriteLine($"CPU: {CPU?.Model} {CPU?.Frequency}\n" + 
                              $"RAM: {RAM?.Memory} GB\n" +
                              $"VGA: {VGA?.Memory} GB {VGA?.Bits} bit\n" +
                              $"Motherboard: {Motherboard?.Model}\n" +
                              $"PSU: {PSU?.Power} watt\n" );
        }

        public ICPU CPU { get; set; }
        public IVGA VGA { get; set; }
        public IMotherboard Motherboard { get; set; }
        public RAM RAM { get; set; }
        public PSU PSU { get; set; }

    }
}
