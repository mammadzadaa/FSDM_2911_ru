using System;

namespace Composite
{
    public class File : Component
    {
        public File(string name) : base(name)
        {}
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
        }
    }
}
