using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public static class UnitImageFactory
    {
        private static Dictionary<Type, Image> CreatedUnits;

        static UnitImageFactory()
        {
            CreatedUnits = new Dictionary<Type, Image>();
        }
        //instead of loading image each time when Goblin or Dragin is created 
        //loading acts only once and that picture is used for each dragon or goblin
        //thus saving the memory is obvious
        public static Image CreateDragonImage()
        {
            Type dragon = typeof(Dragon);
            if (!CreatedUnits.ContainsKey(dragon))
            {
                CreatedUnits.Add(dragon, Image.Load());
            }
            return CreatedUnits[dragon];
        }
        public static Image CreateGoblinImage()
        {
            Type goblin = typeof(Goblin);
            if (!CreatedUnits.ContainsKey(goblin))
            {
                CreatedUnits.Add(goblin, Image.Load() );
            }
            return CreatedUnits[goblin];
        }
    }
}
