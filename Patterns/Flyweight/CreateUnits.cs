using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class CreateUnits
    {
        List<Unit> Units { get; set; }
        public CreateUnits(int Dragons, int Goblins)
        {
            Units = new List<Unit>();
            for (int i = 0; i < Dragons; i++)
            {
                Units.Add(new Dragon());
            }
            for (int i = 0; i < Goblins; i++)
            {
                Units.Add(new Goblin());
            }
        }
    }
}
