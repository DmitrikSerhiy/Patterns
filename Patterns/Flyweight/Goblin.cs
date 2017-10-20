using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class Goblin : Unit
    {
        public Goblin()
        {
            Name = "Goblin";
            Health = 10;
            Picture = UnitImageFactory.CreateGoblinImage();
        }
    }
}
