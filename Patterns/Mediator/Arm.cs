using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class Arm : BodyPart
    {
        public Arm(Brain brain) : base(brain)
        {

        }
        public void Raise() 
        {
            Console.WriteLine("Arm is raising");
        }
    }
}
