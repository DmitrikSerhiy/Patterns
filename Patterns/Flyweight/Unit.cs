using System;
using System.Collections.Generic;
using System.Text;


namespace Flyweight
{
    public abstract class Unit
    {
        public string Name { get; protected set; }
        public int Health { get; protected set; }
        public Image Picture { get; set; }
    }
}
