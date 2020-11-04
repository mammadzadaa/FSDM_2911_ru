using System;
using System.Collections.Generic;

namespace Composite
{
    public class Folder : Component
    {

        public Folder(string name) : base(name)
        {}
        private List<Component> children = new List<Component>();
        public void Add(Component component)
        {
            children.Add(component);
        }
        public void Remove(Component component)
        {
            children.Remove(component);
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
            foreach (var item in children)
            {
                item.Display(depth + 2);
            }
        }
    }
}
