using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class Leg : BodyPart
    {
        public Leg(Brain brain) : base(brain)
        {

        }
        public void Jump()
        {
            Console.WriteLine("Leg is jumping");
        }
    }
}
