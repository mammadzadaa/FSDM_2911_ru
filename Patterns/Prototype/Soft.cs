using System;

namespace Prototype
{
    public class Soft : ICloneable
    {
        public string Version { get; set; }

        public Soft(string version)
        {
            Version = version;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}