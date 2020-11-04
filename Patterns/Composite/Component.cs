namespace Composite
{
    public abstract class Component
    {
        public Component(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public abstract void Display(int depth);
    }
}
