using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class Dragon : Unit
    {
        public Dragon()
        {
            Name = "Dragon";
            Health = 200;
            Picture = UnitImageFactory.CreateDragonImage();
        }
    }
}
