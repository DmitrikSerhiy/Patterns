using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public interface IComponent
    {
        void Display();
        void Add(IComponent component);
        void Remove(IComponent component);
    }
}
