using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Leaf : Component
    {
        private string Name;
        public Leaf(string name) : base(name)
        {
            Name = name; 
        }

        public override void Display()
        {
            Console.WriteLine(Name);
        }

        public override void Add(IComponent component)
        {
            throw new NotImplementedException();
        }

        public override void Remove(IComponent component)
        {
             throw new NotImplementedException();
        }
    }
}
