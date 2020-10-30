using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class ComputerBuilder
    {
        private Computer computer = new Computer();
        public ComputerBuilder AddCPU(string model, float frequency)
        {
            computer.CPU = new CPU() {Frequency = frequency, Model = model };
            return this;
        }
        public ComputerBuilder AddMotherboard(string model)
        {
            computer.Motherboard = new Motherboard() { Model = model };
            return this;
        }
        public ComputerBuilder AddPSU(int watts)
        {
            computer.PSU = new PSU(watts);
            return this;
        }
        public ComputerBuilder AddRAM(int amount)
        {
            computer.RAM = new RAM(amount);
            return this;

        }
        public ComputerBuilder AddVGA(IVGA vga)
        {
            computer.VGA = vga;
            return this;
        }

        public Computer Build()
        {
            return computer;
        }

    }
}
