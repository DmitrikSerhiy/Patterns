using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class Stomach : BodyPart
    {
        public Stomach(Brain brain) : base(brain)
        {

        }
        public void Work()
        {
            Console.WriteLine("Stomach is busy");
        }
    }
}
