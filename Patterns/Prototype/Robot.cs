using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class Robot : ICloneable
    {
        public Robot(string name, string model, string vendor, string color, double upTime, double weight, Soft soft)
        {
            Name = name;
            Model = model;
            Vendor = vendor;
            Color = color;
            UpTime = upTime;
            Weight = weight;
            Soft = soft;
        }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Vendor { get; set; }
        public string Color { get; set; }
        public double UpTime { get; set; }
        public double Weight { get; set; }
        public Soft Soft { get; set; }

        public object Clone()
        {
            var temp = MemberwiseClone() as Robot;
            temp.Soft = Soft.Clone() as Soft;
            return temp;
        }

        public override string ToString()
        {
            return $"{Name} is {Color} {Model} robot, made by {Vendor}. Up time is {UpTime} hours and weights {Weight} kg" +
                   $"\nSoftware version is {Soft?.Version}";
        }
    }
}
