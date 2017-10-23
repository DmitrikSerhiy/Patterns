using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class Eye : BodyPart
    {
        public Eye(Brain brain) : base(brain)
        {

        }
        public void Blink()
        {
            Console.WriteLine("Eye is Blinking");
        }
    }
}
