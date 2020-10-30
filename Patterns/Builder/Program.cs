using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var computer = new Computer(new CPU(),new VGA(), null, new RAM(16),new PSU(800));
            var computer1 = new Computer(cPU:new CPU(),vGA: new VGA(),rAM: new RAM(16),pSU: new PSU(800));

            computer.Info();
            computer1.Info();

            var builder = new ComputerBuilder();
            builder.AddCPU("AMD",3.5f);
            builder.AddMotherboard("Gigabyte");
            builder.AddPSU(450);
            builder.AddRAM(8);
            builder.AddVGA(new VGA() { Memory = 4, Bits = 256 });
            builder.Build().Info();

            new ComputerBuilder().AddCPU("AMD", 3.5f)
                                 .AddMotherboard("Gigabyte")
                                 .AddPSU(450)
                                 .AddRAM(8)
                                 .AddVGA(new VGA() { Memory = 4, Bits = 256 })
                                 .Build().Info();

        }
    }
}
