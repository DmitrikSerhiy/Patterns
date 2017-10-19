using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Component : IComponent //this is composite
    {

        List<IComponent> children = new List<IComponent>();

        private string Name;

        public Component(string name)
        {
            Name = name;
        }
        

        public virtual void Add(IComponent component)
        {
            children.Add(component);
        }

        public virtual void Display()
        {
            Console.WriteLine(Name);

            foreach (var item in children)
            {
                item.Display();
            }
        }

        public virtual void Remove(IComponent component)
        {
            children.Remove(component);
        }
    }
}
